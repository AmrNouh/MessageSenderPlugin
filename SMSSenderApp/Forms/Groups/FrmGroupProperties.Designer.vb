Namespace Forms.Groups
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmGroupProperties
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
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LblGroupName = New DevExpress.XtraEditors.LabelControl()
        Me.ChkAddManually = New DevExpress.XtraEditors.CheckEdit()
        Me.CmbGroupSettings = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LblMaturityPeriod = New DevExpress.XtraEditors.LabelControl()
        Me.SpnDays = New DevExpress.XtraEditors.SpinEdit()
        Me.LblDay = New DevExpress.XtraEditors.LabelControl()
        Me.LblAddedIn = New DevExpress.XtraEditors.LabelControl()
        Me.LblPeriodInDays = New DevExpress.XtraEditors.LabelControl()
        Me.LblName = New DevExpress.XtraEditors.LabelControl()
        Me.LblBalance = New DevExpress.XtraEditors.LabelControl()
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ChkAddManually.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CmbGroupSettings.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SpnDays.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer), CType(CType(250,Byte),Integer))
        Me.StyleController1.Appearance.Options.UseBorderColor = true
        Me.StyleController1.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue
        Me.StyleController1.AppearanceFocused.Options.UseBorderColor = true
        '
        'BtnCancel
        '
        Me.BtnCancel.AllowFocus = false
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Location = New System.Drawing.Point(169, 218)
        Me.BtnCancel.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(120, 35)
        Me.BtnCancel.StyleController = Me.StyleController1
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "إلغاء"
        '
        'BtnSave
        '
        Me.BtnSave.AllowFocus = false
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.BtnSave.Appearance.Options.UseFont = true
        Me.BtnSave.Location = New System.Drawing.Point(27, 218)
        Me.BtnSave.MinimumSize = New System.Drawing.Size(120, 35)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 35)
        Me.BtnSave.StyleController = Me.StyleController1
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "حفظ"
        '
        'LblGroupName
        '
        Me.LblGroupName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblGroupName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblGroupName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblGroupName.Appearance.Options.UseFont = true
        Me.LblGroupName.Appearance.Options.UseForeColor = true
        Me.LblGroupName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblGroupName.Location = New System.Drawing.Point(27, 28)
        Me.LblGroupName.Name = "LblGroupName"
        Me.LblGroupName.Size = New System.Drawing.Size(161, 16)
        Me.LblGroupName.StyleController = Me.StyleController1
        Me.LblGroupName.TabIndex = 10
        Me.LblGroupName.Text = "طريقة إضافة العملاء للمجموعة"
        '
        'ChkAddManually
        '
        Me.ChkAddManually.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.ChkAddManually.Location = New System.Drawing.Point(42, 56)
        Me.ChkAddManually.Name = "ChkAddManually"
        Me.ChkAddManually.Properties.AllowFocused = false
        Me.ChkAddManually.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9.25!)
        Me.ChkAddManually.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.ChkAddManually.Properties.Appearance.Options.UseFont = true
        Me.ChkAddManually.Properties.Appearance.Options.UseForeColor = true
        Me.ChkAddManually.Properties.Caption = "يتم إالإضافة يدوياً"
        Me.ChkAddManually.Size = New System.Drawing.Size(130, 20)
        Me.ChkAddManually.StyleController = Me.StyleController1
        Me.ChkAddManually.TabIndex = 13
        '
        'CmbGroupSettings
        '
        Me.CmbGroupSettings.EditValue = ""
        Me.CmbGroupSettings.Location = New System.Drawing.Point(42, 104)
        Me.CmbGroupSettings.Name = "CmbGroupSettings"
        Me.CmbGroupSettings.Properties.AllowFocused = false
        Me.CmbGroupSettings.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmbGroupSettings.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9.25!)
        Me.CmbGroupSettings.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.CmbGroupSettings.Properties.Appearance.Options.UseFont = true
        Me.CmbGroupSettings.Properties.Appearance.Options.UseForeColor = true
        Me.CmbGroupSettings.Properties.AutoHeight = false
        Me.CmbGroupSettings.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CmbGroupSettings.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbGroupSettings.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmbGroupSettings.Properties.Items.AddRange(New Object() {"كل من له فواتير مستحقة", "عملاء جدد", "أوقفوا تعاملتهم منذ فترة", "عملاء داخل مجموعة", "عملاء بلغ رصيدهم قيمة معينة"})
        Me.CmbGroupSettings.Size = New System.Drawing.Size(200, 20)
        Me.CmbGroupSettings.StyleController = Me.StyleController1
        Me.CmbGroupSettings.TabIndex = 14
        '
        'LblMaturityPeriod
        '
        Me.LblMaturityPeriod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblMaturityPeriod.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblMaturityPeriod.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblMaturityPeriod.Appearance.Options.UseFont = true
        Me.LblMaturityPeriod.Appearance.Options.UseForeColor = true
        Me.LblMaturityPeriod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblMaturityPeriod.Location = New System.Drawing.Point(42, 139)
        Me.LblMaturityPeriod.Name = "LblMaturityPeriod"
        Me.LblMaturityPeriod.Size = New System.Drawing.Size(79, 16)
        Me.LblMaturityPeriod.TabIndex = 10
        Me.LblMaturityPeriod.Text = "فترة الاستحقاق"
        Me.LblMaturityPeriod.Visible = false
        '
        'SpnDays
        '
        Me.SpnDays.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnDays.Location = New System.Drawing.Point(42, 163)
        Me.SpnDays.Name = "SpnDays"
        Me.SpnDays.Properties.AllowFocused = false
        Me.SpnDays.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.SpnDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.SpnDays.Properties.Appearance.Options.UseFont = true
        Me.SpnDays.Properties.Appearance.Options.UseForeColor = true
        Me.SpnDays.Properties.Appearance.Options.UseTextOptions = true
        Me.SpnDays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpnDays.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SpnDays.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SpnDays.Properties.AppearanceFocused.Font = New System.Drawing.Font("Dexef", 10!)
        Me.SpnDays.Properties.AppearanceFocused.Options.UseFont = true
        Me.SpnDays.Properties.AppearanceFocused.Options.UseTextOptions = true
        Me.SpnDays.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpnDays.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SpnDays.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SpnDays.Properties.AutoHeight = false
        Me.SpnDays.Properties.BeepOnError = false
        Me.SpnDays.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SpnDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpnDays.Properties.MaskSettings.Set("mask", "d")
        Me.SpnDays.Size = New System.Drawing.Size(126, 20)
        Me.SpnDays.StyleController = Me.StyleController1
        Me.SpnDays.TabIndex = 15
        '
        'LblDay
        '
        Me.LblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblDay.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblDay.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblDay.Appearance.Options.UseFont = true
        Me.LblDay.Appearance.Options.UseForeColor = true
        Me.LblDay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblDay.Location = New System.Drawing.Point(171, 165)
        Me.LblDay.Name = "LblDay"
        Me.LblDay.Size = New System.Drawing.Size(22, 16)
        Me.LblDay.TabIndex = 10
        Me.LblDay.Text = "يوم"
        '
        'LblAddedIn
        '
        Me.LblAddedIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblAddedIn.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblAddedIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblAddedIn.Appearance.Options.UseFont = true
        Me.LblAddedIn.Appearance.Options.UseForeColor = true
        Me.LblAddedIn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblAddedIn.Location = New System.Drawing.Point(42, 139)
        Me.LblAddedIn.Name = "LblAddedIn"
        Me.LblAddedIn.Size = New System.Drawing.Size(84, 16)
        Me.LblAddedIn.TabIndex = 16
        Me.LblAddedIn.Text = "تم إضافتهم منذ"
        Me.LblAddedIn.Visible = false
        '
        'LblPeriodInDays
        '
        Me.LblPeriodInDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblPeriodInDays.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblPeriodInDays.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblPeriodInDays.Appearance.Options.UseFont = true
        Me.LblPeriodInDays.Appearance.Options.UseForeColor = true
        Me.LblPeriodInDays.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblPeriodInDays.Location = New System.Drawing.Point(42, 139)
        Me.LblPeriodInDays.Name = "LblPeriodInDays"
        Me.LblPeriodInDays.Size = New System.Drawing.Size(63, 16)
        Me.LblPeriodInDays.TabIndex = 17
        Me.LblPeriodInDays.Text = "الفترة بالأيام"
        Me.LblPeriodInDays.Visible = false
        '
        'LblName
        '
        Me.LblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblName.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblName.Appearance.Options.UseFont = true
        Me.LblName.Appearance.Options.UseForeColor = true
        Me.LblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblName.Location = New System.Drawing.Point(42, 139)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(78, 16)
        Me.LblName.TabIndex = 18
        Me.LblName.Text = "اسم المجموعة"
        Me.LblName.Visible = false
        '
        'LblBalance
        '
        Me.LblBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LblBalance.Appearance.Font = New System.Drawing.Font("Dexef", 10!)
        Me.LblBalance.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer), CType(CType(112,Byte),Integer))
        Me.LblBalance.Appearance.Options.UseFont = true
        Me.LblBalance.Appearance.Options.UseForeColor = true
        Me.LblBalance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LblBalance.Location = New System.Drawing.Point(42, 139)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(30, 16)
        Me.LblBalance.TabIndex = 19
        Me.LblBalance.Text = "الرصيد"
        Me.LblBalance.Visible = false
        '
        'FrmGroupProperties
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(479, 285)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblPeriodInDays)
        Me.Controls.Add(Me.LblAddedIn)
        Me.Controls.Add(Me.SpnDays)
        Me.Controls.Add(Me.CmbGroupSettings)
        Me.Controls.Add(Me.ChkAddManually)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblDay)
        Me.Controls.Add(Me.LblMaturityPeriod)
        Me.Controls.Add(Me.LblGroupName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.ShowIcon = false
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmGroupProperties"
        Me.Padding = New System.Windows.Forms.Padding(24, 0, 24, 0)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الخصائص"
        CType(Me.StyleController1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ChkAddManually.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CmbGroupSettings.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SpnDays.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
        Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LblGroupName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents ChkAddManually As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents CmbGroupSettings As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents LblMaturityPeriod As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SpnDays As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents LblDay As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblAddedIn As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblPeriodInDays As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblBalance As DevExpress.XtraEditors.LabelControl
    End Class
End NameSpace