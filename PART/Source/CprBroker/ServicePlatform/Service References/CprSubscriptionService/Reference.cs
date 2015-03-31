﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Providers.ServicePlatform.CprSubscriptionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/", ConfigurationName="CprSubscriptionService.CprSubscriptionWebServicePortType")]
    public interface CprSubscriptionWebServicePortType {
        
        // CODEGEN: Generating message contract since the operation AddPNRSubscription is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponse AddPNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionRequest request);
        
        // CODEGEN: Generating message contract since the operation RemovePNRSubscription is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponse RemovePNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/")]
    public partial class AddPNRSubscriptionType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private InvocationContextType invocationContextField;
        
        private string pNRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/InvocationContext/1/", Order=0)]
        public InvocationContextType InvocationContext {
            get {
                return this.invocationContextField;
            }
            set {
                this.invocationContextField = value;
                this.RaisePropertyChanged("InvocationContext");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/cpr/PNR/1/", Order=1)]
        public string PNR {
            get {
                return this.pNRField;
            }
            set {
                this.pNRField = value;
                this.RaisePropertyChanged("PNR");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/InvocationContext/1/")]
    public partial class InvocationContextType : object, System.ComponentModel.INotifyPropertyChanged {
        
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
                this.RaisePropertyChanged("ServiceAgreementUUID");
            }
        }
        
        /// <remarks/>
        public string UserSystemUUID {
            get {
                return this.userSystemUUIDField;
            }
            set {
                this.userSystemUUIDField = value;
                this.RaisePropertyChanged("UserSystemUUID");
            }
        }
        
        /// <remarks/>
        public string UserUUID {
            get {
                return this.userUUIDField;
            }
            set {
                this.userUUIDField = value;
                this.RaisePropertyChanged("UserUUID");
            }
        }
        
        /// <remarks/>
        public string OnBehalfOfUser {
            get {
                return this.onBehalfOfUserField;
            }
            set {
                this.onBehalfOfUserField = value;
                this.RaisePropertyChanged("OnBehalfOfUser");
            }
        }
        
        /// <remarks/>
        public string ServiceUUID {
            get {
                return this.serviceUUIDField;
            }
            set {
                this.serviceUUIDField = value;
                this.RaisePropertyChanged("ServiceUUID");
            }
        }
        
        /// <remarks/>
        public string CallersServiceCallIdentifier {
            get {
                return this.callersServiceCallIdentifierField;
            }
            set {
                this.callersServiceCallIdentifierField = value;
                this.RaisePropertyChanged("CallersServiceCallIdentifier");
            }
        }
        
        /// <remarks/>
        public string AccountingInfo {
            get {
                return this.accountingInfoField;
            }
            set {
                this.accountingInfoField = value;
                this.RaisePropertyChanged("AccountingInfo");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/")]
    public partial class RemovePNRSubscriptionResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/")]
    public partial class RemovePNRSubscriptionType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private InvocationContextType invocationContextField;
        
        private string pNRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/InvocationContext/1/", Order=0)]
        public InvocationContextType InvocationContext {
            get {
                return this.invocationContextField;
            }
            set {
                this.invocationContextField = value;
                this.RaisePropertyChanged("InvocationContext");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://serviceplatformen.dk/xml/schemas/cpr/PNR/1/", Order=1)]
        public string PNR {
            get {
                return this.pNRField;
            }
            set {
                this.pNRField = value;
                this.RaisePropertyChanged("PNR");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/")]
    public partial class AddPNRSubscriptionResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPNRSubscriptionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/", Order=0)]
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionType AddPNRSubscription;
        
        public AddPNRSubscriptionRequest() {
        }
        
        public AddPNRSubscriptionRequest(CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionType AddPNRSubscription) {
            this.AddPNRSubscription = AddPNRSubscription;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPNRSubscriptionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddPNRSubscriptionResponse", Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/", Order=0)]
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponseType AddPNRSubscriptionResponse1;
        
        public AddPNRSubscriptionResponse() {
        }
        
        public AddPNRSubscriptionResponse(CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponseType AddPNRSubscriptionResponse1) {
            this.AddPNRSubscriptionResponse1 = AddPNRSubscriptionResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemovePNRSubscriptionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/", Order=0)]
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionType RemovePNRSubscription;
        
        public RemovePNRSubscriptionRequest() {
        }
        
        public RemovePNRSubscriptionRequest(CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionType RemovePNRSubscription) {
            this.RemovePNRSubscription = RemovePNRSubscription;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemovePNRSubscriptionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemovePNRSubscriptionResponse", Namespace="http://serviceplatformen.dk/xml/wsdl/soap11/CprSubscriptionService/1/", Order=0)]
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponseType RemovePNRSubscriptionResponse1;
        
        public RemovePNRSubscriptionResponse() {
        }
        
        public RemovePNRSubscriptionResponse(CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponseType RemovePNRSubscriptionResponse1) {
            this.RemovePNRSubscriptionResponse1 = RemovePNRSubscriptionResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CprSubscriptionWebServicePortTypeChannel : CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CprSubscriptionWebServicePortTypeClient : System.ServiceModel.ClientBase<CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType>, CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType {
        
        public CprSubscriptionWebServicePortTypeClient() {
        }
        
        public CprSubscriptionWebServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CprSubscriptionWebServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CprSubscriptionWebServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CprSubscriptionWebServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponse CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType.AddPNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionRequest request) {
            return base.Channel.AddPNRSubscription(request);
        }
        
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponseType AddPNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionType AddPNRSubscription1) {
            CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionRequest inValue = new CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionRequest();
            inValue.AddPNRSubscription = AddPNRSubscription1;
            CprBroker.Providers.ServicePlatform.CprSubscriptionService.AddPNRSubscriptionResponse retVal = ((CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType)(this)).AddPNRSubscription(inValue);
            return retVal.AddPNRSubscriptionResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponse CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType.RemovePNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionRequest request) {
            return base.Channel.RemovePNRSubscription(request);
        }
        
        public CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponseType RemovePNRSubscription(CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionType RemovePNRSubscription1) {
            CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionRequest inValue = new CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionRequest();
            inValue.RemovePNRSubscription = RemovePNRSubscription1;
            CprBroker.Providers.ServicePlatform.CprSubscriptionService.RemovePNRSubscriptionResponse retVal = ((CprBroker.Providers.ServicePlatform.CprSubscriptionService.CprSubscriptionWebServicePortType)(this)).RemovePNRSubscription(inValue);
            return retVal.RemovePNRSubscriptionResponse1;
        }
    }
}
