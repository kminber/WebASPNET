﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjemploWebASPNET.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuarios", Namespace="http://schemas.datacontract.org/2004/07/EjemploWCF")]
    [System.SerializableAttribute()]
    public partial class Usuarios : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> activoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
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
        public System.Nullable<bool> activo {
            get {
                return this.activoField;
            }
            set {
                if ((this.activoField.Equals(value) != true)) {
                    this.activoField = value;
                    this.RaisePropertyChanged("activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreUsuarioField, value) != true)) {
                    this.nombreUsuarioField = value;
                    this.RaisePropertyChanged("nombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerUsuarios", ReplyAction="http://tempuri.org/IService1/ObtenerUsuariosResponse")]
        EjemploWebASPNET.ServiceReference1.Usuarios[] ObtenerUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerUsuarios", ReplyAction="http://tempuri.org/IService1/ObtenerUsuariosResponse")]
        System.Threading.Tasks.Task<EjemploWebASPNET.ServiceReference1.Usuarios[]> ObtenerUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificarAcceso", ReplyAction="http://tempuri.org/IService1/VerificarAccesoResponse")]
        bool VerificarAcceso(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificarAcceso", ReplyAction="http://tempuri.org/IService1/VerificarAccesoResponse")]
        System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        void InsertarUsuario(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task InsertarUsuarioAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        void EliminarUsuario(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DesactivarUsuario", ReplyAction="http://tempuri.org/IService1/DesactivarUsuarioResponse")]
        bool DesactivarUsuario(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DesactivarUsuario", ReplyAction="http://tempuri.org/IService1/DesactivarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> DesactivarUsuarioAsync(string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EjemploWebASPNET.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EjemploWebASPNET.ServiceReference1.IService1>, EjemploWebASPNET.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EjemploWebASPNET.ServiceReference1.Usuarios[] ObtenerUsuarios() {
            return base.Channel.ObtenerUsuarios();
        }
        
        public System.Threading.Tasks.Task<EjemploWebASPNET.ServiceReference1.Usuarios[]> ObtenerUsuariosAsync() {
            return base.Channel.ObtenerUsuariosAsync();
        }
        
        public bool VerificarAcceso(string user, string pass) {
            return base.Channel.VerificarAcceso(user, pass);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string user, string pass) {
            return base.Channel.VerificarAccesoAsync(user, pass);
        }
        
        public void InsertarUsuario(string user, string pass) {
            base.Channel.InsertarUsuario(user, pass);
        }
        
        public System.Threading.Tasks.Task InsertarUsuarioAsync(string user, string pass) {
            return base.Channel.InsertarUsuarioAsync(user, pass);
        }
        
        public void EliminarUsuario(string user) {
            base.Channel.EliminarUsuario(user);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(string user) {
            return base.Channel.EliminarUsuarioAsync(user);
        }
        
        public bool DesactivarUsuario(string user) {
            return base.Channel.DesactivarUsuario(user);
        }
        
        public System.Threading.Tasks.Task<bool> DesactivarUsuarioAsync(string user) {
            return base.Channel.DesactivarUsuarioAsync(user);
        }
    }
}
