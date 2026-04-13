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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputToolStripMenuItem = New ToolStripMenuItem()
        LihatToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblDivisi = New Label()
        GroupBox1 = New GroupBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        lblGender = New Label()
        lblTglLahir = New Label()
        lblID = New Label()
        lblNama = New Label()
        cmbDivisi = New ComboBox()
        dtpTanggalLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        PictureBox3 = New PictureBox()
        TabPage2 = New TabPage()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox6 = New PictureBox()
        TabPage3 = New TabPage()
        PictureBox8 = New PictureBox()
        GroupBox3 = New GroupBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        RadioButton10 = New RadioButton()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        PictureBox7 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputToolStripMenuItem, LihatToolStripMenuItem, SimpanToolStripMenuItem, BukaToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(601, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputToolStripMenuItem
        ' 
        InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        InputToolStripMenuItem.Size = New Size(61, 24)
        InputToolStripMenuItem.Text = "Input"
        ' 
        ' LihatToolStripMenuItem
        ' 
        LihatToolStripMenuItem.Name = "LihatToolStripMenuItem"
        LihatToolStripMenuItem.Size = New Size(60, 24)
        LihatToolStripMenuItem.Text = "Lihat"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(77, 24)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(59, 24)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(70, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 187)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(601, 401)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Silver
        TabPage1.Controls.Add(lblDivisi)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(lblGender)
        TabPage1.Controls.Add(lblTglLahir)
        TabPage1.Controls.Add(lblID)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(PictureBox3)
        TabPage1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(593, 368)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Main Data"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.BackColor = Color.White
        lblDivisi.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDivisi.Location = New Point(23, 179)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(47, 19)
        lblDivisi.TabIndex = 10
        lblDivisi.Text = "Divisi"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(PictureBox5)
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(142, 215)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(176, 91)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.sigma_female
        PictureBox5.Location = New Point(127, 56)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 24)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.sigma
        PictureBox4.Location = New Point(127, 27)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(30, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(18, 56)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(103, 24)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(18, 27)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.White
        lblGender.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblGender.Location = New Point(23, 225)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(93, 19)
        lblGender.TabIndex = 8
        lblGender.Text = "Jenis Kelamin"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.White
        lblTglLahir.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTglLahir.Location = New Point(23, 128)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(97, 19)
        lblTglLahir.TabIndex = 7
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.White
        lblID.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.Black
        lblID.Location = New Point(23, 83)
        lblID.Name = "lblID"
        lblID.Size = New Size(84, 19)
        lblID.TabIndex = 6
        lblID.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.White
        lblNama.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(18, 32)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(103, 19)
        lblNama.TabIndex = 5
        lblNama.Text = "Nama Lengkap"
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"- Ahli Modifikasi", "- Ahli Mesin", "- Ahli Kreatifitas", "- Ahli Dokumentasi", "- Ahli Marchendise", "- Ahli Touring"})
        cmbDivisi.Location = New Point(142, 176)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(261, 28)
        cmbDivisi.TabIndex = 4
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(142, 128)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(261, 27)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(142, 77)
        txtID.Name = "txtID"
        txtID.Size = New Size(261, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(142, 28)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(261, 27)
        txtNama.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.ini
        PictureBox3.Location = New Point(-21, -68)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(617, 437)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(MaskedTextBox1)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(PictureBox6)
        TabPage2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(593, 368)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Contact and Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(377, 111)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(162, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(177, 235)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(244, 27)
        txtAlamat.TabIndex = 10
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(42, 109)
        MaskedTextBox1.Mask = "0000-0000-0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(162, 27)
        MaskedTextBox1.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(269, 209)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 19)
        Label7.TabIndex = 8
        Label7.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(439, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 19)
        Label6.TabIndex = 7
        Label6.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Book Antiqua", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(83, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 19)
        Label4.TabIndex = 6
        Label4.Text = "Nomor HP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(619, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.ini
        PictureBox6.Location = New Point(-22, -27)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(623, 396)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 3
        PictureBox6.TabStop = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(PictureBox8)
        TabPage3.Controls.Add(GroupBox3)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(PictureBox7)
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(593, 368)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profile and Activity"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Location = New Point(24, 55)
        PictureBox8.Margin = New Padding(3, 4, 3, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(131, 185)
        PictureBox8.TabIndex = 17
        PictureBox8.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBox8)
        GroupBox3.Controls.Add(CheckBox7)
        GroupBox3.Controls.Add(CheckBox6)
        GroupBox3.Controls.Add(CheckBox5)
        GroupBox3.Controls.Add(CheckBox4)
        GroupBox3.Controls.Add(CheckBox3)
        GroupBox3.Controls.Add(CheckBox2)
        GroupBox3.Controls.Add(CheckBox1)
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(397, 19)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(192, 261)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hobi"
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(101, 89)
        CheckBox8.Margin = New Padding(3, 4, 3, 4)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(78, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Charity"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(101, 36)
        CheckBox7.Margin = New Padding(3, 4, 3, 4)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(105, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Night Drive"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(7, 196)
        CheckBox6.Margin = New Padding(3, 4, 3, 4)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(84, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Sunmori"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(101, 196)
        CheckBox5.Margin = New Padding(3, 4, 3, 4)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(70, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Ngopi"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(7, 141)
        CheckBox4.Margin = New Padding(3, 4, 3, 4)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(67, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Modif"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(101, 141)
        CheckBox3.Margin = New Padding(3, 4, 3, 4)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(109, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Car Photogr"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(7, 89)
        CheckBox2.Margin = New Padding(3, 4, 3, 4)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(80, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Touring"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(7, 36)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(80, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Drifting"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(191, 288)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(398, 31)
        Button2.TabIndex = 3
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(42, 288)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 2
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton10)
        GroupBox2.Controls.Add(RadioButton9)
        GroupBox2.Controls.Add(RadioButton8)
        GroupBox2.Controls.Add(RadioButton7)
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(191, 19)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(199, 261)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Jabatan"
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AutoSize = True
        RadioButton10.Location = New Point(3, 116)
        RadioButton10.Margin = New Padding(3, 4, 3, 4)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(132, 24)
        RadioButton10.TabIndex = 7
        RadioButton10.TabStop = True
        RadioButton10.Text = "Official Member"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(113, 216)
        RadioButton9.Margin = New Padding(3, 4, 3, 4)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(82, 24)
        RadioButton9.TabIndex = 6
        RadioButton9.TabStop = True
        RadioButton9.Text = "Sweeper"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(3, 149)
        RadioButton8.Margin = New Padding(3, 4, 3, 4)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(118, 24)
        RadioButton8.TabIndex = 5
        RadioButton8.TabStop = True
        RadioButton8.Text = "Road Captain"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(3, 83)
        RadioButton7.Margin = New Padding(3, 4, 3, 4)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(133, 24)
        RadioButton7.TabIndex = 4
        RadioButton7.TabStop = True
        RadioButton7.Text = "Public Relations"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(3, 183)
        RadioButton6.Margin = New Padding(3, 4, 3, 4)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(99, 24)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "Bendahara"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(3, 216)
        RadioButton5.Margin = New Padding(3, 4, 3, 4)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(91, 24)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "Sekretaris"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(3, 49)
        RadioButton4.Margin = New Padding(3, 4, 3, 4)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(122, 24)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Vice-President"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(3, 16)
        RadioButton3.Margin = New Padding(3, 4, 3, 4)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(89, 24)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "President"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Newspapers_Decorative_Frame_PNG_Images___Frame_Clipart__Decorative_Border__Newspaper_PNG_Transparent_Background___Pngtree
        PictureBox7.Location = New Point(0, 19)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(184, 261)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.ini
        PictureBox2.Location = New Point(-43, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(690, 361)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.OldLace
        Label1.Font = New Font("Tw Cen MT", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(417, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 33)
        Label1.TabIndex = 12
        Label1.Text = "W82 Community"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.OldLace
        Label3.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(474, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 24)
        Label3.TabIndex = 15
        Label3.Text = "Car "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.OldLace
        Label5.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Brown
        Label5.Location = New Point(509, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 24)
        Label5.TabIndex = 16
        Label5.Text = "Enthusiast"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-66, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(690, 181)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(601, 579)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents lblDivisi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
