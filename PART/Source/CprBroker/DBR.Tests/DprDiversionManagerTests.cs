﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CprBroker.DBR;
using System.Data.Linq;

namespace CprBroker.Tests.DBR
{
    namespace DprDiversionManagerTests
    {
        public class GetTasks : DbrTestBase
        {
            [Test]
            public void SyncTasks_NewQueuesWithPort_Created(
                [Range(1, 100)]int c)
            {

                using (var manager = new DprDiversionManager())
                {
                    for (int i = 0; i < c; i++)
                        AddDbrQueue(true);

                    var tasks = manager.GetTasks();
                    var c2 = tasks.Length;

                    Assert.AreEqual(c, c2);
                }
            }

            [Test]
            public void SyncTasks_NewQueueWithoutPort_NoQueues(
                [Range(1, 100)]int c)
            {

                using (var manager = new DprDiversionManager())
                {
                    for (int i = 0; i < c; i++)
                        AddDbrQueue(false);
                    var tasks = manager.GetTasks();
                    var c2 = tasks.Length;

                    Assert.AreEqual(0, c2);
                }
            }
        }

        public class Start : DbrTestBase
        {
            public class DprDiversionManagerStub : DprDiversionManager
            {
                protected override TimeSpan CalculateActionTimerInterval(TimeSpan currentInterval)
                {
                    var ms = TimeSpan.FromMilliseconds(1);

                    if (currentInterval == ms)
                        return TimeSpan.FromSeconds(60);
                    else
                        return ms;
                }

                public bool PerformTimerAction_Called = false;
                protected override void PerformTimerAction()
                {
                    base.PerformTimerAction();
                    PerformTimerAction_Called = true;
                }

                public void WaitForFirstRun()
                {
                    while (!PerformTimerAction_Called)
                        System.Threading.Thread.Sleep(100);
                }
            }
            [Test]
            public void Start_Start_CorrectCurrentCount([Range(1, 20)] int count)
            {
                using (var manager = new DprDiversionManagerStub())
                {
                    for (int i = 0; i < count; i++)
                        AddDbrQueue(true);
                    
                    manager.Start();
                    manager.WaitForFirstRun();

                    var c = manager.GetCurrentTaskExecuters().Length;
                    Assert.AreEqual(count, c);
                }
            }

            [Test]
            public void Start_StartAndStop_ZeroCurrent([Range(1, 20)] int count)
            {
                using (var manager = new DprDiversionManagerStub())
                {
                    for (int i = 0; i < count; i++)
                        AddDbrQueue(true);

                    manager.Start();
                    manager.WaitForFirstRun();

                    manager.Stop();
                    var c = manager.GetCurrentTaskExecuters().Length;
                    Assert.AreEqual(0, c);
                }
            }

            [Test]
            public void Start_Queue_GoesToDbr()
            {
                using (var manager = new DprDiversionManagerStub())
                {
                    var q = AddDbrQueue(true);

                    manager.Start();
                    manager.WaitForFirstRun();

                    var dpr = CreateDprProvider(q);
                    string pnr = "";
                    dpr.CallDiversion(Providers.DPR.InquiryType.DataUpdatedAutomaticallyFromCpr, Providers.DPR.DetailType.ExtendedData, pnr);
                }

                using (var dataContext = new DataContext(DbrDatabase.ConnectionString))
                {
                    var c = dataContext.ExecuteQuery<int>("SELECT * FROM DTTOTAL WHERE PNR ={0}", decimal.Parse(pnr));
                    Assert.AreEqual(1, c);
                }
            }
        }


    }

}