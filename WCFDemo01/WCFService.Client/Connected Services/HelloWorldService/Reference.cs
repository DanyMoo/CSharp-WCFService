﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFService.Client.HelloWorldService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.LearnWCFService.com", ConfigurationName="HelloWorldService.HelloWorldService")]
    public interface HelloWorldService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.LearnWCFService.com/HelloWorldService/GetHelloWorld", ReplyAction="http://www.LearnWCFService.com/HelloWorldService/GetHelloWorldResponse")]
        string GetHelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.LearnWCFService.com/HelloWorldService/GetHelloWorld", ReplyAction="http://www.LearnWCFService.com/HelloWorldService/GetHelloWorldResponse")]
        System.Threading.Tasks.Task<string> GetHelloWorldAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldServiceChannel : WCFService.Client.HelloWorldService.HelloWorldService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldServiceClient : System.ServiceModel.ClientBase<WCFService.Client.HelloWorldService.HelloWorldService>, WCFService.Client.HelloWorldService.HelloWorldService {
        
        public HelloWorldServiceClient() {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHelloWorld() {
            return base.Channel.GetHelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> GetHelloWorldAsync() {
            return base.Channel.GetHelloWorldAsync();
        }
    }
}
