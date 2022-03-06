Public Class Data_Menu
    Sub KosongkanForm()
        txt_id.Text = ""
        txt_nama.Text = ""
        cmb_jenis.Text = ""
        txt_varian.Text = ""
        txt_harga.Text = ""
        txt_stok.Text = ""
        txt_id.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat , jadi ketika form pertama kali di load kondisi form sudah dalam keadaan kosong
    End Sub

    Sub MatikanForm()
        txt_id.Enabled = False
        txt_nama.Enabled = False
        cmb_jenis.Enabled = False
        txt_varian.Enabled = False
        txt_harga.Enabled = False
        txt_stok.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub

    Sub HidupkanForm()
        txt_id.Enabled = True
        txt_nama.Enabled = True
        cmb_jenis.Enabled = True
        txt_varian.Enabled = True
        txt_harga.Enabled = True
        txt_stok.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub

    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Menu", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita buat pada Data Grid View didalam form 
    End Sub

    Private Sub Form_Data_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
        'Coding diatas bermaksud , ketika form Input Buku di load pertama kali , form langsung dimatikan dan data yang dari Access langsung ditampilkan di Data Grid View
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or cmb_jenis.Text = "" Or txt_varian.Text = "" Or txt_harga.Text = "" Or txt_stok.Text = "" Then
            MsgBox("Data Buku Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data ada yang kosong , atau belum diisi , maka akan tampil pesan bahwa data yang di input belum lengkap
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu where id_menu ='" & txt_id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian id menu (primary key) ada inputan data yang sama , maka ke Else : data sudah ada

            'Jika data inputan tidak sama , maka ke If Not : masukkan inputan dari form ke database Ms.Access
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txt_id.Text & "', '" & txt_nama.Text & "', '" & cmb_jenis.Text & "','" & txt_varian.Text & "','" & txt_harga.Text & "','" & txt_stok.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or cmb_jenis.Text =
"" Or txt_varian.Text = "" Or txt_harga.Text = "" Or txt_stok.Text =
"" Then
            MsgBox("Data Buku Belum Lengkap")
            Exit Sub
            'Coding berfungsi untuk mengecek jika ada field yang belum terisi atau belum lengkap
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu set nama_menu = '" &
            txt_nama.Text & "',jenis_menu ='" & cmb_jenis.Text & "',varian_rasa = '" &
            txt_varian.Text & "',harga = '" & txt_harga.Text & "',jumlah_stok = '" &
            txt_stok.Text & "' where id_menu
='" & txt_id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
            'Coding berfungsi untuk mengedit dan mengupdate data yang dipilih untuk kemudian disimpan lagi di tabel Ms.Access yang sdh dibuat
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txt_id.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
            'Coding berfungsi untuk mengecek , jika tidak ada data yang dipilih untuk dihapus , maka akan tampil pesan diatas 
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = System.Windows.Forms.DialogResult.Yes Then
                'Coding berfungsi untuk memberi konfirmasi ke user , apakah yakin untuk mendelete data 
                'Jika yakin , maka akan berjalan coding dibawah ini untuk mendelete data yang dipilih 
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Menu where id_menu ='" & txt_id.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txt_id.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        cmb_jenis.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_varian.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txt_harga.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txt_stok.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kita arahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan eterusnya
        Call HidupkanForm()
        txt_id.Enabled = False 'Ketika mengedit , kita tidak bisa mengedit kode buku nya , kita hanya bisa mengedit di field2 lainnya
    End Sub
End Class