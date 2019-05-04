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
Public Class Lisans

    Public Sub lisanskontrol()

    End Sub
    Private Sub lisans_Load_1(ByVal sender As Object, ByVal e As EventArgs)
        lisanskontrol()
        labelX4.Text = Conversions.ToString(My.Computer.Info.TotalPhysicalMemory) + Conversions.ToString(My.Computer.Info.TotalVirtualMemory)
        labelX5.Text = Environment.MachineName
        labelX6.Text = System.Environment.UserName

    End Sub


    Private Sub buttonX1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Application.[Exit]()
    End Sub

    Private Sub buttonX2_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        If (textBoxX1.Text) <> String.Empty Then
            Try
                Dim w As New System.Net.WebClient()
                Dim reqparm As New System.Collections.Specialized.NameValueCollection()
                reqparm.Add("ekle", ".")
                reqparm.Add("gonderen", (labelX5.Text + "&" + labelX6.Text))
                reqparm.Add("hwid", labelX4.Text)
                reqparm.Add("mesaj", textBoxX1.Text)
                Dim b As Byte() = w.UploadValues("http://panel.crackingstar.org/weareyoung/include/include/hwid.php", "POST", reqparm)
                Dim s As String = System.Text.Encoding.UTF8.GetString(b)
                MessageBox.Show(s, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz!")
            End Try
        Else
            MessageBox.Show("Lütfen Geçerli Bir Mesaj Bırakınız! Yöneticinin Onayından Geçecektir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub symbolBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Clipboard.SetText(labelX4.Text)
        MessageBox.Show("Hwid Kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lisans_FormClosing_1(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Application.[Exit]()
    End Sub

    Private Sub buttonX3_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        If textBoxX2.Text <> String.Empty OrElse textBoxX3.Text <> String.Empty Then
            Dim w As New System.Net.WebClient()
            Dim post_sorgu As New System.Collections.Specialized.NameValueCollection()
            post_sorgu.Add("ekle", ".")
            post_sorgu.Add("gonderen", (labelX5.Text + "&" + labelX6.Text))
            post_sorgu.Add("mail", textBoxX2.Text)
            post_sorgu.Add("mesaj", textBoxX3.Text)
            Dim b As Byte() = w.UploadValues("http://panel.crackingstar.org/weareyoung/include/iletisim.php", "POST", post_sorgu)
            Dim s As String = System.Text.Encoding.UTF8.GetString(b)
            MessageBox.Show(s, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Lütfen Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub buttonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX2.Click
        If (textBoxX1.Text) <> String.Empty Then
            Try
                Dim w As New System.Net.WebClient()
                Dim reqparm As New System.Collections.Specialized.NameValueCollection()
                reqparm.Add("ekle", ".")
                reqparm.Add("gonderen", (labelX5.Text + "&" + labelX6.Text))
                reqparm.Add("hwid", labelX4.Text)
                reqparm.Add("mesaj", textBoxX1.Text)
                Dim b As Byte() = w.UploadValues("http://panel.crackingstar.org/weareyoung/include/hwid.php", "POST", reqparm)
                Dim s As String = System.Text.Encoding.UTF8.GetString(b)
                MessageBox.Show(s, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz!")
            End Try
        Else
            MessageBox.Show("Lütfen Geçerli Bir Mesaj Bırakınız! Yöneticinin Onayından Geçecektir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        End
    End Sub

    Private Sub buttonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX3.Click
        If textBoxX2.Text <> String.Empty OrElse textBoxX3.Text <> String.Empty Then
            Dim w As New System.Net.WebClient()
            Dim post_sorgu As New System.Collections.Specialized.NameValueCollection()
            post_sorgu.Add("ekle", ".")
            post_sorgu.Add("gonderen", (labelX5.Text + "&" + labelX6.Text))
            post_sorgu.Add("mail", textBoxX2.Text)
            post_sorgu.Add("mesaj", textBoxX3.Text)
            Dim b As Byte() = w.UploadValues("http://panel.crackingstar.org/weareyoung/include/iletisim.php", "POST", post_sorgu)
            Dim s As String = System.Text.Encoding.UTF8.GetString(b)
            MessageBox.Show(s, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Lütfen Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Lisans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lisanskontrol()
        labelX4.Text = Conversions.ToString(My.Computer.Info.TotalPhysicalMemory) + Conversions.ToString(My.Computer.Info.TotalVirtualMemory)
        labelX5.Text = Environment.MachineName
        labelX6.Text = System.Environment.UserName
        Timer1.Start()
        MsgBox("Ücretsiz Kullanım Hakkınız Bitmiştir. Programımızı Denediğiniz İçin Teşekkür Ederiz. Devam Etmek İçin Kayıt Yaptırın...", MsgBoxStyle.Information, "Bilgilendirme...")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Giris.Hide()
    End Sub

    Private Sub tabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Clipboard.SetText(labelX4.Text)
        MsgBox("HWID Kopyalandı!", MsgBoxStyle.Information, "Bilgilendirme...")
    End Sub
End Class