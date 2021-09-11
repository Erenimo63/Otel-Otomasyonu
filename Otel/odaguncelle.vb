Imports System.Data.SQLite
Public Class odaguncelle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Sub odaguncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from oda", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    Do While oku.Read()
                        combonumara.Items.Add(oku("oda_numarasi"))
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub combonumara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combonumara.SelectedIndexChanged
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from oda where oda_numarasi='{ combonumara.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "oda")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "oda"
                    DataGridView1.Columns(0).HeaderText = "Oda Numarası"
                    DataGridView1.Columns(1).HeaderText = "Kat Numarası"
                    DataGridView1.Columns(2).HeaderText = "Oda Boyutu"
                    DataGridView1.Columns(3).HeaderText = "Oda Tipi"
                    DataGridView1.Columns(4).HeaderText = "Durum"
                    DataGridView1.Columns(5).HeaderText = "Doluluk"
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtnumara.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtkat.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtboyut.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        combotip.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using guncelle As New SQLiteCommand($"update oda set oda_numarasi='{txtnumara.Text}',kat_numarasi='{txtkat.Text}',oda_boyutu='{txtboyut.Text}',oda_tipi='{combotip.Text}' where oda_numarasi ='{combonumara.Text}'", baglanti)
                Try
                    baglanti.Open()
                    guncelle.ExecuteNonQuery()
                    MessageBox.Show("Bilgiler Güncellendi")
                Catch hata As Exception
                    MessageBox.Show("Hata :" + hata.Message)
                Finally
                    baglanti.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using sil As New SQLiteCommand($"delete from oda where oda_numarasi ='{combonumara.Text}'", baglanti)
                Try
                    baglanti.Open()
                    sil.ExecuteNonQuery()
                    MessageBox.Show("Oda Silindi")
                Catch hata As Exception
                    MessageBox.Show("Hata :" + hata.Message)
                Finally
                    baglanti.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using guncelle As New SQLiteCommand($"update oda set durum='{"Temiz"}' where oda_numarasi ='{combonumara.Text}'", baglanti)
                Try
                    baglanti.Open()
                    guncelle.ExecuteNonQuery()
                    MessageBox.Show("Oda Temizlendi")
                Catch hata As Exception
                    MessageBox.Show("Hata :" + hata.Message)
                Finally
                    baglanti.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using guncelle As New SQLiteCommand($"update oda set durum='{"Arızalı"}' where oda_numarasi ='{combonumara.Text}'", baglanti)
                Try
                    baglanti.Open()
                    guncelle.ExecuteNonQuery()
                    MessageBox.Show("Arıza Bildirildi")
                Catch hata As Exception
                    MessageBox.Show("Hata :" + hata.Message)
                Finally
                    baglanti.Close()
                End Try
            End Using
        End Using
    End Sub
End Class