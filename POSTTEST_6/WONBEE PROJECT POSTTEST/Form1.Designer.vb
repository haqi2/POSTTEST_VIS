<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose untuk membersihkan daftar komponen.
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

    ' Diperlukan oleh Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: Prosedur berikut diperlukan oleh Windows Form Designer
    ' Dapat dimodifikasi menggunakan Windows Form Designer.  
    ' Jangan memodifikasi menggunakan code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        cbKategori = New ComboBox()
        Label5 = New Label()
        txtKet = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvAkun = New DataGridView()
        btnSimpan = New Button()
        txtLevel = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(dgvAkun, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()


        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cbKategori)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtKet)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(dgvAkun)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(txtLevel)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, 170)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1055, 513)
        Panel1.TabIndex = 0


        Label4.AutoSize = True
        Label4.BackColor = Color.Sienna
        Label4.Location = New Point(96, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 14
        Label4.Text = "Kategori"


        cbKategori.FormattingEnabled = True
        cbKategori.Location = New Point(45, 302)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(175, 28)
        cbKategori.TabIndex = 13


        Label5.AutoSize = True
        Label5.BackColor = Color.Sienna
        Label5.Location = New Point(70, 351)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 12
        Label5.Text = "Keterangan Akun"


        txtKet.Location = New Point(45, 375)
        txtKet.Margin = New Padding(3, 4, 3, 4)
        txtKet.Name = "txtKet"
        txtKet.Size = New Size(175, 27)
        txtKet.TabIndex = 11


        Label3.AutoSize = True
        Label3.BackColor = Color.Sienna
        Label3.Location = New Point(109, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 8
        Label3.Text = "Level"


        Label2.AutoSize = True
        Label2.BackColor = Color.Sienna
        Label2.Location = New Point(96, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 7
        Label2.Text = "Password"


        Label1.AutoSize = True
        Label1.BackColor = Color.Sienna
        Label1.Location = New Point(96, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 6
        Label1.Text = "Username"


        dgvAkun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAkun.GridColor = SystemColors.HighlightText
        dgvAkun.Location = New Point(327, 88)
        dgvAkun.Margin = New Padding(3, 4, 3, 4)
        dgvAkun.Name = "dgvAkun"
        dgvAkun.RowHeadersWidth = 51
        dgvAkun.Size = New Size(641, 379)
        dgvAkun.TabIndex = 5


        btnSimpan.BackColor = Color.Sienna
        btnSimpan.Font = New Font("Palatino Linotype", 9.0F)
        btnSimpan.Location = New Point(70, 420)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(118, 47)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan Akun"
        btnSimpan.UseVisualStyleBackColor = False


        txtLevel.Location = New Point(45, 235)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(175, 27)
        txtLevel.TabIndex = 2


        txtPassword.Location = New Point(45, 167)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(175, 27)
        txtPassword.TabIndex = 1


        txtUsername.Location = New Point(45, 103)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(175, 27)
        txtUsername.TabIndex = 0


        PictureBox1.Image = My.Resources.Resources.coklat
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1055, 517)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False


        PictureBox2.Image = My.Resources.Resources.we_weonbi
        PictureBox2.Location = New Point(-1, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1055, 227)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False


        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 668)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "MenuUtama"
        Text = "MenuUtama"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvAkun, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents dgvAkun As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtKet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents Label4 As Label
End Class