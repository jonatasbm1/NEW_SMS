<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIEntrada
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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


    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIEntrada))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadeDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesDosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CritérioDeTaxaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColsultaGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaisDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PensarEmMaisConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosGerenciaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeCobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PensarEmMaisRelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.TesteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ProdutosToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.CadastroToolStripMenuItem.Text = "Register"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadeDeMedidaToolStripMenuItem, Me.TiposToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ClientesDosClientesToolStripMenuItem, Me.CritérioDeTaxaToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SistemaToolStripMenuItem.Text = "System"
        '
        'UnidadeDeMedidaToolStripMenuItem
        '
        Me.UnidadeDeMedidaToolStripMenuItem.Name = "UnidadeDeMedidaToolStripMenuItem"
        Me.UnidadeDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UnidadeDeMedidaToolStripMenuItem.Text = "UQ"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TiposToolStripMenuItem.Text = "Type"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ClientesToolStripMenuItem.Text = "Customers"
        '
        'ClientesDosClientesToolStripMenuItem
        '
        Me.ClientesDosClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ClientesDosClientesToolStripMenuItem.Name = "ClientesDosClientesToolStripMenuItem"
        Me.ClientesDosClientesToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ClientesDosClientesToolStripMenuItem.Text = "Consignees"
        '
        'CritérioDeTaxaToolStripMenuItem
        '
        Me.CritérioDeTaxaToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.CritérioDeTaxaToolStripMenuItem.Name = "CritérioDeTaxaToolStripMenuItem"
        Me.CritérioDeTaxaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CritérioDeTaxaToolStripMenuItem.Text = "Charges Criteria"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProdutosToolStripMenuItem.Text = "Products"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColsultaGeralToolStripMenuItem, Me.LocaisDeEstoqueToolStripMenuItem, Me.PensarEmMaisConsultasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ConsultasToolStripMenuItem.Text = "Warehouse"
        '
        'ColsultaGeralToolStripMenuItem
        '
        Me.ColsultaGeralToolStripMenuItem.Name = "ColsultaGeralToolStripMenuItem"
        Me.ColsultaGeralToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ColsultaGeralToolStripMenuItem.Text = "Registration / Item Inquiry"
        '
        'LocaisDeEstoqueToolStripMenuItem
        '
        Me.LocaisDeEstoqueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LocaisDeEstoqueToolStripMenuItem.Name = "LocaisDeEstoqueToolStripMenuItem"
        Me.LocaisDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.LocaisDeEstoqueToolStripMenuItem.Text = "Location"
        '
        'PensarEmMaisConsultasToolStripMenuItem
        '
        Me.PensarEmMaisConsultasToolStripMenuItem.Name = "PensarEmMaisConsultasToolStripMenuItem"
        Me.PensarEmMaisConsultasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.PensarEmMaisConsultasToolStripMenuItem.Text = "???"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatóriosGerenciaisToolStripMenuItem, Me.RelatóriosDeCobrançaToolStripMenuItem, Me.PensarEmMaisRelatóriosToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Reports"
        '
        'RelatóriosGerenciaisToolStripMenuItem
        '
        Me.RelatóriosGerenciaisToolStripMenuItem.Name = "RelatóriosGerenciaisToolStripMenuItem"
        Me.RelatóriosGerenciaisToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.RelatóriosGerenciaisToolStripMenuItem.Text = "Storage Average Report"
        '
        'RelatóriosDeCobrançaToolStripMenuItem
        '
        Me.RelatóriosDeCobrançaToolStripMenuItem.Name = "RelatóriosDeCobrançaToolStripMenuItem"
        Me.RelatóriosDeCobrançaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.RelatóriosDeCobrançaToolStripMenuItem.Text = "Invoices"
        '
        'PensarEmMaisRelatóriosToolStripMenuItem
        '
        Me.PensarEmMaisRelatóriosToolStripMenuItem.Name = "PensarEmMaisRelatóriosToolStripMenuItem"
        Me.PensarEmMaisRelatóriosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PensarEmMaisRelatóriosToolStripMenuItem.Text = "???"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TesteToolStripMenuItem.Text = "Test"
        Me.TesteToolStripMenuItem.Visible = False
        '
        'MDIEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SMS.My.Resources.Resources.novo_plano_de_fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 741)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSR Stock Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadeDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColsultaGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PensarEmMaisConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosGerenciaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosDeCobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PensarEmMaisRelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesDosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocaisDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CritérioDeTaxaToolStripMenuItem As ToolStripMenuItem
End Class
