<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSMSTemplate
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSMSTemplate))
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.LblGroup = New DevExpress.XtraEditors.LabelControl()
        Me.LblAddress = New DevExpress.XtraEditors.LabelControl()
        Me.TxtName = New DevExpress.XtraEditors.TextEdit()
        Me.LblName = New DevExpress.XtraEditors.LabelControl()
        Me.TxtAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.TLUEGroups = New DevExpress.XtraEditors.TreeListLookUpEdit()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.SvgImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtAddress.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TLUEGroups.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TreeList1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImageListBoxControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SvgImageCollection,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'LblGroup
        '
        Me.LblGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblGroup.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblGroup.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblGroup.Appearance.Options.UseFont = true
        Me.LblGroup.Appearance.Options.UseForeColor = true
        Me.LblGroup.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblGroup.Location = New System.Drawing.Point(23, 69)
        Me.LblGroup.Name = "LblGroup"
        Me.LblGroup.Size = New System.Drawing.Size(58, 16)
        Me.LblGroup.TabIndex = 7
        Me.LblGroup.Text = "توجد بداخل"
        '
        'LblAddress
        '
        Me.LblAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblAddress.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblAddress.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblAddress.Appearance.Options.UseFont = true
        Me.LblAddress.Appearance.Options.UseForeColor = true
        Me.LblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblAddress.Location = New System.Drawing.Point(23, 129)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(34, 16)
        Me.LblAddress.TabIndex = 8
        Me.LblAddress.Text = "الرسالة"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtName.Location = New System.Drawing.Point(23, 40)
        Me.TxtName.MinimumSize = New System.Drawing.Size(433, 20)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.TxtName.Properties.Appearance.Options.UseFont = true
        Me.TxtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtName.Size = New System.Drawing.Size(433, 20)
        Me.TxtName.StyleController = Me.StyleController1
        Me.TxtName.TabIndex = 9
        '
        'LblName
        '
        Me.LblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblName.Appearance.Options.UseFont = true
        Me.LblName.Appearance.Options.UseForeColor = true
        Me.LblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblName.Location = New System.Drawing.Point(23, 15)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(31, 16)
        Me.LblName.TabIndex = 10
        Me.LblName.Text = "الاسم"
        '
        'TxtAddress
        '
        Me.TxtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtAddress.Location = New System.Drawing.Point(23, 159)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.TxtAddress.Properties.Appearance.Options.UseFont = true
        Me.TxtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtAddress.Size = New System.Drawing.Size(297, 150)
        Me.TxtAddress.StyleController = Me.StyleController1
        Me.TxtAddress.TabIndex = 12
        '
        'TLUEGroups
        '
        Me.TLUEGroups.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TLUEGroups.Location = New System.Drawing.Point(23, 96)
        Me.TLUEGroups.MinimumSize = New System.Drawing.Size(217, 20)
        Me.TLUEGroups.Name = "TLUEGroups"
        Me.TLUEGroups.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.TLUEGroups.Properties.Appearance.Options.UseFont = true
        Me.TLUEGroups.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TLUEGroups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TLUEGroups.Properties.NullText = ""
        Me.TLUEGroups.Properties.TreeList = Me.TreeList1
        Me.TLUEGroups.Size = New System.Drawing.Size(247, 20)
        Me.TLUEGroups.StyleController = Me.StyleController1
        Me.TLUEGroups.TabIndex = 11
        '
        'TreeList1
        '
        Me.TreeList1.Location = New System.Drawing.Point(11, -55)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.ShowIndentAsRowStyle = true
        Me.TreeList1.Size = New System.Drawing.Size(400, 232)
        Me.TreeList1.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Appearance.Options.UseForeColor = true
        Me.BtnCancel.Location = New System.Drawing.Point(171, 349)
        Me.BtnCancel.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(120, 35)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "إلغاء"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.BtnSave.Appearance.Options.UseFont = true
        Me.BtnSave.Appearance.Options.UseForeColor = true
        Me.BtnSave.Location = New System.Drawing.Point(34, 349)
        Me.BtnSave.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 35)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "حفظ"
        '
        'ImageListBoxControl1
        '
        Me.ImageListBoxControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ImageListBoxControl1.ImageList = Me.SvgImageCollection
        Me.ImageListBoxControl1.Location = New System.Drawing.Point(327, 159)
        Me.ImageListBoxControl1.Name = "ImageListBoxControl1"
        Me.ImageListBoxControl1.Size = New System.Drawing.Size(142, 150)
        Me.ImageListBoxControl1.StyleController = Me.StyleController1
        Me.ImageListBoxControl1.TabIndex = 15
        '
        'SvgImageCollection
        '
        Me.SvgImageCollection.Add("variable-symbol-in-window (1)", CType(resources.GetObject("SvgImageCollection.variable-symbol-in-window (1)"),DevExpress.Utils.Svg.SvgImage))
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Appearance.Options.UseForeColor = true
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(327, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "المتغيرات"
        '
        'FrmSMSTemplate
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(479, 405)
        Me.Controls.Add(Me.ImageListBoxControl1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblGroup)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TLUEGroups)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.ShowIcon = false
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmSMSTemplate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الخصائص"
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtAddress.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TLUEGroups.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TreeList1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImageListBoxControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SvgImageCollection,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents LblGroup As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TLUEGroups As DevExpress.XtraEditors.TreeListLookUpEdit
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents SvgImageCollection As DevExpress.Utils.SvgImageCollection
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
