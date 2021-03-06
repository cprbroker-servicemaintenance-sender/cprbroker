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
using CprBroker.Schemas.Util;
using CprBroker.Schemas.Part;
using NUnit.Framework;

namespace CprBroker.Tests.Schemas
{
    namespace EnumsTests
    {
        [TestFixture]
        public class IsValidCivilRegistrationStatus
        {
            [Test]
            public void IsValidCivilRegistrationStatus_Valid_ReturnsTrue(
                [Values(1, 3, 5, 7, 20, 30, 50, 60, 70, 80, 90)]decimal status)
            {
                var result = Enums.IsValidCivilRegistrationStatus(status);
                Assert.True(result);
            }

            [Test]
            public void IsValidCivilRegistrationStatus_Invalid_ReturnsFalse(
                [Values(0, 15, -2, 17, 99, 103, 2007, -43)]decimal status)
            {
                var result = Enums.IsValidCivilRegistrationStatus(status);
                Assert.False(result);
            }

        }

        [TestFixture]
        public class IsActiveCivilRegistrationStatus
        {

            [Test]
            public void IsActiveCivilRegistrationStatus_Inactive_ReturnsFalse(
                [Values(30, 50, 60)]decimal status)
            {
                var result = Enums.IsActiveCivilRegistrationStatus(status);
                Assert.False(result);
            }

            [Test]
            public void IsActiveCivilRegistrationStatus_Active_ReturnsTrue(
                [Values(1, 3, 5, 7, 20, 70, 80, 90)]decimal status)
            {
                var result = Enums.IsActiveCivilRegistrationStatus(status);
                Assert.True(result);
            }

            [Test]
            [ExpectedException(typeof(ArgumentException))]
            public void IsActiveCivilRegistrationStatus_InvalidNumber_ThrowsException(
                [Values(0, 15, -2, 17, 99, 103, 2007, -43)]decimal status)
            {
                var result = Enums.IsActiveCivilRegistrationStatus(status);
                Assert.True(result);
            }

        }

        [TestFixture]
        public class PersonNumberToGender
        {
            [Test]
            public void PersonNumberToGender_Odd_Male(
                [Values("1234567891", "9999999999")]string pnr)
            {
                var ret = Enums.PersonNumberToGender(pnr);
                Assert.AreEqual(ret, PersonGenderCodeType.male);
            }

            [Test]
            public void PersonNumberToGender_Even_Female(
                [Values("1234567890", "9999999998")]string pnr)
            {
                var ret = Enums.PersonNumberToGender(pnr);
                Assert.AreEqual(ret, PersonGenderCodeType.female);
            }
        }
    }
}
