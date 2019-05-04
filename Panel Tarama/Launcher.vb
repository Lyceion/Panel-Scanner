Public Class Launcher
    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        End
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        If HuraComboBox1.Text = "Türkçe" Then
            Me.Hide()
            TurkceBaslat()
        Else
            Me.Hide()
            IngilizceBaslat()
        End If
    End Sub
    Private Sub TurkceBaslat()
        Giris.Show()
    End Sub
    Private Sub IngilizceBaslat()
        GiriZ.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("http://UyduMeydani.Com/")
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles Me.Load
        HuraComboBox1.Text = "Türkçe"
    End Sub
End Class