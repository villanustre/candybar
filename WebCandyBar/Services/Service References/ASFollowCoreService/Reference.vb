﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ASFollowCoreService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Step", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class [Step]
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private textField As String
        
        Private orderField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private descriptionField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property text() As String
            Get
                Return Me.textField
            End Get
            Set
                If (Object.ReferenceEquals(Me.textField, value) <> true) Then
                    Me.textField = value
                    Me.RaisePropertyChanged("text")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=1)>  _
        Public Property order() As Integer
            Get
                Return Me.orderField
            End Get
            Set
                If (Me.orderField.Equals(value) <> true) Then
                    Me.orderField = value
                    Me.RaisePropertyChanged("order")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public Property description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.descriptionField, value) <> true) Then
                    Me.descriptionField = value
                    Me.RaisePropertyChanged("description")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Action", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Action
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private stepsField() As ASFollowCoreService.[Step]
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nameField, value) <> true) Then
                    Me.nameField = value
                    Me.RaisePropertyChanged("name")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property steps() As ASFollowCoreService.[Step]()
            Get
                Return Me.stepsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.stepsField, value) <> true) Then
                    Me.stepsField = value
                    Me.RaisePropertyChanged("steps")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ASFollowCoreService.ASfollowCoreServiceSoap")>  _
    Public Interface ASfollowCoreServiceSoap
        
        'CODEGEN: Generating message contract since element name pingResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function ping(ByVal request As ASFollowCoreService.pingRequest) As ASFollowCoreService.pingResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function pingAsync(ByVal request As ASFollowCoreService.pingRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.pingResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addActionByName", ReplyAction:="*")>  _
        Function addActionByName(ByVal request As ASFollowCoreService.addActionByNameRequest) As ASFollowCoreService.addActionByNameResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addActionByName", ReplyAction:="*")>  _
        Function addActionByNameAsync(ByVal request As ASFollowCoreService.addActionByNameRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addActionByNameAndSteps", ReplyAction:="*")>  _
        Function addActionByNameAndSteps(ByVal request As ASFollowCoreService.addActionByNameAndStepsRequest) As ASFollowCoreService.addActionByNameAndStepsResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addActionByNameAndSteps", ReplyAction:="*")>  _
        Function addActionByNameAndStepsAsync(ByVal request As ASFollowCoreService.addActionByNameAndStepsRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameAndStepsResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getActionByName", ReplyAction:="*")>  _
        Function getActionByName(ByVal request As ASFollowCoreService.getActionByNameRequest) As ASFollowCoreService.getActionByNameResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getActionByName", ReplyAction:="*")>  _
        Function getActionByNameAsync(ByVal request As ASFollowCoreService.getActionByNameRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.getActionByNameResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class pingRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ping", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.pingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.pingRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class pingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class pingResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="pingResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.pingResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.pingResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class pingResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public pingResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal pingResult As String)
            MyBase.New
            Me.pingResult = pingResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addActionByNameRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addActionByName", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.addActionByNameRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.addActionByNameRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addActionByNameRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String)
            MyBase.New
            Me.name = name
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addActionByNameResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addActionByNameResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.addActionByNameResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.addActionByNameResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addActionByNameResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public addActionByNameResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal addActionByNameResult As String)
            MyBase.New
            Me.addActionByNameResult = addActionByNameResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addActionByNameAndStepsRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addActionByNameAndSteps", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.addActionByNameAndStepsRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.addActionByNameAndStepsRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addActionByNameAndStepsRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public steps() As ASFollowCoreService.[Step]
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String, ByVal steps() As ASFollowCoreService.[Step])
            MyBase.New
            Me.name = name
            Me.steps = steps
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addActionByNameAndStepsResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addActionByNameAndStepsResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.addActionByNameAndStepsResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.addActionByNameAndStepsResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addActionByNameAndStepsResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public addActionByNameAndStepsResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal addActionByNameAndStepsResult As String)
            MyBase.New
            Me.addActionByNameAndStepsResult = addActionByNameAndStepsResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getActionByNameRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getActionByName", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.getActionByNameRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.getActionByNameRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class getActionByNameRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String)
            MyBase.New
            Me.name = name
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getActionByNameResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getActionByNameResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASFollowCoreService.getActionByNameResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASFollowCoreService.getActionByNameResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class getActionByNameResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getActionByNameResult As ASFollowCoreService.Action
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getActionByNameResult As ASFollowCoreService.Action)
            MyBase.New
            Me.getActionByNameResult = getActionByNameResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ASfollowCoreServiceSoapChannel
        Inherits ASFollowCoreService.ASfollowCoreServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ASfollowCoreServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of ASFollowCoreService.ASfollowCoreServiceSoap)
        Implements ASFollowCoreService.ASfollowCoreServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_ping(ByVal request As ASFollowCoreService.pingRequest) As ASFollowCoreService.pingResponse Implements ASFollowCoreService.ASfollowCoreServiceSoap.ping
            Return MyBase.Channel.ping(request)
        End Function
        
        Public Function ping() As String
            Dim inValue As ASFollowCoreService.pingRequest = New ASFollowCoreService.pingRequest()
            inValue.Body = New ASFollowCoreService.pingRequestBody()
            Dim retVal As ASFollowCoreService.pingResponse = CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).ping(inValue)
            Return retVal.Body.pingResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_pingAsync(ByVal request As ASFollowCoreService.pingRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.pingResponse) Implements ASFollowCoreService.ASfollowCoreServiceSoap.pingAsync
            Return MyBase.Channel.pingAsync(request)
        End Function
        
        Public Function pingAsync() As System.Threading.Tasks.Task(Of ASFollowCoreService.pingResponse)
            Dim inValue As ASFollowCoreService.pingRequest = New ASFollowCoreService.pingRequest()
            inValue.Body = New ASFollowCoreService.pingRequestBody()
            Return CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).pingAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_addActionByName(ByVal request As ASFollowCoreService.addActionByNameRequest) As ASFollowCoreService.addActionByNameResponse Implements ASFollowCoreService.ASfollowCoreServiceSoap.addActionByName
            Return MyBase.Channel.addActionByName(request)
        End Function
        
        Public Function addActionByName(ByVal name As String) As String
            Dim inValue As ASFollowCoreService.addActionByNameRequest = New ASFollowCoreService.addActionByNameRequest()
            inValue.Body = New ASFollowCoreService.addActionByNameRequestBody()
            inValue.Body.name = name
            Dim retVal As ASFollowCoreService.addActionByNameResponse = CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).addActionByName(inValue)
            Return retVal.Body.addActionByNameResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_addActionByNameAsync(ByVal request As ASFollowCoreService.addActionByNameRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameResponse) Implements ASFollowCoreService.ASfollowCoreServiceSoap.addActionByNameAsync
            Return MyBase.Channel.addActionByNameAsync(request)
        End Function
        
        Public Function addActionByNameAsync(ByVal name As String) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameResponse)
            Dim inValue As ASFollowCoreService.addActionByNameRequest = New ASFollowCoreService.addActionByNameRequest()
            inValue.Body = New ASFollowCoreService.addActionByNameRequestBody()
            inValue.Body.name = name
            Return CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).addActionByNameAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_addActionByNameAndSteps(ByVal request As ASFollowCoreService.addActionByNameAndStepsRequest) As ASFollowCoreService.addActionByNameAndStepsResponse Implements ASFollowCoreService.ASfollowCoreServiceSoap.addActionByNameAndSteps
            Return MyBase.Channel.addActionByNameAndSteps(request)
        End Function
        
        Public Function addActionByNameAndSteps(ByVal name As String, ByVal steps() As ASFollowCoreService.[Step]) As String
            Dim inValue As ASFollowCoreService.addActionByNameAndStepsRequest = New ASFollowCoreService.addActionByNameAndStepsRequest()
            inValue.Body = New ASFollowCoreService.addActionByNameAndStepsRequestBody()
            inValue.Body.name = name
            inValue.Body.steps = steps
            Dim retVal As ASFollowCoreService.addActionByNameAndStepsResponse = CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).addActionByNameAndSteps(inValue)
            Return retVal.Body.addActionByNameAndStepsResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_addActionByNameAndStepsAsync(ByVal request As ASFollowCoreService.addActionByNameAndStepsRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameAndStepsResponse) Implements ASFollowCoreService.ASfollowCoreServiceSoap.addActionByNameAndStepsAsync
            Return MyBase.Channel.addActionByNameAndStepsAsync(request)
        End Function
        
        Public Function addActionByNameAndStepsAsync(ByVal name As String, ByVal steps() As ASFollowCoreService.[Step]) As System.Threading.Tasks.Task(Of ASFollowCoreService.addActionByNameAndStepsResponse)
            Dim inValue As ASFollowCoreService.addActionByNameAndStepsRequest = New ASFollowCoreService.addActionByNameAndStepsRequest()
            inValue.Body = New ASFollowCoreService.addActionByNameAndStepsRequestBody()
            inValue.Body.name = name
            inValue.Body.steps = steps
            Return CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).addActionByNameAndStepsAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_getActionByName(ByVal request As ASFollowCoreService.getActionByNameRequest) As ASFollowCoreService.getActionByNameResponse Implements ASFollowCoreService.ASfollowCoreServiceSoap.getActionByName
            Return MyBase.Channel.getActionByName(request)
        End Function
        
        Public Function getActionByName(ByVal name As String) As ASFollowCoreService.Action
            Dim inValue As ASFollowCoreService.getActionByNameRequest = New ASFollowCoreService.getActionByNameRequest()
            inValue.Body = New ASFollowCoreService.getActionByNameRequestBody()
            inValue.Body.name = name
            Dim retVal As ASFollowCoreService.getActionByNameResponse = CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).getActionByName(inValue)
            Return retVal.Body.getActionByNameResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASFollowCoreService_ASfollowCoreServiceSoap_getActionByNameAsync(ByVal request As ASFollowCoreService.getActionByNameRequest) As System.Threading.Tasks.Task(Of ASFollowCoreService.getActionByNameResponse) Implements ASFollowCoreService.ASfollowCoreServiceSoap.getActionByNameAsync
            Return MyBase.Channel.getActionByNameAsync(request)
        End Function
        
        Public Function getActionByNameAsync(ByVal name As String) As System.Threading.Tasks.Task(Of ASFollowCoreService.getActionByNameResponse)
            Dim inValue As ASFollowCoreService.getActionByNameRequest = New ASFollowCoreService.getActionByNameRequest()
            inValue.Body = New ASFollowCoreService.getActionByNameRequestBody()
            inValue.Body.name = name
            Return CType(Me,ASFollowCoreService.ASfollowCoreServiceSoap).getActionByNameAsync(inValue)
        End Function
    End Class
End Namespace
