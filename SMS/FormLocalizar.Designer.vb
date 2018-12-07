<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLocalizar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLocalizar))
        Me.ButtonLocalizar = New System.Windows.Forms.Button()
        Me.ButtonProximo = New System.Windows.Forms.Button()
        Me.TextBoxFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonLocalizar
        '
        Me.ButtonLocalizar.Location = New System.Drawing.Point(237, 12)
        Me.ButtonLocalizar.Name = "ButtonLocalizar"
        Me.ButtonLocalizar.Size = New System.Drawing.Size(98, 23)
        Me.ButtonLocalizar.TabIndex = 0
        Me.ButtonLocalizar.Text = "Find"
        Me.ButtonLocalizar.UseVisualStyleBackColor = True
        '
        'ButtonProximo
        '
        Me.ButtonProximo.Location = New System.Drawing.Point(237, 41)
        Me.ButtonProximo.Name = "ButtonProximo"
        Me.ButtonProximo.Size = New System.Drawing.Size(98, 23)
        Me.ButtonProximo.TabIndex = 1
        Me.ButtonProximo.Text = "Find next"
        Me.ButtonProximo.UseVisualStyleBackColor = True
        '
        'TextBoxFiltro
        '
        Me.TextBoxFiltro.Location = New System.Drawing.Point(12, 28)
        Me.TextBoxFiltro.Name = "TextBoxFiltro"
        Me.TextBoxFiltro.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxFiltro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Criteria"
        '
        'Timer1
        '
        '
        'FormLocalizar
        '
        Me.AcceptButton = Me.ButtonLocalizar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 74)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFiltro)
        Me.Controls.Add(Me.ButtonProximo)
        Me.Controls.Add(Me.ButtonLocalizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLocalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonLocalizar As System.Windows.Forms.Button
    Friend WithEvents ButtonProximo As System.Windows.Forms.Button
    Friend WithEvents TextBoxFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
