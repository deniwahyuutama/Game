Public Class Profil

    Private Sub Profil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call bukakoneksi()
        DataGridView1.DataSource = Koneksi.tampil("select * from Nama")
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                rename = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                newPlayer.TextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                newPlayer.Text = "Rename"
                newPlayer.Show()
            End If
        Catch ex As Exception
            MsgBox("data kosong", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                Koneksi.hapus("delete from nama where nama = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value + "'")
                DataGridView1.DataSource = Koneksi.tampil("select * from nama")
            End If
        Catch ex As Exception
            MsgBox("data belum dipilih", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                If DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 1 Then
                    lev = 1
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 2 Then
                    lev = 2
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 3 Then
                    lev = 3
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 4 Then
                    lev = 4
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                ElseIf DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = 5 Then
                    lev = 5
                    nm = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                End If
                leve = lev
                Form2.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("data kosong", MsgBoxStyle.Information)
        End Try
    End Sub
End Class