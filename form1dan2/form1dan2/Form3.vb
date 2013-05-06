Public Class Form3
    Public er As Integer
    Dim menit As Integer, detik As Integer, ms As Integer, ur As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ms -= 1
        If ms < 0 Then
            detik -= 1
            If detik < 0 Then
                detik = 59
                menit -= 1
            End If
        End If
        labtime.Text = Format(menit, "00") & ":" & Format(detik, "00")
        If detik = 0 Then
            Timer1.Enabled = False
            Me.Hide()
            Score.Show()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If lev = 1 Then
            Call bukakoneksi()
            menit = 2
            detik = 0
            labtime.Text = "Ready"
            Timer1.Enabled = True


            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Manchester_City")
            DataGridView1.Hide()

            Label3.Text = DataGridView1.Item(0, 0).Value
            Label4.Text = DataGridView1.Item(0, 1).Value
            Label5.Text = DataGridView1.Item(0, 2).Value
            Label6.Text = DataGridView1.Item(0, 3).Value
            Label7.Text = DataGridView1.Item(0, 4).Value
            Label8.Text = DataGridView1.Item(0, 5).Value
            Label9.Text = DataGridView1.Item(0, 6).Value
            Label10.Text = DataGridView1.Item(0, 7).Value
            Label11.Text = DataGridView1.Item(0, 8).Value
            Label1.Text = DataGridView1.Item(0, 9).Value
            Label12.Text = DataGridView1.Item(0, 10).Value

            DataGridView2.DataSource = Koneksi.tampil("SELECT * FROM Juventus")
            DataGridView2.Hide()

            Label2.Text = DataGridView2.Item(0, 0).Value
            Label14.Text = DataGridView2.Item(0, 1).Value
            Label15.Text = DataGridView2.Item(0, 2).Value
            Label16.Text = DataGridView2.Item(0, 3).Value
            Label17.Text = DataGridView2.Item(0, 4).Value
            Label18.Text = DataGridView2.Item(0, 5).Value
            Label19.Text = DataGridView2.Item(0, 6).Value
            Label20.Text = DataGridView2.Item(0, 7).Value
            Label21.Text = DataGridView2.Item(0, 8).Value
            Label22.Text = DataGridView2.Item(0, 9).Value
            Label13.Text = DataGridView2.Item(0, 10).Value

            DataGridView3.DataSource = Koneksi.tampil("SELECT * FROM Borussia_Dortmund")
            DataGridView3.Hide()

            Label23.Text = DataGridView3.Item(0, 0).Value
            Label24.Text = DataGridView3.Item(0, 1).Value
            Label25.Text = DataGridView3.Item(0, 2).Value
            Label26.Text = DataGridView3.Item(0, 3).Value
            Label27.Text = DataGridView3.Item(0, 4).Value
            Label28.Text = DataGridView3.Item(0, 5).Value
            Label29.Text = DataGridView3.Item(0, 6).Value
            Label30.Text = DataGridView3.Item(0, 7).Value
            Label31.Text = DataGridView3.Item(0, 8).Value
            Label32.Text = DataGridView3.Item(0, 9).Value
            Label33.Text = DataGridView3.Item(0, 10).Value
        ElseIf lev = 2 Then
            Call bukakoneksi()
            menit = 1
            detik = 45
            labtime.Text = "Ready"
            Timer1.Enabled = True
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Manchester_United")
            DataGridView1.Hide()

            Label3.Text = DataGridView1.Item(0, 0).Value
            Label4.Text = DataGridView1.Item(0, 1).Value
            Label5.Text = DataGridView1.Item(0, 2).Value
            Label6.Text = DataGridView1.Item(0, 3).Value
            Label7.Text = DataGridView1.Item(0, 4).Value
            Label8.Text = DataGridView1.Item(0, 5).Value
            Label9.Text = DataGridView1.Item(0, 6).Value
            Label10.Text = DataGridView1.Item(0, 7).Value
            Label11.Text = DataGridView1.Item(0, 8).Value
            Label1.Text = DataGridView1.Item(0, 9).Value
            Label12.Text = DataGridView1.Item(0, 10).Value

            DataGridView2.DataSource = Koneksi.tampil("SELECT * FROM Atletico_Madrid")
            DataGridView2.Hide()

            Label2.Text = DataGridView2.Item(0, 0).Value
            Label14.Text = DataGridView2.Item(0, 1).Value
            Label15.Text = DataGridView2.Item(0, 2).Value
            Label16.Text = DataGridView2.Item(0, 3).Value
            Label17.Text = DataGridView2.Item(0, 4).Value
            Label18.Text = DataGridView2.Item(0, 5).Value
            Label19.Text = DataGridView2.Item(0, 6).Value
            Label20.Text = DataGridView2.Item(0, 7).Value
            Label21.Text = DataGridView2.Item(0, 8).Value
            Label22.Text = DataGridView2.Item(0, 9).Value
            Label13.Text = DataGridView2.Item(0, 10).Value

            DataGridView3.DataSource = Koneksi.tampil("SELECT * FROM SC_Freiburg")
            DataGridView3.Hide()

            Label23.Text = DataGridView3.Item(0, 0).Value
            Label24.Text = DataGridView3.Item(0, 1).Value
            Label25.Text = DataGridView3.Item(0, 2).Value
            Label26.Text = DataGridView3.Item(0, 3).Value
            Label27.Text = DataGridView3.Item(0, 4).Value
            Label28.Text = DataGridView3.Item(0, 5).Value
            Label29.Text = DataGridView3.Item(0, 6).Value
            Label30.Text = DataGridView3.Item(0, 7).Value
            Label31.Text = DataGridView3.Item(0, 8).Value
            Label32.Text = DataGridView3.Item(0, 9).Value
            Label33.Text = DataGridView3.Item(0, 10).Value
        ElseIf lev = 3 Then
            Call bukakoneksi()
            menit = 1
            detik = 30
            labtime.Text = "Ready"
            Timer1.Enabled = True
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Arsenal")
            DataGridView1.Hide()

            Label3.Text = DataGridView1.Item(0, 0).Value
            Label4.Text = DataGridView1.Item(0, 1).Value
            Label5.Text = DataGridView1.Item(0, 2).Value
            Label6.Text = DataGridView1.Item(0, 3).Value
            Label7.Text = DataGridView1.Item(0, 4).Value
            Label8.Text = DataGridView1.Item(0, 5).Value
            Label9.Text = DataGridView1.Item(0, 6).Value
            Label10.Text = DataGridView1.Item(0, 7).Value
            Label11.Text = DataGridView1.Item(0, 8).Value
            Label1.Text = DataGridView1.Item(0, 9).Value
            Label12.Text = DataGridView1.Item(0, 10).Value

            DataGridView2.DataSource = Koneksi.tampil("SELECT * FROM Fiorentina")
            DataGridView2.Hide()

            Label2.Text = DataGridView2.Item(0, 0).Value
            Label14.Text = DataGridView2.Item(0, 1).Value
            Label15.Text = DataGridView2.Item(0, 2).Value
            Label16.Text = DataGridView2.Item(0, 3).Value
            Label17.Text = DataGridView2.Item(0, 4).Value
            Label18.Text = DataGridView2.Item(0, 5).Value
            Label19.Text = DataGridView2.Item(0, 6).Value
            Label20.Text = DataGridView2.Item(0, 7).Value
            Label21.Text = DataGridView2.Item(0, 8).Value
            Label22.Text = DataGridView2.Item(0, 9).Value
            Label13.Text = DataGridView2.Item(0, 10).Value

            DataGridView3.DataSource = Koneksi.tampil("SELECT * FROM Valencia")
            DataGridView3.Hide()

            Label23.Text = DataGridView3.Item(0, 0).Value
            Label24.Text = DataGridView3.Item(0, 1).Value
            Label25.Text = DataGridView3.Item(0, 2).Value
            Label26.Text = DataGridView3.Item(0, 3).Value
            Label27.Text = DataGridView3.Item(0, 4).Value
            Label28.Text = DataGridView3.Item(0, 5).Value
            Label29.Text = DataGridView3.Item(0, 6).Value
            Label30.Text = DataGridView3.Item(0, 7).Value
            Label31.Text = DataGridView3.Item(0, 8).Value
            Label32.Text = DataGridView3.Item(0, 9).Value
            Label33.Text = DataGridView3.Item(0, 10).Value
        ElseIf lev = 4 Then
            Call bukakoneksi()
            menit = 1
            detik = 15
            labtime.Text = "Ready"
            Timer1.Enabled = True
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Tottenham")
            DataGridView1.Hide()

            Label3.Text = DataGridView1.Item(0, 0).Value
            Label4.Text = DataGridView1.Item(0, 1).Value
            Label5.Text = DataGridView1.Item(0, 2).Value
            Label6.Text = DataGridView1.Item(0, 3).Value
            Label7.Text = DataGridView1.Item(0, 4).Value
            Label8.Text = DataGridView1.Item(0, 5).Value
            Label9.Text = DataGridView1.Item(0, 6).Value
            Label10.Text = DataGridView1.Item(0, 7).Value
            Label11.Text = DataGridView1.Item(0, 8).Value
            Label1.Text = DataGridView1.Item(0, 9).Value
            Label12.Text = DataGridView1.Item(0, 10).Value

            DataGridView2.DataSource = Koneksi.tampil("SELECT * FROM Real_Madrid")
            DataGridView2.Hide()

            Label2.Text = DataGridView2.Item(0, 0).Value
            Label14.Text = DataGridView2.Item(0, 1).Value
            Label15.Text = DataGridView2.Item(0, 2).Value
            Label16.Text = DataGridView2.Item(0, 3).Value
            Label17.Text = DataGridView2.Item(0, 4).Value
            Label18.Text = DataGridView2.Item(0, 5).Value
            Label19.Text = DataGridView2.Item(0, 6).Value
            Label20.Text = DataGridView2.Item(0, 7).Value
            Label21.Text = DataGridView2.Item(0, 8).Value
            Label22.Text = DataGridView2.Item(0, 9).Value
            Label13.Text = DataGridView2.Item(0, 10).Value

            DataGridView3.DataSource = Koneksi.tampil("SELECT * FROM AC_Milan")
            DataGridView3.Hide()

            Label23.Text = DataGridView3.Item(0, 0).Value
            Label24.Text = DataGridView3.Item(0, 1).Value
            Label25.Text = DataGridView3.Item(0, 2).Value
            Label26.Text = DataGridView3.Item(0, 3).Value
            Label27.Text = DataGridView3.Item(0, 4).Value
            Label28.Text = DataGridView3.Item(0, 5).Value
            Label29.Text = DataGridView3.Item(0, 6).Value
            Label30.Text = DataGridView3.Item(0, 7).Value
            Label31.Text = DataGridView3.Item(0, 8).Value
            Label32.Text = DataGridView3.Item(0, 9).Value
            Label33.Text = DataGridView3.Item(0, 10).Value
        ElseIf lev = 5 Then
            Call bukakoneksi()
            menit = 1
            detik = 0
            labtime.Text = "Ready"
            Timer1.Enabled = True
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Chelsea")
            DataGridView1.Hide()

            Label3.Text = DataGridView1.Item(0, 0).Value
            Label4.Text = DataGridView1.Item(0, 1).Value
            Label5.Text = DataGridView1.Item(0, 2).Value
            Label6.Text = DataGridView1.Item(0, 3).Value
            Label7.Text = DataGridView1.Item(0, 4).Value
            Label8.Text = DataGridView1.Item(0, 5).Value
            Label9.Text = DataGridView1.Item(0, 6).Value
            Label10.Text = DataGridView1.Item(0, 7).Value
            Label11.Text = DataGridView1.Item(0, 8).Value
            Label1.Text = DataGridView1.Item(0, 9).Value
            Label12.Text = DataGridView1.Item(0, 10).Value

            DataGridView2.DataSource = Koneksi.tampil("SELECT * FROM Bayern_Munich")
            DataGridView2.Hide()

            Label2.Text = DataGridView2.Item(0, 0).Value
            Label14.Text = DataGridView2.Item(0, 1).Value
            Label15.Text = DataGridView2.Item(0, 2).Value
            Label16.Text = DataGridView2.Item(0, 3).Value
            Label17.Text = DataGridView2.Item(0, 4).Value
            Label18.Text = DataGridView2.Item(0, 5).Value
            Label19.Text = DataGridView2.Item(0, 6).Value
            Label20.Text = DataGridView2.Item(0, 7).Value
            Label21.Text = DataGridView2.Item(0, 8).Value
            Label22.Text = DataGridView2.Item(0, 9).Value
            Label13.Text = DataGridView2.Item(0, 10).Value

            DataGridView3.DataSource = Koneksi.tampil("SELECT * FROM Real_Sociedad")
            DataGridView3.Hide()

            Label23.Text = DataGridView3.Item(0, 0).Value
            Label24.Text = DataGridView3.Item(0, 1).Value
            Label25.Text = DataGridView3.Item(0, 2).Value
            Label26.Text = DataGridView3.Item(0, 3).Value
            Label27.Text = DataGridView3.Item(0, 4).Value
            Label28.Text = DataGridView3.Item(0, 5).Value
            Label29.Text = DataGridView3.Item(0, 6).Value
            Label30.Text = DataGridView3.Item(0, 7).Value
            Label31.Text = DataGridView3.Item(0, 8).Value
            Label32.Text = DataGridView3.Item(0, 9).Value
            Label33.Text = DataGridView3.Item(0, 10).Value

        End If


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If Label3.Text = DataGridView1.Item(0, 0).Value Then
            Label3.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If Label8.Text = DataGridView1.Item(0, 5).Value Then
            Label8.Hide()
            er += 1
            Label35.Text += 5
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Label7.Text = DataGridView1.Item(0, 4).Value Then
            Label7.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If Label9.Text = DataGridView1.Item(0, 6).Value Then
            Label9.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = DataGridView1.Item(0, 3).Value Then
            Label6.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        If Label10.Text = DataGridView1.Item(0, 7).Value Then
            Label10.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        If Label12.Text = DataGridView1.Item(0, 10).Value Then
            Label12.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label4.Text = DataGridView1.Item(0, 1).Value Then
            Label4.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        If Label11.Text = DataGridView1.Item(0, 8).Value Then
            Label11.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Label1.Text = DataGridView1.Item(0, 9).Value Then
            Label1.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Label5.Text = DataGridView1.Item(0, 2).Value Then
            Label5.Hide()
            Label35.Text += 5
            er += 1
        End If
    End Sub
End Class