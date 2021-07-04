Namespace Forms.Groups
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAddCustomerToGroup
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
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LblCustomerName = New DevExpress.XtraEditors.LabelControl()
        Me.LUECustomerName = New DevExpress.XtraEditors.LookUpEdit()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        CType(Me.LUECustomerName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Location = New System.Drawing.Point(161, 109)
        Me.BtnCancel.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(120, 35)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "إلغاء"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnSave.Appearance.Options.UseFont = true
        Me.BtnSave.Location = New System.Drawing.Point(23, 109)
        Me.BtnSave.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 35)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "حفظ"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblCustomerName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblCustomerName.Appearance.Options.UseFont = true
        Me.LblCustomerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblCustomerName.Location = New System.Drawing.Point(23, 27)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(31, 16)
        Me.LblCustomerName.TabIndex = 11
        Me.LblCustomerName.Text = "الاسم"
        '
        'LUECustomerName
        '
        Me.LUECustomerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LUECustomerName.Location = New System.Drawing.Point(23, 57)
        Me.LUECustomerName.MinimumSize = New System.Drawing.Size(433, 20)
        Me.LUECustomerName.Name = "LUECustomerName"
        Me.LUECustomerName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.LUECustomerName.Properties.Appearance.Options.UseFont = true
        Me.LUECustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LUECustomerName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUECustomerName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "الاسم", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LUECustomerName.Properties.NullText = ""
        Me.LUECustomerName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LUECustomerName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.LUECustomerName.Properties.ShowFooter = false
        Me.LUECustomerName.Properties.ShowLines = false
        Me.LUECustomerName.Size = New System.Drawing.Size(433, 20)
        Me.LUECustomerName.StyleController = Me.StyleController1
        Me.LUECustomerName.TabIndex = 10
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'FrmAddCustomerToGroup
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(479, 171)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblCustomerName)
        Me.Controls.Add(Me.LUECustomerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.ShowIcon = false
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmAddCustomerToGroup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة عميل"
        CType(Me.LUECustomerName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LblCustomerName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LUECustomerName As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    End Class
End NameSpace