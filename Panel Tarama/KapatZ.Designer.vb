<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KapatZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KapatZ))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThirteenButton1 = New Panel_Tarama.ThirteenButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please Click ""Kapat!"" After " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Update Downloaded!"
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.Black
        Me.ThirteenButton1.ColorScheme = Panel_Tarama.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(73, 54)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(118, 44)
        Me.ThirteenButton1.TabIndex = 4
        Me.ThirteenButton1.Text = "Close!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Take Me Away!)"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'KapatZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(260, 108)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThirteenButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KapatZ"
        Me.Text = "KapatZ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ThirteenButton1 As ThirteenButton
End Class
