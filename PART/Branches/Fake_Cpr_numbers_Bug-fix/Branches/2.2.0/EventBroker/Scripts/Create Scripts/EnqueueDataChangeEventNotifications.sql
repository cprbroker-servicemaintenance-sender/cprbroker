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
 * Niels Elgaard Larsen
 * Leif Lodahl
 * Steen Deth
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

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'EnqueueDataChangeEventNotifications')
	BEGIN
		DROP  Procedure  EnqueueDataChangeEventNotifications
	END

GO

CREATE Procedure EnqueueDataChangeEventNotifications
(
		--@StartDate DateTime,
		--@EndDate DateTime,
		@Now DateTime,
		@SubscriptionTypeId Int
)

AS
		-- Subscriptions (that ARE NOT deactivated) for specific persons that deactivated
		INSERT INTO EventNotification (SubscriptionId, PersonUUID, CreatedDate)
		SELECT S.SubscriptionId, DCE.PersonUuid, @Now
		FROM DataChangeEvent AS DCE
		INNER JOIN SubscriptionPerson AS SP ON SP.PersonUuid = DCE.PersonUuid
		INNER JOIN Subscription AS S ON S.SubscriptionId = SP.SubscriptionId
		WHERE 
			--DCE.ReceivedDate BETWEEN @StartDate AND @EndDate
			S.IsForAllPersons = 0
			AND S.SubscriptionTypeId = @SubscriptionTypeId
			-- We test if the subscription has been deactivated
			AND S.Deactivated IS NULL
		
		-- Subscriptions (that ARE deactivated) for specific persons
		INSERT INTO EventNotification (SubscriptionId, PersonUUID, CreatedDate, IsLastNotification)
		SELECT S.SubscriptionId, DCE.PersonUuid, @Now, 1
		FROM DataChangeEvent AS DCE
		INNER JOIN SubscriptionPerson AS SP ON SP.PersonUuid = DCE.PersonUuid
		INNER JOIN Subscription AS S ON S.SubscriptionId = SP.SubscriptionId
		WHERE 
			--DCE.ReceivedDate BETWEEN @StartDate AND @EndDate
			S.IsForAllPersons = 0
			AND S.SubscriptionTypeId = @SubscriptionTypeId
			-- We test if the subscription has been deactivated
			AND S.Deactivated IS NOT NULL
		
		-- Subscriptions for all persons
		INSERT INTO EventNotification (SubscriptionId, PersonUUID, CreatedDate)
		SELECT S.SubscriptionId, DCE.PersonUuid, @Now
		FROM DataChangeEvent AS DCE,	Subscription AS S	
		WHERE 
			--DCE.ReceivedDate BETWEEN @StartDate AND @EndDate
			S.IsForAllPersons = 1
			AND S.SubscriptionTypeId = @SubscriptionTypeId
GO

