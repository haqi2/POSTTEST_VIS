<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTglLahir = New Label()
        lblNomor = New Label()
        lblAlamat = New Label()
        lblJK = New Label()
        picPoster = New PictureBox()
        lblHobi = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.aslinya_2_
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(871, 605)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(459, 114)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(18, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "..."
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(459, 162)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(18, 20)
        lblUmur.TabIndex = 2
        lblUmur.Text = "..."
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Location = New Point(459, 210)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(18, 20)
        lblTglLahir.TabIndex = 3
        lblTglLahir.Text = "..."
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Location = New Point(459, 264)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(18, 20)
        lblNomor.TabIndex = 4
        lblNomor.Text = "..."
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(459, 320)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(18, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "..."
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(459, 369)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(18, 20)
        lblJK.TabIndex = 6
        lblJK.Text = "..."
        ' 
        ' picPoster
        ' 
        picPoster.Location = New Point(35, 188)
        picPoster.Margin = New Padding(3, 4, 3, 4)
        picPoster.Name = "picPoster"
        picPoster.Size = New Size(237, 176)
        picPoster.TabIndex = 7
        picPoster.TabStop = False
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(459, 421)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(18, 20)
        lblHobi.TabIndex = 8
        lblHobi.Text = "..."
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(lblHobi)
        Controls.Add(picPoster)
        Controls.Add(lblJK)
        Controls.Add(lblAlamat)
        Controls.Add(lblNomor)
        Controls.Add(lblTglLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents picPoster As PictureBox
    Friend WithEvents lblHobi As Label
End Class
