﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.umur_kasir = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.tempat_lahir = New System.Windows.Forms.TextBox()
        Me.no_hp = New System.Windows.Forms.TextBox()
        Me.nama_kasir = New System.Windows.Forms.TextBox()
        Me.id_kasir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(603, 374)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 34)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(517, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 31)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(22, 443)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersWidth = 51
        Me.DGV2.Size = New System.Drawing.Size(658, 98)
        Me.DGV2.TabIndex = 43
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(428, 328)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(73, 31)
        Me.btn_simpan.TabIndex = 42
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(603, 330)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(73, 31)
        Me.btn_delete.TabIndex = 41
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_input)
        Me.GroupBox1.Controls.Add(Me.umur_kasir)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.agama)
        Me.GroupBox1.Controls.Add(Me.jenis_kelamin)
        Me.GroupBox1.Controls.Add(Me.tempat_lahir)
        Me.GroupBox1.Controls.Add(Me.no_hp)
        Me.GroupBox1.Controls.Add(Me.nama_kasir)
        Me.GroupBox1.Controls.Add(Me.id_kasir)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 384)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Kasir"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(265, 109)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 28)
        Me.btn_edit.TabIndex = 34
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(265, 68)
        Me.btn_input.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 24)
        Me.btn_input.TabIndex = 35
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'umur_kasir
        '
        Me.umur_kasir.Location = New System.Drawing.Point(103, 135)
        Me.umur_kasir.Name = "umur_kasir"
        Me.umur_kasir.Size = New System.Drawing.Size(141, 20)
        Me.umur_kasir.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Umur :"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Karyawan Tetap", "Karyawan Kontrak"})
        Me.status.Location = New System.Drawing.Point(104, 350)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(141, 21)
        Me.status.TabIndex = 17
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(104, 250)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(184, 94)
        Me.alamat.TabIndex = 16
        Me.alamat.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"Islam", "Budha", "Hindhu", "Kristen"})
        Me.agama.Location = New System.Drawing.Point(104, 163)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(141, 21)
        Me.agama.TabIndex = 14
        '
        'jenis_kelamin
        '
        Me.jenis_kelamin.FormattingEnabled = True
        Me.jenis_kelamin.Items.AddRange(New Object() {"Perempuan", "Laki-Laki"})
        Me.jenis_kelamin.Location = New System.Drawing.Point(104, 190)
        Me.jenis_kelamin.Name = "jenis_kelamin"
        Me.jenis_kelamin.Size = New System.Drawing.Size(141, 21)
        Me.jenis_kelamin.TabIndex = 13
        '
        'tempat_lahir
        '
        Me.tempat_lahir.Location = New System.Drawing.Point(103, 83)
        Me.tempat_lahir.Name = "tempat_lahir"
        Me.tempat_lahir.Size = New System.Drawing.Size(141, 20)
        Me.tempat_lahir.TabIndex = 12
        '
        'no_hp
        '
        Me.no_hp.Location = New System.Drawing.Point(104, 217)
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(141, 20)
        Me.no_hp.TabIndex = 11
        '
        'nama_kasir
        '
        Me.nama_kasir.Location = New System.Drawing.Point(103, 56)
        Me.nama_kasir.Name = "nama_kasir"
        Me.nama_kasir.Size = New System.Drawing.Size(141, 20)
        Me.nama_kasir.TabIndex = 10
        '
        'id_kasir
        '
        Me.id_kasir.Location = New System.Drawing.Point(103, 29)
        Me.id_kasir.Name = "id_kasir"
        Me.id_kasir.Size = New System.Drawing.Size(141, 20)
        Me.id_kasir.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Status :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Alamat :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "No HP :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Agama :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jenis Kelamin :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tanggal Lahir :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tempat Lahir :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Kasir :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Kasir :"
        '
        'OpenFile1
        '
        Me.OpenFile1.FileName = "OpenFileDialog1"
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 563)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents umur_kasir As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents status As ComboBox
    Friend WithEvents alamat As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents agama As ComboBox
    Friend WithEvents jenis_kelamin As ComboBox
    Friend WithEvents tempat_lahir As TextBox
    Friend WithEvents no_hp As TextBox
    Friend WithEvents nama_kasir As TextBox
    Friend WithEvents id_kasir As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFile1 As OpenFileDialog
End Class
