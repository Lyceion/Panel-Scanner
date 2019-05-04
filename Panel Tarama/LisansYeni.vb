Imports Microsoft.VisualBasic.CompilerServices
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.WebRequestMethods.Http
Imports System.IO
Imports System.Management
Imports System.Net
Imports Microsoft.Win32
Public Class LisansYeni
    Public Shared hwid As String = Conversions.ToString(My.Computer.Info.TotalPhysicalMemory) + Conversions.ToString(My.Computer.Info.TotalVirtualMemory)
    Dim kod As New System.Net.WebClient

    Private Sub LisansYeni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hiviaydi.Text = hwid
    End Sub

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        Try
            Dim client As New Net.WebClient
            client.Credentials = New Net.NetworkCredential("u994935175", "candestan123")
            client.UploadString("ftp://cylpic.pe.hu/licenseler.txt", "Lisansı: " & HuraTextBox1.Text & "-" & HuraTextBox2.Text & "-" & HuraTextBox3.Text & "-" & HuraTextBox4.Text & "  HWID:" & hiviaydi.Text + vbNewLine)
            MsgBox("Lisansınız Gönderildi! Lütfen Yönetici Onayı Bekleyiniz...")
            End
        Catch ex As Exception
            MsgBox("Sunucu Hatası Lütfen Daha Sonra Tekrar Deneyiniz!")
            End
        End Try

    End Sub
End Class