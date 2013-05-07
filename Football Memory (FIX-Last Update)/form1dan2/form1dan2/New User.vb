Public Class New_User


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call bukakoneksi()

        Koneksi.tambah("INSERT INTO Nama (Nama, Leve1,Score) VALUES ('" + TextBox1.Text + "', '1','0')")
        MsgBox("Data telah ditambahkan", MsgBoxStyle.Information)
      
        Profil.DataGridView1.DataSource = Koneksi.tampil("select * from Nama")
        Liga.Show()
        Me.Hide()
    End Sub
End Class