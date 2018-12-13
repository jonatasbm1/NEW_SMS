<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadProducts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadUq))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewUq = New System.Windows.Forms.DataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewUq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(177, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "UQ Record"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewUq)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 309)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registration"
        '
        'DataGridViewUq
        '
        Me.DataGridViewUq.AllowUserToAddRows = False
        Me.DataGridViewUq.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewUq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUq.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewUq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnUq, Me.ColumnDescri})
        Me.DataGridViewUq.Location = New System.Drawing.Point(6, 43)
        Me.DataGridViewUq.Name = "DataGridViewUq"
        Me.DataGridViewUq.ReadOnly = True
        Me.DataGridViewUq.Size = New System.Drawing.Size(526, 260)
        Me.DataGridViewUq.TabIndex = 0
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "ID"
        Me.ColumnID.HeaderText = "Id"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'ColumnUq
        '
        Me.ColumnUq.DataPropertyName = "UQ"
        Me.ColumnUq.HeaderText = "UQ"
        Me.ColumnUq.Name = "ColumnUq"
        Me.ColumnUq.ReadOnly = True
        '
        'ColumnDescri
        '
        Me.ColumnDescri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDescri.DataPropertyName = "DESCRIPTION"
        Me.ColumnDescri.HeaderText = "Description"
        Me.ColumnDescri.Name = "ColumnDescri"
        Me.ColumnDescri.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExportarToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'F2AperteParaAbilitarAEdiçãoToolStripMenuItem
        '
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_toque_100
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Name = "F2AperteParaAbilitarAEdiçãoToolStripMenuItem"
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Size = New System.Drawing.Size(177, 20)
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Text = "F3 - Press to Enable Editing"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_ms_excel_48
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ExportarToolStripMenuItem.Text = "Export Crt+E"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
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
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 463)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(634, 23)
        Me.ProgressBar.TabIndex = 65
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelStatus.Location = New System.Drawing.Point(12, 447)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelStatus.TabIndex = 66
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.Visible = False
        '
        'FormCadUq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(658, 498)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormCadUq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UQ Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewUq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewUq As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F2AperteParaAbilitarAEdiçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUq As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescri As DataGridViewTextBoxColumn
End Class
