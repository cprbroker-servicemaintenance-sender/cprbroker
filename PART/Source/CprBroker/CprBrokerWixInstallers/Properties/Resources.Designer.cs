﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBrokerWixInstallers.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CprBrokerWixInstallers.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code;Name
        ///A;Absolute
        ///B;Calculated
        ///C;No Coordinates
        ///.
        /// </summary>
        internal static string AddressCoordinateQualityType {
            get {
                return ResourceManager.GetString("AddressCoordinateQualityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApplicationId;Name;Token;RegistrationDate;IsApproved;ApprovedDate
        ///{3E9890FF-0038-42A4-987A-99B63E8BC865};Base Application;07059250-E448-4040-B695-9C03F9E59E38;2009-06-25;True;
        ///{C98F9BE7-2DDE-404a-BAB5-5A7B1BBC3063};Event Broker;FCD568A0-8F18-4b6f-8691-C09239F158F3;2011-01-01;True;
        ///{4A78A5C8-B39B-41B9-9707-5782DAA56E2A};CPR Business Application Demo;5f8b7af5-422e-46bb-9273-5e244dc37505;2011-01-01;True;.
        /// </summary>
        internal static string Application {
            get {
                return ResourceManager.GetString("Application", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CivilStatusCodeTypeId;Name
        ///0;Ugift
        ///1;Gift
        ///2;RegistreretPartner
        ///3;Separeret
        ///4;Skilt
        ///5;OphaevetPartnerskab
        ///6;Enke
        ///7;Laengstlevende.
        /// </summary>
        internal static string CivilStatusCodeType {
            get {
                return ResourceManager.GetString("CivilStatusCodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContactChannelTypeId;Name
        ///0;Email
        ///1;Telephone
        ///2;Other
        ///.
        /// </summary>
        internal static string ContactChannelType {
            get {
                return ResourceManager.GetString("ContactChannelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id;Name
        ///0;iso3166alpha2
        ///1;iso3166alpha3
        ///2;unnumeric3
        ///3;imk
        ///.
        /// </summary>
        internal static string CountrySchemeType {
            get {
                return ResourceManager.GetString("CountrySchemeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  ForeignKey [FK_AddressPoint_DanishAddress]    Script Date: 02/27/2011 22:16:41 ******/
        ///IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N&apos;[dbo].[FK_AddressPoint_DanishAddress]&apos;) AND parent_object_id = OBJECT_ID(N&apos;[dbo].[AddressPoint]&apos;))
        ///ALTER TABLE [dbo].[AddressPoint] DROP CONSTRAINT [FK_AddressPoint_DanishAddress]
        ///GO
        ////****** Object:  ForeignKey [FK_AddressPointStatus_AddressCoordinateQualityType]    Script Date: 02/27/2011 22:16:41 ******/
        ///IF  EXISTS (SELECT * F [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreatePartDatabaseObjects {
            get {
                return ResourceManager.GetString("CreatePartDatabaseObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GenderId;GenderName
        ///0;Male
        ///1;Female
        ///2;Unspecified
        ///.
        /// </summary>
        internal static string Gender {
            get {
                return ResourceManager.GetString("Gender", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LifecycleStatusId;LifecycleStatusName
        ///0;Created
        ///1;Imported
        ///2;Deactivated
        ///3;Deleted
        ///4;Updated
        ///.
        /// </summary>
        internal static string LifecycleStatus {
            get {
                return ResourceManager.GetString("LifecycleStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LifeStatusCodeTypeId;Name
        ///0;Prenatal
        ///1;Foedt
        ///2;Forsvundet
        ///3;Doed
        ///.
        /// </summary>
        internal static string LifeStatusCodeType {
            get {
                return ResourceManager.GetString("LifeStatusCodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LogTypeId;Name
        ///1;Critical
        ///2;Error
        ///4;Warning
        ///8;Information
        ///16;Verbose
        ///256;Start
        ///512;Stop
        ///1024;Suspend
        ///2048;Resume
        ///4096;Transfer
        ///.
        /// </summary>
        internal static string LogType {
            get {
                return ResourceManager.GetString("LogType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RelationshipTypeId;ForwardName
        ///0;Mother
        ///1;Father
        ///2;Children
        ///3;Spouse
        ///4;Registered partner
        ///5;Residence collection
        ///6;Custody
        ///7;Parenting adult children
        ///8;Guardian of person
        ///9;Guardianship owner
        ///10;Replacement for
        ///11;Replaced by
        ///.
        /// </summary>
        internal static string RelationshipType {
            get {
                return ResourceManager.GetString("RelationshipType", resourceCulture);
            }
        }
    }
}
