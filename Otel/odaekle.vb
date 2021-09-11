Imports System.Data.SQLite
Public Class odaekle
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Sub odaekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            If radiotemiz.Checked = True Then
                Using kayit As New SQLiteCommand($"insert into oda(oda_numarasi,kat_numarasi,oda_boyutu,oda_tipi,durum,doluluk) values('{txtodanumara.Text}','{txtkatnumara.Text}','{txtodaboyutu.Text}','{comboodatipi.Text}','{"Temiz"}','{"Boş"}')", baglanti)
                    Try
                        baglanti.Open()
                        kayit.ExecuteNonQuery()
                        MessageBox.Show("Kayıt Yapıldı")
                    Catch hata As Exception
                        MessageBox.Show("Hata : " + hata.Message)
                    Finally
                        baglanti.Close()
                    End Try
                End Using
            End If
            If radioariza.Checked = True Then
                Using kayit As New SQLiteCommand($"insert into oda(oda_numarasi,kat_numarasi,oda_boyutu,oda_tipi,durum,doluluk) values('{txtodanumara.Text}','{txtkatnumara.Text}','{txtodaboyutu.Text}','{comboodatipi.Text}','{"Arızalı"}','{"Boş"}')", baglanti)
                    Try
                        baglanti.Open()
                        kayit.ExecuteNonQuery()
                        MessageBox.Show("Kayıt Yapıldı")
                    Catch hata As Exception
                        MessageBox.Show("Hata : " + hata.Message)
                    Finally
                        baglanti.Close()
                    End Try
                End Using
            End If
            If radiokirli.Checked = True Then
                Using kayit As New SQLiteCommand($"insert into oda(oda_numarasi,kat_numarasi,oda_boyutu,oda_tipi,durum,doluluk) values('{txtodanumara.Text}','{txtkatnumara.Text}','{txtodaboyutu.Text}','{comboodatipi.Text}','{"Kirli"}','{"Boş"}')", baglanti)
                    Try
                        baglanti.Open()
                        kayit.ExecuteNonQuery()
                        MessageBox.Show("Kayıt Yapıldı")
                    Catch hata As Exception
                        MessageBox.Show("Hata : " + hata.Message)
                    Finally
                        baglanti.Close()
                    End Try
                End Using
            End If
        End Using
    End Sub
End Class