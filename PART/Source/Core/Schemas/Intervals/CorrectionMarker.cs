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

namespace CprBroker.Schemas.Part
{
    public interface IHasCorrectionMarker : ITimedType
    {
        char CorrectionMarker { get; }
    }

    public interface IHasNullableCorrectionMarker : ITimedType
    {
        char? CorrectionMarker { get; }
    }

    public static class CorrectionMarker
    {
        public const char Edit_Overwritten = 'K';
        public const char Undo = 'A';
        public const char TechnicalChange = 'Æ';
        public const char OK = ' ';


        public static IQueryable<ITimedType> Filter(IQueryable<ITimedType> originalDataObjects)
        {
            var dataObjects = originalDataObjects.ToList();

            // Filter out undo records            
            var undoRecords = dataObjects.Where(o => o is IHasCorrectionMarker && (o as IHasCorrectionMarker).CorrectionMarker == Undo).ToArray();

            dataObjects.RemoveAll(oldRecord =>
                !undoRecords.Contains(oldRecord)
                &&
                undoRecords.Where(undoRecord =>
                    undoRecord.Tag == oldRecord.Tag
                    && undoRecord.Registration.RegistrationDate > oldRecord.Registration.RegistrationDate
                    && undoRecord.ToStartTS() == oldRecord.ToStartTS()
                    ).FirstOrDefault() != null
            );
            dataObjects = dataObjects.Except(undoRecords).ToList();

            var editAndTechnicalChange = new char[] { Edit_Overwritten, TechnicalChange };

            // Filter out records that have been overwritten, and also delete the record with the marker
            var editRecords = dataObjects.Where(o => o is IHasCorrectionMarker && editAndTechnicalChange.Contains((o as IHasCorrectionMarker).CorrectionMarker)).ToArray();

            dataObjects.RemoveAll(oldRecord =>
                !editRecords.Contains(oldRecord)
                &&
                editRecords.Where(undoRecord =>
                    undoRecord.Tag == oldRecord.Tag
                    && undoRecord.Registration.RegistrationDate > oldRecord.Registration.RegistrationDate
                    && undoRecord.ToStartTS() == oldRecord.ToStartTS()
                    ).FirstOrDefault() != null
            );
            dataObjects = dataObjects.Except(editRecords).ToList();

            return dataObjects.AsQueryable();
        }

        public static bool IsOk(this IHasCorrectionMarker obj)
        {
            return obj.CorrectionMarker.Equals(CorrectionMarker.OK);
        }

        public static bool IsOk(this IHasNullableCorrectionMarker obj)
        {
            return !obj.CorrectionMarker.HasValue || obj.CorrectionMarker.Equals(CorrectionMarker.OK);
        }
    }
}
