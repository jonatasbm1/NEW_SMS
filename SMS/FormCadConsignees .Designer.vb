<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadConsignees
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadConsignees))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPagePesquisa = New System.Windows.Forms.TabPage()
        Me.DataGridViewConsignees = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LocalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageCad = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDescricao = New System.Windows.Forms.TextBox()
        Me.ComboBoxConsignees = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonCancelarCad = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxParceiro = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.NovoCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewContact = New System.Windows.Forms.DataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFuncao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelefone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelefone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelefone3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewAdress = New System.Windows.Forms.DataGridView()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ColumnAid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnANome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnANumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAComplemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnABairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnACidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnATel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnATel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnATel3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnConsigness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescrConsig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPagePesquisa.SuspendLayout()
        CType(Me.DataGridViewConsignees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPageCad.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewAdress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(484, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Consignees Record"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TabControl)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1343, 327)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consignees Data"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPageCad)
        Me.TabControl.Controls.Add(Me.TabPagePesquisa)
        Me.TabControl.Location = New System.Drawing.Point(6, 19)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1331, 302)
        Me.TabControl.TabIndex = 0
        '
        'TabPagePesquisa
        '
        Me.TabPagePesquisa.Controls.Add(Me.DataGridViewConsignees)
        Me.TabPagePesquisa.Controls.Add(Me.MenuStrip1)
        Me.TabPagePesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePesquisa.Name = "TabPagePesquisa"
        Me.TabPagePesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePesquisa.Size = New System.Drawing.Size(1323, 276)
        Me.TabPagePesquisa.TabIndex = 1
        Me.TabPagePesquisa.Text = "Search"
        Me.TabPagePesquisa.UseVisualStyleBackColor = True
        '
        'DataGridViewConsignees
        '
        Me.DataGridViewConsignees.AllowUserToAddRows = False
        Me.DataGridViewConsignees.AllowUserToDeleteRows = False
        Me.DataGridViewConsignees.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewConsignees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewConsignees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewConsignees.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewConsignees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConsignees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCid, Me.ColumnConsigness, Me.ColumnDescrConsig})
        Me.DataGridViewConsignees.Location = New System.Drawing.Point(3, 30)
        Me.DataGridViewConsignees.Name = "DataGridViewConsignees"
        Me.DataGridViewConsignees.ReadOnly = True
        Me.DataGridViewConsignees.Size = New System.Drawing.Size(1314, 240)
        Me.DataGridViewConsignees.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalizarToolStripMenuItem, Me.ToolStripMenuItem2, Me.FiltrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1317, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LocalizarToolStripMenuItem
        '
        Me.LocalizarToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_localizar_e_substituir_40
        Me.LocalizarToolStripMenuItem.Name = "LocalizarToolStripMenuItem"
        Me.LocalizarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LocalizarToolStripMenuItem.Text = "Find"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'FiltrarToolStripMenuItem
        '
        Me.FiltrarToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_filtro_40
        Me.FiltrarToolStripMenuItem.Name = "FiltrarToolStripMenuItem"
        Me.FiltrarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FiltrarToolStripMenuItem.Text = "Filter"
        '
        'TabPageCad
        '
        Me.TabPageCad.Controls.Add(Me.Label3)
        Me.TabPageCad.Controls.Add(Me.TextBoxDescricao)
        Me.TabPageCad.Controls.Add(Me.ComboBoxConsignees)
        Me.TabPageCad.Controls.Add(Me.Label6)
        Me.TabPageCad.Controls.Add(Me.ButtonCancelarCad)
        Me.TabPageCad.Controls.Add(Me.ButtonSalvar)
        Me.TabPageCad.Controls.Add(Me.ComboBoxCliente)
        Me.TabPageCad.Controls.Add(Me.Label2)
        Me.TabPageCad.Controls.Add(Me.TextBoxParceiro)
        Me.TabPageCad.Controls.Add(Me.MenuStrip2)
        Me.TabPageCad.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCad.Name = "TabPageCad"
        Me.TabPageCad.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCad.Size = New System.Drawing.Size(1323, 276)
        Me.TabPageCad.TabIndex = 0
        Me.TabPageCad.Text = "Registration / Editing"
        Me.TabPageCad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Consignees description"
        '
        'TextBoxDescricao
        '
        Me.TextBoxDescricao.Enabled = False
        Me.TextBoxDescricao.Location = New System.Drawing.Point(6, 157)
        Me.TextBoxDescricao.Multiline = True
        Me.TextBoxDescricao.Name = "TextBoxDescricao"
        Me.TextBoxDescricao.Size = New System.Drawing.Size(317, 100)
        Me.TextBoxDescricao.TabIndex = 67
        '
        'ComboBoxConsignees
        '
        Me.ComboBoxConsignees.FormattingEnabled = True
        Me.ComboBoxConsignees.Location = New System.Drawing.Point(9, 108)
        Me.ComboBoxConsignees.Name = "ComboBoxConsignees"
        Me.ComboBoxConsignees.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxConsignees.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Customer"
        '
        'ButtonCancelarCad
        '
        Me.ButtonCancelarCad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonCancelarCad.Enabled = False
        Me.ButtonCancelarCad.Location = New System.Drawing.Point(567, 234)
        Me.ButtonCancelarCad.Name = "ButtonCancelarCad"
        Me.ButtonCancelarCad.Size = New System.Drawing.Size(189, 23)
        Me.ButtonCancelarCad.TabIndex = 11
        Me.ButtonCancelarCad.Text = "Undo / Editing"
        Me.ButtonCancelarCad.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSalvar.Enabled = False
        Me.ButtonSalvar.Location = New System.Drawing.Point(567, 205)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(189, 23)
        Me.ButtonSalvar.TabIndex = 10
        Me.ButtonSalvar.Text = "Salve"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(9, 64)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxCliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Consignee"
        '
        'TextBoxParceiro
        '
        Me.TextBoxParceiro.Location = New System.Drawing.Point(6, 108)
        Me.TextBoxParceiro.Name = "TextBoxParceiro"
        Me.TextBoxParceiro.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxParceiro.TabIndex = 0
        Me.TextBoxParceiro.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoCadastroToolStripMenuItem, Me.ToolStripMenuItem1, Me.EditarToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExcluirToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1317, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'NovoCadastroToolStripMenuItem
        '
        Me.NovoCadastroToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_adicionar_48
        Me.NovoCadastroToolStripMenuItem.Name = "NovoCadastroToolStripMenuItem"
        Me.NovoCadastroToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.NovoCadastroToolStripMenuItem.Text = "New Record"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_editar_64
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EditarToolStripMenuItem.Text = "Edit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem3.Text = "|"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_cancelar_48
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ExcluirToolStripMenuItem.Text = "Delete"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.MenuStrip3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1346, 299)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consignees Contacts"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1334, 250)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewContact)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1326, 224)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consignee Contacts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewContact
        '
        Me.DataGridViewContact.AllowUserToAddRows = False
        Me.DataGridViewContact.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewContact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewContact.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNome, Me.ColumnFuncao, Me.ColumnEmail, Me.ColumnTelefone1, Me.ColumnTelefone2, Me.ColumnTelefone3})
        Me.DataGridViewContact.Location = New System.Drawing.Point(3, 6)
        Me.DataGridViewContact.Name = "DataGridViewContact"
        Me.DataGridViewContact.ReadOnly = True
        Me.DataGridViewContact.Size = New System.Drawing.Size(1320, 212)
        Me.DataGridViewContact.TabIndex = 2
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "ID"
        Me.ColumnID.HeaderText = "Id"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'ColumnNome
        '
        Me.ColumnNome.DataPropertyName = "NOME"
        Me.ColumnNome.HeaderText = "Name"
        Me.ColumnNome.Name = "ColumnNome"
        Me.ColumnNome.ReadOnly = True
        Me.ColumnNome.Width = 250
        '
        'ColumnFuncao
        '
        Me.ColumnFuncao.DataPropertyName = "FUNCAO"
        Me.ColumnFuncao.HeaderText = "Position"
        Me.ColumnFuncao.Name = "ColumnFuncao"
        Me.ColumnFuncao.ReadOnly = True
        Me.ColumnFuncao.Width = 250
        '
        'ColumnEmail
        '
        Me.ColumnEmail.DataPropertyName = "EMAIL"
        Me.ColumnEmail.HeaderText = "Email Address"
        Me.ColumnEmail.Name = "ColumnEmail"
        Me.ColumnEmail.ReadOnly = True
        Me.ColumnEmail.Width = 200
        '
        'ColumnTelefone1
        '
        Me.ColumnTelefone1.DataPropertyName = "TEL1"
        Me.ColumnTelefone1.HeaderText = "Phone number 1"
        Me.ColumnTelefone1.Name = "ColumnTelefone1"
        Me.ColumnTelefone1.ReadOnly = True
        Me.ColumnTelefone1.Width = 200
        '
        'ColumnTelefone2
        '
        Me.ColumnTelefone2.DataPropertyName = "TEL2"
        Me.ColumnTelefone2.HeaderText = "Phone number 2"
        Me.ColumnTelefone2.Name = "ColumnTelefone2"
        Me.ColumnTelefone2.ReadOnly = True
        Me.ColumnTelefone2.Width = 200
        '
        'ColumnTelefone3
        '
        Me.ColumnTelefone3.DataPropertyName = "TEL3"
        Me.ColumnTelefone3.HeaderText = "Phone number 3"
        Me.ColumnTelefone3.Name = "ColumnTelefone3"
        Me.ColumnTelefone3.ReadOnly = True
        Me.ColumnTelefone3.Width = 200
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewAdress)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1326, 224)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Address to deliver"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewAdress
        '
        Me.DataGridViewAdress.AllowUserToAddRows = False
        Me.DataGridViewAdress.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewAdress.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewAdress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAdress.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAdress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnAid, Me.ColumnANome, Me.ColumnAEndereco, Me.ColumnANumero, Me.ColumnAComplemento, Me.ColumnABairro, Me.ColumnACidade, Me.ColumnAEstado, Me.ColumnAEmail, Me.ColumnATel1, Me.ColumnATel2, Me.ColumnATel3, Me.ColumnObs})
        Me.DataGridViewAdress.Location = New System.Drawing.Point(3, 6)
        Me.DataGridViewAdress.Name = "DataGridViewAdress"
        Me.DataGridViewAdress.ReadOnly = True
        Me.DataGridViewAdress.Size = New System.Drawing.Size(1320, 212)
        Me.DataGridViewAdress.TabIndex = 3
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem, Me.ToolStripMenuItem4, Me.ExportarToolStripMenuItem, Me.ToolStripMenuItem5})
        Me.MenuStrip3.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1340, 24)
        Me.MenuStrip3.TabIndex = 3
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'F2AperteParaAbilitarAEdiçãoToolStripMenuItem
        '
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_toque_100
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Name = "F2AperteParaAbilitarAEdiçãoToolStripMenuItem"
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Size = New System.Drawing.Size(177, 20)
        Me.F2AperteParaAbilitarAEdiçãoToolStripMenuItem.Text = "F3 - Press to Enable Editing"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem4.Text = "|"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.SMS.My.Resources.Resources.icons8_ms_excel_48
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ExportarToolStripMenuItem.Text = "Export Crt+E"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem5.Text = "|"
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
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.LabelStatus)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1355, 691)
        Me.Panel1.TabIndex = 66
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelStatus.Location = New System.Drawing.Point(6, 638)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelStatus.TabIndex = 67
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(6, 654)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1340, 23)
        Me.ProgressBar.TabIndex = 66
        '
        'ColumnAid
        '
        Me.ColumnAid.DataPropertyName = "ID"
        Me.ColumnAid.HeaderText = "Id"
        Me.ColumnAid.Name = "ColumnAid"
        Me.ColumnAid.ReadOnly = True
        Me.ColumnAid.Visible = False
        '
        'ColumnANome
        '
        Me.ColumnANome.DataPropertyName = "NAME"
        Me.ColumnANome.HeaderText = "Consignee Name"
        Me.ColumnANome.Name = "ColumnANome"
        Me.ColumnANome.ReadOnly = True
        Me.ColumnANome.Width = 250
        '
        'ColumnAEndereco
        '
        Me.ColumnAEndereco.DataPropertyName = "ENDERECO"
        Me.ColumnAEndereco.HeaderText = "Address"
        Me.ColumnAEndereco.Name = "ColumnAEndereco"
        Me.ColumnAEndereco.ReadOnly = True
        Me.ColumnAEndereco.Width = 250
        '
        'ColumnANumero
        '
        Me.ColumnANumero.DataPropertyName = "NUMERO"
        Me.ColumnANumero.HeaderText = "Number"
        Me.ColumnANumero.Name = "ColumnANumero"
        Me.ColumnANumero.ReadOnly = True
        Me.ColumnANumero.Width = 50
        '
        'ColumnAComplemento
        '
        Me.ColumnAComplemento.DataPropertyName = "COMPLEMENTO"
        Me.ColumnAComplemento.HeaderText = "Complement"
        Me.ColumnAComplemento.Name = "ColumnAComplemento"
        Me.ColumnAComplemento.ReadOnly = True
        Me.ColumnAComplemento.Width = 150
        '
        'ColumnABairro
        '
        Me.ColumnABairro.DataPropertyName = "BAIRRO"
        Me.ColumnABairro.HeaderText = "Suburb"
        Me.ColumnABairro.Name = "ColumnABairro"
        Me.ColumnABairro.ReadOnly = True
        Me.ColumnABairro.Width = 150
        '
        'ColumnACidade
        '
        Me.ColumnACidade.DataPropertyName = "CIDADE"
        Me.ColumnACidade.HeaderText = "City"
        Me.ColumnACidade.Name = "ColumnACidade"
        Me.ColumnACidade.ReadOnly = True
        Me.ColumnACidade.Width = 150
        '
        'ColumnAEstado
        '
        Me.ColumnAEstado.DataPropertyName = "ESTADO"
        Me.ColumnAEstado.HeaderText = "Estado"
        Me.ColumnAEstado.Name = "ColumnAEstado"
        Me.ColumnAEstado.ReadOnly = True
        Me.ColumnAEstado.Visible = False
        Me.ColumnAEstado.Width = 150
        '
        'ColumnAEmail
        '
        Me.ColumnAEmail.DataPropertyName = "EMAIL"
        Me.ColumnAEmail.HeaderText = "Email Address"
        Me.ColumnAEmail.Name = "ColumnAEmail"
        Me.ColumnAEmail.ReadOnly = True
        Me.ColumnAEmail.Width = 200
        '
        'ColumnATel1
        '
        Me.ColumnATel1.DataPropertyName = "TEL1"
        Me.ColumnATel1.HeaderText = "Phone number 1"
        Me.ColumnATel1.Name = "ColumnATel1"
        Me.ColumnATel1.ReadOnly = True
        Me.ColumnATel1.Width = 200
        '
        'ColumnATel2
        '
        Me.ColumnATel2.DataPropertyName = "TEL2"
        Me.ColumnATel2.HeaderText = "Phone number 2"
        Me.ColumnATel2.Name = "ColumnATel2"
        Me.ColumnATel2.ReadOnly = True
        Me.ColumnATel2.Width = 200
        '
        'ColumnATel3
        '
        Me.ColumnATel3.DataPropertyName = "TEL3"
        Me.ColumnATel3.HeaderText = "Phone number 3"
        Me.ColumnATel3.Name = "ColumnATel3"
        Me.ColumnATel3.ReadOnly = True
        Me.ColumnATel3.Width = 200
        '
        'ColumnObs
        '
        Me.ColumnObs.DataPropertyName = "OBS"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnObs.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnObs.HeaderText = "Notes / References"
        Me.ColumnObs.Name = "ColumnObs"
        Me.ColumnObs.ReadOnly = True
        Me.ColumnObs.Width = 300
        '
        'ColumnCid
        '
        Me.ColumnCid.DataPropertyName = "ID"
        Me.ColumnCid.HeaderText = "id"
        Me.ColumnCid.Name = "ColumnCid"
        Me.ColumnCid.ReadOnly = True
        Me.ColumnCid.Visible = False
        '
        'ColumnConsigness
        '
        Me.ColumnConsigness.DataPropertyName = "NOME"
        Me.ColumnConsigness.HeaderText = "Consignees"
        Me.ColumnConsigness.Name = "ColumnConsigness"
        Me.ColumnConsigness.ReadOnly = True
        Me.ColumnConsigness.Width = 300
        '
        'ColumnDescrConsig
        '
        Me.ColumnDescrConsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDescrConsig.DataPropertyName = "DESCRICAO"
        Me.ColumnDescrConsig.HeaderText = "Consignees Description"
        Me.ColumnDescrConsig.Name = "ColumnDescrConsig"
        Me.ColumnDescrConsig.ReadOnly = True
        '
        'FormCadConsignees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1369, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormCadConsignees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consignees record"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPagePesquisa.ResumeLayout(False)
        Me.TabPagePesquisa.PerformLayout()
        CType(Me.DataGridViewConsignees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPageCad.ResumeLayout(False)
        Me.TabPageCad.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewAdress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageCad As TabPage
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxParceiro As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents NovoCadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPagePesquisa As TabPage
    Friend WithEvents DataGridViewConsignees As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FiltrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LocalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewContact As DataGridView
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents F2AperteParaAbilitarAEdiçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonCancelarCad As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNome As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFuncao As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEmail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelefone1 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelefone2 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelefone3 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewAdress As DataGridView
    Friend WithEvents ComboBoxConsignees As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDescricao As TextBox
    Friend WithEvents ColumnAid As DataGridViewTextBoxColumn
    Friend WithEvents ColumnANome As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAEndereco As DataGridViewTextBoxColumn
    Friend WithEvents ColumnANumero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAComplemento As DataGridViewTextBoxColumn
    Friend WithEvents ColumnABairro As DataGridViewTextBoxColumn
    Friend WithEvents ColumnACidade As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAEstado As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAEmail As DataGridViewTextBoxColumn
    Friend WithEvents ColumnATel1 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnATel2 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnATel3 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnObs As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCid As DataGridViewTextBoxColumn
    Friend WithEvents ColumnConsigness As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescrConsig As DataGridViewTextBoxColumn
End Class
