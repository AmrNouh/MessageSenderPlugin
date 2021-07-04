Imports DevExpress.XtraGrid
Imports SMSSenderApp.Forms.Groups.Controls

Namespace Forms.Groups

    Public Class FrmAddCustomerToGroup

        Private Sub LoadCustomers()
            LUECustomerName.Properties.DisplayMember = "Name"
            LUECustomerName.Properties.ValueMember = "Name"
            LUECustomerName.Properties.KeyMember = "Id"
            Dim Sql As New SQLControl
            Sql.ExecQuery("Select Id,Name From Cust")
            If Sql.HasException(True) Then Return
            LUECustomerName.Properties.DataSource = Sql.DBDT
        End Sub
        Private Sub FrmAddCustomerToGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadCustomers()
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub LoadGroupHome()
            dim ctl As New CtlGroupsHome With{.Dock=DockStyle.Fill}
            FrmSmsHome.TabMessages.Controls.Clear()
            FrmSmsHome.TabMessages.Controls.Add(ctl)
            ctl.Show()
        End Sub
    End Class
End NameSpace