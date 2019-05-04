<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiriZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiriZ))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ackapa = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 30)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(51, 23)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'ackapa
        '
        Me.ackapa.AutoSize = True
        Me.ackapa.Location = New System.Drawing.Point(16, 14)
        Me.ackapa.Name = "ackapa"
        Me.ackapa.Size = New System.Drawing.Size(38, 13)
        Me.ackapa.TabIndex = 10
        Me.ackapa.Text = "Durum"
        Me.ackapa.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(60, 17)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(34, 35)
        Me.WebBrowser1.TabIndex = 9
        Me.WebBrowser1.Visible = False
        '
        'GiriZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(110, 67)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ackapa)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GiriZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GiriZ"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ackapa As Label
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
