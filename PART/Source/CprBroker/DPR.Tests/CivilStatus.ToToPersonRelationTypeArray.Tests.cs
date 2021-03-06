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
using CprBroker.Schemas;
using CprBroker.Schemas.Part;
using CprBroker.Providers.DPR;
using CprBroker.PartInterface;

namespace CprBroker.Tests.DPR.CivilStatusTests
{
    [TestFixture]
    public class ToToPersonRelationTypeArray : BaseTests
    {
        public char[] AllMaritalStates = new char[] { 'U', 'G', 'F', 'D', 'E', 'P', 'O', 'L', 'u', 'g', 'f', 'd', 'e', 'p', 'o', 'l' };
        [Test]
        [ExpectedException]
        [Ignore]
        public void ToToPersonRelationTypeArray_Null_ThrowsException()
        {
            CivilStatusWrapper.ToPersonRelationTypeArray(null, null, UuidMap.CprStringToUuid, 'U', 'G', 'W', 'D', false);
        }

        [Test]
        [Ignore]
        public void ToToPersonRelationTypeArray_CorrectStatus_Returns2(
            [ValueSource("AllMaritalStates")] char maritalStatus)
        {
            var civilStates = AllMaritalStates.Select(c => new CivilStatusStub() { SpousePNR = Utilities.RandomCprNumber(), MaritalStatus = c } as CivilStatus).ToArray();
            var result = CivilStatusWrapper.ToPersonRelationTypeArray(null, civilStates, UuidMap.CprStringToUuid, maritalStatus, maritalStatus, maritalStatus, maritalStatus, false);
            // 2 are expected because of upper and lower cases
            Assert.AreEqual(2, result.Length);
        }

        [Test]
        [Ignore]
        public void ToToPersonRelationTypeArray_NoSpouse_ReturnsEmpty(
            [ValueSource("AllMaritalStates")] char maritalStatus)
        {
            var civilStates = AllMaritalStates.Select(c => new CivilStatusStub() { SpousePNR = 0, MaritalStatus = c } as CivilStatus).ToArray();
            var result = CivilStatusWrapper.ToPersonRelationTypeArray(null, civilStates, UuidMap.CprStringToUuid, maritalStatus, maritalStatus, maritalStatus, maritalStatus, false);
            Assert.AreEqual(0, result.Length);
        }
    }
}
