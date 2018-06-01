Imports Blackbaud.AppFx.XmlTypes.DataForms
Imports Blackbaud.AppFx.UIModeling.Core
Imports Blackbaud.AppFx

Public Class UserMultiRoleAssignmentViewDataFormUIModel
    Public Const USER_DATALIST_ID As String = "9ec070b3-6b89-46d9-9bed-160cbc64d27e"
    Public Const ROLE_DATALIST_ID As String = "9572AD07-3803-4DA1-8FA5-7588E55B2956"
    Dim strUserList As String, strRoleList As String
    Private Sub UserMultiRoleAssignmentViewDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        USERCLEARALL.DisplayStyle = ValueDisplayStyle.BadImageAndText
        ROLECLEARALL.DisplayStyle = ValueDisplayStyle.BadImageAndText
        USERSELECTALL.DisplayStyle = ValueDisplayStyle.GoodImageAndText
        ROLESELECTALL.DisplayStyle = ValueDisplayStyle.GoodImageAndText
        DISPLAYNUMBEROFADMINS.Value = DISPLAYNUMBEROFADMINS.Value & " Admins"
        DISPLAYNUMBEROFUSERS.Value = DISPLAYNUMBEROFUSERS.Value & " Users"
        DISPLAYNUMBEROFROLES.Value = DISPLAYNUMBEROFROLES.Value & " Roles"
        _userslist.DisplayReadOnly = True
        _rolelist.DisplayReadOnly = True
        PopulateActiveUser()
        PopulateRole()
    End Sub
    Private Sub PopulateActiveUser()
        Dim req As New Server.DataListLoadRequest
        req.DataListID = New Guid(USER_DATALIST_ID)
        req.SecurityContext = New Server.RequestSecurityContext()
        req.SecurityContext.SecurityFeatureID = New Guid(USER_DATALIST_ID)
        req.SecurityContext.SecurityFeatureType = Server.SecurityFeatureType.DataList
        req.IncludeMetaData = True
        req.Parameters = New DataFormItem()
        req.ContextRecordID = MyBase.RecordId.ToString
        Dim reply As Server.DataListLoadReply = Server.DataListLoad(req, GetRequestContext())
        Dim letmesee As String = ""
        Dim MaxRow As Integer = reply.TotalAvailableRows
        Dim locCount As Integer = 0
        USERSLIST.Value.Clear()
        DUMMY.Caption = MaxRow.ToString
        For Each row As Server.DataListResultRow In reply.Rows
            Dim USERSLISTITEM As New UserMultiRoleAssignmentViewDataFormUSERSLISTUIModel
            USERSLISTITEM.USERID.Value = New Guid(reply.Rows(locCount).Values(0))
            USERSLISTITEM.USERNAME.Value = reply.Rows(locCount).Values(1)
            USERSLISTITEM.NUMBEROFROLES.Value = reply.Rows(locCount).Values(3)
            USERSLIST.Value.Add(USERSLISTITEM)
            locCount = locCount + 1
        Next

    End Sub

    Private Sub PopulateRole()
        Dim req As New Server.DataListLoadRequest
        req.DataListID = New Guid(ROLE_DATALIST_ID)
        req.SecurityContext = New Server.RequestSecurityContext()
        req.SecurityContext.SecurityFeatureID = New Guid(USER_DATALIST_ID)
        req.SecurityContext.SecurityFeatureType = Server.SecurityFeatureType.DataList
        req.IncludeMetaData = True
        req.Parameters = New DataFormItem()
        req.ContextRecordID = MyBase.RecordId.ToString
        Dim reply As Server.DataListLoadReply = Server.DataListLoad(req, GetRequestContext())
        Dim letmesee As String = ""
        Dim MaxRow As Integer = reply.TotalAvailableRows
        Dim locCount As Integer = 0
        ROLELIST.Value.Clear()
        DUMMY.Caption = MaxRow.ToString
        For Each row As Server.DataListResultRow In reply.Rows
            Dim ROLESLISTITEM As New UserMultiRoleAssignmentViewDataFormROLELISTUIModel
            ROLESLISTITEM.ROLEID.Value = New Guid(reply.Rows(locCount).Values(0))
            ROLESLISTITEM.ROLENAME.Value = reply.Rows(locCount).Values(2)
            ROLESLISTITEM.NUMBEROFUSERS.Value = reply.Rows(locCount).Values(4)
            ROLELIST.Value.Add(ROLESLISTITEM)
            locCount = locCount + 1
        Next
    End Sub
    Private Sub _roleselectall_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _roleselectall.InvokeAction
        _rolelist.SelectAllItems()
    End Sub

    Private Sub _userselectall_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _userselectall.InvokeAction
        _userslist.SelectAllItems()
    End Sub

    Private Sub _userclearall_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _userclearall.InvokeAction
        _userslist.ClearSelectedItems()
    End Sub


    Private Sub _roleclearall_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _roleclearall.InvokeAction
        _rolelist.ClearSelectedItems()
    End Sub

    Private Sub _assignrole_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _assignrole.InvokeAction
        ToggleList()
        AssignRolesToUsers(strUserList, strRoleList, 0) 'Assign Role
        _userslist.Value.Clear()
        _rolelist.Value.Clear()
        Call PopulateActiveUser()
        Call PopulateRole()
    End Sub

    Private Sub ToggleList()

        strUserList = ""
        strRoleList = ""

        If _userslist.SelectedItems.Count > 0 And _rolelist.SelectedItems.Count > 0 Then

            strUserList = "<USER_LIST>"
            strRoleList = "<ROLE_LIST>"

            Dim MaxSelectedItem As Integer = 0
            Dim LoopCounter As Integer = _userslist.SelectedItems.Count - 1

            For MaxSelectedItem = 0 To LoopCounter
                strUserList = strUserList & "<USER_LIST>"
                strUserList = strUserList & "<I_HEADER>"
                strUserList = strUserList & "<USERID>" & _userslist.SelectedItems.Item(MaxSelectedItem).USERID.Value.ToString() & "</USERID>"
                strUserList = strUserList & "</I_HEADER>"
                strUserList = strUserList & "</USER_LIST>"
            Next
            MaxSelectedItem = 0
            LoopCounter = _rolelist.SelectedItems.Count - 1
            For MaxSelectedItem = 0 To LoopCounter
                strRoleList = strRoleList & "<ROLE_LIST>"
                strRoleList = strRoleList & "<I_HEADER>"
                strRoleList = strRoleList & "<ROLEID>" & _rolelist.SelectedItems.Item(MaxSelectedItem).ROLEID.Value.ToString() & "</ROLEID>"
                strRoleList = strRoleList & "</I_HEADER>"
                strRoleList = strRoleList & "</ROLE_LIST>"
            Next


            strUserList = strUserList & "</USER_LIST>"
            strRoleList = strRoleList & "</ROLE_LIST>"

            _dummy.Value = strUserList & vbCrLf & "_________________________________________" & vbCrLf & strRoleList
        End If
    End Sub

    Private Sub AssignRolesToUsers(ByVal _userList As String, ByVal _roleList As String, ByVal _actionId As Integer)
        '***********************************************************************************************************************
        '               Instantiate and send Interaction parameters to add interaction to the hosting organization record
        '***********************************************************************************************************************
        Dim _RoleAssignmentRecordOperation As New Server.RecordOperationPerformRequest
        _RoleAssignmentRecordOperation.RecordOperationID = New Guid("ce8f50ef-cdb1-41ee-8a8e-1d1566e4fc76")
        _RoleAssignmentRecordOperation.ID = USER_DATALIST_ID ' Will do nothing 
        _RoleAssignmentRecordOperation.Parameters = New DataFormItem()
        _RoleAssignmentRecordOperation.Parameters.Values.Add("SELECTEDUSERIDLIST", _userList)
        _RoleAssignmentRecordOperation.Parameters.Values.Add("SELECTEDROLEIDLIST", _roleList)
        _RoleAssignmentRecordOperation.Parameters.Values.Add("ACTION", _actionId)
        Dim cd As Server.RecordOperationPerformReply = Server.RecordOperationPerform(_RoleAssignmentRecordOperation, GetRequestContext())
        '***********************************************************************************************************************

    End Sub

    Private Sub _removerole_InvokeAction(sender As Object, e As AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _removerole.InvokeAction
        ToggleList()
        AssignRolesToUsers(strUserList, strRoleList, 1) 'Remove Role
        _userslist.Value.Clear()
        _rolelist.Value.Clear()
        Call PopulateActiveUser()
        Call PopulateRole()
    End Sub
End Class