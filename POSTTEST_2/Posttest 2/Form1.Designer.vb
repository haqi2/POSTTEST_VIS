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
        txtTambahJudul = New TextBox()
        txtGenre = New TextBox()
        txtHapusJudul = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(93, 22)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(106, 23)
        txtTambahJudul.TabIndex = 0
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(93, 59)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(106, 23)
        txtGenre.TabIndex = 1
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(91, 40)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(112, 23)
        txtHapusJudul.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(93, 91)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(91, 85)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.BackgroundColor = SystemColors.ButtonFace
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvBuku.Location = New Point(199, 222)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(272, 174)
        dgvBuku.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.Name = "Column2"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.HighlightText
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(60, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(252, 134)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "TambahBuku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 5
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 4
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonHighlight
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Location = New Point(357, 48)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(252, 128)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "HapusBuku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 8
        Label3.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(850, 483)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dgvBuku)
        Name = "Form1"
        Text = "Posttest 2"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
