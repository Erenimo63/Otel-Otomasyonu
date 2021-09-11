<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kayit
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtsoyisim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtisim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsifre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkimlik = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(234, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 31)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Kayıt"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Geri"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtsoyisim
        '
        Me.txtsoyisim.Location = New System.Drawing.Point(312, 27)
        Me.txtsoyisim.Name = "txtsoyisim"
        Me.txtsoyisim.Size = New System.Drawing.Size(100, 20)
        Me.txtsoyisim.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(226, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Soyisim :"
        '
        'txtisim
        '
        Me.txtisim.Location = New System.Drawing.Point(115, 27)
        Me.txtisim.Name = "txtisim"
        Me.txtisim.Size = New System.Drawing.Size(100, 20)
        Me.txtisim.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "İsim :"
        '
        'txtsifre
        '
        Me.txtsifre.Location = New System.Drawing.Point(312, 77)
        Me.txtsifre.Name = "txtsifre"
        Me.txtsifre.Size = New System.Drawing.Size(100, 20)
        Me.txtsifre.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(226, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Şifre :"
        '
        'txtkimlik
        '
        Me.txtkimlik.Location = New System.Drawing.Point(115, 77)
        Me.txtkimlik.Name = "txtkimlik"
        Me.txtkimlik.Size = New System.Drawing.Size(100, 20)
        Me.txtkimlik.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "T.C Kimlik :"
        '
        'kayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(432, 152)
        Me.Controls.Add(Me.txtsifre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkimlik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsoyisim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtisim)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kayit"
        Me.Text = "Otel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtsoyisim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtisim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsifre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkimlik As TextBox
    Friend WithEvents Label4 As Label
End Class
