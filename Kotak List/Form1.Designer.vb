<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.listBulan = New System.Windows.Forms.ListBox()
        Me.listTahun = New System.Windows.Forms.ListBox()
        Me.tombolOK = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBulan
        '
        Me.listBulan.FormattingEnabled = True
        Me.listBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret ", "April ", "Mei ", "Juni ", "Juli ", "Agustus ", "September ", "Oktober ", "November ", "Desember"})
        Me.listBulan.Location = New System.Drawing.Point(13, 13)
        Me.listBulan.Name = "listBulan"
        Me.listBulan.Size = New System.Drawing.Size(121, 121)
        Me.listBulan.TabIndex = 0
        '
        'listTahun
        '
        Me.listTahun.FormattingEnabled = True
        Me.listTahun.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016"})
        Me.listTahun.Location = New System.Drawing.Point(151, 13)
        Me.listTahun.Name = "listTahun"
        Me.listTahun.Size = New System.Drawing.Size(121, 121)
        Me.listTahun.TabIndex = 1
        '
        'tombolOK
        '
        Me.tombolOK.Location = New System.Drawing.Point(13, 159)
        Me.tombolOK.Name = "tombolOK"
        Me.tombolOK.Size = New System.Drawing.Size(121, 31)
        Me.tombolOK.TabIndex = 2
        Me.tombolOK.Text = "OK"
        Me.tombolOK.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(151, 159)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(121, 31)
        Me.tombolReset.TabIndex = 3
        Me.tombolReset.Text = "Reset"
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 213)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolOK)
        Me.Controls.Add(Me.listTahun)
        Me.Controls.Add(Me.listBulan)
        Me.Name = "Form1"
        Me.Text = "Demo Kotak List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listBulan As System.Windows.Forms.ListBox
    Friend WithEvents listTahun As System.Windows.Forms.ListBox
    Friend WithEvents tombolOK As System.Windows.Forms.Button
    Friend WithEvents tombolReset As System.Windows.Forms.Button

End Class
