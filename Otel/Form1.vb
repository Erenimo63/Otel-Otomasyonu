Imports System.Data.SQLite
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kayit.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using baglanti As New SQLiteConnection("data source = db/Otel.db")
            Using sorgu As New SQLiteCommand($"select * from personel where personel_kimlik ='{txtkimlik.Text}' and personel_sifre ='{txtsifre.Text}'", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = sorgu.ExecuteReader()
                    If oku.Read Then
                        anamenü.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Kimlik Ve Şifre Yanlış")
                    End If

                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
