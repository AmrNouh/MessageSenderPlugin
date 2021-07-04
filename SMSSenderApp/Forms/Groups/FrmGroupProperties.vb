Imports SMSSenderApp.Forms.Groups.Controls

Namespace Forms.Groups
    Public Class FrmGroupProperties
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            'Save Action Here

            Me.Close()
            LoadGroupHome()
        End Sub

        Private Sub LoadGroupHome()
            Dim ctl As New CtlGroupsHome With {.Dock = DockStyle.Fill}
            FrmSmsHome.TabMessages.Controls.Clear()
            FrmSmsHome.TabMessages.Controls.Add(ctl)
            ctl.Show()
        End Sub

        Private Sub ChangeComboIndex(ByVal index As Integer)
            CmbGroupSettings.SelectedIndex = index
        End Sub

        Private Sub CmbGroupSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGroupSettings.SelectedIndexChanged
            If CmbGroupSettings.SelectedIndex = 0 Then
                SetAllFalse()
                LblMaturityPeriod.Visible = True
                SetSpinTrue()
            ElseIf CmbGroupSettings.SelectedIndex = 1 Then
                SetAllFalse()
                LblAddedIn.Visible = True
                SetSpinTrue()
            ElseIf CmbGroupSettings.SelectedIndex = 2 Then
                SetAllFalse()
                LblPeriodInDays.Visible = True
                SetSpinTrue()
            ElseIf CmbGroupSettings.SelectedIndex = 3 Then
                SetAllFalse()
                SetSpinFalse()
                LblName.Visible = True
            ElseIf CmbGroupSettings.SelectedIndex = 4 Then
                SetAllFalse()
                LblBalance.Visible = True
                SpnDays.Enabled = True
                SpnDays.Visible = True
                Else 
                    SetAllFalse()
            End If
        End Sub

        Private Sub FrmGroupProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ChangeComboIndex(0)
        End Sub

        Private sub SetAllFalse()
            LblMaturityPeriod.Visible = False
            LblAddedIn.Visible = False
            LblPeriodInDays.Visible = False
            LblName.Visible = False
            LblBalance.Visible = False
            LblDay.Visible =False
        End sub

        Private Sub  SetSpinFalse()
            LblDay.Visible = False
            SpnDays.Enabled = False
            SpnDays.Visible = False
        End Sub

        Private Sub  SetSpinTrue()
            LblDay.Visible = True
            SpnDays.Enabled = True
            SpnDays.Visible = True
        End Sub
    End Class
End Namespace