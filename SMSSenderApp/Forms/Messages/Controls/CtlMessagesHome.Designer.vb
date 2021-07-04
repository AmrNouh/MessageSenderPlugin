Namespace Forms.Messages.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CtlMessagesHome
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
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlMessagesHome))
        Me.ColName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.PnlTemplates = New DevExpress.XtraEditors.SidePanel()
        Me.SidePanel2 = New DevExpress.XtraEditors.SidePanel()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.TileView = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.SrhCutomers = New DevExpress.XtraEditors.SearchControl()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.PnlTilte = New System.Windows.Forms.Panel()
        Me.BtnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.LblCustomers = New DevExpress.XtraEditors.LabelControl()
        Me.SidePanel3 = New DevExpress.XtraEditors.SidePanel()
        Me.PnlMessagesHistory = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSendMessage = New DevExpress.XtraEditors.SimpleButton()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUserGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCamera = New DevExpress.XtraEditors.SimpleButton()
        Me.SvgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        Me.LblBalance = New DevExpress.XtraEditors.LabelControl()
        Me.LblCustomerName = New DevExpress.XtraEditors.LabelControl()
        Me.SidePanel2.SuspendLayout
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlSearch.SuspendLayout
        CType(Me.SrhCutomers.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlTilte.SuspendLayout
        Me.SidePanel3.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.SvgImageBox1,System.ComponentModel.ISupportInitialize).BeginInit
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
        'PnlTemplates
        '
        Me.PnlTemplates.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlTemplates.Location = New System.Drawing.Point(0, 0)
        Me.PnlTemplates.Name = "PnlTemplates"
        Me.PnlTemplates.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlTemplates.Size = New System.Drawing.Size(233, 663)
        Me.PnlTemplates.TabIndex = 0
        Me.PnlTemplates.Text = "SidePanel1"
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
        Me.SidePanel2.TabIndex = 0
        Me.SidePanel2.Text = "SidePanel2"
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
        TileViewItemElement1.ImageOptions.Image = CType(resources.GetObject("resource.Image"),System.Drawing.Image)
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileViewItemElement1.Text = "ColName"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TileView.TileTemplate.Add(TileViewItemElement1)
        '
        'PnlSearch
        '
        Me.PnlSearch.Controls.Add(Me.SrhCutomers)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(10, 44)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.PnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlSearch.Size = New System.Drawing.Size(309, 40)
        Me.PnlSearch.TabIndex = 1
        '
        'SrhCutomers
        '
        Me.SrhCutomers.Client = Me.GridControl
        Me.SrhCutomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SrhCutomers.EditValue = ""
        Me.SrhCutomers.Location = New System.Drawing.Point(10, 9)
        Me.SrhCutomers.Name = "SrhCutomers"
        Me.SrhCutomers.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhCutomers.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhCutomers.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.DodgerBlue
        Me.SrhCutomers.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhCutomers.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SrhCutomers.Properties.Appearance.Options.UseFont = true
        Me.SrhCutomers.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SrhCutomers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SrhCutomers.Properties.Client = Me.GridControl
        Me.SrhCutomers.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhCutomers.Properties.ShowPopupShadow = false
        Me.SrhCutomers.Properties.Sorted = true
        Me.SrhCutomers.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.SrhCutomers.Size = New System.Drawing.Size(289, 20)
        Me.SrhCutomers.StyleController = Me.StyleController1
        Me.SrhCutomers.TabIndex = 0
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'PnlTilte
        '
        Me.PnlTilte.Controls.Add(Me.BtnAddCustomer)
        Me.PnlTilte.Controls.Add(Me.LblCustomers)
        Me.PnlTilte.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTilte.Location = New System.Drawing.Point(10, 9)
        Me.PnlTilte.Name = "PnlTilte"
        Me.PnlTilte.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.PnlTilte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlTilte.Size = New System.Drawing.Size(309, 35)
        Me.PnlTilte.TabIndex = 0
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAddCustomer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAddCustomer.ImageOptions.SvgImage = CType(resources.GetObject("BtnAddCustomer.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnAddCustomer.Location = New System.Drawing.Point(11, 0)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnAddCustomer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnAddCustomer.Size = New System.Drawing.Size(40, 35)
        Me.BtnAddCustomer.TabIndex = 4
        '
        'LblCustomers
        '
        Me.LblCustomers.Appearance.Font = New System.Drawing.Font("Dexef", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblCustomers.Appearance.Options.UseFont = true
        Me.LblCustomers.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblCustomers.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblCustomers.Location = New System.Drawing.Point(76, 0)
        Me.LblCustomers.Name = "LblCustomers"
        Me.LblCustomers.Size = New System.Drawing.Size(222, 35)
        Me.LblCustomers.TabIndex = 5
        Me.LblCustomers.Text = "العملاء"
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
        Me.SidePanel3.TabIndex = 0
        Me.SidePanel3.Text = "SidePanel3"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.btnUserGroup)
        Me.Panel2.Controls.Add(Me.btnCamera)
        Me.Panel2.Controls.Add(Me.SvgImageBox1)
        Me.Panel2.Controls.Add(Me.LblBalance)
        Me.Panel2.Controls.Add(Me.LblCustomerName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(100, 25)
        Me.Panel2.MinimumSize = New System.Drawing.Size(574, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 75)
        Me.Panel2.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(120, 17)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton1.Size = New System.Drawing.Size(47, 41)
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "SimpleButton3"
        '
        'btnUserGroup
        '
        Me.btnUserGroup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnUserGroup.ImageOptions.SvgImage = CType(resources.GetObject("btnUserGroup.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnUserGroup.Location = New System.Drawing.Point(73, 17)
        Me.btnUserGroup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserGroup.Name = "btnUserGroup"
        Me.btnUserGroup.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnUserGroup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnUserGroup.Size = New System.Drawing.Size(47, 41)
        Me.btnUserGroup.TabIndex = 12
        Me.btnUserGroup.Text = "SimpleButton2"
        '
        'btnCamera
        '
        Me.btnCamera.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCamera.ImageOptions.SvgImage = CType(resources.GetObject("btnCamera.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnCamera.Location = New System.Drawing.Point(26, 17)
        Me.btnCamera.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnCamera.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCamera.Size = New System.Drawing.Size(47, 41)
        Me.btnCamera.TabIndex = 11
        Me.btnCamera.Text = "SimpleButton1"
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
        'LblBalance
        '
        Me.LblBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblBalance.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblBalance.Appearance.Options.UseFont = true
        Me.LblBalance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblBalance.Location = New System.Drawing.Point(416, 45)
        Me.LblBalance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(108, 25)
        Me.LblBalance.TabIndex = 10
        Me.LblBalance.Text = "0"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblCustomerName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblCustomerName.Appearance.Options.UseFont = true
        Me.LblCustomerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblCustomerName.Location = New System.Drawing.Point(189, 25)
        Me.LblCustomerName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(335, 25)
        Me.LblCustomerName.TabIndex = 10
        Me.LblCustomerName.Text = "شركة الحمد للتجارة و التوريدات"
        '
        'CtlMessagesHome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SidePanel3)
        Me.Controls.Add(Me.SidePanel2)
        Me.Controls.Add(Me.PnlTemplates)
        Me.Name = "CtlMessagesHome"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(1279, 663)
        Me.SidePanel2.ResumeLayout(false)
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TileView,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlSearch.ResumeLayout(false)
        CType(Me.SrhCutomers.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlTilte.ResumeLayout(false)
        Me.SidePanel3.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.SvgImageBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents PnlTemplates As DevExpress.XtraEditors.SidePanel
        Friend WithEvents SidePanel2 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents SidePanel3 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents PnlTilte As Panel
        Friend WithEvents BtnAddCustomer As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LblCustomers As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PnlSearch As Panel
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents TileView As DevExpress.XtraGrid.Views.Tile.TileView
        Friend WithEvents ColName As DevExpress.XtraGrid.Columns.TileViewColumn
        Friend WithEvents SrhCutomers As DevExpress.XtraEditors.SearchControl
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents SvgImageBox1 As DevExpress.XtraEditors.SvgImageBox
        Friend WithEvents LblCustomerName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnUserGroup As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnCamera As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LblBalance As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PnlMessagesHistory As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
        Friend WithEvents BtnSendMessage As DevExpress.XtraEditors.SimpleButton
    End Class
End NameSpace