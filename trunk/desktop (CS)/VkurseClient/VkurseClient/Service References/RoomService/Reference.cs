﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VkurseClient.RoomService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", ConfigurationName="RoomService.RoomService")]
    public interface RoomService {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message getRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.getResponse get(VkurseClient.RoomService.getRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message removeRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.removeResponse remove(VkurseClient.RoomService.removeRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message insertRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.insertResponse insert(VkurseClient.RoomService.insertRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message updateRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.updateResponse update(VkurseClient.RoomService.updateRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message getAllRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.getAllResponse getAll(VkurseClient.RoomService.getAllRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message findFreeIDRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.findFreeIDResponse findFreeID(VkurseClient.RoomService.findFreeIDRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://DefaultNamespace) of message insertWithNewIDRequest does not match the default value (http://nebula.innolab.net.ru:8180/axis/RoomService.jws)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        VkurseClient.RoomService.insertWithNewIDResponse insertWithNewID(VkurseClient.RoomService.insertWithNewIDRequest request);
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="getResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
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
        public string room;
        
        public insertRequest() {
        }
        
        public insertRequest(string room) {
            this.room = room;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
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
        public string room;
        
        public updateRequest() {
        }
        
        public updateRequest(string room) {
            this.room = room;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="findFreeIDResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
    public partial class findFreeIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int findFreeIDReturn;
        
        public findFreeIDResponse() {
        }
        
        public findFreeIDResponse(int findFreeIDReturn) {
            this.findFreeIDReturn = findFreeIDReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertWithNewID", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    public partial class insertWithNewIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string room;
        
        public insertWithNewIDRequest() {
        }
        
        public insertWithNewIDRequest(string room) {
            this.room = room;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertWithNewIDResponse", WrapperNamespace="http://nebula.innolab.net.ru:8180/axis/RoomService.jws", IsWrapped=true)]
    public partial class insertWithNewIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool insertWithNewIDReturn;
        
        public insertWithNewIDResponse() {
        }
        
        public insertWithNewIDResponse(bool insertWithNewIDReturn) {
            this.insertWithNewIDReturn = insertWithNewIDReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RoomServiceChannel : VkurseClient.RoomService.RoomService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoomServiceClient : System.ServiceModel.ClientBase<VkurseClient.RoomService.RoomService>, VkurseClient.RoomService.RoomService {
        
        public RoomServiceClient() {
        }
        
        public RoomServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.getResponse VkurseClient.RoomService.RoomService.get(VkurseClient.RoomService.getRequest request) {
            return base.Channel.get(request);
        }
        
        public string get(int ID) {
            VkurseClient.RoomService.getRequest inValue = new VkurseClient.RoomService.getRequest();
            inValue.ID = ID;
            VkurseClient.RoomService.getResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).get(inValue);
            return retVal.getReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.removeResponse VkurseClient.RoomService.RoomService.remove(VkurseClient.RoomService.removeRequest request) {
            return base.Channel.remove(request);
        }
        
        public bool remove(int ID) {
            VkurseClient.RoomService.removeRequest inValue = new VkurseClient.RoomService.removeRequest();
            inValue.ID = ID;
            VkurseClient.RoomService.removeResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).remove(inValue);
            return retVal.removeReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.insertResponse VkurseClient.RoomService.RoomService.insert(VkurseClient.RoomService.insertRequest request) {
            return base.Channel.insert(request);
        }
        
        public bool insert(string room) {
            VkurseClient.RoomService.insertRequest inValue = new VkurseClient.RoomService.insertRequest();
            inValue.room = room;
            VkurseClient.RoomService.insertResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).insert(inValue);
            return retVal.insertReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.updateResponse VkurseClient.RoomService.RoomService.update(VkurseClient.RoomService.updateRequest request) {
            return base.Channel.update(request);
        }
        
        public bool update(string room) {
            VkurseClient.RoomService.updateRequest inValue = new VkurseClient.RoomService.updateRequest();
            inValue.room = room;
            VkurseClient.RoomService.updateResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).update(inValue);
            return retVal.updateReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.getAllResponse VkurseClient.RoomService.RoomService.getAll(VkurseClient.RoomService.getAllRequest request) {
            return base.Channel.getAll(request);
        }
        
        public string[] getAll() {
            VkurseClient.RoomService.getAllRequest inValue = new VkurseClient.RoomService.getAllRequest();
            VkurseClient.RoomService.getAllResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).getAll(inValue);
            return retVal.getAllReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.findFreeIDResponse VkurseClient.RoomService.RoomService.findFreeID(VkurseClient.RoomService.findFreeIDRequest request) {
            return base.Channel.findFreeID(request);
        }
        
        public int findFreeID() {
            VkurseClient.RoomService.findFreeIDRequest inValue = new VkurseClient.RoomService.findFreeIDRequest();
            VkurseClient.RoomService.findFreeIDResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).findFreeID(inValue);
            return retVal.findFreeIDReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VkurseClient.RoomService.insertWithNewIDResponse VkurseClient.RoomService.RoomService.insertWithNewID(VkurseClient.RoomService.insertWithNewIDRequest request) {
            return base.Channel.insertWithNewID(request);
        }
        
        public bool insertWithNewID(string room) {
            VkurseClient.RoomService.insertWithNewIDRequest inValue = new VkurseClient.RoomService.insertWithNewIDRequest();
            inValue.room = room;
            VkurseClient.RoomService.insertWithNewIDResponse retVal = ((VkurseClient.RoomService.RoomService)(this)).insertWithNewID(inValue);
            return retVal.insertWithNewIDReturn;
        }
    }
}