<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class offlineList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(offlineList))
        Me.gunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Circular_PictureBox1 = New C_UI_.Circular_PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.a_h = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gunaVScrollBar1
        '
        Me.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.gunaVScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.gunaVScrollBar1.LargeChange = 10
        Me.gunaVScrollBar1.Location = New System.Drawing.Point(1185, 198)
        Me.gunaVScrollBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.gunaVScrollBar1.Maximum = 1
        Me.gunaVScrollBar1.Name = "gunaVScrollBar1"
        Me.gunaVScrollBar1.Radius = 2
        Me.gunaVScrollBar1.ScrollbarSize = 5
        Me.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gunaVScrollBar1.Size = New System.Drawing.Size(36, 548)
        Me.gunaVScrollBar1.TabIndex = 68
        Me.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.listView1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 198)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1217, 583)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'listView1
        '
        Me.listView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.listView1.ForeColor = System.Drawing.Color.White
        Me.listView1.FullRowSelect = True
        Me.listView1.HideSelection = False
        Me.listView1.LargeImageList = Me.imageList1
        Me.listView1.Location = New System.Drawing.Point(2, 2)
        Me.listView1.Margin = New System.Windows.Forms.Padding(2)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(1208, 65535)
        Me.listView1.SmallImageList = Me.imageList1
        Me.listView1.TabIndex = 67
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.List
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(30, 30)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Circular_PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1221, 198)
        Me.Panel2.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(1037, 15)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 20)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = ""
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(1077, 15)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = ""
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(1123, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Youtube Horn v1.0 | Offline"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(1157, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1188, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Circular_PictureBox1
        '
        Me.Circular_PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Circular_PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.admin_d2
        Me.Circular_PictureBox1.Location = New System.Drawing.Point(21, 76)
        Me.Circular_PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Circular_PictureBox1.Name = "Circular_PictureBox1"
        Me.Circular_PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.Circular_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Circular_PictureBox1.TabIndex = 9
        Me.Circular_PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(109, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(110, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0 items"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 2
        Me.BunifuElipse1.TargetControl = Me
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.BackColor = System.Drawing.Color.Transparent
        Me.GunaResizeControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.White
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(0, 746)
        Me.GunaResizeControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(1221, 35)
        Me.GunaResizeControl1.TabIndex = 5
        Me.GunaResizeControl1.TargetControl = Me
        '
        'timer4
        '
        Me.timer4.Enabled = True
        Me.timer4.Interval = 29
        '
        'a_h
        '
        Me.a_h.Interval = 29
        '
        'offlineList
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 781)
        Me.Controls.Add(Me.gunaVScrollBar1)
        Me.Controls.Add(Me.GunaResizeControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1221, 781)
        Me.Name = "offlineList"
        Me.Opacity = 0R
        Me.Text = "offlineList"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Circular_PictureBox1 As C_UI_.Circular_PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Private WithEvents imageList1 As ImageList
    Private WithEvents gunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Private WithEvents timer1 As Timer
    Public WithEvents listView1 As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Private WithEvents timer4 As Timer
    Private WithEvents a_h As Timer
End Class
