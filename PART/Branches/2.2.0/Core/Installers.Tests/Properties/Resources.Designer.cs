﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Tests.Installers.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CprBroker.Tests.Installers.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;configuration&gt;
        ///
        ///  &lt;configSections&gt;
        ///    &lt;section name=&quot;loggingConfiguration&quot; type=&quot;Microsoft.Practices.EnterpriseLibrary.Logging.Configuration.LoggingSettings, Microsoft.Practices.EnterpriseLibrary.Logging&quot; /&gt;
        ///
        ///    &lt;sectionGroup name=&quot;applicationSettings&quot; type=&quot;System.Configuration.ApplicationSettingsGroup, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089&quot; &gt;
        ///      &lt;section name=&quot;CprBroker.Config.Properties.Settings&quot; type=&quot;System.Configur [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CprBroker_EventBroker_Backend_exe {
            get {
                return ResourceManager.GetString("CprBroker_EventBroker_Backend_exe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;!-- 
        ///    Note: As an alternative to hand editing this file you can use the 
        ///    web admin tool to configure settings for your application. Use
        ///    the Website-&gt;Asp.Net Configuration option in Visual Studio.
        ///    A full list of settings and comments can be found in 
        ///    machine.config.comments usually located in 
        ///    \Windows\Microsoft.Net\Framework\v2.x\Config 
        ///--&gt;
        ///&lt;configuration&gt;
        ///  &lt;configSections&gt;
        ///    &lt;sectionGroup name=&quot;dataProvidersGroup&quot;&gt;
        ///      &lt;section name=&quot;dataProvi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WebConfig {
            get {
                return ResourceManager.GetString("WebConfig", resourceCulture);
            }
        }
    }
}