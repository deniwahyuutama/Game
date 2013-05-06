Public Class newPlayer

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Text = "Rename" Then
            Koneksi.tambah("update nama set nama = '" + TextBox1.Text + "' where nama = '" + rename + "'")
            MsgBox("Data telah diubah", MsgBoxStyle.Information)
        End If
        Profil.DataGridView1.DataSource = Koneksi.tampil("select * from nama")
        Me.Close()
    End Sub

    Private Sub newPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class