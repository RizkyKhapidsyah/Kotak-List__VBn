Public Class Form1

    Private Sub tombolOK_Click(sender As Object, e As EventArgs) Handles tombolOK.Click
        Dim strMasukan As String 'memuat bulan dan tahun terseleksi

        If listBulan.SelectedIndex = -1 Then
            'tidak ada bulan diseleksi
            MessageBox.Show("Pilihlah bulan.")
        ElseIf listTahun.SelectedIndex = -1 Then
            'tidak ada tahun diseleksi
            MessageBox.Show("Pilihlah tahun.")
        Else
            'membaca tahun dan bulan terseleksi
            strMasukan = listBulan.SelectedItem.ToString() &
            " " & listTahun.SelectedItem.ToString()
            MessageBox.Show("Anda memilih " & strMasukan)
        End If
    End Sub

    Private Sub tombolReset_Click(sender As Object, e As EventArgs) Handles tombolReset.Click
        'mengatur ulang kotak-kotak list untuk membatalkan seleksi
        listBulan.SelectedIndex = -1
        listTahun.SelectedIndex = -1
    End Sub
End Class
