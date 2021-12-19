<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVNama = New System.Windows.Forms.ListView()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'LVNama
        '
        Me.LVNama.Location = New System.Drawing.Point(12, 67)
        Me.LVNama.Name = "LVNama"
        Me.LVNama.Size = New System.Drawing.Size(261, 137)
        Me.LVNama.TabIndex = 1
        Me.LVNama.UseCompatibleStateImageBehavior = False
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(59, 29)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(214, 23)
        Me.tbNama.TabIndex = 2
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(12, 228)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(103, 38)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(170, 228)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(103, 38)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 278)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.LVNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LVNama As ListView
    Friend WithEvents tbNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKeluar As Button
End Class
