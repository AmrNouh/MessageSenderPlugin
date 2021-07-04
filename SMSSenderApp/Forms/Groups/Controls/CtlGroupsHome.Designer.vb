Namespace Forms.Groups.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CtlGroupsHome
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlGroupsHome))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.ColName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.BtnEditGroupName = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGroupSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.SvgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        Me.LblGroupName = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblMemberNumber = New DevExpress.XtraEditors.LabelControl()
        Me.BtnSendMessage = New DevExpress.XtraEditors.SimpleButton()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PnlMessagesHistory = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SidePanel3 = New DevExpress.XtraEditors.SidePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.PnlTilte = New System.Windows.Forms.Panel()
        Me.LblCustomersGroups = New DevExpress.XtraEditors.LabelControl()
        Me.SrhGroup = New DevExpress.XtraEditors.SearchControl()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.TileView = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.SidePanel2 = New DevExpress.XtraEditors.SidePanel()
        Me.PnlTemplates = New DevExpress.XtraEditors.SidePanel()
        CType(Me.SvgImageBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel4.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.SidePanel3.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.PnlTilte.SuspendLayout
        CType(Me.SrhGroup.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlSearch.SuspendLayout
        Me.SidePanel2.SuspendLayout
        Me.SuspendLayout
        '
        'ColName
        '
        Me.ColName.AccessibleName = ""
        Me.ColName.Caption = "Name"
        Me.ColName.FieldName = "Name"
        Me.ColName.Name = "ColName"
        Me.ColName.Visible = true
        Me.ColName.VisibleIndex = 0
        '
        'BtnEditGroupName
        '
        Me.BtnEditGroupName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnEditGroupName.ImageOptions.SvgImage = CType(resources.GetObject("BtnEditGroupName.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnEditGroupName.Location = New System.Drawing.Point(120, 17)
        Me.BtnEditGroupName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditGroupName.Name = "BtnEditGroupName"
        Me.BtnEditGroupName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnEditGroupName.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnEditGroupName.Size = New System.Drawing.Size(47, 41)
        Me.BtnEditGroupName.TabIndex = 13
        Me.BtnEditGroupName.Text = "SimpleButton3"
        '
        'BtnGroupSettings
        '
        Me.BtnGroupSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnGroupSettings.ImageOptions.SvgImage = CType(resources.GetObject("BtnGroupSettings.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnGroupSettings.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.BtnGroupSettings.Location = New System.Drawing.Point(73, 17)
        Me.BtnGroupSettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGroupSettings.Name = "BtnGroupSettings"
        Me.BtnGroupSettings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnGroupSettings.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnGroupSettings.Size = New System.Drawing.Size(47, 41)
        Me.BtnGroupSettings.TabIndex = 12
        Me.BtnGroupSettings.Text = "SimpleButton2"
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAddCustomer.ImageOptions.SvgImage = CType(resources.GetObject("BtnAddCustomer.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnAddCustomer.Location = New System.Drawing.Point(26, 17)
        Me.BtnAddCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnAddCustomer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnAddCustomer.Size = New System.Drawing.Size(47, 41)
        Me.BtnAddCustomer.TabIndex = 11
        Me.BtnAddCustomer.Text = "SimpleButton1"
        '
        'SvgImageBox1
        '
        Me.SvgImageBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SvgImageBox1.Location = New System.Drawing.Point(531, 25)
        Me.SvgImageBox1.Name = "SvgImageBox1"
        Me.SvgImageBox1.Size = New System.Drawing.Size(24, 24)
        Me.SvgImageBox1.SvgImage = CType(resources.GetObject("SvgImageBox1.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox1.TabIndex = 0
        Me.SvgImageBox1.Text = "SvgImageBox1"
        '
        'LblGroupName
        '
        Me.LblGroupName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblGroupName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblGroupName.Appearance.Options.UseFont = true
        Me.LblGroupName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblGroupName.Location = New System.Drawing.Point(189, 25)
        Me.LblGroupName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LblGroupName.Name = "LblGroupName"
        Me.LblGroupName.Size = New System.Drawing.Size(335, 25)
        Me.LblGroupName.TabIndex = 10
        Me.LblGroupName.Text = "مجموعة1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.BtnEditGroupName)
        Me.Panel2.Controls.Add(Me.BtnGroupSettings)
        Me.Panel2.Controls.Add(Me.BtnAddCustomer)
        Me.Panel2.Controls.Add(Me.SvgImageBox1)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.LblMemberNumber)
        Me.Panel2.Controls.Add(Me.LblGroupName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(100, 25)
        Me.Panel2.MinimumSize = New System.Drawing.Size(574, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 75)
        Me.Panel2.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(451, 45)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 25)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "مشترك"
        '
        'LblMemberNumber
        '
        Me.LblMemberNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblMemberNumber.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblMemberNumber.Appearance.Options.UseFont = true
        Me.LblMemberNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblMemberNumber.Location = New System.Drawing.Point(499, 45)
        Me.LblMemberNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LblMemberNumber.Name = "LblMemberNumber"
        Me.LblMemberNumber.Size = New System.Drawing.Size(25, 25)
        Me.LblMemberNumber.TabIndex = 10
        Me.LblMemberNumber.Text = "20"
        '
        'BtnSendMessage
        '
        Me.BtnSendMessage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnSendMessage.ImageOptions.SvgImage = CType(resources.GetObject("BtnSendMessage.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnSendMessage.Location = New System.Drawing.Point(19, 10)
        Me.BtnSendMessage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSendMessage.Name = "BtnSendMessage"
        Me.BtnSendMessage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnSendMessage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnSendMessage.Size = New System.Drawing.Size(40, 40)
        Me.BtnSendMessage.TabIndex = 12
        Me.BtnSendMessage.Text = "SimpleButton1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.MemoEdit1.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.MemoEdit1.Properties.AdvancedModeOptions.Label = "الرسالة"
        Me.MemoEdit1.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.DodgerBlue
        Me.MemoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MemoEdit1.Properties.Padding = New System.Windows.Forms.Padding(45)
        Me.MemoEdit1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.MemoEdit1.Size = New System.Drawing.Size(554, 60)
        Me.MemoEdit1.StyleController = Me.StyleController1
        Me.MemoEdit1.TabIndex = 0
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.BtnSendMessage)
        Me.Panel4.Controls.Add(Me.MemoEdit1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(81, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(554, 60)
        Me.Panel4.TabIndex = 0
        '
        'PnlMessagesHistory
        '
        Me.PnlMessagesHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMessagesHistory.Location = New System.Drawing.Point(0, 125)
        Me.PnlMessagesHistory.Name = "PnlMessagesHistory"
        Me.PnlMessagesHistory.Padding = New System.Windows.Forms.Padding(79, 0, 79, 0)
        Me.PnlMessagesHistory.Size = New System.Drawing.Size(716, 438)
        Me.PnlMessagesHistory.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 563)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(81, 20, 81, 20)
        Me.Panel3.Size = New System.Drawing.Size(716, 100)
        Me.Panel3.TabIndex = 1
        '
        'SidePanel3
        '
        Me.SidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer))
        Me.SidePanel3.Appearance.Options.UseBackColor = true
        Me.SidePanel3.Controls.Add(Me.PnlMessagesHistory)
        Me.SidePanel3.Controls.Add(Me.Panel3)
        Me.SidePanel3.Controls.Add(Me.Panel1)
        Me.SidePanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SidePanel3.Location = New System.Drawing.Point(233, 0)
        Me.SidePanel3.Name = "SidePanel3"
        Me.SidePanel3.Size = New System.Drawing.Size(716, 663)
        Me.SidePanel3.TabIndex = 1
        Me.SidePanel3.Text = "SidePanel3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(100, 25, 100, 25)
        Me.Panel1.Size = New System.Drawing.Size(716, 125)
        Me.Panel1.TabIndex = 0
        '
        'BtnAddGroup
        '
        Me.BtnAddGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAddGroup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAddGroup.ImageOptions.SvgImage = CType(resources.GetObject("BtnAddGroup.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnAddGroup.Location = New System.Drawing.Point(11, 0)
        Me.BtnAddGroup.Name = "BtnAddGroup"
        Me.BtnAddGroup.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnAddGroup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnAddGroup.Size = New System.Drawing.Size(40, 35)
        Me.BtnAddGroup.TabIndex = 4
        '
        'PnlTilte
        '
        Me.PnlTilte.Controls.Add(Me.BtnAddGroup)
        Me.PnlTilte.Controls.Add(Me.LblCustomersGroups)
        Me.PnlTilte.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTilte.Location = New System.Drawing.Point(10, 9)
        Me.PnlTilte.Name = "PnlTilte"
        Me.PnlTilte.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.PnlTilte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlTilte.Size = New System.Drawing.Size(309, 35)
        Me.PnlTilte.TabIndex = 0
        '
        'LblCustomersGroups
        '
        Me.LblCustomersGroups.Appearance.Font = New System.Drawing.Font("Dexef", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblCustomersGroups.Appearance.Options.UseFont = true
        Me.LblCustomersGroups.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblCustomersGroups.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblCustomersGroups.Location = New System.Drawing.Point(76, 0)
        Me.LblCustomersGroups.Name = "LblCustomersGroups"
        Me.LblCustomersGroups.Size = New System.Drawing.Size(222, 35)
        Me.LblCustomersGroups.TabIndex = 5
        Me.LblCustomersGroups.Text = "مجموعات العملاء"
        '
        'SrhGroup
        '
        Me.SrhGroup.Client = Me.GridControl
        Me.SrhGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SrhGroup.EditValue = ""
        Me.SrhGroup.Location = New System.Drawing.Point(10, 9)
        Me.SrhGroup.Name = "SrhGroup"
        Me.SrhGroup.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhGroup.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhGroup.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.DodgerBlue
        Me.SrhGroup.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhGroup.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SrhGroup.Properties.Appearance.Options.UseFont = true
        Me.SrhGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SrhGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SrhGroup.Properties.Client = Me.GridControl
        Me.SrhGroup.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhGroup.Properties.ShowPopupShadow = false
        Me.SrhGroup.Properties.Sorted = true
        Me.SrhGroup.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.SrhGroup.Size = New System.Drawing.Size(289, 20)
        Me.SrhGroup.StyleController = Me.StyleController1
        Me.SrhGroup.TabIndex = 0
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(10, 84)
        Me.GridControl.MainView = Me.TileView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(309, 570)
        Me.GridControl.TabIndex = 2
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView})
        '
        'TileView
        '
        Me.TileView.Appearance.EmptySpace.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileView.Appearance.EmptySpace.Options.UseBackColor = true
        Me.TileView.Appearance.ItemFocused.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileView.Appearance.ItemFocused.Font = New System.Drawing.Font("Dexef", 10!)
        Me.TileView.Appearance.ItemFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.TileView.Appearance.ItemFocused.Options.UseBackColor = true
        Me.TileView.Appearance.ItemFocused.Options.UseFont = true
        Me.TileView.Appearance.ItemFocused.Options.UseForeColor = true
        Me.TileView.Appearance.ItemHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(123,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.TileView.Appearance.ItemHovered.Font = New System.Drawing.Font("Dexef", 10!)
        Me.TileView.Appearance.ItemHovered.ForeColor = System.Drawing.Color.White
        Me.TileView.Appearance.ItemHovered.Options.UseBackColor = true
        Me.TileView.Appearance.ItemHovered.Options.UseFont = true
        Me.TileView.Appearance.ItemHovered.Options.UseForeColor = true
        Me.TileView.Appearance.ItemNormal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileView.Appearance.ItemNormal.Font = New System.Drawing.Font("Dexef", 10!)
        Me.TileView.Appearance.ItemNormal.Options.UseBackColor = true
        Me.TileView.Appearance.ItemNormal.Options.UseFont = true
        Me.TileView.Appearance.ItemSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(123,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.TileView.Appearance.ItemSelected.Font = New System.Drawing.Font("Dexef", 10!)
        Me.TileView.Appearance.ItemSelected.ForeColor = System.Drawing.Color.White
        Me.TileView.Appearance.ItemSelected.Options.UseBackColor = true
        Me.TileView.Appearance.ItemSelected.Options.UseFont = true
        Me.TileView.Appearance.ItemSelected.Options.UseForeColor = true
        Me.TileView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColName})
        Me.TileView.ContextButtonOptions.AllowGlyphSkinning = true
        Me.TileView.GridControl = Me.GridControl
        Me.TileView.Name = "TileView"
        Me.TileView.OptionsSelection.MultiSelect = true
        Me.TileView.OptionsTiles.AllowItemHover = true
        Me.TileView.OptionsTiles.AllowPressAnimation = false
        Me.TileView.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(12, 8, 12, 8)
        Me.TileView.OptionsTiles.IndentBetweenGroups = 0
        Me.TileView.OptionsTiles.IndentBetweenItems = 0
        Me.TileView.OptionsTiles.ItemSize = New System.Drawing.Size(248, 50)
        Me.TileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
        Me.TileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.TileView.OptionsTiles.RowCount = 0
        Me.TileView.TileColumns.Add(TableColumnDefinition1)
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Dexef", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = true
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = true
        TileViewItemElement1.Column = Me.ColName
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileViewItemElement1.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        TileViewItemElement1.Text = "ColName"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TileView.TileTemplate.Add(TileViewItemElement1)
        '
        'PnlSearch
        '
        Me.PnlSearch.Controls.Add(Me.SrhGroup)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(10, 44)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.PnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlSearch.Size = New System.Drawing.Size(309, 40)
        Me.PnlSearch.TabIndex = 1
        '
        'SidePanel2
        '
        Me.SidePanel2.Controls.Add(Me.GridControl)
        Me.SidePanel2.Controls.Add(Me.PnlSearch)
        Me.SidePanel2.Controls.Add(Me.PnlTilte)
        Me.SidePanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel2.Location = New System.Drawing.Point(949, 0)
        Me.SidePanel2.Name = "SidePanel2"
        Me.SidePanel2.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.SidePanel2.Size = New System.Drawing.Size(330, 663)
        Me.SidePanel2.TabIndex = 2
        Me.SidePanel2.Text = "SidePanel2"
        '
        'PnlTemplates
        '
        Me.PnlTemplates.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlTemplates.Location = New System.Drawing.Point(0, 0)
        Me.PnlTemplates.Name = "PnlTemplates"
        Me.PnlTemplates.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlTemplates.Size = New System.Drawing.Size(233, 663)
        Me.PnlTemplates.TabIndex = 3
        Me.PnlTemplates.Text = "SidePanel1"
        '
        'CtlGroupsHome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SidePanel3)
        Me.Controls.Add(Me.SidePanel2)
        Me.Controls.Add(Me.PnlTemplates)
        Me.Name = "CtlGroupsHome"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(1279, 663)
        CType(Me.SvgImageBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel4.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.SidePanel3.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.PnlTilte.ResumeLayout(false)
        CType(Me.SrhGroup.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TileView,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlSearch.ResumeLayout(false)
        Me.SidePanel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents BtnEditGroupName As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnGroupSettings As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnAddCustomer As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SvgImageBox1 As DevExpress.XtraEditors.SvgImageBox
        Friend WithEvents LblGroupName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel2 As Panel
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblMemberNumber As DevExpress.XtraEditors.LabelControl
        Friend WithEvents BtnSendMessage As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
        Friend WithEvents Panel4 As Panel
        Friend WithEvents PnlMessagesHistory As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents SidePanel3 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents BtnAddGroup As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PnlTilte As Panel
        Friend WithEvents LblCustomersGroups As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SrhGroup As DevExpress.XtraEditors.SearchControl
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents TileView As DevExpress.XtraGrid.Views.Tile.TileView
        Friend WithEvents ColName As DevExpress.XtraGrid.Columns.TileViewColumn
        Friend WithEvents PnlSearch As Panel
        Friend WithEvents SidePanel2 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents PnlTemplates As DevExpress.XtraEditors.SidePanel
    End Class
End NameSpace