<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpajak = New System.Windows.Forms.TextBox()
        Me.Pajak = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txttendered = New System.Windows.Forms.TextBox()
        Me.txtitems = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txt_KodeMenu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtreceipt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGrandtotal = New System.Windows.Forms.TextBox()
        Me.txtkasir = New System.Windows.Forms.TextBox()
        Me.txtjamtransaksi = New System.Windows.Forms.TextBox()
        Me.txttgltransaksi = New System.Windows.Forms.TextBox()
        Me.txtidpelanggan = New System.Windows.Forms.TextBox()
        Me.txtmachine = New System.Windows.Forms.TextBox()
        Me.txtidkasir = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(432, 474)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(114, 20)
        Me.txtsubtotal.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(335, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Sub Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpajak
        '
        Me.txtpajak.Location = New System.Drawing.Point(702, 429)
        Me.txtpajak.Name = "txtpajak"
        Me.txtpajak.Size = New System.Drawing.Size(138, 20)
        Me.txtpajak.TabIndex = 34
        '
        'Pajak
        '
        Me.Pajak.AutoSize = True
        Me.Pajak.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pajak.Location = New System.Drawing.Point(596, 433)
        Me.Pajak.Name = "Pajak"
        Me.Pajak.Size = New System.Drawing.Size(58, 19)
        Me.Pajak.TabIndex = 33
        Me.Pajak.Text = "Pajak"
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(596, 488)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(78, 19)
        Me.Change.TabIndex = 32
        Me.Change.Text = "Kembali"
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(703, 490)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(137, 20)
        Me.txtchange.TabIndex = 30
        '
        'txttendered
        '
        Me.txttendered.Location = New System.Drawing.Point(702, 460)
        Me.txttendered.Name = "txttendered"
        Me.txttendered.Size = New System.Drawing.Size(138, 20)
        Me.txttendered.TabIndex = 27
        '
        'txtitems
        '
        Me.txtitems.Location = New System.Drawing.Point(432, 435)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(114, 20)
        Me.txtitems.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(337, 436)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Items"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(597, 458)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 19)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Tendered"
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(149, 474)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(75, 33)
        Me.btn_tutup.TabIndex = 31
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(41, 476)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(149, 431)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 33)
        Me.btn_save.TabIndex = 22
        Me.btn_save.Text = "Simpan"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(807, 118)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Pembelian"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(772, 81)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Menu"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Menu"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Harga"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah "
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtjumlah)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.txt_KodeMenu)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 60)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Pembelian"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(715, 27)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(69, 20)
        Me.txtjumlah.TabIndex = 12
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(512, 24)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(114, 20)
        Me.txtharga.TabIndex = 11
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(308, 24)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(128, 20)
        Me.txtnama.TabIndex = 10
        '
        'txt_KodeMenu
        '
        Me.txt_KodeMenu.Location = New System.Drawing.Point(136, 26)
        Me.txt_KodeMenu.Name = "txt_KodeMenu"
        Me.txt_KodeMenu.Size = New System.Drawing.Size(107, 20)
        Me.txt_KodeMenu.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(632, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Jumlah "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(442, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Harga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(249, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kode Menu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtreceipt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtnamapelanggan)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtGrandtotal)
        Me.GroupBox1.Controls.Add(Me.txtkasir)
        Me.GroupBox1.Controls.Add(Me.txtjamtransaksi)
        Me.GroupBox1.Controls.Add(Me.txttgltransaksi)
        Me.GroupBox1.Controls.Add(Me.txtidpelanggan)
        Me.GroupBox1.Controls.Add(Me.txtmachine)
        Me.GroupBox1.Controls.Add(Me.txtidkasir)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 221)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'txtreceipt
        '
        Me.txtreceipt.Location = New System.Drawing.Point(119, 160)
        Me.txtreceipt.Name = "txtreceipt"
        Me.txtreceipt.Size = New System.Drawing.Size(151, 20)
        Me.txtreceipt.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Receipt"
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.Location = New System.Drawing.Point(119, 125)
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(151, 20)
        Me.txtnamapelanggan.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Nama Pelanggan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(332, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 79)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtGrandtotal
        '
        Me.txtGrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandtotal.Location = New System.Drawing.Point(529, 15)
        Me.txtGrandtotal.Name = "txtGrandtotal"
        Me.txtGrandtotal.Size = New System.Drawing.Size(255, 47)
        Me.txtGrandtotal.TabIndex = 15
        '
        'txtkasir
        '
        Me.txtkasir.Location = New System.Drawing.Point(633, 128)
        Me.txtkasir.Name = "txtkasir"
        Me.txtkasir.Size = New System.Drawing.Size(151, 20)
        Me.txtkasir.TabIndex = 14
        '
        'txtjamtransaksi
        '
        Me.txtjamtransaksi.Location = New System.Drawing.Point(633, 102)
        Me.txtjamtransaksi.Name = "txtjamtransaksi"
        Me.txtjamtransaksi.Size = New System.Drawing.Size(151, 20)
        Me.txtjamtransaksi.TabIndex = 13
        '
        'txttgltransaksi
        '
        Me.txttgltransaksi.Location = New System.Drawing.Point(633, 72)
        Me.txttgltransaksi.Name = "txttgltransaksi"
        Me.txttgltransaksi.Size = New System.Drawing.Size(151, 20)
        Me.txttgltransaksi.TabIndex = 12
        '
        'txtidpelanggan
        '
        Me.txtidpelanggan.Location = New System.Drawing.Point(119, 90)
        Me.txtidpelanggan.Name = "txtidpelanggan"
        Me.txtidpelanggan.Size = New System.Drawing.Size(151, 20)
        Me.txtidpelanggan.TabIndex = 11
        '
        'txtmachine
        '
        Me.txtmachine.Location = New System.Drawing.Point(119, 57)
        Me.txtmachine.Name = "txtmachine"
        Me.txtmachine.Size = New System.Drawing.Size(151, 20)
        Me.txtmachine.TabIndex = 10
        '
        'txtidkasir
        '
        Me.txtidkasir.Location = New System.Drawing.Point(119, 25)
        Me.txtidkasir.Name = "txtidkasir"
        Me.txtidkasir.Size = New System.Drawing.Size(151, 20)
        Me.txtidkasir.TabIndex = 8
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(347, 25)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(169, 23)
        Me.Total.TabIndex = 7
        Me.Total.Text = "Total Harga Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(567, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kasir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(567, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(563, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Machine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID kasir"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 515)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpajak)
        Me.Controls.Add(Me.Pajak)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.txttendered)
        Me.Controls.Add(Me.txtitems)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtpajak As TextBox
    Friend WithEvents Pajak As Label
    Friend WithEvents Change As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents txttendered As TextBox
    Friend WithEvents txtitems As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txt_KodeMenu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtGrandtotal As TextBox
    Friend WithEvents txtkasir As TextBox
    Friend WithEvents txtjamtransaksi As TextBox
    Friend WithEvents txttgltransaksi As TextBox
    Friend WithEvents txtidpelanggan As TextBox
    Friend WithEvents txtmachine As TextBox
    Friend WithEvents txtidkasir As TextBox
    Friend WithEvents Total As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnamapelanggan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtreceipt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Timer1 As Timer
End Class
