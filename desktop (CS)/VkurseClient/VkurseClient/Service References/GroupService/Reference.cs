﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VkurseClient.GroupService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", ConfigurationName="GroupService.GroupService")]
    public interface GroupService {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message getRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.getResponse get(VkurseClient.GroupService.getRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message removeRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.removeResponse remove(VkurseClient.GroupService.removeRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message insertRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.insertResponse insert(VkurseClient.GroupService.insertRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message updateRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.updateResponse update(VkurseClient.GroupService.updateRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message getAllRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.getAllResponse getAll(VkurseClient.GroupService.getAllRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message findFreeIDRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/GroupService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.GroupService.findFreeIDResponse findFreeID(VkurseClient.GroupService.findFreeIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class getRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int ID;
        
        public getRequest() {
        }
        
        public getRequest(int ID) {
            this.ID = ID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class getResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getReturn;
        
        public getResponse() {
        }
        
        public getResponse(string getReturn) {
            this.getReturn = getReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="remove", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class removeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int ID;
        
        public removeRequest() {
        }
        
        public removeRequest(int ID) {
            this.ID = ID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class removeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool removeReturn;
        
        public removeResponse() {
        }
        
        public removeResponse(bool removeReturn) {
            this.removeReturn = removeReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insert", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class insertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string group;
        
        public insertRequest() {
        }
        
        public insertRequest(string group) {
            this.group = group;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class insertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool insertReturn;
        
        public insertResponse() {
        }
        
        public insertResponse(bool insertReturn) {
            this.insertReturn = insertReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class updateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string group;
        
        public updateRequest() {
        }
        
        public updateRequest(string group) {
            this.group = group;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class updateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool updateReturn;
        
        public updateResponse() {
        }
        
        public updateResponse(bool updateReturn) {
            this.updateReturn = updateReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAll", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class getAllRequest {
        
        public getAllRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class getAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string[] getAllReturn;
        
        public getAllResponse() {
        }
        
        public getAllResponse(string[] getAllReturn) {
            this.getAllReturn = getAllReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findFreeID", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class findFreeIDRequest {
        
        public findFreeIDRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findFreeIDResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/GroupService.jws", IsWrapped=true)]
    public partial class findFreeIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int findFreeIDReturn;
        
        public findFreeIDResponse() {
        }
        
        public findFreeIDResponse(int findFreeIDReturn) {
            this.findFreeIDReturn = findFreeIDReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GroupServiceChannel : VkurseClient.GroupService.GroupService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupServiceClient : System.ServiceModel.ClientBase<VkurseClient.GroupService.GroupService>, VkurseClient.GroupService.GroupService {
        
        public GroupServiceClient() {
        }
        
        public GroupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.getResponse VkurseClient.GroupService.GroupService.get(VkurseClient.GroupService.getRequest request) {
            return base.Channel.get(request);
        }
        
        public string get(int ID) {
            VkurseClient.GroupService.getRequest inValue = new VkurseClient.GroupService.getRequest();
            inValue.ID = ID;
            VkurseClient.GroupService.getResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).get(inValue);
            return retVal.getReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.removeResponse VkurseClient.GroupService.GroupService.remove(VkurseClient.GroupService.removeRequest request) {
            return base.Channel.remove(request);
        }
        
        public bool remove(int ID) {
            VkurseClient.GroupService.removeRequest inValue = new VkurseClient.GroupService.removeRequest();
            inValue.ID = ID;
            VkurseClient.GroupService.removeResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).remove(inValue);
            return retVal.removeReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.insertResponse VkurseClient.GroupService.GroupService.insert(VkurseClient.GroupService.insertRequest request) {
            return base.Channel.insert(request);
        }
        
        public bool insert(string group) {
            VkurseClient.GroupService.insertRequest inValue = new VkurseClient.GroupService.insertRequest();
            inValue.group = group;
            VkurseClient.GroupService.insertResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).insert(inValue);
            return retVal.insertReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.updateResponse VkurseClient.GroupService.GroupService.update(VkurseClient.GroupService.updateRequest request) {
            return base.Channel.update(request);
        }
        
        public bool update(string group) {
            VkurseClient.GroupService.updateRequest inValue = new VkurseClient.GroupService.updateRequest();
            inValue.group = group;
            VkurseClient.GroupService.updateResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).update(inValue);
            return retVal.updateReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.getAllResponse VkurseClient.GroupService.GroupService.getAll(VkurseClient.GroupService.getAllRequest request) {
            return base.Channel.getAll(request);
        }
        
        public string[] getAll() {
            VkurseClient.GroupService.getAllRequest inValue = new VkurseClient.GroupService.getAllRequest();
            VkurseClient.GroupService.getAllResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).getAll(inValue);
            return retVal.getAllReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.GroupService.findFreeIDResponse VkurseClient.GroupService.GroupService.findFreeID(VkurseClient.GroupService.findFreeIDRequest request) {
            return base.Channel.findFreeID(request);
        }
        
        public int findFreeID() {
            VkurseClient.GroupService.findFreeIDRequest inValue = new VkurseClient.GroupService.findFreeIDRequest();
            VkurseClient.GroupService.findFreeIDResponse retVal = ((VkurseClient.GroupService.GroupService)(this)).findFreeID(inValue);
            return retVal.findFreeIDReturn;
        }
    }
}
