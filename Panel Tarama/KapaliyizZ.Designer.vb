<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KapaliyizZ
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KapaliyizZ))
        Me.HuraForm1 = New Panel_Tarama.HuraForm()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.HuraButton1 = New Panel_Tarama.HuraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Panel_Tarama.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.RichTextBox1)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Red
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(437, 200)
        Me.HuraForm1.TabIndex = 1
        Me.HuraForm1.Text = "PROGRAM IS CLOSED!"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 49)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(413, 139)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(408, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(26, 27)
        Me.HuraButton1.TabIndex = 1
        Me.HuraButton1.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Closed Annoucment Under:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Timer2
        '
        '
        'KapaliyizZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 200)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KapaliyizZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KapaliyizZ"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents HuraButton1 As HuraButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
