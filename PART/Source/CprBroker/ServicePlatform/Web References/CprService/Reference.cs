﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace CprBroker.Providers.ServicePlatform.CprService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CprBinding", Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprService/1/")]
    public partial class CprService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback forwardToCPRServiceOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CprService() {
            this.Url = global::CprBroker.Providers.ServicePlatform.Properties.Settings.Default.CprBroker_Providers_ServicePlatform_CprService_CprService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event forwardToCPRServiceCompletedEventHandler forwardToCPRServiceCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestElementName="forwardToCPRServiceRequest", RequestNamespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprService/1/", ResponseNamespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprService/1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result")]
        public string forwardToCPRService([System.Xml.Serialization.XmlElementAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/InvocationContext/1/")] InvocationContextType InvocationContext, string gctpMessage) {
            object[] results = this.Invoke("forwardToCPRService", new object[] {
                        InvocationContext,
                        gctpMessage});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void forwardToCPRServiceAsync(InvocationContextType InvocationContext, string gctpMessage) {
            this.forwardToCPRServiceAsync(InvocationContext, gctpMessage, null);
        }
        
        /// <remarks/>
        public void forwardToCPRServiceAsync(InvocationContextType InvocationContext, string gctpMessage, object userState) {
            if ((this.forwardToCPRServiceOperationCompleted == null)) {
                this.forwardToCPRServiceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnforwardToCPRServiceOperationCompleted);
            }
            this.InvokeAsync("forwardToCPRService", new object[] {
                        InvocationContext,
                        gctpMessage}, this.forwardToCPRServiceOperationCompleted, userState);
        }
        
        private void OnforwardToCPRServiceOperationCompleted(object arg) {
            if ((this.forwardToCPRServiceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.forwardToCPRServiceCompleted(this, new forwardToCPRServiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/InvocationContext/1/")]
    public partial class InvocationContextType {
        
        private string serviceAgreementUUIDField;
        
        private string userSystemUUIDField;
        
        private string userUUIDField;
        
        private string onBehalfOfUserField;
        
        private string serviceUUIDField;
        
        private string callersServiceCallIdentifierField;
        
        private string accountingInfoField;
        
        /// <remarks/>
        public string ServiceAgreementUUID {
            get {
                return this.serviceAgreementUUIDField;
            }
            set {
                this.serviceAgreementUUIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserSystemUUID {
            get {
                return this.userSystemUUIDField;
            }
            set {
                this.userSystemUUIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserUUID {
            get {
                return this.userUUIDField;
            }
            set {
                this.userUUIDField = value;
            }
        }
        
        /// <remarks/>
        public string OnBehalfOfUser {
            get {
                return this.onBehalfOfUserField;
            }
            set {
                this.onBehalfOfUserField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceUUID {
            get {
                return this.serviceUUIDField;
            }
            set {
                this.serviceUUIDField = value;
            }
        }
        
        /// <remarks/>
        public string CallersServiceCallIdentifier {
            get {
                return this.callersServiceCallIdentifierField;
            }
            set {
                this.callersServiceCallIdentifierField = value;
            }
        }
        
        /// <remarks/>
        public string AccountingInfo {
            get {
                return this.accountingInfoField;
            }
            set {
                this.accountingInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void forwardToCPRServiceCompletedEventHandler(object sender, forwardToCPRServiceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class forwardToCPRServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal forwardToCPRServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591