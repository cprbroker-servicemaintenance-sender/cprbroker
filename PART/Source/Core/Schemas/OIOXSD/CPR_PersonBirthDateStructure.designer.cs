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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/11/24/")]
    [System.Xml.Serialization.XmlRootAttribute("PersonBirthDateStructure", Namespace="http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/11/24/", IsNullable=false)]
    public partial class PersonBirthDateStructureType {
        
        private System.DateTime birthDateField;
        
        private bool birthDateUncertaintyIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/03/15/", DataType="date")]
        public System.DateTime BirthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        public bool BirthDateUncertaintyIndicator {
            get {
                return this.birthDateUncertaintyIndicatorField;
            }
            set {
                this.birthDateUncertaintyIndicatorField = value;
            }
        }
    }
}