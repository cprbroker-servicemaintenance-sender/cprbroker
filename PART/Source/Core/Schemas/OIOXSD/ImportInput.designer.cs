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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImportInputType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oio:sagdok:2.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("ImportInput", Namespace="urn:oio:sagdok:2.0.0", IsNullable=false)]
    public partial class ImportInputType {
        
        private string noteTekstField;
        
        /// <remarks/>
        public string NoteTekst {
            get {
                return this.noteTekstField;
            }
            set {
                this.noteTekstField = value;
            }
        }
    }
}