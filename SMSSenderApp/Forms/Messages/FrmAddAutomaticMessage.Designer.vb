<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddAutomaticMessage
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
        Me.TxtGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.LblGroupName = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TxtGroupName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Location = New System.Drawing.Point(161, 112)
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
        Me.BtnSave.Location = New System.Drawing.Point(23, 112)
        Me.BtnSave.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 35)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "حفظ"
        '
        'TxtGroupName
        '
        Me.TxtGroupName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtGroupName.Location = New System.Drawing.Point(23, 60)
        Me.TxtGroupName.MinimumSize = New System.Drawing.Size(433, 20)
        Me.TxtGroupName.Name = "TxtGroupName"
        Me.TxtGroupName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.TxtGroupName.Properties.Appearance.Options.UseFont = true
        Me.TxtGroupName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtGroupName.Size = New System.Drawing.Size(433, 20)
        Me.TxtGroupName.StyleController = Me.StyleController1
        Me.TxtGroupName.TabIndex = 10
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'LblGroupName
        '
        Me.LblGroupName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblGroupName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblGroupName.Appearance.Options.UseFont = true
        Me.LblGroupName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblGroupName.Location = New System.Drawing.Point(23, 30)
        Me.LblGroupName.Name = "LblGroupName"
        Me.LblGroupName.Size = New System.Drawing.Size(31, 16)
        Me.LblGroupName.TabIndex = 11
        Me.LblGroupName.Text = "الاسم"
        '
        'FrmAddAutomaticMessage
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 11!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 176)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtGroupName)
        Me.Controls.Add(Me.LblGroupName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.ShowIcon = false
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmAddAutomaticMessage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الرسائل الدورية"
        CType(Me.TxtGroupName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblGroupName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
End Class
