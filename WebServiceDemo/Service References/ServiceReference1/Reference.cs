﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceDemo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServiceSample1Soap")]
    public interface ServiceSample1Soap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddName", ReplyAction="*")]
        WebServiceDemo.ServiceReference1.AddNameResponse AddName(WebServiceDemo.ServiceReference1.AddNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddName", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddNameResponse> AddNameAsync(WebServiceDemo.ServiceReference1.AddNameRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (AddName2Names) of message AddName2Names does not match the default value (AddName1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddName2Names", ReplyAction="*")]
        WebServiceDemo.ServiceReference1.AddName2Names1 AddName1(WebServiceDemo.ServiceReference1.AddName2Names request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddName2Names", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddName2Names1> AddName1Async(WebServiceDemo.ServiceReference1.AddName2Names request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KeepInSession", ReplyAction="*")]
        WebServiceDemo.ServiceReference1.KeepInSessionResponse KeepInSession(WebServiceDemo.ServiceReference1.KeepInSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KeepInSession", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.KeepInSessionResponse> KeepInSessionAsync(WebServiceDemo.ServiceReference1.KeepInSessionRequest request);
        
        // CODEGEN: Generating message contract since element name GetListFromSessionResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListFromSession", ReplyAction="*")]
        WebServiceDemo.ServiceReference1.GetListFromSessionResponse GetListFromSession(WebServiceDemo.ServiceReference1.GetListFromSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListFromSession", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.GetListFromSessionResponse> GetListFromSessionAsync(WebServiceDemo.ServiceReference1.GetListFromSessionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddName", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.AddNameRequestBody Body;
        
        public AddNameRequest() {
        }
        
        public AddNameRequest(WebServiceDemo.ServiceReference1.AddNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public AddNameRequestBody() {
        }
        
        public AddNameRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.AddNameResponseBody Body;
        
        public AddNameResponse() {
        }
        
        public AddNameResponse(WebServiceDemo.ServiceReference1.AddNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddNameResult;
        
        public AddNameResponseBody() {
        }
        
        public AddNameResponseBody(string AddNameResult) {
            this.AddNameResult = AddNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddName2Names", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddName2Names {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string name2;
        
        public AddName2Names() {
        }
        
        public AddName2Names(string name, string name2) {
            this.name = name;
            this.name2 = name2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddName2NamesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddName2Names1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string AddName2NamesResult;
        
        public AddName2Names1() {
        }
        
        public AddName2Names1(string AddName2NamesResult) {
            this.AddName2NamesResult = AddName2NamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KeepInSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KeepInSession", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.KeepInSessionRequestBody Body;
        
        public KeepInSessionRequest() {
        }
        
        public KeepInSessionRequest(WebServiceDemo.ServiceReference1.KeepInSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KeepInSessionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public KeepInSessionRequestBody() {
        }
        
        public KeepInSessionRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KeepInSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KeepInSessionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.KeepInSessionResponseBody Body;
        
        public KeepInSessionResponse() {
        }
        
        public KeepInSessionResponse(WebServiceDemo.ServiceReference1.KeepInSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class KeepInSessionResponseBody {
        
        public KeepInSessionResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListFromSessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListFromSession", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.GetListFromSessionRequestBody Body;
        
        public GetListFromSessionRequest() {
        }
        
        public GetListFromSessionRequest(WebServiceDemo.ServiceReference1.GetListFromSessionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetListFromSessionRequestBody {
        
        public GetListFromSessionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListFromSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListFromSessionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceDemo.ServiceReference1.GetListFromSessionResponseBody Body;
        
        public GetListFromSessionResponse() {
        }
        
        public GetListFromSessionResponse(WebServiceDemo.ServiceReference1.GetListFromSessionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListFromSessionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceDemo.ServiceReference1.ArrayOfString GetListFromSessionResult;
        
        public GetListFromSessionResponseBody() {
        }
        
        public GetListFromSessionResponseBody(WebServiceDemo.ServiceReference1.ArrayOfString GetListFromSessionResult) {
            this.GetListFromSessionResult = GetListFromSessionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSample1SoapChannel : WebServiceDemo.ServiceReference1.ServiceSample1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSample1SoapClient : System.ServiceModel.ClientBase<WebServiceDemo.ServiceReference1.ServiceSample1Soap>, WebServiceDemo.ServiceReference1.ServiceSample1Soap {
        
        public ServiceSample1SoapClient() {
        }
        
        public ServiceSample1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSample1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSample1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSample1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceDemo.ServiceReference1.AddNameResponse WebServiceDemo.ServiceReference1.ServiceSample1Soap.AddName(WebServiceDemo.ServiceReference1.AddNameRequest request) {
            return base.Channel.AddName(request);
        }
        
        public string AddName(string name) {
            WebServiceDemo.ServiceReference1.AddNameRequest inValue = new WebServiceDemo.ServiceReference1.AddNameRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.AddNameRequestBody();
            inValue.Body.name = name;
            WebServiceDemo.ServiceReference1.AddNameResponse retVal = ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).AddName(inValue);
            return retVal.Body.AddNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddNameResponse> WebServiceDemo.ServiceReference1.ServiceSample1Soap.AddNameAsync(WebServiceDemo.ServiceReference1.AddNameRequest request) {
            return base.Channel.AddNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddNameResponse> AddNameAsync(string name) {
            WebServiceDemo.ServiceReference1.AddNameRequest inValue = new WebServiceDemo.ServiceReference1.AddNameRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.AddNameRequestBody();
            inValue.Body.name = name;
            return ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).AddNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceDemo.ServiceReference1.AddName2Names1 WebServiceDemo.ServiceReference1.ServiceSample1Soap.AddName1(WebServiceDemo.ServiceReference1.AddName2Names request) {
            return base.Channel.AddName1(request);
        }
        
        public string AddName1(string name, string name2) {
            WebServiceDemo.ServiceReference1.AddName2Names inValue = new WebServiceDemo.ServiceReference1.AddName2Names();
            inValue.name = name;
            inValue.name2 = name2;
            WebServiceDemo.ServiceReference1.AddName2Names1 retVal = ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).AddName1(inValue);
            return retVal.AddName2NamesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddName2Names1> WebServiceDemo.ServiceReference1.ServiceSample1Soap.AddName1Async(WebServiceDemo.ServiceReference1.AddName2Names request) {
            return base.Channel.AddName1Async(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.AddName2Names1> AddName1Async(string name, string name2) {
            WebServiceDemo.ServiceReference1.AddName2Names inValue = new WebServiceDemo.ServiceReference1.AddName2Names();
            inValue.name = name;
            inValue.name2 = name2;
            return ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).AddName1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceDemo.ServiceReference1.KeepInSessionResponse WebServiceDemo.ServiceReference1.ServiceSample1Soap.KeepInSession(WebServiceDemo.ServiceReference1.KeepInSessionRequest request) {
            return base.Channel.KeepInSession(request);
        }
        
        public void KeepInSession(string name) {
            WebServiceDemo.ServiceReference1.KeepInSessionRequest inValue = new WebServiceDemo.ServiceReference1.KeepInSessionRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.KeepInSessionRequestBody();
            inValue.Body.name = name;
            WebServiceDemo.ServiceReference1.KeepInSessionResponse retVal = ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).KeepInSession(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.KeepInSessionResponse> WebServiceDemo.ServiceReference1.ServiceSample1Soap.KeepInSessionAsync(WebServiceDemo.ServiceReference1.KeepInSessionRequest request) {
            return base.Channel.KeepInSessionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.KeepInSessionResponse> KeepInSessionAsync(string name) {
            WebServiceDemo.ServiceReference1.KeepInSessionRequest inValue = new WebServiceDemo.ServiceReference1.KeepInSessionRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.KeepInSessionRequestBody();
            inValue.Body.name = name;
            return ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).KeepInSessionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceDemo.ServiceReference1.GetListFromSessionResponse WebServiceDemo.ServiceReference1.ServiceSample1Soap.GetListFromSession(WebServiceDemo.ServiceReference1.GetListFromSessionRequest request) {
            return base.Channel.GetListFromSession(request);
        }
        
        public WebServiceDemo.ServiceReference1.ArrayOfString GetListFromSession() {
            WebServiceDemo.ServiceReference1.GetListFromSessionRequest inValue = new WebServiceDemo.ServiceReference1.GetListFromSessionRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.GetListFromSessionRequestBody();
            WebServiceDemo.ServiceReference1.GetListFromSessionResponse retVal = ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).GetListFromSession(inValue);
            return retVal.Body.GetListFromSessionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.GetListFromSessionResponse> WebServiceDemo.ServiceReference1.ServiceSample1Soap.GetListFromSessionAsync(WebServiceDemo.ServiceReference1.GetListFromSessionRequest request) {
            return base.Channel.GetListFromSessionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceDemo.ServiceReference1.GetListFromSessionResponse> GetListFromSessionAsync() {
            WebServiceDemo.ServiceReference1.GetListFromSessionRequest inValue = new WebServiceDemo.ServiceReference1.GetListFromSessionRequest();
            inValue.Body = new WebServiceDemo.ServiceReference1.GetListFromSessionRequestBody();
            return ((WebServiceDemo.ServiceReference1.ServiceSample1Soap)(this)).GetListFromSessionAsync(inValue);
        }
    }
}
