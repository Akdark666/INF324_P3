﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet tblAlumno();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tblAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> tblAlumnoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insAlumno(string ci, string nom, string pat, string depto, int pra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task insAlumnoAsync(string ci, string nom, string pat, string depto, int pra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actAlumno(string ci, string nom, string pat, string depto, int pra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task actAlumnoAsync(string ci, string nom, string pat, string depto, int pra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliAlumno(string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task eliAlumnoAsync(string ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowsFormsApplication1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.WebServiceSoap>, WindowsFormsApplication1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet tblAlumno() {
            return base.Channel.tblAlumno();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> tblAlumnoAsync() {
            return base.Channel.tblAlumnoAsync();
        }
        
        public void insAlumno(string ci, string nom, string pat, string depto, int pra) {
            base.Channel.insAlumno(ci, nom, pat, depto, pra);
        }
        
        public System.Threading.Tasks.Task insAlumnoAsync(string ci, string nom, string pat, string depto, int pra) {
            return base.Channel.insAlumnoAsync(ci, nom, pat, depto, pra);
        }
        
        public void actAlumno(string ci, string nom, string pat, string depto, int pra) {
            base.Channel.actAlumno(ci, nom, pat, depto, pra);
        }
        
        public System.Threading.Tasks.Task actAlumnoAsync(string ci, string nom, string pat, string depto, int pra) {
            return base.Channel.actAlumnoAsync(ci, nom, pat, depto, pra);
        }
        
        public void eliAlumno(string ci) {
            base.Channel.eliAlumno(ci);
        }
        
        public System.Threading.Tasks.Task eliAlumnoAsync(string ci) {
            return base.Channel.eliAlumnoAsync(ci);
        }
    }
}
