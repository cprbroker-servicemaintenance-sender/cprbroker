﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Providers.ServicePlatform.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CprBroker.Providers.ServicePlatform.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A01 Flytning
        ///A02 Forsvinding
        ///A03 Genfinding
        ///A04 Genindrejse
        ///A06 Udrejse
        ///A07 Ændring af supplerende adresse
        ///A08 Opdatering af udlandsfelter/valgretsfelter
        ///A09 Korrektion af aktuel adresse
        ///A10 Annullation af aktuel adresse - udrejse eller forsvinding
        ///A13 Navneændring (ved ændring af adresseringsnavn/fornavn/mellemnavn/efternavn)
        ///A14 Navngivelse
        ///A15 Opdater navnefelter (ved ændring af adresseringsnavn/fornavn/mellemnavn/efternavn)
        ///A16 Korrektion af aktuelle navne (ved ændring af fornavn/mellemnavn/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CprEvents {
            get {
                return ResourceManager.GetString("CprEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;iso-8859-1&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;Gctp v=&quot;1.0&quot; &gt;
        ///    &lt;System r=&quot;CprSoeg&quot;&gt;
        ///        &lt;Service r=&quot;Stam+&quot;&gt;
        ///            &lt;CprServiceHeader r=&quot;Stam+&quot;&gt;
        ///                &lt;Key&gt;
        ///                    &lt;Field r=&quot;PNR&quot; v=&quot;&quot;/&gt;
        ///                &lt;/Key&gt;
        ///            &lt;/CprServiceHeader&gt;
        ///        &lt;/Service&gt;
        ///    &lt;/System&gt;
        ///&lt;/Gctp&gt;.
        /// </summary>
        internal static string PnrLookup {
            get {
                return ResourceManager.GetString("PnrLookup", resourceCulture);
            }
        }
    }
}
