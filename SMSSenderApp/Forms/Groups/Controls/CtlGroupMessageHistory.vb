Public Class CtlGroupMessageHistory
    Private Sub CtlGroupMessageHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dim Sql As New SQLControl
        Sql.ExecQuery("Select id,name Message from cust")
        If Sql.HasException(True) Then Return
        GridControl1.DataSource = sql.DBDT
    End Sub
End Class
