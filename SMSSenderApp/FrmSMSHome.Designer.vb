Partial Public Class FrmSmsHome
    Inherits DevExpress.XtraBars.ToolbarForm.ToolbarForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSmsHome))
        Me.TbrTitleBar = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
        Me.ToolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PnlMenuBar = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New DevExpress.XtraEditors.LabelControl()
        Me.SvgImageCompanyLogo = New DevExpress.XtraEditors.SvgImageBox()
        Me.btnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddUserGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAutomaticMessage = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkReports = New DevExpress.XtraEditors.CheckButton()
        Me.ChkMessage = New DevExpress.XtraEditors.CheckButton()
        Me.Acc = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccSMSMessages = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccSMSGroups = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccSMSProvidors = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccSMSAutomatic = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccSMSSettings = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl()
        Me.TabMessages = New DevExpress.XtraTab.XtraTabPage()
        Me.TabReports = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.TbrTitleBar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ToolbarFormManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMenuBar.SuspendLayout
        CType(Me.SvgImageCompanyLogo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Acc,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Tabs,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tabs.SuspendLayout
        Me.SuspendLayout
        '
        'TbrTitleBar
        '
        Me.TbrTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TbrTitleBar.Manager = Me.ToolbarFormManager1
        Me.TbrTitleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.TbrTitleBar.Name = "TbrTitleBar"
        Me.TbrTitleBar.Size = New System.Drawing.Size(1162, 31)
        Me.TbrTitleBar.TabIndex = 0
        Me.TbrTitleBar.TabStop = false
        Me.TbrTitleBar.ToolbarForm = Me
        '
        'ToolbarFormManager1
        '
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlTop)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlRight)
        Me.ToolbarFormManager1.Form = Me
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlTop.Manager = Me.ToolbarFormManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1162, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 804)
        Me.barDockControlBottom.Manager = Me.ToolbarFormManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1162, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.ToolbarFormManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 773)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1162, 31)
        Me.barDockControlRight.Manager = Me.ToolbarFormManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 773)
        '
        'PnlMenuBar
        '
        Me.PnlMenuBar.Controls.Add(Me.lblCompanyName)
        Me.PnlMenuBar.Controls.Add(Me.SvgImageCompanyLogo)
        Me.PnlMenuBar.Controls.Add(Me.btnAddCustomer)
        Me.PnlMenuBar.Controls.Add(Me.btnAddUserGroup)
        Me.PnlMenuBar.Controls.Add(Me.BtnAutomaticMessage)
        Me.PnlMenuBar.Controls.Add(Me.ChkReports)
        Me.PnlMenuBar.Controls.Add(Me.ChkMessage)
        Me.PnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenuBar.Location = New System.Drawing.Point(0, 31)
        Me.PnlMenuBar.Name = "PnlMenuBar"
        Me.PnlMenuBar.Padding = New System.Windows.Forms.Padding(42, 0, 0, 0)
        Me.PnlMenuBar.Size = New System.Drawing.Size(1162, 41)
        Me.PnlMenuBar.TabIndex = 4
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCompanyName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.lblCompanyName.Appearance.Options.UseFont = true
        Me.lblCompanyName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCompanyName.Location = New System.Drawing.Point(358, 7)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(402, 25)
        Me.lblCompanyName.TabIndex = 9
        Me.lblCompanyName.Text = "شركة الحمد للتجارة و التوريدات"
        '
        'SvgImageCompanyLogo
        '
        Me.SvgImageCompanyLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SvgImageCompanyLogo.Location = New System.Drawing.Point(770, 1)
        Me.SvgImageCompanyLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SvgImageCompanyLogo.Name = "SvgImageCompanyLogo"
        Me.SvgImageCompanyLogo.Size = New System.Drawing.Size(35, 38)
        Me.SvgImageCompanyLogo.SvgImage = CType(resources.GetObject("SvgImageCompanyLogo.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageCompanyLogo.TabIndex = 8
        Me.SvgImageCompanyLogo.Text = "SvgImageBox1"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddCustomer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddCustomer.ImageOptions.SvgImage = CType(resources.GetObject("btnAddCustomer.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnAddCustomer.Location = New System.Drawing.Point(136, 0)
        Me.btnAddCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnAddCustomer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAddCustomer.Size = New System.Drawing.Size(47, 41)
        Me.btnAddCustomer.TabIndex = 7
        Me.btnAddCustomer.Text = "SimpleButton3"
        '
        'btnAddUserGroup
        '
        Me.btnAddUserGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddUserGroup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddUserGroup.ImageOptions.SvgImage = CType(resources.GetObject("btnAddUserGroup.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnAddUserGroup.Location = New System.Drawing.Point(89, 0)
        Me.btnAddUserGroup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddUserGroup.Name = "btnAddUserGroup"
        Me.btnAddUserGroup.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnAddUserGroup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAddUserGroup.Size = New System.Drawing.Size(47, 41)
        Me.btnAddUserGroup.TabIndex = 6
        Me.btnAddUserGroup.Text = "SimpleButton2"
        '
        'BtnAutomaticMessage
        '
        Me.BtnAutomaticMessage.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAutomaticMessage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAutomaticMessage.ImageOptions.SvgImage = CType(resources.GetObject("BtnAutomaticMessage.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnAutomaticMessage.Location = New System.Drawing.Point(42, 0)
        Me.BtnAutomaticMessage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAutomaticMessage.Name = "BtnAutomaticMessage"
        Me.BtnAutomaticMessage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnAutomaticMessage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnAutomaticMessage.Size = New System.Drawing.Size(47, 41)
        Me.BtnAutomaticMessage.TabIndex = 5
        Me.BtnAutomaticMessage.Text = "SimpleButton1"
        '
        'ChkReports
        '
        Me.ChkReports.AllowFocus = false
        Me.ChkReports.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ChkReports.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.ChkReports.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer))
        Me.ChkReports.Appearance.Options.UseFont = true
        Me.ChkReports.Appearance.Options.UseForeColor = true
        Me.ChkReports.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10!)
        Me.ChkReports.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ChkReports.AppearancePressed.Options.UseFont = true
        Me.ChkReports.AppearancePressed.Options.UseForeColor = true
        Me.ChkReports.GroupIndex = 1
        Me.ChkReports.Location = New System.Drawing.Point(983, 5)
        Me.ChkReports.Margin = New System.Windows.Forms.Padding(5)
        Me.ChkReports.Name = "ChkReports"
        Me.ChkReports.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.ChkReports.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChkReports.Size = New System.Drawing.Size(80, 31)
        Me.ChkReports.TabIndex = 0
        Me.ChkReports.TabStop = false
        Me.ChkReports.Text = "التقارير"
        '
        'ChkMessage
        '
        Me.ChkMessage.AllowFocus = false
        Me.ChkMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ChkMessage.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.ChkMessage.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer))
        Me.ChkMessage.Appearance.Options.UseFont = true
        Me.ChkMessage.Appearance.Options.UseForeColor = true
        Me.ChkMessage.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ChkMessage.AppearancePressed.Options.UseForeColor = true
        Me.ChkMessage.Checked = true
        Me.ChkMessage.GroupIndex = 1
        Me.ChkMessage.Location = New System.Drawing.Point(1069, 5)
        Me.ChkMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkMessage.Name = "ChkMessage"
        Me.ChkMessage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.ChkMessage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChkMessage.Size = New System.Drawing.Size(80, 31)
        Me.ChkMessage.TabIndex = 0
        Me.ChkMessage.Text = "الرسائل"
        '
        'Acc
        '
        Me.Acc.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.Acc.AllowItemSelection = true
        Me.Acc.Appearance.Item.Pressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.Acc.Appearance.Item.Pressed.Options.UseForeColor = true
        Me.Acc.Dock = System.Windows.Forms.DockStyle.Left
        Me.Acc.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccSMSMessages, Me.AccSMSGroups, Me.AccSMSProvidors, Me.AccSMSAutomatic, Me.AccSMSSettings})
        Me.Acc.ItemHeight = 50
        Me.Acc.Location = New System.Drawing.Point(0, 72)
        Me.Acc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Acc.Name = "Acc"
        Me.Acc.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.Acc.Size = New System.Drawing.Size(72, 732)
        Me.Acc.TabIndex = 9
        '
        'AccSMSMessages
        '
        Me.AccSMSMessages.ImageOptions.SvgImage = CType(resources.GetObject("AccSMSMessages.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.AccSMSMessages.ImageOptions.SvgImageSize = New System.Drawing.Size(26, 24)
        Me.AccSMSMessages.Name = "AccSMSMessages"
        Me.AccSMSMessages.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccSMSMessages.Text = "Element1"
        '
        'AccSMSGroups
        '
        Me.AccSMSGroups.ImageOptions.SvgImage = CType(resources.GetObject("AccSMSGroups.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.AccSMSGroups.ImageOptions.SvgImageSize = New System.Drawing.Size(28, 24)
        Me.AccSMSGroups.Name = "AccSMSGroups"
        Me.AccSMSGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccSMSGroups.Text = "Element4"
        '
        'AccSMSProvidors
        '
        Me.AccSMSProvidors.ImageOptions.SvgImage = CType(resources.GetObject("AccSMSProvidors.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.AccSMSProvidors.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 28)
        Me.AccSMSProvidors.Name = "AccSMSProvidors"
        Me.AccSMSProvidors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccSMSProvidors.Text = "Element2"
        '
        'AccSMSAutomatic
        '
        Me.AccSMSAutomatic.ImageOptions.SvgImage = CType(resources.GetObject("AccSMSAutomatic.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.AccSMSAutomatic.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
        Me.AccSMSAutomatic.Name = "AccSMSAutomatic"
        Me.AccSMSAutomatic.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccSMSAutomatic.Text = "Element3"
        '
        'AccSMSSettings
        '
        Me.AccSMSSettings.ImageOptions.SvgImage = CType(resources.GetObject("AccSMSSettings.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.AccSMSSettings.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
        Me.AccSMSSettings.Name = "AccSMSSettings"
        Me.AccSMSSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccSMSSettings.Text = "Element5"
        '
        'Tabs
        '
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(72, 72)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(4)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.TabMessages
        Me.Tabs.Size = New System.Drawing.Size(1090, 732)
        Me.Tabs.TabIndex = 10
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabMessages, Me.TabReports})
        '
        'TabMessages
        '
        Me.TabMessages.Name = "TabMessages"
        Me.TabMessages.Size = New System.Drawing.Size(1088, 707)
        Me.TabMessages.Text = "TabMessages"
        '
        'TabReports
        '
        Me.TabReports.Name = "TabReports"
        Me.TabReports.Size = New System.Drawing.Size(1088, 707)
        Me.TabReports.Text = "TabReports"
        '
        'FrmSmsHome
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1162, 804)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.Acc)
        Me.Controls.Add(Me.PnlMenuBar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.TbrTitleBar)
        Me.Font = New System.Drawing.Font("Dexef", 10!)
        Me.IconOptions.ShowIcon = false
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSmsHome"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الرسائل الدورية"
        Me.ToolbarFormControl = Me.TbrTitleBar
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TbrTitleBar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ToolbarFormManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMenuBar.ResumeLayout(false)
        CType(Me.SvgImageCompanyLogo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Acc,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tabs,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tabs.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TbrTitleBar As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl
    Friend WithEvents ToolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PnlMenuBar As Panel
    Friend WithEvents ChkMessage As DevExpress.XtraEditors.CheckButton
    Friend WithEvents ChkReports As DevExpress.XtraEditors.CheckButton
    Friend WithEvents lblCompanyName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SvgImageCompanyLogo As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents btnAddCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddUserGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAutomaticMessage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Acc As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccSMSMessages As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccSMSGroups As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccSMSProvidors As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccSMSAutomatic As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccSMSSettings As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabMessages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabReports As DevExpress.XtraTab.XtraTabPage

#End Region

End Class
