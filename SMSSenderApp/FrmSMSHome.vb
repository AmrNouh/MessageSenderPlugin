Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports SMSSenderApp.Forms.Messages.Controls
Imports SMSSenderApp.Cls.ClsDef
Imports SMSSenderApp.Forms.Groups
Imports SMSSenderApp.Forms.Groups.Controls


Partial Public Class FrmSmsHome

    Shared Sub New()
        Dim asm As Reflection.Assembly = GetType(DevExpress.UserSkins.SkinGray).Assembly
        'If your custom skin is derived from a template skin that resides in the BonusSkins library, ensure that you register the template skin first using the BonusSkins.Register method.  
        'DevExpress.UserSkins.BonusSkins.Register()  
        DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm)
        'Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
        'Information on custom skins registered in the main thread is not available in the splash screen thread  
        'until you call the SplashScreenManager.RegisterUserSkins method.  
        'To provide information on custom skins to the splash screen thread, uncomment the following line. 
        'DevExpress.XtraSplashScreen.SplashScreenManager.RegisterUserSkins(asm)

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DEXEF", "Light")
    End Sub

    Public Sub New()

        InitializeComponent()
        MyServer = "DESKTOP-NGRJ27E"
        MyDataBase = "DEXEFDB6"

        windowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent

        Acc.SelectElement(AccSMSMessages)

        Tabs.ShowTabHeader = DefaultBoolean.False
        Tabs.SelectedTabPage = TabMessages
        Dim ctl As New CtlMessagesHome With {.Dock = DockStyle.Fill}
        TabMessages.Controls.Add(ctl)
        ctl.Show()

    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim frmAddCustomer As New FrmAddCustomer With{.StartPosition=FormStartPosition.CenterParent}
        frmAddCustomer.ShowDialog(Me)
    End Sub

    Private Sub AccSMSGroups_Click(sender As Object, e As EventArgs) Handles AccSMSGroups.Click
        dim ctl As New CtlGroupsHome With{.Dock=DockStyle.Fill}
        TabMessages.Controls.Clear()
        TabMessages.Controls.Add(ctl)
        ctl.Show()
    End Sub

    Private Sub AccSMSMessages_Click(sender As Object, e As EventArgs) Handles AccSMSMessages.Click
        Dim ctl As New CtlMessagesHome With {.Dock = DockStyle.Fill}
        TabMessages.Controls.Clear()
        TabMessages.Controls.Add(ctl)
        ctl.Show()
    End Sub

    Private Sub AccSMSProvidors_Click(sender As Object, e As EventArgs) Handles AccSMSProvidors.Click

    End Sub

    Private Sub AccSMSAutomatic_Click(sender As Object, e As EventArgs) Handles AccSMSAutomatic.Click

    End Sub

    Private Sub AccSMSSettings_Click(sender As Object, e As EventArgs) Handles AccSMSSettings.Click

    End Sub

    Private Sub btnAddUserGroup_Click(sender As Object, e As EventArgs) Handles btnAddUserGroup.Click
        Dim addGroup As New FrmAddGroup With{.StartPosition=FormStartPosition.CenterParent}
        addGroup.ShowDialog(Me)
    End Sub

    Private Sub BtnAutomaticMessage_Click(sender As Object, e As EventArgs) Handles BtnAutomaticMessage.Click
        Dim autoMessage As New FrmAddAutomaticMessage with {.StartPosition=FormStartPosition.CenterParent}
        autoMessage.ShowDialog(me)
    End Sub
End Class
