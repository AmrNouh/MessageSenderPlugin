Imports SMSSenderApp.Forms.Groups.Controls

Namespace Forms.Groups

    Public Class FrmAddGroup

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub LoadGroupHome()
            FrmSmsHome.Acc.SelectElement(FrmSmsHome.AccSMSGroups)
            dim ctl As New CtlGroupsHome With{.Dock=DockStyle.Fill}
            FrmSmsHome.TabMessages.Controls.Clear()
            FrmSmsHome.TabMessages.Controls.Add(ctl)
            ctl.Show()
        End Sub
    End Class
End NameSpace