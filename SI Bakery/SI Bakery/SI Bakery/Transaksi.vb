Public Class Transaksi
    Private Sub TransaksiPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub
    Private Sub txt_Kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KodeMenu.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) itu Tombol ENTER
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Menu where ID_Menu ='" & txt_KodeMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("Kode Menu Tidak Ada")
            Else
                txt_KodeMenu.Text = DM.Item("ID_Menu")
                txtnama.Text = DM.Item("Nama")
                txtharga.Text = DM.Item("Harga")
                txtjumlah.Enabled = True
                txtjumlah.Focus()
            End If
        End If
    End Sub
    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            txtGrandtotal.Text = hitung
            txtsubtotal.Text = hitung
        Next
    End Sub
    Private Sub txttendered_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttendered.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txttendered.Text) < Val(txtGrandtotal.Text) Then
                MsgBox("Uang Pembayaran Kurang")
            ElseIf Val(txttendered.Text) = Val(txtGrandtotal.Text) Then
                txtchange.Text = 0
            ElseIf Val(txttendered.Text) > Val(txtGrandtotal.Text) Then
                txtchange.Text = Val(txttendered.Text) - Val(txtGrandtotal.Text)
                btn_save.Focus()
            End If
        End If
    End Sub
    Sub kosongkanitem()
        txt_KodeMenu.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
    End Sub
    Sub kondisiawal()
        txttgltransaksi.Text = Today
        txtjamtransaksi.Text = TimeOfDay
        txtkasir.Text = Login.txtUN.Text
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtjamtransaksi.Text = TimeOfDay
    End Sub
    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtnama.Text = "" Or txtharga.Text = "" Then
                MsgBox("Masukkan Kode Menu dan tekan enter ")
            Else
                DataGridView1.Rows.Add(New String() {txt_KodeMenu.Text,
             txtnama.Text, txtharga.Text, txtjumlah.Text, Val(txtharga.Text) * Val(txtjumlah.Text)})
                Call RumusGrandTotal()
                Call kosongkanitem()
                txt_KodeMenu.Focus()
                Call carijumlahitem()
            End If
        End If
    End Sub


    Private Sub txtidpelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtidpelanggan.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Pelanggan where ID_Pelanggan ='" & txtidpelanggan.Text & "'", Conn)
            DM = CMD.ExecuteReader

            If DM.HasRows = True Then
                DM.Read()
                txtidpelanggan.Text = DM.Item("ID_Pelanggan")
                txtnamapelanggan.Text = DM.Item("Nama_Pelanggan")
                txtreceipt.Text = DM.Item("receipt")
                txt_KodeMenu.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data pelanggan tidak ada")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call kosongkanitem()
    End Sub
    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub
    Sub Barcode1()
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim Barcode As String
        Barcode = ("C:\Users\ASUS\Pictures\Foto Karyawan\")
        Barcode = Barcode + txtreceipt.Text + ".jpg"
        PictureBox1.Image.Save(Barcode)
        If txtchange.Text = "" Or txtGrandtotal.Text = "" Then
            MsgBox("Data Transaksi Belum Lengkap")
            'Pengecekan , apabila transaksi belum terjadi maka tidak bisa di ENTER
        Else
            Dim Simpantransaksi As String = "Insert into Transaksi values ('" & txtreceipt.Text & "', '" & txtidpelanggan.Text & "',
             '" & txtGrandtotal.Text & "', '" & txttgltransaksi.Text & "', '" & txtjamtransaksi.Text & "', '" & txtkasir.Text & "', 
             '" & txtitems.Text & "','" & txtpajak.Text & "','" & txttendered.Text & "','" & txtchange.Text & "', '" & Barcode & "')"
            CMD = New OleDb.OleDbCommand(Simpantransaksi, Conn)
            CMD.ExecuteNonQuery()
            Call Barcode1()
            'Data disimpan di tabel Penjualan

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim Simpandetail As String = "Insert into Detail_Transaksi values ('" & txtreceipt.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "', '" &
DataGridView1.Rows(baris).Cells(1).Value & "', '" &
DataGridView1.Rows(baris).Cells(2).Value & "', '" & DataGridView1.Rows(baris).Cells(3).Value & "','" & DataGridView1.Rows(baris).Cells(4).Value & "'," & GetRandom(1111, 99999).ToString() & ")"
                CMD = New OleDb.OleDbCommand(Simpandetail, Conn)
                CMD.ExecuteNonQuery()

                CMD = New OleDb.OleDbCommand("select * from Menu where ID_Menu = '" &
            DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                DM = CMD.ExecuteReader
                DM.Read()
                Dim kurangistok As String = "Update Menu set Stok = '" &
            DM.Item("Stok") - DataGridView1.Rows(baris).Cells(3).Value & "' where ID_Menu = '" &
            DataGridView1.Rows(baris).Cells(0).Value & "'"
                CMD = New OleDb.OleDbCommand(kurangistok, Conn)
                CMD.ExecuteNonQuery()
            Next
            MsgBox("Transaksi Telah Tersimpan")
            DataGridView1.Rows.Clear()
            Call kosongkanitem()
            Call kondisiawal()


        End If
    End Sub
    Sub carijumlahitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(3).Value
            txtitems.Text = hitungitem
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Total_Akhir As Integer
        Dim Hitung As Integer
        Total_Akhir = ((0.1) * Val(txtGrandtotal.Text)) + Val(txtGrandtotal.Text)
        txtGrandtotal.Text = Total_Akhir
        Hitung = Val(txtsubtotal.Text) * 0.1
        txtpajak.Text = Hitung
    End Sub

End Class
