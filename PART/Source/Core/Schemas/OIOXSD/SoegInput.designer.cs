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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoegInputType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:2.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("SoegInput", Namespace="urn:oio:sagdok:2.0.0", IsNullable=false)]
    public partial class SoegInputType {
        
        private string foersteResultatReferenceField;
        
        private string maksimalAntalKvantitetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string FoersteResultatReference {
            get {
                return this.foersteResultatReferenceField;
            }
            set {
                this.foersteResultatReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string MaksimalAntalKvantitet {
            get {
                return this.maksimalAntalKvantitetField;
            }
            set {
                this.maksimalAntalKvantitetField = value;
            }
        }
    }
}