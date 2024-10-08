﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFCalculatorServiceLocal
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFCalculatorServiceLocal.IWCFCalculatorServiceLocal")]
    public interface IWCFCalculatorServiceLocal
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Add", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Subtract", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Multiply", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Divide", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Mod", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/ModResponse")]
        System.Threading.Tasks.Task<double> ModAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Power", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/PowerResponse")]
        System.Threading.Tasks.Task<double> PowerAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/Root", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/RootResponse")]
        System.Threading.Tasks.Task<double> RootAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFCalculatorServiceLocal/SolveArithmetic", ReplyAction="http://tempuri.org/IWCFCalculatorServiceLocal/SolveArithmeticResponse")]
        System.Threading.Tasks.Task<double> SolveArithmeticAsync(string equation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IWCFCalculatorServiceLocalChannel : WCFCalculatorServiceLocal.IWCFCalculatorServiceLocal, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class WCFCalculatorServiceLocalClient : System.ServiceModel.ClientBase<WCFCalculatorServiceLocal.IWCFCalculatorServiceLocal>, WCFCalculatorServiceLocal.IWCFCalculatorServiceLocal
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WCFCalculatorServiceLocalClient() : 
                base(WCFCalculatorServiceLocalClient.GetDefaultBinding(), WCFCalculatorServiceLocalClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWCFCalculatorServiceLocal.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFCalculatorServiceLocalClient(EndpointConfiguration endpointConfiguration) : 
                base(WCFCalculatorServiceLocalClient.GetBindingForEndpoint(endpointConfiguration), WCFCalculatorServiceLocalClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFCalculatorServiceLocalClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WCFCalculatorServiceLocalClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFCalculatorServiceLocalClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WCFCalculatorServiceLocalClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFCalculatorServiceLocalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(string a, string b)
        {
            return base.Channel.AddAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(string a, string b)
        {
            return base.Channel.SubtractAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(string a, string b)
        {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(string a, string b)
        {
            return base.Channel.DivideAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> ModAsync(string a, string b)
        {
            return base.Channel.ModAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> PowerAsync(string a, string b)
        {
            return base.Channel.PowerAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> RootAsync(string a, string b)
        {
            return base.Channel.RootAsync(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SolveArithmeticAsync(string equation)
        {
            return base.Channel.SolveArithmeticAsync(equation);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFCalculatorServiceLocal))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFCalculatorServiceLocal))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:53568/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WCFCalculatorServiceLocalClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWCFCalculatorServiceLocal);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WCFCalculatorServiceLocalClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWCFCalculatorServiceLocal);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IWCFCalculatorServiceLocal,
        }
    }
}
