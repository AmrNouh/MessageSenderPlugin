Namespace Forms.Messages.Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CtlMsgTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlMsgTemplate))
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.SrhCutomers = New DevExpress.XtraEditors.SearchControl()
        Me.TLTemplates = New DevExpress.XtraTreeList.TreeList()
        Me.ColName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.SvgImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.PnlTilte = New System.Windows.Forms.Panel()
        Me.BtnSMSTemplate = New DevExpress.XtraEditors.SimpleButton()
        Me.LblCustomers = New DevExpress.XtraEditors.LabelControl()
        Me.PnlSearch.SuspendLayout
        CType(Me.SrhCutomers.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TLTemplates,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SvgImageCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlTilte.SuspendLayout
        Me.SuspendLayout
        '
        'PnlSearch
        '
        Me.PnlSearch.Controls.Add(Me.SrhCutomers)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(0, 35)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.PnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlSearch.Size = New System.Drawing.Size(363, 40)
        Me.PnlSearch.TabIndex = 3
        '
        'SrhCutomers
        '
        Me.SrhCutomers.Client = Me.TLTemplates
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
        Me.SrhCutomers.Properties.Client = Me.TLTemplates
        Me.SrhCutomers.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.SrhCutomers.Properties.ShowPopupShadow = false
        Me.SrhCutomers.Properties.Sorted = true
        Me.SrhCutomers.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.SrhCutomers.Size = New System.Drawing.Size(343, 20)
        Me.SrhCutomers.StyleController = Me.StyleController1
        Me.SrhCutomers.TabIndex = 0
        '
        'TLTemplates
        '
        Me.TLTemplates.Appearance.FocusedCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLTemplates.Appearance.FocusedCell.Options.UseBackColor = true
        Me.TLTemplates.Appearance.FocusedRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLTemplates.Appearance.FocusedRow.Options.UseBackColor = true
        Me.TLTemplates.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLTemplates.Appearance.Row.Font = New System.Drawing.Font("Dexef", 10!)
        Me.TLTemplates.Appearance.Row.Options.UseBackColor = true
        Me.TLTemplates.Appearance.Row.Options.UseFont = true
        Me.TLTemplates.Appearance.SelectedRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLTemplates.Appearance.SelectedRow.Options.UseBackColor = true
        Me.TLTemplates.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.ColName})
        Me.TLTemplates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLTemplates.Location = New System.Drawing.Point(0, 75)
        Me.TLTemplates.Name = "TLTemplates"
        Me.TLTemplates.OptionsBehavior.Editable = false
        Me.TLTemplates.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
        Me.TLTemplates.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell
        Me.TLTemplates.OptionsView.ShowButtons = false
        Me.TLTemplates.OptionsView.ShowColumns = false
        Me.TLTemplates.OptionsView.ShowFirstLines = false
        Me.TLTemplates.OptionsView.ShowHorzLines = false
        Me.TLTemplates.OptionsView.ShowIndicator = false
        Me.TLTemplates.OptionsView.ShowRoot = false
        Me.TLTemplates.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.TLTemplates.OptionsView.ShowVertLines = false
        Me.TLTemplates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TLTemplates.RowHeight = 50
        Me.TLTemplates.SelectImageList = Me.SvgImageCollection
        Me.TLTemplates.Size = New System.Drawing.Size(363, 497)
        Me.TLTemplates.TabIndex = 4
        '
        'ColName
        '
        Me.ColName.Caption = "Name"
        Me.ColName.FieldName = "Name"
        Me.ColName.Name = "ColName"
        Me.ColName.Visible = true
        Me.ColName.VisibleIndex = 0
        '
        'SvgImageCollection
        '
        Me.SvgImageCollection.Add("SVGFolder", CType(resources.GetObject("SvgImageCollection.SVGFolder"),DevExpress.Utils.Svg.SvgImage))
        Me.SvgImageCollection.Add("SVGOpenedFolder", CType(resources.GetObject("SvgImageCollection.SVGOpenedFolder"),DevExpress.Utils.Svg.SvgImage))
        Me.SvgImageCollection.Add("SVGEditMessage", CType(resources.GetObject("SvgImageCollection.SVGEditMessage"),DevExpress.Utils.Svg.SvgImage))
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
        Me.PnlTilte.Controls.Add(Me.BtnSMSTemplate)
        Me.PnlTilte.Controls.Add(Me.LblCustomers)
        Me.PnlTilte.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTilte.Location = New System.Drawing.Point(0, 0)
        Me.PnlTilte.Name = "PnlTilte"
        Me.PnlTilte.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.PnlTilte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PnlTilte.Size = New System.Drawing.Size(363, 35)
        Me.PnlTilte.TabIndex = 2
        '
        'BtnSMSTemplate
        '
        Me.BtnSMSTemplate.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSMSTemplate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnSMSTemplate.ImageOptions.SvgImage = CType(resources.GetObject("BtnAddCustomer.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.BtnSMSTemplate.Location = New System.Drawing.Point(11, 0)
        Me.BtnSMSTemplate.Name = "BtnSMSTemplate"
        Me.BtnSMSTemplate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnSMSTemplate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnSMSTemplate.Size = New System.Drawing.Size(40, 35)
        Me.BtnSMSTemplate.TabIndex = 4
        Me.BtnSMSTemplate.Text = "SimpleButton1"
        '
        'LblCustomers
        '
        Me.LblCustomers.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblCustomers.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer), CType(CType(171,Byte),Integer))
        Me.LblCustomers.Appearance.Options.UseFont = true
        Me.LblCustomers.Appearance.Options.UseForeColor = true
        Me.LblCustomers.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblCustomers.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblCustomers.Location = New System.Drawing.Point(130, 0)
        Me.LblCustomers.Name = "LblCustomers"
        Me.LblCustomers.Size = New System.Drawing.Size(222, 35)
        Me.LblCustomers.TabIndex = 5
        Me.LblCustomers.Text = "قوالب الرسائل"
        '
        'CtlMsgTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 11!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TLTemplates)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.PnlTilte)
        Me.Name = "CtlMsgTemplate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(363, 572)
        Me.PnlSearch.ResumeLayout(false)
        CType(Me.SrhCutomers.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TLTemplates,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SvgImageCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlTilte.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents PnlSearch As Panel
        Friend WithEvents SrhCutomers As DevExpress.XtraEditors.SearchControl
        Friend WithEvents PnlTilte As Panel
        Friend WithEvents BtnSMSTemplate As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LblCustomers As DevExpress.XtraEditors.LabelControl
        Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
        Friend WithEvents SvgImageCollection As DevExpress.Utils.SvgImageCollection
        Friend WithEvents TLTemplates As DevExpress.XtraTreeList.TreeList
        Friend WithEvents ColName As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End NameSpace