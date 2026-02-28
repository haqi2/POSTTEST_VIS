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
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblRanking = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(234, 175)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(95, 28)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(353, 176)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(95, 26)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(166, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 2
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(166, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 3
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblRanking
        ' 
        lblRanking.AutoSize = True
        lblRanking.Location = New Point(319, 273)
        lblRanking.Name = "lblRanking"
        lblRanking.Size = New Size(76, 20)
        lblRanking.TabIndex = 4
        lblRanking.Text = "Predikat :-"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(271, 138)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(160, 27)
        txtIPS.TabIndex = 5
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(271, 217)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(160, 27)
        txtIPK.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 446)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(lblRanking)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRanking As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox

End Class
