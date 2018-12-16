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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadProducts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewProdutos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescriR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUnid = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnDimenA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMedA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnDminB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMedB = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnDimenC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMedC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipoP = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnQtdP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(578, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Cadastro de Produtos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProdutos)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1482, 389)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registration"
        '
        'DataGridViewProdutos
        '
        Me.DataGridViewProdutos.AllowUserToAddRows = False
        Me.DataGridViewProdutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProdutos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnIdCliente, Me.ColumnProduto, Me.ColumnDescriR, Me.ColumnDescriC, Me.ColumnUnid, Me.ColumnDimenA, Me.ColumnMedA, Me.ColumnDminB, Me.ColumnMedB, Me.ColumnDimenC, Me.ColumnMedC, Me.ColumnPeso, Me.ColumnTipoP, Me.ColumnQtdP})
        Me.DataGridViewProdutos.Location = New System.Drawing.Point(6, 43)
        Me.DataGridViewProdutos.Name = "DataGridViewProdutos"
        Me.DataGridViewProdutos.ReadOnly = True
        Me.DataGridViewProdutos.Size = New System.Drawing.Size(1470, 340)
        Me.DataGridViewProdutos.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExportarToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1476, 24)
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
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 617)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1482, 23)
        Me.ProgressBar.TabIndex = 65
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelStatus.Location = New System.Drawing.Point(15, 595)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelStatus.TabIndex = 66
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.Visible = False
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(15, 138)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(437, 21)
        Me.ComboBoxCliente.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(15, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Selecione o Cliente"
        Me.Label2.Visible = False
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "ID"
        Me.ColumnID.HeaderText = "Id"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'ColumnIdCliente
        '
        Me.ColumnIdCliente.DataPropertyName = "ID_CLIENTE"
        Me.ColumnIdCliente.HeaderText = "IdCliente"
        Me.ColumnIdCliente.Name = "ColumnIdCliente"
        Me.ColumnIdCliente.ReadOnly = True
        Me.ColumnIdCliente.Visible = False
        '
        'ColumnProduto
        '
        Me.ColumnProduto.DataPropertyName = "PRODUTO"
        Me.ColumnProduto.HeaderText = "Produto"
        Me.ColumnProduto.Name = "ColumnProduto"
        Me.ColumnProduto.ReadOnly = True
        Me.ColumnProduto.Width = 250
        '
        'ColumnDescriR
        '
        Me.ColumnDescriR.DataPropertyName = "DESCRI_RESUMIDA"
        Me.ColumnDescriR.HeaderText = "Descrição Resumida"
        Me.ColumnDescriR.Name = "ColumnDescriR"
        Me.ColumnDescriR.ReadOnly = True
        Me.ColumnDescriR.Width = 250
        '
        'ColumnDescriC
        '
        Me.ColumnDescriC.DataPropertyName = "DESCRI_COMPLETA"
        Me.ColumnDescriC.HeaderText = "Descrição Completa"
        Me.ColumnDescriC.Name = "ColumnDescriC"
        Me.ColumnDescriC.ReadOnly = True
        Me.ColumnDescriC.Width = 250
        '
        'ColumnUnid
        '
        Me.ColumnUnid.DataPropertyName = "ID_UNID_MED"
        Me.ColumnUnid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnUnid.HeaderText = "Unidade de Medida"
        Me.ColumnUnid.Name = "ColumnUnid"
        Me.ColumnUnid.ReadOnly = True
        Me.ColumnUnid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnUnid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnDimenA
        '
        Me.ColumnDimenA.DataPropertyName = "DIMENCAO_A"
        Me.ColumnDimenA.HeaderText = "Dimensão A"
        Me.ColumnDimenA.Name = "ColumnDimenA"
        Me.ColumnDimenA.ReadOnly = True
        '
        'ColumnMedA
        '
        Me.ColumnMedA.DataPropertyName = "ID_TIPO_DI_A"
        Me.ColumnMedA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnMedA.HeaderText = "Medida A"
        Me.ColumnMedA.Name = "ColumnMedA"
        Me.ColumnMedA.ReadOnly = True
        Me.ColumnMedA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnMedA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnDminB
        '
        Me.ColumnDminB.DataPropertyName = "DIMENCAO_B"
        Me.ColumnDminB.HeaderText = "Dimensão B"
        Me.ColumnDminB.Name = "ColumnDminB"
        Me.ColumnDminB.ReadOnly = True
        '
        'ColumnMedB
        '
        Me.ColumnMedB.DataPropertyName = "ID_TIPO_DI_B"
        Me.ColumnMedB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnMedB.HeaderText = "Medida B"
        Me.ColumnMedB.Name = "ColumnMedB"
        Me.ColumnMedB.ReadOnly = True
        Me.ColumnMedB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnMedB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnDimenC
        '
        Me.ColumnDimenC.DataPropertyName = "DIMENCAO_C"
        Me.ColumnDimenC.HeaderText = "Dimensão C"
        Me.ColumnDimenC.Name = "ColumnDimenC"
        Me.ColumnDimenC.ReadOnly = True
        '
        'ColumnMedC
        '
        Me.ColumnMedC.DataPropertyName = "ID_TIPO_DI_C"
        Me.ColumnMedC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnMedC.HeaderText = "Medida C"
        Me.ColumnMedC.Name = "ColumnMedC"
        Me.ColumnMedC.ReadOnly = True
        Me.ColumnMedC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnMedC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnPeso
        '
        Me.ColumnPeso.DataPropertyName = "PESO"
        Me.ColumnPeso.HeaderText = "Peso"
        Me.ColumnPeso.Name = "ColumnPeso"
        Me.ColumnPeso.ReadOnly = True
        '
        'ColumnTipoP
        '
        Me.ColumnTipoP.DataPropertyName = "ID_TIPO_PADRAO"
        Me.ColumnTipoP.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnTipoP.HeaderText = "Tipo Padrão"
        Me.ColumnTipoP.Name = "ColumnTipoP"
        Me.ColumnTipoP.ReadOnly = True
        Me.ColumnTipoP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnTipoP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnQtdP
        '
        Me.ColumnQtdP.DataPropertyName = "QTD_PADRAO"
        Me.ColumnQtdP.HeaderText = "Qtd Padrão"
        Me.ColumnQtdP.Name = "ColumnQtdP"
        Me.ColumnQtdP.ReadOnly = True
        '
        'FormCadProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1506, 652)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCliente)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormCadProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewProdutos As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F2AperteParaAbilitarAEdiçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnIdCliente As DataGridViewTextBoxColumn
    Friend WithEvents ColumnProduto As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescriR As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescriC As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUnid As DataGridViewComboBoxColumn
    Friend WithEvents ColumnDimenA As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMedA As DataGridViewComboBoxColumn
    Friend WithEvents ColumnDminB As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMedB As DataGridViewComboBoxColumn
    Friend WithEvents ColumnDimenC As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMedC As DataGridViewComboBoxColumn
    Friend WithEvents ColumnPeso As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipoP As DataGridViewComboBoxColumn
    Friend WithEvents ColumnQtdP As DataGridViewTextBoxColumn
End Class
