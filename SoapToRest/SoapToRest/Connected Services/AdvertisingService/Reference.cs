﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapToRest.AdvertisingService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnnonsKlass", Namespace="http://schemas.datacontract.org/2004/07/AdvertisingService")]
    [System.SerializableAttribute()]
    public partial class AnnonsKlass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string onHooverTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string resourceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string onHooverText {
            get {
                return this.onHooverTextField;
            }
            set {
                if ((object.ReferenceEquals(this.onHooverTextField, value) != true)) {
                    this.onHooverTextField = value;
                    this.RaisePropertyChanged("onHooverText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string resource {
            get {
                return this.resourceField;
            }
            set {
                if ((object.ReferenceEquals(this.resourceField, value) != true)) {
                    this.resourceField = value;
                    this.RaisePropertyChanged("resource");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdvertisingService.IServiceAdvertising")]
    public interface IServiceAdvertising {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoWork", ReplyAction="http://tempuri.org/IServiceAdvertising/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoWork", ReplyAction="http://tempuri.org/IServiceAdvertising/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/ReadAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/ReadAnnonsResponse")]
        SoapToRest.AdvertisingService.AnnonsKlass[] ReadAnnons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/ReadAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/ReadAnnonsResponse")]
        System.Threading.Tasks.Task<SoapToRest.AdvertisingService.AnnonsKlass[]> ReadAnnonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/CreateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/CreateAnnonsResponse")]
        void CreateAnnons(string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/CreateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/CreateAnnonsResponse")]
        System.Threading.Tasks.Task CreateAnnonsAsync(string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/UpdateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/UpdateAnnonsResponse")]
        void UpdateAnnons(int addId, string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/UpdateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/UpdateAnnonsResponse")]
        System.Threading.Tasks.Task UpdateAnnonsAsync(int addId, string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DeleteAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/DeleteAnnonsResponse")]
        void DeleteAnnons(int addId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DeleteAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/DeleteAnnonsResponse")]
        System.Threading.Tasks.Task DeleteAnnonsAsync(int addId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAdvertisingChannel : SoapToRest.AdvertisingService.IServiceAdvertising, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAdvertisingClient : System.ServiceModel.ClientBase<SoapToRest.AdvertisingService.IServiceAdvertising>, SoapToRest.AdvertisingService.IServiceAdvertising {
        
        public ServiceAdvertisingClient() {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdvertisingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public SoapToRest.AdvertisingService.AnnonsKlass[] ReadAnnons() {
            return base.Channel.ReadAnnons();
        }
        
        public System.Threading.Tasks.Task<SoapToRest.AdvertisingService.AnnonsKlass[]> ReadAnnonsAsync() {
            return base.Channel.ReadAnnonsAsync();
        }
        
        public void CreateAnnons(string resource, string onHooverText) {
            base.Channel.CreateAnnons(resource, onHooverText);
        }
        
        public System.Threading.Tasks.Task CreateAnnonsAsync(string resource, string onHooverText) {
            return base.Channel.CreateAnnonsAsync(resource, onHooverText);
        }
        
        public void UpdateAnnons(int addId, string resource, string onHooverText) {
            base.Channel.UpdateAnnons(addId, resource, onHooverText);
        }
        
        public System.Threading.Tasks.Task UpdateAnnonsAsync(int addId, string resource, string onHooverText) {
            return base.Channel.UpdateAnnonsAsync(addId, resource, onHooverText);
        }
        
        public void DeleteAnnons(int addId) {
            base.Channel.DeleteAnnons(addId);
        }
        
        public System.Threading.Tasks.Task DeleteAnnonsAsync(int addId) {
            return base.Channel.DeleteAnnonsAsync(addId);
        }
    }
}