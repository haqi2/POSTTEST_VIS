<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
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
        Panel1 = New Panel()
        Label5 = New Label()
        txtKet = New TextBox()
        txtTipe = New TextBox()
        Label4 = New Label()
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
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtKet)
        Panel1.Controls.Add(txtTipe)
        Panel1.Controls.Add(Label4)
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
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.IndianRed
        Label5.Location = New Point(70, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 12
        Label5.Text = "Keterangan Akun"
        ' 
        ' txtKet
        ' 
        txtKet.Location = New Point(60, 332)
        txtKet.Margin = New Padding(3, 4, 3, 4)
        txtKet.Name = "txtKet"
        txtKet.Size = New Size(150, 27)
        txtKet.TabIndex = 11
        ' 
        ' txtTipe
        ' 
        txtTipe.Enabled = False
        txtTipe.Location = New Point(60, 266)
        txtTipe.Margin = New Padding(3, 4, 3, 4)
        txtTipe.Name = "txtTipe"
        txtTipe.Size = New Size(150, 27)
        txtTipe.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.IndianRed
        Label4.Location = New Point(96, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 9
        Label4.Text = "TipeAkun"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.IndianRed
        Label3.Location = New Point(108, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 8
        Label3.Text = "Level"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.IndianRed
        Label2.Location = New Point(96, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 7
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Location = New Point(96, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 6
        Label1.Text = "Username"
        ' 
        ' dgvAkun
        ' 
        dgvAkun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAkun.GridColor = SystemColors.HighlightText
        dgvAkun.Location = New Point(273, 88)
        dgvAkun.Margin = New Padding(3, 4, 3, 4)
        dgvAkun.Name = "dgvAkun"
        dgvAkun.RowHeadersWidth = 51
        dgvAkun.Size = New Size(750, 360)
        dgvAkun.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.BackColor = Color.IndianRed
        btnSimpan.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ControlText
        btnSimpan.Location = New Point(70, 412)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(118, 47)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan Akun"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtLevel
        ' 
        txtLevel.Location = New Point(60, 211)
        txtLevel.Margin = New Padding(3, 4, 3, 4)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(150, 27)
        txtLevel.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(60, 156)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 27)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(60, 101)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 27)
        txtUsername.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.niga
        PictureBox1.Location = New Point(0, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1055, 513)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.ini_yang_benar
        PictureBox2.Location = New Point(-1, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1055, 227)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' MenuUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 650)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtKet As TextBox
    Friend WithEvents Label5 As Label

End Class
