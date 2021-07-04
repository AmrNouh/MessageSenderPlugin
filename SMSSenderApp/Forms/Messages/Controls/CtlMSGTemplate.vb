Namespace Forms.Messages.Controls
    Public Class CtlMsgTemplate

        Private Sub LoadTemplates()
            Dim sql As New SQLControl
            sql.ExecQuery("SELECT id,ParentID,ArName Name,CASE WHEN isp arent=1 THEN 0 ELSE 1 END ImageIndex  FROM dbo.Accounts")
            If sql.HasException(True) Then Return

            TLTemplates.DataSource = sql.DBDT
        End Sub
        Private Sub CtlMsgTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadTemplates()
        End Sub

        Private Sub BtnSMSTemplate_Click(sender As Object, e As EventArgs) Handles BtnSMSTemplate.Click
            Dim smsTemplate As New FrmSMSTemplate With{.StartPosition=FormStartPosition.CenterParent}
            smsTemplate.ShowDialog(me)

        End Sub
    End Class
End NameSpace