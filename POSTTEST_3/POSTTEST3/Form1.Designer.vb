<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        pictGambar = New PictureBox()
        tglLahir = New DateTimePicker()
        txtNomor = New TextBox()
        txtAlamat = New TextBox()
        pilihCowo = New RadioButton()
        pilihCewe = New RadioButton()
        gbJK = New GroupBox()
        btnSubmit = New Button()
        btnPrint = New Button()
        gbHobi = New GroupBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictGambar, ComponentModel.ISupportInitialize).BeginInit()
        gbJK.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.asli_1
        PictureBox1.Location = New Point(-2, -2)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(871, 605)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(410, 89)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(245, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(410, 138)
        txtUmur.Margin = New Padding(3, 4, 3, 4)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(304, 27)
        txtUmur.TabIndex = 2
        ' 
        ' pictGambar
        ' 
        pictGambar.Location = New Point(52, 165)
        pictGambar.Margin = New Padding(3, 4, 3, 4)
        pictGambar.Name = "pictGambar"
        pictGambar.Size = New Size(249, 185)
        pictGambar.SizeMode = PictureBoxSizeMode.Zoom
        pictGambar.TabIndex = 3
        pictGambar.TabStop = False
        ' 
        ' tglLahir
        ' 
        tglLahir.Location = New Point(467, 192)
        tglLahir.Margin = New Padding(3, 4, 3, 4)
        tglLahir.Name = "tglLahir"
        tglLahir.Size = New Size(247, 27)
        tglLahir.TabIndex = 4
        ' 
        ' txtNomor
        ' 
        txtNomor.Location = New Point(467, 236)
        txtNomor.Margin = New Padding(3, 4, 3, 4)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(266, 27)
        txtNomor.TabIndex = 5
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(447, 283)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(286, 27)
        txtAlamat.TabIndex = 6
        ' 
        ' pilihCowo
        ' 
        pilihCowo.AutoSize = True
        pilihCowo.Location = New Point(31, 29)
        pilihCowo.Margin = New Padding(3, 4, 3, 4)
        pilihCowo.Name = "pilihCowo"
        pilihCowo.Size = New Size(85, 24)
        pilihCowo.TabIndex = 7
        pilihCowo.TabStop = True
        pilihCowo.Text = "Laki-laki"
        pilihCowo.UseVisualStyleBackColor = True
        ' 
        ' pilihCewe
        ' 
        pilihCewe.AutoSize = True
        pilihCewe.Location = New Point(31, 81)
        pilihCewe.Margin = New Padding(3, 4, 3, 4)
        pilihCewe.Name = "pilihCewe"
        pilihCewe.Size = New Size(104, 24)
        pilihCewe.TabIndex = 8
        pilihCewe.TabStop = True
        pilihCewe.Text = "Perempuan"
        pilihCewe.UseVisualStyleBackColor = True
        ' 
        ' gbJK
        ' 
        gbJK.BackColor = Color.LightGray
        gbJK.Controls.Add(pilihCewe)
        gbJK.Controls.Add(pilihCowo)
        gbJK.Location = New Point(319, 358)
        gbJK.Margin = New Padding(3, 4, 3, 4)
        gbJK.Name = "gbJK"
        gbJK.Padding = New Padding(3, 4, 3, 4)
        gbJK.Size = New Size(166, 126)
        gbJK.TabIndex = 9
        gbJK.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(123, 378)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(98, 40)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Browse"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(52, 523)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(249, 31)
        btnPrint.TabIndex = 11
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.LightGray
        gbHobi.Controls.Add(CheckBox6)
        gbHobi.Controls.Add(CheckBox5)
        gbHobi.Controls.Add(CheckBox4)
        gbHobi.Controls.Add(CheckBox3)
        gbHobi.Controls.Add(CheckBox2)
        gbHobi.Controls.Add(CheckBox1)
        gbHobi.Location = New Point(507, 358)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(250, 125)
        gbHobi.TabIndex = 12
        gbHobi.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 23)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(79, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Coding"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(3, 53)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(91, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Traveling"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(3, 83)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(83, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Gaming"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(124, 23)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(95, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Bernyanyi"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(124, 53)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(92, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Olahraga"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(124, 81)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(93, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Kulineran"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 600)
        Controls.Add(gbHobi)
        Controls.Add(btnPrint)
        Controls.Add(btnSubmit)
        Controls.Add(gbJK)
        Controls.Add(txtAlamat)
        Controls.Add(txtNomor)
        Controls.Add(tglLahir)
        Controls.Add(pictGambar)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pictGambar, ComponentModel.ISupportInitialize).EndInit()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents pictGambar As PictureBox
    Friend WithEvents tglLahir As DateTimePicker
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents pilihCowo As RadioButton
    Friend WithEvents pilihCewe As RadioButton
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox

End Class
