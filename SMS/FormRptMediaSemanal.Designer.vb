<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptMediaSemanal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptMediaSemanal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendarCorte = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbExportTempMedio = New System.Windows.Forms.ProgressBar()
        Me.ButtonGerar = New System.Windows.Forms.Button()
        Me.LabelExportStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(179, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Average Storage Time Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SMS.My.Resources.Resources.Logo_Geral
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendarCorte
        '
        Me.MonthCalendarCorte.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MonthCalendarCorte.Location = New System.Drawing.Point(422, 162)
        Me.MonthCalendarCorte.Name = "MonthCalendarCorte"
        Me.MonthCalendarCorte.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(316, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 64)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Select the cut date of the stock movements"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PbExportTempMedio
        '
        Me.PbExportTempMedio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbExportTempMedio.Location = New System.Drawing.Point(7, 406)
        Me.PbExportTempMedio.Name = "PbExportTempMedio"
        Me.PbExportTempMedio.Size = New System.Drawing.Size(1062, 23)
        Me.PbExportTempMedio.TabIndex = 66
        '
        'ButtonGerar
        '
        Me.ButtonGerar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonGerar.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonGerar.Location = New System.Drawing.Point(422, 349)
        Me.ButtonGerar.Name = "ButtonGerar"
        Me.ButtonGerar.Size = New System.Drawing.Size(233, 23)
        Me.ButtonGerar.TabIndex = 67
        Me.ButtonGerar.Text = "Generate Report"
        Me.ButtonGerar.UseVisualStyleBackColor = True
        '
        'LabelExportStatus
        '
        Me.LabelExportStatus.AutoSize = True
        Me.LabelExportStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelExportStatus.Location = New System.Drawing.Point(4, 390)
        Me.LabelExportStatus.Name = "LabelExportStatus"
        Me.LabelExportStatus.Size = New System.Drawing.Size(101, 13)
        Me.LabelExportStatus.TabIndex = 68
        Me.LabelExportStatus.Text = "Exporting row 1 of 1"
        Me.LabelExportStatus.Visible = False
        '
        'FormRptMediaSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1076, 441)
        Me.Controls.Add(Me.LabelExportStatus)
        Me.Controls.Add(Me.ButtonGerar)
        Me.Controls.Add(Me.PbExportTempMedio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthCalendarCorte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRptMediaSemanal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Average"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MonthCalendarCorte As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents PbExportTempMedio As ProgressBar
    Friend WithEvents ButtonGerar As Button
    Friend WithEvents LabelExportStatus As Label
End Class
