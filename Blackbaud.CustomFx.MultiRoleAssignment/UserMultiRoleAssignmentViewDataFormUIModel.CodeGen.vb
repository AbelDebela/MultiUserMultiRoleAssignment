﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.167.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'User Multi Role Assignment View Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "17a59746-9324-4885-ba67-df03f30ae0aa", "2156ee54-18ff-4ce6-b880-13f346911870", "User Multi Role Assignment")>
Partial Public Class [UserMultiRoleAssignmentViewDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _dummy As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _displaynumberofusers As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _displaynumberofroles As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _displaynumberofadmins As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _userslist As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormUSERSLISTUIModel)
    Private WithEvents _rolelist As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormROLELISTUIModel)
    Private WithEvents _activeusers As Global.Blackbaud.AppFx.UIModeling.Core.GroupField
    Private WithEvents _activeroles As Global.Blackbaud.AppFx.UIModeling.Core.GroupField
    Private WithEvents _userselectall As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _userclearall As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _roleselectall As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _roleclearall As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _assignrole As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _removerole As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public Sub New()
        MyBase.New()

        _dummy = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _displaynumberofusers = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _displaynumberofroles = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _displaynumberofadmins = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _userslist = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormUSERSLISTUIModel)
        _rolelist = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormROLELISTUIModel)
        _activeusers = New Global.Blackbaud.AppFx.UIModeling.Core.GroupField
        _activeroles = New Global.Blackbaud.AppFx.UIModeling.Core.GroupField
        _userselectall = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _userclearall = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _roleselectall = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _roleclearall = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _assignrole = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _removerole = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("17a59746-9324-4885-ba67-df03f30ae0aa")
        MyBase.DataFormInstanceId = New System.Guid("2156ee54-18ff-4ce6-b880-13f346911870")
        MyBase.RecordType = "User Multi Role Assignment"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/customconfigurationsetting/UserMultiRoleAssignmentViewDataForm.html"

        '
        '_dummy
        '
        _dummy.Name = "DUMMY"
        _dummy.Caption = "Field 1"
        _dummy.DBReadOnly = True
        _dummy.MaxLength = 50
        Me.Fields.Add(_dummy)
        '
        '_displaynumberofusers
        '
        _displaynumberofusers.Name = "DISPLAYNUMBEROFUSERS"
        _displaynumberofusers.Caption = "# Users"
        _displaynumberofusers.DBReadOnly = True
        _displaynumberofusers.MaxLength = 200
        Me.Fields.Add(_displaynumberofusers)
        '
        '_displaynumberofroles
        '
        _displaynumberofroles.Name = "DISPLAYNUMBEROFROLES"
        _displaynumberofroles.Caption = "# Roles"
        _displaynumberofroles.DBReadOnly = True
        _displaynumberofroles.MaxLength = 200
        Me.Fields.Add(_displaynumberofroles)
        '
        '_displaynumberofadmins
        '
        _displaynumberofadmins.Name = "DISPLAYNUMBEROFADMINS"
        _displaynumberofadmins.Caption = "# Admins"
        _displaynumberofadmins.DBReadOnly = True
        _displaynumberofadmins.MaxLength = 200
        Me.Fields.Add(_displaynumberofadmins)
        '
        '_userslist
        '
        _userslist.Name = "USERSLIST"
        _userslist.Caption = "USERSLIST"
        _userslist.DBReadOnly = True
        Me.Fields.Add(_userslist)
        '
        '_rolelist
        '
        _rolelist.Name = "ROLELIST"
        _rolelist.Caption = "ROLELIST"
        _rolelist.DBReadOnly = True
        Me.Fields.Add(_rolelist)
        '
        '_activeusers
        '
        _activeusers.Name = "ACTIVEUSERS"
        _activeusers.Caption = "Active users"
        Me.Fields.Add(_activeusers)
        '
        '_activeroles
        '
        _activeroles.Name = "ACTIVEROLES"
        _activeroles.Caption = "Roles"
        Me.Fields.Add(_activeroles)
        '
        '_userselectall
        '
        _userselectall.Name = "USERSELECTALL"
        _userselectall.Caption = "Select all"
        _userselectall.ImageKey = "RES:check"
        Me.Actions.Add(_userselectall)
        '
        '_userclearall
        '
        _userclearall.Name = "USERCLEARALL"
        _userclearall.Caption = "Clear all"
        _userclearall.ImageKey = "RES:delete"
        Me.Actions.Add(_userclearall)
        '
        '_roleselectall
        '
        _roleselectall.Name = "ROLESELECTALL"
        _roleselectall.Caption = "Select all"
        _roleselectall.ImageKey = "RES:check"
        Me.Actions.Add(_roleselectall)
        '
        '_roleclearall
        '
        _roleclearall.Name = "ROLECLEARALL"
        _roleclearall.Caption = "Clear all"
        _roleclearall.ImageKey = "RES:delete"
        Me.Actions.Add(_roleclearall)
        '
        '_assignrole
        '
        _assignrole.Name = "ASSIGNROLE"
        _assignrole.Caption = "Assign Roles"
        _assignrole.ImageKey = "RES:check"
        Me.Actions.Add(_assignrole)
        '
        '_removerole
        '
        _removerole.Name = "REMOVEROLE"
        _removerole.Caption = "Remove roles"
        _removerole.ImageKey = "RES:delete"
        Me.Actions.Add(_removerole)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Field 1
    ''' </summary>
    <System.ComponentModel.Description("Field 1")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [DUMMY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _dummy
        End Get
    End Property
    
    ''' <summary>
    ''' # Users
    ''' </summary>
    <System.ComponentModel.Description("# Users")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [DISPLAYNUMBEROFUSERS]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _displaynumberofusers
        End Get
    End Property
    
    ''' <summary>
    ''' # Roles
    ''' </summary>
    <System.ComponentModel.Description("# Roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [DISPLAYNUMBEROFROLES]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _displaynumberofroles
        End Get
    End Property
    
    ''' <summary>
    ''' # Admins
    ''' </summary>
    <System.ComponentModel.Description("# Admins")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [DISPLAYNUMBEROFADMINS]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _displaynumberofadmins
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [USERSLIST]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormUSERSLISTUIModel)
        Get
            Return _userslist
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ROLELIST]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of UserMultiRoleAssignmentViewDataFormROLELISTUIModel)
        Get
            Return _rolelist
        End Get
    End Property
    
    ''' <summary>
    ''' Active users
    ''' </summary>
    <System.ComponentModel.Description("Active users")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ACTIVEUSERS]() As Global.Blackbaud.AppFx.UIModeling.Core.GroupField
        Get
            Return _activeusers
        End Get
    End Property
    
    ''' <summary>
    ''' Roles
    ''' </summary>
    <System.ComponentModel.Description("Roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ACTIVEROLES]() As Global.Blackbaud.AppFx.UIModeling.Core.GroupField
        Get
            Return _activeroles
        End Get
    End Property
    
    ''' <summary>
    ''' Select all
    ''' </summary>
    <System.ComponentModel.Description("Select all")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [USERSELECTALL]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _userselectall
        End Get
    End Property
    
    ''' <summary>
    ''' Clear all
    ''' </summary>
    <System.ComponentModel.Description("Clear all")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [USERCLEARALL]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _userclearall
        End Get
    End Property
    
    ''' <summary>
    ''' Select all
    ''' </summary>
    <System.ComponentModel.Description("Select all")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ROLESELECTALL]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _roleselectall
        End Get
    End Property
    
    ''' <summary>
    ''' Clear all
    ''' </summary>
    <System.ComponentModel.Description("Clear all")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ROLECLEARALL]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _roleclearall
        End Get
    End Property
    
    ''' <summary>
    ''' Assign Roles
    ''' </summary>
    <System.ComponentModel.Description("Assign Roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [ASSIGNROLE]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _assignrole
        End Get
    End Property
    
    ''' <summary>
    ''' Remove roles
    ''' </summary>
    <System.ComponentModel.Description("Remove roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [REMOVEROLE]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _removerole
        End Get
    End Property
    
End Class
