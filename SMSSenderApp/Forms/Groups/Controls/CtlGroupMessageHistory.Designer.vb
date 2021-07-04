<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlGroupMessageHistory
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
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlGroupMessageHistory))
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.ColMessage = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.ColMSGCount = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.ColCharCount = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ColMessage
        '
        Me.ColMessage.Caption = "Message"
        Me.ColMessage.FieldName = "Message"
        Me.ColMessage.Name = "ColMessage"
        Me.ColMessage.Visible = true
        Me.ColMessage.VisibleIndex = 0
        '
        'ColMSGCount
        '
        Me.ColMSGCount.Caption = "MSGCount"
        Me.ColMSGCount.FieldName = "MSGCount"
        Me.ColMSGCount.Name = "ColMSGCount"
        Me.ColMSGCount.Visible = true
        Me.ColMSGCount.VisibleIndex = 2
        '
        'ColCharCount
        '
        Me.ColCharCount.Caption = "CharCount"
        Me.ColCharCount.FieldName = "CharCount"
        Me.ColCharCount.Name = "ColCharCount"
        Me.ColCharCount.Visible = true
        Me.ColCharCount.VisibleIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GridControl1.Size = New System.Drawing.Size(726, 641)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer))
        Me.TileView1.Appearance.EmptySpace.Options.UseBackColor = true
        Me.TileView1.Appearance.ItemFocused.Options.UseTextOptions = true
        Me.TileView1.Appearance.ItemFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.TileView1.Appearance.ItemNormal.Options.UseTextOptions = true
        Me.TileView1.Appearance.ItemNormal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.TileView1.Appearance.ItemSelected.Options.UseTextOptions = true
        Me.TileView1.Appearance.ItemSelected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.TileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColMessage, Me.ColCharCount, Me.ColMSGCount})
        Me.TileView1.FocusBorderColor = System.Drawing.Color.Transparent
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsBehavior.AllowSmoothScrolling = true
        Me.TileView1.OptionsTiles.AllowPressAnimation = false
        Me.TileView1.OptionsTiles.ColumnCount = 1
        Me.TileView1.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TileView1.OptionsTiles.IndentBetweenItems = 20
        Me.TileView1.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
        Me.TileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(10)
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(457, 100)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.RowCount = 0
        Me.TileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        TableColumnDefinition1.Length.Value = 145R
        TableColumnDefinition2.Length.Value = 230R
        TableColumnDefinition3.Length.Value = 62R
        Me.TileView1.TileColumns.Add(TableColumnDefinition1)
        Me.TileView1.TileColumns.Add(TableColumnDefinition2)
        Me.TileView1.TileColumns.Add(TableColumnDefinition3)
        Me.TileView1.TileRows.Add(TableRowDefinition1)
        Me.TileView1.TileRows.Add(TableRowDefinition2)
        TableSpan1.ColumnSpan = 2
        Me.TileView1.TileSpans.Add(TableSpan1)
        TileViewItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseBackColor = true
        TileViewItemElement1.ColumnIndex = 2
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement1.StretchVertical = true
        TileViewItemElement1.Text = "BackGround"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        TileViewItemElement1.TextLocation = New System.Drawing.Point(-20, 0)
        TileViewItemElement1.TextVisible = false
        TileViewItemElement1.Width = 70
        TileViewItemElement2.Column = Me.ColMessage
        TileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement2.Text = "ColMessage"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement3.ColumnIndex = 2
        TileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        TileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement3.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        TileViewItemElement3.RowIndex = 1
        TileViewItemElement3.Text = "ImageGroup"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        TileViewItemElement3.TextVisible = false
        TileViewItemElement3.ZIndex = 1
        TileViewItemElement4.Column = Me.ColMSGCount
        TileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement4.RowIndex = 1
        TileViewItemElement4.Text = "ColMSGCount"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement5.Column = Me.ColCharCount
        TileViewItemElement5.ColumnIndex = 1
        TileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement5.RowIndex = 1
        TileViewItemElement5.Text = "ColCharCount"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        Me.TileView1.TileTemplate.Add(TileViewItemElement4)
        Me.TileView1.TileTemplate.Add(TileViewItemElement5)
        '
        'CtlGroupMessageHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 11!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "CtlGroupMessageHistory"
        Me.Size = New System.Drawing.Size(726, 641)
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TileView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents ColMessage As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents ColCharCount As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents ColMSGCount As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
