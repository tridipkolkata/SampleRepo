﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartIndexerService.PartIndexerWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthHeader", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AuthHeader : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PartIndexerWS.SearchDataIndexSoap")]
    public interface SearchDataIndexSoap {
        
        // CODEGEN: Generating message contract since element name auth from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StartIndex", ReplyAction="*")]
        PartIndexerService.PartIndexerWS.StartIndexResponse StartIndex(PartIndexerService.PartIndexerWS.StartIndexRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StartIndexRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StartIndex", Namespace="http://tempuri.org/", Order=0)]
        public PartIndexerService.PartIndexerWS.StartIndexRequestBody Body;
        
        public StartIndexRequest() {
        }
        
        public StartIndexRequest(PartIndexerService.PartIndexerWS.StartIndexRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StartIndexRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PartIndexerService.PartIndexerWS.AuthHeader auth;
        
        public StartIndexRequestBody() {
        }
        
        public StartIndexRequestBody(PartIndexerService.PartIndexerWS.AuthHeader auth) {
            this.auth = auth;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StartIndexResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StartIndexResponse", Namespace="http://tempuri.org/", Order=0)]
        public PartIndexerService.PartIndexerWS.StartIndexResponseBody Body;
        
        public StartIndexResponse() {
        }
        
        public StartIndexResponse(PartIndexerService.PartIndexerWS.StartIndexResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StartIndexResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StartIndexResult;
        
        public StartIndexResponseBody() {
        }
        
        public StartIndexResponseBody(string StartIndexResult) {
            this.StartIndexResult = StartIndexResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SearchDataIndexSoapChannel : PartIndexerService.PartIndexerWS.SearchDataIndexSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearchDataIndexSoapClient : System.ServiceModel.ClientBase<PartIndexerService.PartIndexerWS.SearchDataIndexSoap>, PartIndexerService.PartIndexerWS.SearchDataIndexSoap {
        
        public SearchDataIndexSoapClient() {
        }
        
        public SearchDataIndexSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearchDataIndexSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchDataIndexSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchDataIndexSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PartIndexerService.PartIndexerWS.StartIndexResponse PartIndexerService.PartIndexerWS.SearchDataIndexSoap.StartIndex(PartIndexerService.PartIndexerWS.StartIndexRequest request) {
            return base.Channel.StartIndex(request);
        }
        
        public string StartIndex(PartIndexerService.PartIndexerWS.AuthHeader auth) {
            PartIndexerService.PartIndexerWS.StartIndexRequest inValue = new PartIndexerService.PartIndexerWS.StartIndexRequest();
            inValue.Body = new PartIndexerService.PartIndexerWS.StartIndexRequestBody();
            inValue.Body.auth = auth;
            PartIndexerService.PartIndexerWS.StartIndexResponse retVal = ((PartIndexerService.PartIndexerWS.SearchDataIndexSoap)(this)).StartIndex(inValue);
            return retVal.Body.StartIndexResult;
        }
    }
}