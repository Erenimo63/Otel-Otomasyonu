Imports System.Data.SQLite
Public Class checkout
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim fiyat As Int16
    Dim gunluk As Int16 = 125
    Dim gun As String

    Private Sub txtkimlik_TextChanged(sender As Object, e As EventArgs) Handles txtkimlik.TextChanged
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select musteri_adi,musteri_soyadi,musteri_telefon,kac_gun,musteri_mail,oda_numara,kayit_tarihi,musteri_resim from check_in where tc_kimlik='{ txtkimlik.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "check_in")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "check_in"
                    DataGridView1.Columns(0).HeaderText = "Adı"
                    DataGridView1.Columns(1).HeaderText = "Soyadı"
                    DataGridView1.Columns(2).HeaderText = "Telefon Numarası"
                    DataGridView1.Columns(3).HeaderText = "Kaç Gün"
                    DataGridView1.Columns(4).HeaderText = "E_Mail"
                    DataGridView1.Columns(5).HeaderText = "Oda Numarası"
                    DataGridView1.Columns(6).HeaderText = "Giriş Tarihi"
                    DataGridView1.Columns(7).HeaderText = "Müşteri Resmi"
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ms As String
        Dim img As Bitmap
        checkkuru.Checked = False
        checkodaservis.Checked = False
        checkhavaalanı.Checked = False
        checkarac.Checked = False
        txtadi.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtsoyadi.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtnumara.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtgun.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        gun = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtoda.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        dategiris.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        ms = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        PictureBox1.ImageLocation = ms
        Convert.ToInt16(gun)
        fiyat = gun * gunluk
        txtucret.Text = fiyat

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using kayit As New SQLiteCommand($"insert into arsiv (musteri_adi,musteri_soyadi,musteri_telefon,musteri_mail,oda_numarası,kac_gun,giris_tarihi,cikis_tarihi,ucret) values('{txtadi.Text}','{txtsoyadi.Text}','{txtnumara.Text}','{txtmail.Text}','{txtoda.Text}','{txtgun.Text}','{dategiris.Value.ToString("dd/MM/yyyy")}','{datecikis.Value.ToString("dd/MM/yyyy")}','{txtucret.Text}')", baglanti)
                Using sil As New SQLiteCommand($"delete from check_in where tc_kimlik='{txtkimlik.Text}'", baglanti)
                    Using doluluk As New SQLiteCommand($"update oda set doluluk = '{"Boş"}' where oda_numarasi='{txtoda.Text}'", baglanti)
                        Using durum As New SQLiteCommand($"update oda set durum = '{"Kirli"}' where oda_numarasi='{txtoda.Text}'", baglanti)
                            Try
                                baglanti.Open()
                                kayit.ExecuteNonQuery()
                                sil.ExecuteNonQuery()
                                durum.ExecuteNonQuery()
                                doluluk.ExecuteNonQuery()
                                MessageBox.Show("Müşteri Çıkışı Yapıldı")
                            Catch hata As Exception
                                MessageBox.Show(" " + hata.Message)
                            Finally
                                baglanti.Close()
                            End Try
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub checkkuru_CheckedChanged(sender As Object, e As EventArgs) Handles checkkuru.CheckedChanged
        If checkkuru.Checked = True Then
            fiyat = fiyat + 350
            txtucret.Text = fiyat
        End If
        If checkkuru.Checked = False Then
            fiyat = fiyat - 350
            txtucret.Text = fiyat
        End If
    End Sub

    Private Sub checkodaservis_CheckedChanged(sender As Object, e As EventArgs) Handles checkodaservis.CheckedChanged
        If checkodaservis.Checked = True Then
            fiyat = fiyat + 500
            txtucret.Text = fiyat
        End If
        If checkodaservis.Checked = False Then
            fiyat = fiyat - 500
            txtucret.Text = fiyat
        End If
    End Sub

    Private Sub checkarac_CheckedChanged(sender As Object, e As EventArgs) Handles checkarac.CheckedChanged
        If checkarac.Checked = True Then
            fiyat = fiyat + 500
            txtucret.Text = fiyat
        End If
        If checkarac.Checked = False Then
            fiyat = fiyat - 500
            txtucret.Text = fiyat
        End If
    End Sub

    Private Sub checkhavaalanı_CheckedChanged(sender As Object, e As EventArgs) Handles checkhavaalanı.CheckedChanged
        If checkhavaalanı.Checked = True Then
            fiyat = fiyat + 400
            txtucret.Text = fiyat
        End If
        If checkhavaalanı.Checked = False Then
            fiyat = fiyat - 400
            txtucret.Text = fiyat
        End If
    End Sub
End Class