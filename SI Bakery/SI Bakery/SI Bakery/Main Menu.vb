Public Class Main_Menu
    Private Sub DataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKasirToolStripMenuItem.Click
        Kasir.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Transaksi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        Data_Menu.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Data_Pelanggan.Show()
    End Sub
End Class