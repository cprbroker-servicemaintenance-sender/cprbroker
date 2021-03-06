﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS"basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The CPR Broker concept was initally developed by
 * Gentofte Kommune / Municipality of Gentofte, Denmark.
 * Contributor(s):
 * Steen Deth
 *
 *
 * The Initial Code for CPR Broker and related components is made in
 * cooperation between Magenta, Gentofte Kommune and IT- og Telestyrelsen /
 * Danish National IT and Telecom Agency
 *
 * Contributor(s):
 * Beemen Beshara
 *
 * The code is currently governed by IT- og Telestyrelsen / Danish National
 * IT and Telecom Agency
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CprBroker.Installers;
using CprBroker.Utilities;

namespace CprBroker.Tests.Installers
{
    namespace WebsiteCustomActionHelpersTests
    {
        [TestFixture]
        public class AddUrlToLocalIntranet
        {
            string[] ValidUrlPatterns = new string[] { "http://PersonMaster:80" };
            string[] RandomUrls
            {
                get
                {
                    List<string> ret = new List<string>();
                    for (int i = 0; i < 5; i++)
                    {
                        ret.Add(string.Format("http://ss{0}/asde", Guid.NewGuid().ToString().Substring(0, 10)));
                    }
                    return ret.ToArray();
                }
            }

            [Test]
            public void AddUrlToLocalIntranet_Valid_Passes(
                [ValueSource("RandomUrls")] string url)
            {
                WebsiteCustomAction.AddUrlToLocalIntranet(url);
            }
        }

        [TestFixture]
        public class RunRegIISCommand
        {
            [Test]
            public void RunRegIISCommand_Normal_Normal()
            {
                var args = "-s abcd";
                var fileName = WebsiteCustomAction.RunRegIISCommand(ref args, new Version(4, 0));
                if (Misc.CurrentWindowsVersion >= new Version(10, 0))
                {
                    Assert.IsNullOrEmpty(fileName);
                }
                else {
                    Assert.AreEqual("dism.exe", fileName);
                    Installation.RunCommand(fileName, args);
                    Assert.IsNotNullOrEmpty(args);
                }
            }

        }

        [TestFixture]
        public class RunRegIIS
        {
            [Test]
            public void RunRegIIS_dist_Succeeds()
            {
                if (Misc.CurrentWindowsVersion < new Version(10, 0))
                {
                    var frameworkVersion = new Version(4, 6, 1);
                    var fileName = CprBroker.Utilities.Strings.EnsureDirectoryEndSlash(Environment.SystemDirectory) + "dism.exe";
                    var args = "/online /enable-feature /featurename:"
                        + (frameworkVersion.Major == 4 ?
                            "IIS-ASPNET45"
                            : "IIS-ASPNET");
                    Installation.RunCommand(fileName, args);
                }
            }
        }
    }
}
