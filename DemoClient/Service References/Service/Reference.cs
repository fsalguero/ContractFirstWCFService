﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoClient.Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorMessage", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ErrorMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string errorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.errorCodeField, value) != true)) {
                    this.errorCodeField = value;
                    this.RaisePropertyChanged("errorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="Service.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org:testIn", ReplyAction="http://tempuri.org/IDemoService/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DemoClient.Service.ErrorMessage), Action="http://tempuri.org:testIn", Name="ErrorMessage", Namespace="http://tempuri.org/")]
        DemoClient.Service.TestResponse Test(DemoClient.Service.TestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int number;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string field1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string field2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string field3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string field4;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string field5;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string field6;
        
        public TestRequest() {
        }
        
        public TestRequest(string name, int number, string field1, string field2, string field3, string field4, string field5, string field6) {
            this.name = name;
            this.number = number;
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
            this.field4 = field4;
            this.field5 = field5;
            this.field6 = field6;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string result1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public short result2;
        
        public TestResponse() {
        }
        
        public TestResponse(string result1, short result2) {
            this.result1 = result1;
            this.result2 = result2;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : DemoClient.Service.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<DemoClient.Service.IDemoService>, DemoClient.Service.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DemoClient.Service.TestResponse Test(DemoClient.Service.TestRequest request) {
            return base.Channel.Test(request);
        }
    }
}
