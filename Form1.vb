Public Class Form1
    Private Sub tbNama_TextChanged(sender As Object, e As EventArgs) Handles tbNama.TextChanged

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nama(0) As String
        nama(0) = tbNama.Text

        Dim list As New ListViewItem
        list = LVNama.Items.Add(nama(0))
        tbNama.Text = ""
        tbNama.Focus()
    End Sub

    Private Sub LVNama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LVNama.View = View.Details
        LVNama.GridLines = True
        LVNama.Columns.Add("Nama", 120)
    End Sub
End Class
