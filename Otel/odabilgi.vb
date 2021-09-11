Imports System.Data.SQLite
Public Class odabilgi
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Sub odabilgi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from oda", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    Do While oku.Read()
                        combonumara.Items.Add(oku("oda_numarasi"))
                    Loop
                End Using
            End Using
            Using getir As New SQLiteCommand($"select * from oda", baglanti)
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
End Class