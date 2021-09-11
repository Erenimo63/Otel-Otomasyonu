Imports System.Data.SQLite
Public Class kayit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub kayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using baglanti As New SQLiteConnection("data source = db/Otel.db")

            Using kayit As New SQLiteCommand($"insert into personel(personel_adi,personel_soyadi,personel_kimlik,personel_sifre) values ('{txtisim.Text}','{txtsoyisim.Text}','{txtkimlik.Text}','{txtsifre.Text}')", baglanti)

                Try
                    baglanti.Open()
                    kayit.ExecuteNonQuery()
                    MessageBox.Show("Kayıt Yapıldı")
                Catch hata As Exception
                    MessageBox.Show(" " + hata.Message)
                Finally
                    baglanti.Close()
                End Try

            End Using
        End Using
    End Sub
End Class