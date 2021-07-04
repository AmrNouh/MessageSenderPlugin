Public Class FrmAddCustomer
    Dim sql As SQLControl
    Private Sub FrmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroups()
        LoadAccounts()
    End Sub

    Private Sub LoadGroups()
        'LUEGroup.Properties.ValueMember()
        'LUEGroup.Properties.DisplayMember()

        'sql = New SQLControl()
        'sql.ExecQuery("")
        'If sql.HasException(True) Then Return
        'LUEGroup.Properties.DataSource = sql.DBDT
        
    End  Sub

    Private Sub LoadAccounts()
        TLUEAccounts.Properties.ValueMember = "Name"
        TLUEAccounts.Properties.DisplayMember = "Name"

        sql = New SQLControl()
        sql.ExecQuery("SELECT ID,ParentID,ArName Name,CASE WHEN isparent=1 THEN 0 ELSE 1 END ImageIndex FROM dbo.Accounts")
        If sql.HasException(True) Then Return
        TLUEAccounts.Properties.DataSource = sql.DBDT
        
    End  Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class