Imports System.Data.SQLite
Public Class checkin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Resim Dosyaları|" & "*.jpg;*.png*"
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            txtresim.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Sub checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from oda where doluluk = '{"Boş"}' and durum = '{"Temiz"}'", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    Do While oku.Read()
                        combooda.Items.Add(oku("oda_numarasi"))
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using kayit As New SQLiteCommand($"insert into check_in (musteri_adi,musteri_soyadi,musteri_ulkesi,musteri_dili,musteri_telefon,musteri_mail,oda_numara,kac_gun,kayit_tarihi,musteri_resim,tc_kimlik,anne_adi,baba_adi,dogum_tarih,uyruk,seri_no,cinsiyet) values ('{txtadi.Text}','{txtsoyadi.Text}','{txtulke.Text}','{txtdil.Text}','{txttelefon.Text}','{txtmail.Text}','{combooda.Text}','{txtgun.Text}','{datekayit.Value.ToString("dd/MM/yyyy")}','{txtresim.Text}','{txtkimlik.Text}','{txtanne.Text}','{txtbaba.Text}','{datedogum.Value.ToString("dd/MM/yyyy")}','{txtuyruk.Text}','{txtseri.Text}','{combocinsiyet.Text}')", baglanti)
                Using guncelle As New SQLiteCommand($"update oda set doluluk ='{"Dolu"}' where oda_numarasi = '{combooda.Text}'", baglanti)
                    Try
                        baglanti.Open()
                        kayit.ExecuteNonQuery()
                        guncelle.ExecuteNonQuery()
                        MessageBox.Show("Kayıt Yapıldı")
                    Catch hata As Exception
                        MessageBox.Show("Hata : " + hata.Message)
                    Finally
                        baglanti.Close()
                    End Try
                End Using
            End Using
        End Using
    End Sub
End Class