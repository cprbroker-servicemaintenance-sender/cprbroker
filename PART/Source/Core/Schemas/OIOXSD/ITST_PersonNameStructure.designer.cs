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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rep.oio.dk/itst.dk/xml/schemas/2006/01/17/")]
    [System.Xml.Serialization.XmlRootAttribute("PersonNameStructure", Namespace="http://rep.oio.dk/itst.dk/xml/schemas/2006/01/17/", IsNullable=false)]
    public partial class PersonNameStructureType {
        
        private string personGivenNameField;
        
        private string personMiddleNameField;
        
        private string personSurnameNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/")]
        public string PersonGivenName {
            get {
                return this.personGivenNameField;
            }
            set {
                this.personGivenNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/")]
        public string PersonMiddleName {
            get {
                return this.personMiddleNameField;
            }
            set {
                this.personMiddleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/")]
        public string PersonSurnameName {
            get {
                return this.personSurnameNameField;
            }
            set {
                this.personSurnameNameField = value;
            }
        }
    }
}