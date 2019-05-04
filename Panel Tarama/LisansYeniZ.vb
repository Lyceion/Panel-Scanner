Imports Microsoft.VisualBasic.CompilerServices

Public Class LisansYeniZ
    Public Shared hwid As String = Conversions.ToString(My.Computer.Info.TotalPhysicalMemory) + Conversions.ToString(My.Computer.Info.TotalVirtualMemory)
    Dim kod As New System.Net.WebClient

    Private Sub LisansYeniZ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hiviaydi.Text = hwid
    End Sub

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        Try
            Dim client As New Net.WebClient
            client.Credentials = New Net.NetworkCredential("u994935175", "candestan123")
            client.UploadString("ftp://cylpic.pe.hu/licenseler.txt", "Lisansı: " & HuraTextBox1.Text & "-" & HuraTextBox2.Text & "-" & HuraTextBox3.Text & "-" & HuraTextBox4.Text & "  HWID:" & hiviaydi.Text + vbNewLine)
            MsgBox("You License Has Been Sended. Wait For Accept by Admin...")
            End
        Catch ex As Exception
            MsgBox("Server Error! Please Try After...")
            End
        End Try

    End Sub
End Class