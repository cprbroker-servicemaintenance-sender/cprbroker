//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace CprBroker.Schemas.Part {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("LaesOejebliksbilledeInput", Namespace="urn:oio:sagdok:person:1.0.0", IsNullable=false)]
    public partial class LaesOejebliksbilledeInputType : OejebliksbilledeInputType {
        
        private string uUIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oio:dkal:1.0.0")]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListOejebliksbilledeInputType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LaesOejebliksbilledeInputType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    public partial class OejebliksbilledeInputType {
        
        private System.Nullable<System.DateTime> virkningDatoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> VirkningDato {
            get {
                return this.virkningDatoField;
            }
            set {
                this.virkningDatoField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("LaesPeriodInput", Namespace="urn:oio:sagdok:person:1.0.0", IsNullable=false)]
    public partial class LaesPeriodInputType : PeriodInputType {
        
        private string uUIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oio:dkal:1.0.0")]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListPeriodInputType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LaesPeriodInputType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    public partial class PeriodInputType {
        
        private System.DateTime virkningFraDatoField;
        
        private System.DateTime virkningTilDatoField;
        
        /// <remarks/>
        public System.DateTime VirkningFraDato {
            get {
                return this.virkningFraDatoField;
            }
            set {
                this.virkningFraDatoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime VirkningTilDato {
            get {
                return this.virkningTilDatoField;
            }
            set {
                this.virkningTilDatoField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("ListPeriodInput", Namespace="urn:oio:sagdok:person:1.0.0", IsNullable=false)]
    public partial class ListPeriodInputType : PeriodInputType {
        
        private string[] uUIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace="urn:oio:dkal:1.0.0")]
        public string[] UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:person:1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("ListOejebliksbilledeInput", Namespace="urn:oio:sagdok:person:1.0.0", IsNullable=false)]
    public partial class ListOejebliksbilledeInputType : OejebliksbilledeInputType {
        
        private string[] uUIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace="urn:oio:dkal:1.0.0")]
        public string[] UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
    }
}