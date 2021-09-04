<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LEDaddr = New System.Windows.Forms.TextBox()
        Me.getinfo = New System.Windows.Forms.Button()
        Me.ledInfo = New System.Windows.Forms.RichTextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.redBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblred = New System.Windows.Forms.Label()
        Me.lblgreen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.greenBar = New System.Windows.Forms.TrackBar()
        Me.lblblue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.blueBar = New System.Windows.Forms.TrackBar()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.lblbright = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brightBar = New System.Windows.Forms.TrackBar()
        CType(Me.redBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.greenBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blueBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brightBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LEDaddr
        '
        Me.LEDaddr.Location = New System.Drawing.Point(39, 43)
        Me.LEDaddr.Name = "LEDaddr"
        Me.LEDaddr.Size = New System.Drawing.Size(357, 20)
        Me.LEDaddr.TabIndex = 0
        Me.LEDaddr.Text = "monitorleds.local"
        '
        'getinfo
        '
        Me.getinfo.Location = New System.Drawing.Point(402, 43)
        Me.getinfo.Name = "getinfo"
        Me.getinfo.Size = New System.Drawing.Size(75, 23)
        Me.getinfo.TabIndex = 1
        Me.getinfo.Text = "Get info"
        Me.getinfo.UseVisualStyleBackColor = True
        '
        'ledInfo
        '
        Me.ledInfo.Enabled = False
        Me.ledInfo.Location = New System.Drawing.Point(522, 21)
        Me.ledInfo.Name = "ledInfo"
        Me.ledInfo.Size = New System.Drawing.Size(241, 156)
        Me.ledInfo.TabIndex = 2
        Me.ledInfo.Text = ""
        '
        'redBar
        '
        Me.redBar.LargeChange = 0
        Me.redBar.Location = New System.Drawing.Point(39, 247)
        Me.redBar.Maximum = 255
        Me.redBar.Name = "redBar"
        Me.redBar.Size = New System.Drawing.Size(485, 45)
        Me.redBar.TabIndex = 3
        Me.redBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(36, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Red:"
        '
        'lblred
        '
        Me.lblred.AutoSize = True
        Me.lblred.Location = New System.Drawing.Point(69, 231)
        Me.lblred.Name = "lblred"
        Me.lblred.Size = New System.Drawing.Size(13, 13)
        Me.lblred.TabIndex = 5
        Me.lblred.Text = "0"
        '
        'lblgreen
        '
        Me.lblgreen.AutoSize = True
        Me.lblgreen.Location = New System.Drawing.Point(69, 282)
        Me.lblgreen.Name = "lblgreen"
        Me.lblgreen.Size = New System.Drawing.Size(13, 13)
        Me.lblgreen.TabIndex = 8
        Me.lblgreen.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(36, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Green:"
        '
        'greenBar
        '
        Me.greenBar.LargeChange = 0
        Me.greenBar.Location = New System.Drawing.Point(39, 298)
        Me.greenBar.Maximum = 255
        Me.greenBar.Name = "greenBar"
        Me.greenBar.Size = New System.Drawing.Size(485, 45)
        Me.greenBar.TabIndex = 6
        Me.greenBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblblue
        '
        Me.lblblue.AutoSize = True
        Me.lblblue.Location = New System.Drawing.Point(69, 333)
        Me.lblblue.Name = "lblblue"
        Me.lblblue.Size = New System.Drawing.Size(13, 13)
        Me.lblblue.TabIndex = 11
        Me.lblblue.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(36, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Blue:"
        '
        'blueBar
        '
        Me.blueBar.LargeChange = 0
        Me.blueBar.Location = New System.Drawing.Point(39, 349)
        Me.blueBar.Maximum = 255
        Me.blueBar.Name = "blueBar"
        Me.blueBar.Size = New System.Drawing.Size(485, 45)
        Me.blueBar.TabIndex = 9
        Me.blueBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'btnColour
        '
        Me.btnColour.Location = New System.Drawing.Point(234, 400)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(105, 23)
        Me.btnColour.TabIndex = 12
        Me.btnColour.Text = "Change colour"
        Me.btnColour.UseVisualStyleBackColor = True
        '
        'lblbright
        '
        Me.lblbright.AutoSize = True
        Me.lblbright.Location = New System.Drawing.Point(96, 167)
        Me.lblbright.Name = "lblbright"
        Me.lblbright.Size = New System.Drawing.Size(13, 13)
        Me.lblbright.TabIndex = 15
        Me.lblbright.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(36, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Brightness:"
        '
        'brightBar
        '
        Me.brightBar.LargeChange = 0
        Me.brightBar.Location = New System.Drawing.Point(39, 183)
        Me.brightBar.Maximum = 255
        Me.brightBar.Name = "brightBar"
        Me.brightBar.Size = New System.Drawing.Size(485, 45)
        Me.brightBar.TabIndex = 13
        Me.brightBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblbright)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.brightBar)
        Me.Controls.Add(Me.btnColour)
        Me.Controls.Add(Me.lblblue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.blueBar)
        Me.Controls.Add(Me.lblgreen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.greenBar)
        Me.Controls.Add(Me.lblred)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.redBar)
        Me.Controls.Add(Me.ledInfo)
        Me.Controls.Add(Me.getinfo)
        Me.Controls.Add(Me.LEDaddr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "WLED Controller"
        CType(Me.redBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.greenBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blueBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brightBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LEDaddr As TextBox
    Friend WithEvents getinfo As Button
    Friend WithEvents ledInfo As RichTextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents redBar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblred As Label
    Friend WithEvents lblgreen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents greenBar As TrackBar
    Friend WithEvents lblblue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents blueBar As TrackBar
    Friend WithEvents btnColour As Button
    Friend WithEvents lblbright As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents brightBar As TrackBar
End Class
