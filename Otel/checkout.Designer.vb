<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtkimlik = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumara = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsoyadi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtadi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtucret = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dategiris = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datecikis = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtoda = New System.Windows.Forms.TextBox()
        Me.txtgun = New System.Windows.Forms.TextBox()
        Me.checkodaservis = New System.Windows.Forms.CheckBox()
        Me.checkhavaalanı = New System.Windows.Forms.CheckBox()
        Me.checkarac = New System.Windows.Forms.CheckBox()
        Me.checkkuru = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtkimlik
        '
        Me.txtkimlik.Location = New System.Drawing.Point(364, 12)
        Me.txtkimlik.Name = "txtkimlik"
        Me.txtkimlik.Size = New System.Drawing.Size(100, 20)
        Me.txtkimlik.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(212, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "T.C Kimlik No :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(736, 58)
        Me.DataGridView1.TabIndex = 48
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(614, 161)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(134, 20)
        Me.txtmail.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(465, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Müşteri E-Mail :"
        '
        'txtnumara
        '
        Me.txtnumara.Location = New System.Drawing.Point(614, 126)
        Me.txtnumara.Name = "txtnumara"
        Me.txtnumara.Size = New System.Drawing.Size(134, 20)
        Me.txtnumara.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(465, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Müşteri Telefon :"
        '
        'txtsoyadi
        '
        Me.txtsoyadi.Location = New System.Drawing.Point(294, 161)
        Me.txtsoyadi.Name = "txtsoyadi"
        Me.txtsoyadi.Size = New System.Drawing.Size(134, 20)
        Me.txtsoyadi.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(142, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Müşteri Soyadı :"
        '
        'txtadi
        '
        Me.txtadi.Location = New System.Drawing.Point(294, 126)
        Me.txtadi.Name = "txtadi"
        Me.txtadi.Size = New System.Drawing.Size(134, 20)
        Me.txtadi.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(142, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Müşteri Adı :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'txtucret
        '
        Me.txtucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtucret.Location = New System.Drawing.Point(442, 296)
        Me.txtucret.Multiline = True
        Me.txtucret.Name = "txtucret"
        Me.txtucret.Size = New System.Drawing.Size(128, 44)
        Me.txtucret.TabIndex = 58
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(13, 309)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 31)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Geri"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(576, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 31)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Çıkış İşlemini Yap"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(480, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Ücret"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(142, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 20)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Oda Numarası :"
        '
        'dategiris
        '
        Me.dategiris.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dategiris.Location = New System.Drawing.Point(614, 196)
        Me.dategiris.Name = "dategiris"
        Me.dategiris.Size = New System.Drawing.Size(134, 20)
        Me.dategiris.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(465, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Giriş Tarih :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(465, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Çıkış Tarih :"
        '
        'datecikis
        '
        Me.datecikis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datecikis.Location = New System.Drawing.Point(614, 231)
        Me.datecikis.Name = "datecikis"
        Me.datecikis.Size = New System.Drawing.Size(134, 20)
        Me.datecikis.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(142, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Kaç Gün :"
        '
        'txtoda
        '
        Me.txtoda.Location = New System.Drawing.Point(294, 196)
        Me.txtoda.Name = "txtoda"
        Me.txtoda.Size = New System.Drawing.Size(134, 20)
        Me.txtoda.TabIndex = 65
        '
        'txtgun
        '
        Me.txtgun.Location = New System.Drawing.Point(294, 231)
        Me.txtgun.Name = "txtgun"
        Me.txtgun.Size = New System.Drawing.Size(134, 20)
        Me.txtgun.TabIndex = 66
        '
        'checkodaservis
        '
        Me.checkodaservis.AutoSize = True
        Me.checkodaservis.ForeColor = System.Drawing.Color.White
        Me.checkodaservis.Location = New System.Drawing.Point(308, 295)
        Me.checkodaservis.Name = "checkodaservis"
        Me.checkodaservis.Size = New System.Drawing.Size(115, 17)
        Me.checkodaservis.TabIndex = 67
        Me.checkodaservis.Text = "Oda Servis Hizmeti"
        Me.checkodaservis.UseVisualStyleBackColor = True
        '
        'checkhavaalanı
        '
        Me.checkhavaalanı.AutoSize = True
        Me.checkhavaalanı.ForeColor = System.Drawing.Color.White
        Me.checkhavaalanı.Location = New System.Drawing.Point(308, 322)
        Me.checkhavaalanı.Name = "checkhavaalanı"
        Me.checkhavaalanı.Size = New System.Drawing.Size(118, 17)
        Me.checkhavaalanı.TabIndex = 67
        Me.checkhavaalanı.Text = "Havaalanı Transferi"
        Me.checkhavaalanı.UseVisualStyleBackColor = True
        '
        'checkarac
        '
        Me.checkarac.AutoSize = True
        Me.checkarac.ForeColor = System.Drawing.Color.White
        Me.checkarac.Location = New System.Drawing.Point(165, 323)
        Me.checkarac.Name = "checkarac"
        Me.checkarac.Size = New System.Drawing.Size(91, 17)
        Me.checkarac.TabIndex = 67
        Me.checkarac.Text = "Araç Kiralama"
        Me.checkarac.UseVisualStyleBackColor = True
        '
        'checkkuru
        '
        Me.checkkuru.AutoSize = True
        Me.checkkuru.ForeColor = System.Drawing.Color.White
        Me.checkkuru.Location = New System.Drawing.Point(165, 295)
        Me.checkkuru.Name = "checkkuru"
        Me.checkkuru.Size = New System.Drawing.Size(137, 17)
        Me.checkkuru.TabIndex = 67
        Me.checkkuru.Text = "Kuru Temizleme Ve Ütü"
        Me.checkkuru.UseVisualStyleBackColor = True
        '
        'checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(760, 345)
        Me.Controls.Add(Me.checkkuru)
        Me.Controls.Add(Me.checkarac)
        Me.Controls.Add(Me.checkhavaalanı)
        Me.Controls.Add(Me.checkodaservis)
        Me.Controls.Add(Me.txtgun)
        Me.Controls.Add(Me.txtoda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datecikis)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dategiris)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtucret)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnumara)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsoyadi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtadi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtkimlik)
        Me.Controls.Add(Me.Label11)
        Me.Name = "checkout"
        Me.Text = "Otel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtkimlik As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumara As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtsoyadi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtadi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtucret As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dategiris As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents datecikis As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtoda As TextBox
    Friend WithEvents txtgun As TextBox
    Friend WithEvents checkodaservis As CheckBox
    Friend WithEvents checkhavaalanı As CheckBox
    Friend WithEvents checkarac As CheckBox
    Friend WithEvents checkkuru As CheckBox
End Class
