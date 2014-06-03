﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Installers.EventBrokerInstallers.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CprBroker.Installers.EventBrokerInstallers.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[BirthdateEventNotification]&apos;) AND type in (N&apos;U&apos;))
        ///DROP TABLE [dbo].[BirthdateEventNotification]
        ///GO
        ///
        ////****** Object:  Table [dbo].[BirthdateEventNotification]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[BirthdateEventNotification]&apos;) AND type in (N&apos;U&apos;))
        ///BEGIN
        ///CREATE TABLE [dbo].[BirthdateEventNotification](
        ///	[EventNotificationId] [uniqueidentifier] NO [rest of string was truncated]&quot;;.
        /// </summary>
        public static string BirthdateEventNotification {
            get {
                return ResourceManager.GetString("BirthdateEventNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  ForeignKey [FK_Channel_ChannelType]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N&apos;[dbo].[FK_Channel_ChannelType]&apos;) AND parent_object_id = OBJECT_ID(N&apos;[dbo].[Channel]&apos;))
        ///ALTER TABLE [dbo].[Channel] DROP CONSTRAINT [FK_Channel_ChannelType]
        ///GO
        ////****** Object:  ForeignKey [FK_Channel_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N&apos;[dbo].[ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Channel {
            get {
                return ResourceManager.GetString("Channel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ChannelTypeId;Name
        ///1;WebService
        ///2;GPAC
        ///3;FileShare
        ///.
        /// </summary>
        public static string ChannelType {
            get {
                return ResourceManager.GetString("ChannelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[ChannelType]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[ChannelType]&apos;) AND type in (N&apos;U&apos;))
        ///DROP TABLE [dbo].[ChannelType]
        ///GO
        ////****** Object:  Table [dbo].[ChannelType]    Script Date: 02/13/2011 17:59:04 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[ChannelType]&apos;) AND type in (N&apos;U&apos;))
        ///BEGIN
        ///CREATE TABLE [d [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ChannelType_Create {
            get {
                return ResourceManager.GetString("ChannelType_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  ForeignKey [FK_Channel_ChannelType]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N&apos;[dbo].[FK_Channel_ChannelType]&apos;) AND parent_object_id = OBJECT_ID(N&apos;[dbo].[Channel]&apos;))
        ///ALTER TABLE [dbo].[Channel] DROP CONSTRAINT [FK_Channel_ChannelType]
        ///GO
        ////****** Object:  ForeignKey [FK_Channel_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N&apos;[dbo].[ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateEventBrokerDatabaseObjects {
            get {
                return ResourceManager.GetString("CreateEventBrokerDatabaseObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* ***** BEGIN LICENSE BLOCK *****
        /// * Version: MPL 1.1/GPL 2.0/LGPL 2.1
        /// *
        /// * The contents of this file are subject to the Mozilla Public License
        /// * Version 1.1 (the &quot;License&quot;); you may not use this file except in
        /// * compliance with the License. You may obtain a copy of the License at
        /// * http://www.mozilla.org/MPL/
        /// *
        /// * Software distributed under the License is distributed on an &quot;AS IS&quot;basis,
        /// * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
        /// * for the specific language  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EnqueueBirthdateEventNotifications {
            get {
                return ResourceManager.GetString("EnqueueBirthdateEventNotifications", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    Input:
        ///    ------
        ///    - Current time (@Now) to mark changes with timestamp
        ///    - Subset of data change events (defined as ReceivedOrder &lt;= @LatestReceivedOrder)
        ///    - @SubscriptionTypeId to mark data change subscriptions (instead of having the typeId hardcoded)
        ///
        ///    Result:
        ///    -------
        ///    Rows inserted in EventNotification for each DataChangeEvent X active subscriptions that are any of these:
        ///    - Are for specific persons, and these persons include the person in the DataChangeEvent
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EnqueueDataChangeEventNotifications {
            get {
                return ResourceManager.GetString("EnqueueDataChangeEventNotifications", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* ***** BEGIN LICENSE BLOCK *****
        /// * Version: MPL 1.1/GPL 2.0/LGPL 2.1
        /// *
        /// * The contents of this file are subject to the Mozilla Public License
        /// * Version 1.1 (the &quot;License&quot;); you may not use this file except in
        /// * compliance with the License. You may obtain a copy of the License at
        /// * http://www.mozilla.org/MPL/
        /// *
        /// * Software distributed under the License is distributed on an &quot;AS IS&quot;basis,
        /// * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
        /// * for the specific language  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string IsBirthdateEvent {
            get {
                return ResourceManager.GetString("IsBirthdateEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ----------------------------------------------------------------------------------------
        ///---   Delete tables that are no longer used   --------------------------------------
        ///----------------------------------------------------------------------------------------
        ///
        ///IF EXISTS (SELECT * FROM sys.tables WHERE object_id  = OBJECT_ID(&apos;BirthdateNotificationPerson&apos;))
        ///	DROP TABLE BirthdateNotificationPerson
        ///GO
        ///
        ///IF EXISTS (SELECT * FROM sys.tables WHERE object_id = object_id(&apos;NotificationPerson&apos;))
        ///	DROP TABLE [rest of string was truncated]&quot;;.
        /// </summary>
        public static string PatchDatabase_2_2 {
            get {
                return ResourceManager.GetString("PatchDatabase_2_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SubscriptionTypeId;TypeName
        ///1;ChangeSubscription
        ///2;BirthdateSubscription
        ///.
        /// </summary>
        public static string SubscriptionType {
            get {
                return ResourceManager.GetString("SubscriptionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[SubscriptionType]    Script Date: 02/13/2011 17:59:04 ******/
        ///IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[SubscriptionType]&apos;) AND type in (N&apos;U&apos;))
        ///DROP TABLE [dbo].[SubscriptionType]
        ///GO
        ///
        ////****** Object:  Table [dbo].[SubscriptionType]    Script Date: 02/13/2011 17:59:04 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[dbo].[SubscriptionType]&apos;) AND type in (N&apos;U [rest of string was truncated]&quot;;.
        /// </summary>
        public static string SubscriptionType_Create {
            get {
                return ResourceManager.GetString("SubscriptionType_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    Preconditions:
        ///    --------------
        ///    Current subset of data changes should have been matched to all the subscriptions that have Criteria IS NOT NULL,
        ///    Matches should have been pushed into SubscriptionCriteriaMatch
        ///
        ///    Input:
        ///    ------
        ///    - Current time (@Now) to mark changes with timestamp
        ///    - Subset of data change events (defined as ReceivedOrder &lt;= @LatestReceivedOrder)
        ///    - @SubscriptionTypeId to mark data change subscriptions (instead of having the typeId hardcoded)
        ///    
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        public static string UpdatePersonLists {
            get {
                return ResourceManager.GetString("UpdatePersonLists", resourceCulture);
            }
        }
    }
}
