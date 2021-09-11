Imports System.Data.SQLite
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class konaklama
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        anamenü.Show()
        Me.Hide()

    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(DataGridView1.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(DataGridView1.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(DataGridView1.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        Dim dataColumn_6 As New DataColumn(DataGridView1.Columns(5).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_6)
        Dim dataColumn_7 As New DataColumn(DataGridView1.Columns(6).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_7)
        Dim dataColumn_8 As New DataColumn(DataGridView1.Columns(7).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_8)
        Dim dataColumn_9 As New DataColumn(DataGridView1.Columns(8).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_9)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(DataGridView1.Columns(0).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(0).Value.ToString()
            dataRow(DataGridView1.Columns(1).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(1).Value.ToString()
            dataRow(DataGridView1.Columns(2).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(2).Value.ToString()
            dataRow(DataGridView1.Columns(3).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(3).Value.ToString()
            dataRow(DataGridView1.Columns(4).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(4).Value.ToString()
            dataRow(DataGridView1.Columns(5).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(5).Value.ToString()
            dataRow(DataGridView1.Columns(6).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(6).Value.ToString()
            dataRow(DataGridView1.Columns(7).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(7).Value.ToString()
            dataRow(DataGridView1.Columns(8).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(8).Value.ToString()

            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(9)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Adi", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Soyadi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Telefon Numarasi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("E-Mail", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Oda Numarasi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Kac Gun Kaldi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Giris Tarihi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Çikis Tarihi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Ucret", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)

        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub

    Private Sub ExportDataToPDFTableaktif()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(9)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("T.C Kimlik", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Adi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Soyadi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Telefon Numarasi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("E-Mail", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Oda Numarasi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Kac Gun Kalacak", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Giris Tarihi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Cinsiyet", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)

        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub


    Private Sub konaklama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from oda", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    Do While oku.Read()
                        combooda.Items.Add(oku("oda_numarasi"))
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub combooda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combooda.SelectedIndexChanged
        Using baglanti As New SQLiteConnection("data source=db/Otel.db")
            Using getir As New SQLiteCommand($"select * from arsiv where oda_numarası='{ combooda.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "arsiv")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "arsiv"
                    DataGridView1.Columns(0).HeaderText = "Adı"
                    DataGridView1.Columns(1).HeaderText = "Soyadı"
                    DataGridView1.Columns(2).HeaderText = "Telefon Numarası"
                    DataGridView1.Columns(3).HeaderText = "E_Mail"
                    DataGridView1.Columns(4).HeaderText = "Oda Numarası"
                    DataGridView1.Columns(5).HeaderText = "Kaç Gün Kaldı"
                    DataGridView1.Columns(6).HeaderText = "Giriş Tarihi"
                    DataGridView1.Columns(7).HeaderText = "Çıkış Tarihi"
                    DataGridView1.Columns(8).HeaderText = "Ücret"
                    RadioButton1.Checked = False
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                MsgBox("PDF Oluşturmak İçin İsim Giriniz")
                Exit Sub
            Else
                ExportDataToPDFTableaktif()
                MsgBox("PDF Oluşturuldu")
            End If
        End If
        If RadioButton1.Checked = False Then
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                MsgBox("PDF Oluşturmak İçin İsim Giriniz")
                Exit Sub
            Else
                ExportDataToPDFTable()
                MsgBox("PDF Oluşturuldu")
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Using baglanti As New SQLiteConnection("data source=db/Otel.db")
                Using getir As New SQLiteCommand($"select tc_kimlik,musteri_adi,musteri_soyadi,musteri_telefon,musteri_mail,oda_numara,kac_gun,kayit_tarihi,cinsiyet from check_in ", baglanti)
                    baglanti.Open()
                    Using da As New SQLiteDataAdapter(getir)
                        Dim ds As New DataSet
                        da.Fill(ds, "check_in")
                        DataGridView1.DataSource = ds
                        DataGridView1.DataMember = "check_in"
                        DataGridView1.Columns(0).HeaderText = "TC Kimlik Numarası"
                        DataGridView1.Columns(1).HeaderText = "Adı"
                        DataGridView1.Columns(2).HeaderText = "Soyadı"
                        DataGridView1.Columns(3).HeaderText = "Telefon Numarası"
                        DataGridView1.Columns(4).HeaderText = "E_Mail"
                        DataGridView1.Columns(5).HeaderText = "Oda Numarası"
                        DataGridView1.Columns(6).HeaderText = "Kaç Gün Kalacak"
                        DataGridView1.Columns(7).HeaderText = "Giriş Tarihi"
                        DataGridView1.Columns(8).HeaderText = "Cinsiyet"
                    End Using
                End Using
            End Using
        End If
    End Sub
End Class