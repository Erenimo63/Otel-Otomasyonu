<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combooda = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.datekayit = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttelefon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtulke = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsoyadi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtadi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtresim = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combocinsiyet = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtseri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtuyruk = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.datedogum = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbaba = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtanne = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtkimlik = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgun = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combooda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.datekayit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtgun)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttelefon)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtulke)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsoyadi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtadi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 369)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Müşteri Bilgileri"
        '
        'combooda
        '
        Me.combooda.FormattingEnabled = True
        Me.combooda.Location = New System.Drawing.Point(162, 231)
        Me.combooda.Name = "combooda"
        Me.combooda.Size = New System.Drawing.Size(100, 21)
        Me.combooda.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(13, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 20)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Oda Numarası :"
        '
        'datekayit
        '
        Me.datekayit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datekayit.Location = New System.Drawing.Point(162, 303)
        Me.datekayit.Name = "datekayit"
        Me.datekayit.Size = New System.Drawing.Size(100, 20)
        Me.datekayit.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Kayıt Tarih :"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(162, 196)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(100, 20)
        Me.txtmail.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Müşteri E-Mail :"
        '
        'txttelefon
        '
        Me.txttelefon.Location = New System.Drawing.Point(162, 161)
        Me.txttelefon.Name = "txttelefon"
        Me.txttelefon.Size = New System.Drawing.Size(100, 20)
        Me.txttelefon.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Müşteri Telefon :"
        '
        'txtdil
        '
        Me.txtdil.Location = New System.Drawing.Point(162, 126)
        Me.txtdil.Name = "txtdil"
        Me.txtdil.Size = New System.Drawing.Size(100, 20)
        Me.txtdil.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Müşteri Dili :"
        '
        'txtulke
        '
        Me.txtulke.Location = New System.Drawing.Point(162, 91)
        Me.txtulke.Name = "txtulke"
        Me.txtulke.Size = New System.Drawing.Size(100, 20)
        Me.txtulke.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Müşteri Ülkesi :"
        '
        'txtsoyadi
        '
        Me.txtsoyadi.Location = New System.Drawing.Point(162, 56)
        Me.txtsoyadi.Name = "txtsoyadi"
        Me.txtsoyadi.Size = New System.Drawing.Size(100, 20)
        Me.txtsoyadi.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Müşteri Soyadı :"
        '
        'txtadi
        '
        Me.txtadi.Location = New System.Drawing.Point(162, 21)
        Me.txtadi.Name = "txtadi"
        Me.txtadi.Size = New System.Drawing.Size(100, 20)
        Me.txtadi.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Müşteri Adı :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtresim)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.combocinsiyet)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtseri)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtuyruk)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.datedogum)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtbaba)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtanne)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtkimlik)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 369)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kimlik Bilgileri"
        '
        'txtresim
        '
        Me.txtresim.Location = New System.Drawing.Point(6, 177)
        Me.txtresim.Name = "txtresim"
        Me.txtresim.Size = New System.Drawing.Size(124, 20)
        Me.txtresim.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 31)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Resim Ekle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'combocinsiyet
        '
        Me.combocinsiyet.FormattingEnabled = True
        Me.combocinsiyet.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.combocinsiyet.Location = New System.Drawing.Point(299, 205)
        Me.combocinsiyet.Name = "combocinsiyet"
        Me.combocinsiyet.Size = New System.Drawing.Size(100, 21)
        Me.combocinsiyet.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(147, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Cinsiyet :"
        '
        'txtseri
        '
        Me.txtseri.Location = New System.Drawing.Point(299, 174)
        Me.txtseri.Name = "txtseri"
        Me.txtseri.Size = New System.Drawing.Size(100, 20)
        Me.txtseri.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(147, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Seri No :"
        '
        'txtuyruk
        '
        Me.txtuyruk.Location = New System.Drawing.Point(299, 143)
        Me.txtuyruk.Name = "txtuyruk"
        Me.txtuyruk.Size = New System.Drawing.Size(100, 20)
        Me.txtuyruk.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(147, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Müşteri Uyruğu :"
        '
        'datedogum
        '
        Me.datedogum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedogum.Location = New System.Drawing.Point(299, 112)
        Me.datedogum.Name = "datedogum"
        Me.datedogum.Size = New System.Drawing.Size(100, 20)
        Me.datedogum.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(147, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 20)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Doğum Tarihi :"
        '
        'txtbaba
        '
        Me.txtbaba.Location = New System.Drawing.Point(299, 81)
        Me.txtbaba.Name = "txtbaba"
        Me.txtbaba.Size = New System.Drawing.Size(100, 20)
        Me.txtbaba.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(147, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 20)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Baba Adı :"
        '
        'txtanne
        '
        Me.txtanne.Location = New System.Drawing.Point(299, 50)
        Me.txtanne.Name = "txtanne"
        Me.txtanne.Size = New System.Drawing.Size(100, 20)
        Me.txtanne.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(147, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Anne Adı :"
        '
        'txtkimlik
        '
        Me.txtkimlik.Location = New System.Drawing.Point(299, 19)
        Me.txtkimlik.Name = "txtkimlik"
        Me.txtkimlik.Size = New System.Drawing.Size(100, 20)
        Me.txtkimlik.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(147, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "T.C Kimlik No :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 31)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Geri"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(768, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 31)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Kayıt"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Kaç Gün :"
        '
        'txtgun
        '
        Me.txtgun.Location = New System.Drawing.Point(162, 267)
        Me.txtgun.Name = "txtgun"
        Me.txtgun.Size = New System.Drawing.Size(100, 20)
        Me.txtgun.TabIndex = 41
        '
        'checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(892, 423)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "checkin"
        Me.Text = "Otel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents datekayit As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttelefon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtulke As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsoyadi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtadi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents combocinsiyet As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtseri As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtuyruk As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents datedogum As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbaba As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtanne As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtkimlik As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents combooda As ComboBox
    Friend WithEvents txtresim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtgun As TextBox
End Class
