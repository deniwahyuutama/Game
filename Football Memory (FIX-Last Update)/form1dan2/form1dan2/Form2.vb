Public Class Form2

    Dim menit As Integer, detik As Integer, ms As Integer, ur As Integer = 0
    'timer countdown
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ms -= 1
        If ms < 0 Then
            detik -= 1
            If detik < 0 Then
                detik = 30
            End If

        End If
        labtime.Text = Format(menit, "00") & ":" & Format(detik, "00")
        If detik = 0 Then
            Timer1.Enabled = False
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
    'waktu sesuai jam real
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If lev = 1 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Manchester_City")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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

        ElseIf lev = 2 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Manchester_United")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        ElseIf lev = 3 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Arsenal")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        ElseIf lev = 4 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Tottenham")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        ElseIf lev = 5 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Chelsea")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        ElseIf lev = 6 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Bayer_Leverkusen")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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

        ElseIf lev = 11 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Barcelona")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        ElseIf lev = 16 Then
            Call bukakoneksi()
            labcutime.Text = TimeOfDay
            DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Juventus")
            DataGridView1.Hide()
            menit = 0
            detik = 0
            'ms = 10
            labtime.Text = "READY"
            Timer1.Enabled = True
            ur = 0

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
        End If
    End Sub
End Class