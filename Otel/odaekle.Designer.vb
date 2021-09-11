<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class odaekle
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
        Me.txtodanumara = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtkatnumara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtodaboyutu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.comboodatipi = New System.Windows.Forms.ComboBox()
        Me.radiotemiz = New System.Windows.Forms.RadioButton()
        Me.radiokirli = New System.Windows.Forms.RadioButton()
        Me.radioariza = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtodanumara
        '
        Me.txtodanumara.Location = New System.Drawing.Point(150, 20)
        Me.txtodanumara.Name = "txtodanumara"
        Me.txtodanumara.Size = New System.Drawing.Size(100, 20)
        Me.txtodanumara.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Oda Numarası :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(16, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 31)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Geri"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtkatnumara
        '
        Me.txtkatnumara.Location = New System.Drawing.Point(388, 20)
        Me.txtkatnumara.Name = "txtkatnumara"
        Me.txtkatnumara.Size = New System.Drawing.Size(100, 20)
        Me.txtkatnumara.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(256, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Kat Numarası :"
        '
        'txtodaboyutu
        '
        Me.txtodaboyutu.Location = New System.Drawing.Point(150, 58)
        Me.txtodaboyutu.Name = "txtodaboyutu"
        Me.txtodaboyutu.Size = New System.Drawing.Size(100, 20)
        Me.txtodaboyutu.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Oda Boyutu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(256, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Oda Tipi :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(379, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 31)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'comboodatipi
        '
        Me.comboodatipi.FormattingEnabled = True
        Me.comboodatipi.Items.AddRange(New Object() {"Tek Kişilik", "İki Kişilik", "Üç Kişilik", "Dört Kişilik"})
        Me.comboodatipi.Location = New System.Drawing.Point(388, 57)
        Me.comboodatipi.Name = "comboodatipi"
        Me.comboodatipi.Size = New System.Drawing.Size(100, 21)
        Me.comboodatipi.TabIndex = 38
        '
        'radiotemiz
        '
        Me.radiotemiz.AutoSize = True
        Me.radiotemiz.ForeColor = System.Drawing.Color.White
        Me.radiotemiz.Location = New System.Drawing.Point(135, 96)
        Me.radiotemiz.Name = "radiotemiz"
        Me.radiotemiz.Size = New System.Drawing.Size(53, 17)
        Me.radiotemiz.TabIndex = 39
        Me.radiotemiz.TabStop = True
        Me.radiotemiz.Text = "Temiz"
        Me.radiotemiz.UseVisualStyleBackColor = True
        '
        'radiokirli
        '
        Me.radiokirli.AutoSize = True
        Me.radiokirli.ForeColor = System.Drawing.Color.White
        Me.radiokirli.Location = New System.Drawing.Point(234, 96)
        Me.radiokirli.Name = "radiokirli"
        Me.radiokirli.Size = New System.Drawing.Size(41, 17)
        Me.radiokirli.TabIndex = 39
        Me.radiokirli.TabStop = True
        Me.radiokirli.Text = "Kirli"
        Me.radiokirli.UseVisualStyleBackColor = True
        '
        'radioariza
        '
        Me.radioariza.AutoSize = True
        Me.radioariza.ForeColor = System.Drawing.Color.White
        Me.radioariza.Location = New System.Drawing.Point(321, 96)
        Me.radioariza.Name = "radioariza"
        Me.radioariza.Size = New System.Drawing.Size(52, 17)
        Me.radioariza.TabIndex = 39
        Me.radioariza.TabStop = True
        Me.radioariza.Text = "Arızalı"
        Me.radioariza.UseVisualStyleBackColor = True
        '
        'odaekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(504, 124)
        Me.Controls.Add(Me.radioariza)
        Me.Controls.Add(Me.radiokirli)
        Me.Controls.Add(Me.radiotemiz)
        Me.Controls.Add(Me.comboodatipi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtodaboyutu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkatnumara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtodanumara)
        Me.Controls.Add(Me.Label2)
        Me.Name = "odaekle"
        Me.Text = "Otel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtodanumara As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtkatnumara As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtodaboyutu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents comboodatipi As ComboBox
    Friend WithEvents radiotemiz As RadioButton
    Friend WithEvents radiokirli As RadioButton
    Friend WithEvents radioariza As RadioButton
End Class
