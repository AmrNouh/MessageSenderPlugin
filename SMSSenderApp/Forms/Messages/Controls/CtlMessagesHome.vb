Namespace Forms.Messages.Controls
    Public Class CtlMessagesHome
        Private Sub LoadCustomers()
            Dim Sql As New SQLControl
            Sql.ExecQuery("Select Id,Name From Cust")
            If Sql.HasException(True) Then Return
            GridControl.DataSource = Sql.DBDT
        End Sub

        Private Sub CtlMessagesHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadCustomers()

            Dim ctl As New CtlMessagesHistory With{.Dock=DockStyle.Fill}
            PnlMessagesHistory.Controls.Clear()
            PnlMessagesHistory.Controls.Add(ctl)
            ctl.Show()

            Dim ctlMsg As New CtlMSGTemplate With{.Dock=DockStyle.Fill}
            PnlTemplates.Controls.Clear()
            PnlTemplates.Controls.Add(ctlMsg)
            ctl.Show()

        End Sub

        Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
            Dim frmAddCustomer As New FrmAddCustomer With{.StartPosition=FormStartPosition.CenterParent}
            frmAddCustomer.ShowDialog()
        End Sub

        Private Sub TileView_ItemPress(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView.ItemPress
            LblCustomerName.Text = CType(TileView.GetFocusedDataRow().Item("Name"), String)
        End Sub
    End Class
End Namespace