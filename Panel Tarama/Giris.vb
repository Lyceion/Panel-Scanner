﻿Imports Microsoft.VisualBasic.CompilerServices
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Imports Microsoft.Win32
Imports System.Management
Imports System.Net
'-----------------------------------------------------------
Partial Public Class Giris
    Inherits Form
    Dim dizi As String
    Dim aktvcode As String
    Dim cpuInfo As String
    Public Shared hwid As String = Conversions.ToString(My.Computer.Info.TotalPhysicalMemory) + Conversions.ToString(My.Computer.Info.TotalVirtualMemory)
    Dim kod As New System.Net.WebClient
    '-----------------------------------------------------------
    Public Sub hwid_sorgu()
        '-----------------------------------------------------------
        RichTextBox1.Text = hwid
        Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/5kvqfgj3zbi0d7j/hwid.txt")
        Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Response.GetResponseStream)
        Dim tamam As String = Okuyucu.ReadToEnd
        Dim hiviaydi As String = RichTextBox1.Text
        If tamam.Contains(hiviaydi) Then
            Form2.Show()
        Else
            MsgBox("Lisans Sorunu Kayıt Olun!", MsgBoxStyle.Exclamation, "HATA")
            LisansYeni.Show()
        End If
        '-----------------------------------------------------------
    End Sub
    '-----------------------------------------------------------
    Public Sub CheckForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/juvhamjzlgp6tul/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        '-----------------------------------------------------------
        If newestversion.Contains(currentversion) Then
            ProgramKontrol()
        Else
            MsgBox("Yeni Güncelleme Var, sizin için indireceğiz...", MsgBoxStyle.Information, "Bilgilendirme!")
            WebBrowser1.Navigate("https://dl.dropbox.com/s/bgqb23rjpiqpoke/Panel%20Tarama.rar")
            MsgBox("Lütfen Dosya İndikten Sonra Programı Kapat Tuşuna Tıklayın!", MsgBoxStyle.Exclamation, "DUR!")
            Kapat.Show()
        End If
        '-----------------------------------------------------------
    End Sub
    '-----------------------------------------------------------
    Private Sub Giris_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CheckForUpdates()
    End Sub
    '-----------------------------------------------------------
    Public Sub Hak_Test()
        '-----------------------------------------------------------
        Try
            Dim regKey As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Intell", True)
            '-----------------------------------------------------------
            If regKey Is Nothing Then

                ' MsgBox("Not Found")
                Registry.CurrentUser.CreateSubKey("Software\Intell\Common\Video").SetValue("Balance", 128)
                Registry.CurrentUser.CreateSubKey("Software\Intell\Common\Audio").SetValue("Contrast", 126)
                Registry.CurrentUser.CreateSubKey("Software\Intell\Common\Audio").SetValue("count", 10)
                Registry.CurrentUser.CreateSubKey("Software\Intell\Common\Audio").SetValue("ComSkip", 30)
                Registry.CurrentUser.CreateSubKey("Software\Intell\Common\File").SetValue("break", 0)
                MessageBox.Show("Bu program deneme sürümüdür programı  " & "10" & "  kez kullanabilirsiniz", "Program kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
            Else
                Dim kh As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Intell\Common\File", True).GetValue("break")
                '-----------------------------------------------------------
                If kh = 0 Then
                    Dim al As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Intell\Common\Audio", True).GetValue("count")
                    ' TextBox1.Text = al
                    al = al - 1
                    Registry.CurrentUser.CreateSubKey("Software\Intell\Common\Audio").SetValue("count", al)
                    '-----------------------------------------------------------
                    If al <= 0 Then
                        hwid_sorgu()
                    Else
                        MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Bu program deneme sürümüdür.Kalan kullan" & ChrW(305) & "m hakk" & ChrW(305) & "n" & ChrW(305) & "z   ", al)), "Program kontrol", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Form2.Show()
                    End If
                    '-----------------------------------------------------------
                End If
                '-----------------------------------------------------------
            End If
            '-----------------------------------------------------------
        Catch arg_1E3_0 As Exception
            ProjectData.SetProjectError(arg_1E3_0)
            ProjectData.ClearProjectError()
        End Try
        '-----------------------------------------------------------
    End Sub
    '-----------------------------------------------------------
    Public Sub ProgramKontrol()
        ProgramKontrolAyar()
        '-----------------------------------------------------------
        If ackapa.Text = "kapali" Then
            Me.Hide()
            kapaliyiz.Show()
        Else
            Hak_Test()
        End If
        '-----------------------------------------------------------
        Timer1.Stop()
    End Sub
    '-----------------------------------------------------------
    Public Sub ProgramKontrolAyar()
        '-----------------------------------------------------------
        ackapa.Text = System.Text.Encoding.ASCII.GetString(kod.DownloadData("https://dl.dropbox.com/s/jkckileflhjjrxm/ackapa.txt"))
    End Sub
    '-----------------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgramKontrol()
    End Sub
End Class
