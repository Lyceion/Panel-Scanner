Public Class kapaliyiz
    Dim kod As New System.Net.WebClient

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Giris.Hide()
        RichTextBox1.Text = System.Text.Encoding.ASCII.GetString(kod.DownloadData("https://dl.dropbox.com/s/0mtjie9sfyxo0dw/girisduyuru.txt"))
    End Sub

    Private Sub kapaliyiz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer2.Start()
        RichTextBox1.Text = System.Text.Encoding.ASCII.GetString(kod.DownloadData("https://dl.dropbox.com/s/0mtjie9sfyxo0dw/girisduyuru.txt"))
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Giris.Hide()
        Timer2.Stop()
    End Sub
End Class