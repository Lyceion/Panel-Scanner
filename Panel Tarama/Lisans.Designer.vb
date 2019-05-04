<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lisans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lisans))
        Me.tabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.tabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX8 = New DevComponents.DotNetBar.LabelX()
        Me.buttonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX7 = New DevComponents.DotNetBar.LabelX()
        Me.labelX6 = New DevComponents.DotNetBar.LabelX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.buttonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.tabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.tabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.labelX3 = New DevComponents.DotNetBar.LabelX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.tabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabControlPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlPanel1.SuspendLayout()
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabItem2
        '
        Me.tabItem2.AttachedControl = Me.tabControlPanel2
        Me.tabItem2.Name = "tabItem2"
        Me.tabItem2.Text = "İletişim"
        '
        'tabControlPanel2
        '
        Me.tabControlPanel2.Controls.Add(Me.PictureBox1)
        Me.tabControlPanel2.Controls.Add(Me.textBoxX3)
        Me.tabControlPanel2.Controls.Add(Me.textBoxX2)
        Me.tabControlPanel2.Controls.Add(Me.labelX8)
        Me.tabControlPanel2.Controls.Add(Me.buttonX3)
        Me.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.tabControlPanel2.Name = "tabControlPanel2"
        Me.tabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.tabControlPanel2.Size = New System.Drawing.Size(626, 147)
        Me.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.tabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.tabControlPanel2.Style.GradientAngle = 90
        Me.tabControlPanel2.TabIndex = 5
        Me.tabControlPanel2.TabItem = Me.tabItem2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = Global.Panel_Tarama.My.Resources.Resources.adLQ87
        Me.PictureBox1.Location = New System.Drawing.Point(359, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'textBoxX3
        '
        Me.textBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textBoxX3.Border.Class = "TextBoxBorder"
        Me.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX3.ForeColor = System.Drawing.Color.Black
        Me.textBoxX3.Location = New System.Drawing.Point(12, 59)
        Me.textBoxX3.Name = "textBoxX3"
        Me.textBoxX3.PreventEnterBeep = True
        Me.textBoxX3.Size = New System.Drawing.Size(328, 20)
        Me.textBoxX3.TabIndex = 80
        Me.textBoxX3.WatermarkText = "Mesajınız.."
        '
        'textBoxX2
        '
        Me.textBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX2.ForeColor = System.Drawing.Color.Black
        Me.textBoxX2.Location = New System.Drawing.Point(12, 33)
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.PreventEnterBeep = True
        Me.textBoxX2.Size = New System.Drawing.Size(328, 20)
        Me.textBoxX2.TabIndex = 0
        Me.textBoxX2.WatermarkText = "Email"
        '
        'labelX8
        '
        Me.labelX8.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelX8.Location = New System.Drawing.Point(12, 4)
        Me.labelX8.Name = "labelX8"
        Me.labelX8.SingleLineColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelX8.Size = New System.Drawing.Size(328, 23)
        Me.labelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.labelX8.TabIndex = 78
        Me.labelX8.Text = "Bilgileri Eksiksiz ve Uygun Bir Şekilde Doldurunuz!"
        Me.labelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'buttonX3
        '
        Me.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX3.Location = New System.Drawing.Point(12, 85)
        Me.buttonX3.Name = "buttonX3"
        Me.buttonX3.Size = New System.Drawing.Size(328, 52)
        Me.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.buttonX3.Symbol = ""
        Me.buttonX3.TabIndex = 67
        Me.buttonX3.Text = "Gönder"
        '
        'textBoxX1
        '
        Me.textBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textBoxX1.ForeColor = System.Drawing.Color.Black
        Me.textBoxX1.Location = New System.Drawing.Point(121, 88)
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.PreventEnterBeep = True
        Me.textBoxX1.Size = New System.Drawing.Size(273, 20)
        Me.textBoxX1.TabIndex = 61
        '
        'labelX7
        '
        Me.labelX7.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX7.Location = New System.Drawing.Point(12, 85)
        Me.labelX7.Name = "labelX7"
        Me.labelX7.Size = New System.Drawing.Size(103, 23)
        Me.labelX7.TabIndex = 62
        Me.labelX7.Text = "Kullanıcı Adınız:"
        '
        'labelX6
        '
        Me.labelX6.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX6.ForeColor = System.Drawing.Color.Red
        Me.labelX6.Location = New System.Drawing.Point(121, 59)
        Me.labelX6.Name = "labelX6"
        Me.labelX6.Size = New System.Drawing.Size(273, 23)
        Me.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.labelX6.TabIndex = 59
        '
        'labelX5
        '
        Me.labelX5.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.ForeColor = System.Drawing.Color.Red
        Me.labelX5.Location = New System.Drawing.Point(121, 33)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(273, 23)
        Me.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.labelX5.TabIndex = 58
        '
        'labelX4
        '
        Me.labelX4.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.ForeColor = System.Drawing.Color.Red
        Me.labelX4.Location = New System.Drawing.Point(59, 7)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.SingleLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelX4.Size = New System.Drawing.Size(248, 23)
        Me.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.labelX4.TabIndex = 57
        '
        'buttonX2
        '
        Me.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX2.Location = New System.Drawing.Point(12, 114)
        Me.buttonX2.Name = "buttonX2"
        Me.buttonX2.Size = New System.Drawing.Size(382, 23)
        Me.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.buttonX2.TabIndex = 56
        Me.buttonX2.Text = "Kayıt Ol"
        '
        'tabItem1
        '
        Me.tabItem1.AttachedControl = Me.tabControlPanel1
        Me.tabItem1.Name = "tabItem1"
        Me.tabItem1.Text = "Lisans"
        '
        'tabControlPanel1
        '
        Me.tabControlPanel1.Controls.Add(Me.buttonX1)
        Me.tabControlPanel1.Controls.Add(Me.Label2)
        Me.tabControlPanel1.Controls.Add(Me.Label1)
        Me.tabControlPanel1.Controls.Add(Me.labelX7)
        Me.tabControlPanel1.Controls.Add(Me.textBoxX1)
        Me.tabControlPanel1.Controls.Add(Me.labelX6)
        Me.tabControlPanel1.Controls.Add(Me.labelX5)
        Me.tabControlPanel1.Controls.Add(Me.labelX4)
        Me.tabControlPanel1.Controls.Add(Me.buttonX2)
        Me.tabControlPanel1.Controls.Add(Me.labelX1)
        Me.tabControlPanel1.Controls.Add(Me.labelX3)
        Me.tabControlPanel1.Controls.Add(Me.labelX2)
        Me.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.tabControlPanel1.Name = "tabControlPanel1"
        Me.tabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.tabControlPanel1.Size = New System.Drawing.Size(626, 147)
        Me.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.tabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.tabControlPanel1.Style.GradientAngle = 90
        Me.tabControlPanel1.TabIndex = 1
        Me.tabControlPanel1.TabItem = Me.tabItem1
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(542, 118)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(75, 23)
        Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.buttonX1.TabIndex = 52
        Me.buttonX1.Text = "Çıkış Yap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(400, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 130)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Panel Tarayıcı By " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@SUPERNOVA ~ @MrCylops" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "**10 Ücretsiz Kullanım Hakkınız Dol" & _
            "muştur." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lisans Alınız..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kullanıcı Adı Yerine Lütfen Forum Kullanıcı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adınız" & _
            "ı Yazınız." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CrackingStar.Org..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(313, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Tıkla " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HWID Kopyala!"
        '
        'labelX1
        '
        Me.labelX1.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Location = New System.Drawing.Point(12, 7)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(41, 23)
        Me.labelX1.TabIndex = 53
        Me.labelX1.Text = "HWID : "
        '
        'labelX3
        '
        Me.labelX3.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX3.Location = New System.Drawing.Point(12, 59)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(103, 23)
        Me.labelX3.TabIndex = 55
        Me.labelX3.Text = "Kullanıcı Adı :"
        '
        'labelX2
        '
        Me.labelX2.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(12, 33)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(103, 23)
        Me.labelX2.TabIndex = 54
        Me.labelX2.Text = "Bilgisayar Adı : "
        '
        'styleManager1
        '
        Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light
        Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'tabControl1
        '
        Me.tabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabControl1.CanReorderTabs = True
        Me.tabControl1.Controls.Add(Me.tabControlPanel1)
        Me.tabControl1.Controls.Add(Me.tabControlPanel2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.ForeColor = System.Drawing.Color.Black
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabControl1.SelectedTabIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(626, 174)
        Me.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.tabControl1.TabIndex = 53
        Me.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabControl1.Tabs.Add(Me.tabItem1)
        Me.tabControl1.Tabs.Add(Me.tabItem2)
        Me.tabControl1.Text = "tabControl1"
        '
        'Timer1
        '
        '
        'Lisans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(626, 174)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lisans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lisans"
        Me.tabControlPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlPanel1.ResumeLayout(False)
        Me.tabControlPanel1.PerformLayout()
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents tabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents textBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents labelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents buttonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents labelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents tabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents tabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
