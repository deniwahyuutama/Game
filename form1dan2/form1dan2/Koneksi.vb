Imports System.Data
Imports System.Data.OleDb
Module Koneksi
    Public rename As String
    Public lev As Integer
    Public leve As Integer
    Public nm As String
    Public conn As OleDbConnection = Nothing
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public ds As DataSet
    Public Response As Integer
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\klub.mdb;"

    Public Sub bukakoneksi()
        Try
            conn = New OleDbConnection(connStr)
            conn.Open()
            'MessageBox.Show("connection with : " + conn.DataSource + vbCrLf + "Provider : " + conn.Provider, "Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Disconnected")
        End Try
    End Sub
    Public Function lihat(ByVal sintak As String)
        Console.WriteLine(sintak)
        cmd = New OleDbCommand(sintak, conn)
        Return cmd.ExecuteReader()
    End Function
    Public Function tampil(ByVal sintak As String)
        Console.WriteLine(sintak)
        da = New OleDbDataAdapter(sintak, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data")
        Return ds.Tables("data")
    End Function

    Public Sub tambah(ByVal sintak As String)
        Try
            Dim CMD As OleDbCommand
            Dim reader As OleDbDataReader = Nothing
            CMD = New OleDbCommand(sintak, conn)
            reader = CMD.ExecuteReader()
            'MessageBox.Show("Berhasil Menambah Data", "Succesed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'MessageBox.Show("Gagal Menambah Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub ubah(ByVal sintak As String)
        cmd = New OleDbCommand(sintak, conn)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Berhasil Update Data", "Succesed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Gagal Update Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub hapus(ByVal sintak As String)
        cmd = New OleDbCommand(sintak, conn)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Data Telah Terhapus", "Succesed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Gagal Menghapus Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Module