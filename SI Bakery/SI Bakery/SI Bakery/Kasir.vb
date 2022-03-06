Imports System.Diagnostics.Eventing.Reader
Public Class Kasir
    Public Property OpenFileDialog1 As Object

    Sub KosongkanForm()
        id_kasir.Text = ""
        nama_kasir.Text = ""
        tempat_lahir.Text = ""
        umur_kasir.Text = ""
        agama.Text = ""
        jenis_kelamin.Text = ""
        no_hp.Text = ""
        alamat.Text = ""
        status.Text = ""
        foto_diri.Text = ""
        id_kasir.Focus()
    End Sub
    Sub MatikanForm()
        id_kasir.Enabled = False
        nama_kasir.Enabled = False
        tempat_lahir.Enabled = False
        DateTimePicker1.Enabled = False
        umur_kasir.Enabled = False
        agama.Enabled = False
        jenis_kelamin.Enabled = False
        no_hp.Enabled = False
        alamat.Enabled = False
        status.Enabled = False
        foto_diri.Enabled = False
    End Sub
    Sub HidupkanForm()
        id_kasir.Enabled = True
        nama_kasir.Enabled = True
        tempat_lahir.Enabled = True
        DateTimePicker1.Enabled = True
        umur_kasir.Enabled = True
        agama.Enabled = True
        jenis_kelamin.Enabled = True
        no_hp.Enabled = True
        alamat.Enabled = True
        status.Enabled = True
        foto_diri.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Kasir", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        DGV2.ReadOnly = True
    End Sub
    Sub Foto1()
        PictureBox1.ImageLocation = ""
    End Sub
    Private Sub Data_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Umur, TL, TS As Integer
        TL = Year(DateTimePicker1.Value)
        TS = Year(Now)
        Umur = TS - TL
        umur_kasir.Text = (Umur & " Tahun ")
    End Sub
    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If id_kasir.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Kasir where id_kasir = '" & id_kasir.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Data Berhasil Dihapus")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If id_kasir.Text = "" Or nama_kasir.Text = "" Or tempat_lahir.Text = "" Or
           agama.Text = "" Or jenis_kelamin.Text = "" Or no_hp.Text = "" Or alamat.Text = "" Or
           status.Text = "" Or foto_diri.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Kasir set nama_kasir = '" & nama_kasir.Text & "', tempat_lahir = '" & tempat_lahir.Text & "',
           agama = '" & agama.Text & "',jenis_kelamin = '" & jenis_kelamin.Text & "',  no_hp = '" &
           no_hp.Text & "', alamat = '" & alamat.Text & "', status = '" & status.Text & "', foto_diri = '" &
           foto_diri.Text & "'Where id_kasir = '" & id_kasir.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If id_kasir.Text = "" Or nama_kasir.Text = "" Or tempat_lahir.Text = "" Or
            agama.Text = "" Or jenis_kelamin.Text = "" Or no_hp.Text = "" Or alamat.Text = "" Or status.Text = "" Or foto_diri.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Kasir where id_kasir ='" & id_kasir.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Kasir values ('" & id_kasir.Text & "', '" & nama_kasir.Text & "', '" & tempat_lahir.Text & "','" & DateTimePicker1.Value & "','" & umur_kasir.Text & "','" & agama.Text & "','" & jenis_kelamin.Text & "','" & no_hp.Text & "','" & alamat.Text & "', '" & status.Text & "','" & foto_diri.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
                Call Foto1()
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub
    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        On Error Resume Next
        id_kasir.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
        nama_kasir.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
        tempat_lahir.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DGV2.Rows(e.RowIndex).Cells(3).Value
        umur_kasir.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
        agama.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        jenis_kelamin.Text = DGV2.Rows(e.RowIndex).Cells(6).Value
        no_hp.Text = DGV2.Rows(e.RowIndex).Cells(7).Value
        alamat.Text = DGV2.Rows(e.RowIndex).Cells(8).Value
        status.Text = DGV2.Rows(e.RowIndex).Cells(9).Value
        Call HidupkanForm()
        id_kasir.Enabled = False
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFile1.Filter = " Image File
(*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif"
        OpenFile1.RestoreDirectory = True
        OpenFile1.ShowDialog()
        If OpenFile1.FileName = "" Then Exit Sub
        PictureBox1.ImageLocation = OpenFile1.FileName
        foto_diri.Text = OpenFile1.FileName
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
    Private Sub id_kasir_TextChanged(sender As Object, e As EventArgs) Handles id_kasir.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Kasir where id_kasir ='" & id_kasir.Text & "'", Conn)
            DM = CMD.ExecuteReader
            'DM.Read()
            If DM.HasRows = True Then
                DM.Read()
                'Dim row As DataRow
                'row = DS.Tables(0).Rows.Find(pegawai)
                id_kasir.Text = DM.Item("id_kasir")
                nama_kasir.Text = DM.Item("nama_kasir")
                tempat_lahir.Text = DM.Item("tempat_lahir")
                DateTimePicker1.Text = DM.Item("tanggal_lahir")
                umur_kasir.Text = DM.Item("umur")
                agama.Text = DM.Item("agama")
                no_hp.Text = DM.Item("no_hp")
                alamat.Text = DM.Item("alamat")
                status.Text = DM.Item("status")
                foto_diri.Text = DM.Item("foto_diri")
                Dim nas As String
                nas = foto_diri.Text
                'PictureBox1.ImageLocation = Replace((DM("Photo")), ";", "\")
                PictureBox1.Image = New Bitmap(nas)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class