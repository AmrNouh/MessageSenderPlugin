Imports SMSSenderApp.Forms.Messages.Controls

Namespace Forms.Groups.Controls
    Public Class CtlGroupsHome
        Private Sub LoadCustomersGroups()
            Dim Sql As New SQLControl
            Sql.ExecQuery("Select Id,Name From Cust")
            If Sql.HasException(True) Then Return
            GridControl.DataSource = Sql.DBDT
        End Sub
        Private Sub BtnAddGroup_Click(sender As Object, e As EventArgs) Handles BtnAddGroup.Click
            Dim addGroup As New FrmAddGroup With{.StartPosition=FormStartPosition.CenterParent}
            addGroup.ShowDialog(Me)
        End Sub

        Private Sub CtlGroupsHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            LoadCustomersGroups()

            Dim ctl As New CtlGroupMessageHistory With{.Dock=DockStyle.Fill}
            PnlMessagesHistory.Controls.Clear()
            PnlMessagesHistory.Controls.Add(ctl)
            ctl.Show()


            Dim ctlMsg As New CtlMSGTemplate With{.Dock=DockStyle.Fill}
            PnlTemplates.Controls.Clear()
            PnlTemplates.Controls.Add(ctlMsg)
            ctl.Show()
        End Sub

        Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
            Dim addCust As New FrmAddCustomerToGroup With{.StartPosition=FormStartPosition.CenterParent}
            addCust.ShowDialog(me)
        End Sub

        Private Sub BtnGroupSettings_Click(sender As Object, e As EventArgs) Handles BtnGroupSettings.Click
            Dim groupProperties As New FrmGroupProperties With {.StartPosition=FormStartPosition.CenterParent}
            groupProperties.ShowDialog(me)
        End Sub

        Private Sub TileView_ItemPress(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView.ItemPress
            LblGroupName.Text = CType(TileView.GetFocusedDataRow().Item("Name"), String)
        End Sub
    End Class
End NameSpace