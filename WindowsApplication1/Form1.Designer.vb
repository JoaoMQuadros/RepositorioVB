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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlunoNome = New System.Windows.Forms.TextBox()
        Me.btnConfirmaNome = New System.Windows.Forms.Button()
        Me.btnPesquisaAluno = New System.Windows.Forms.Button()
        Me.btnDeletarAluno = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.btnLimpaNota = New System.Windows.Forms.Button()
        Me.btnConfirmaNota = New System.Windows.Forms.Button()
        Me.txtPor = New System.Windows.Forms.TextBox()
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.txtFis = New System.Windows.Forms.TextBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDeletarAluno)
        Me.GroupBox1.Controls.Add(Me.btnPesquisaAluno)
        Me.GroupBox1.Controls.Add(Me.btnConfirmaNome)
        Me.GroupBox1.Controls.Add(Me.txtAlunoNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aluno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFis)
        Me.GroupBox2.Controls.Add(Me.txtArt)
        Me.GroupBox2.Controls.Add(Me.txtPor)
        Me.GroupBox2.Controls.Add(Me.btnLimpaNota)
        Me.GroupBox2.Controls.Add(Me.btnConfirmaNota)
        Me.GroupBox2.Controls.Add(Me.txtMat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvResultado)
        Me.GroupBox3.Location = New System.Drawing.Point(475, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 421)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exibe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Aluno :"
        '
        'txtAlunoNome
        '
        Me.txtAlunoNome.Location = New System.Drawing.Point(9, 53)
        Me.txtAlunoNome.Name = "txtAlunoNome"
        Me.txtAlunoNome.Size = New System.Drawing.Size(442, 20)
        Me.txtAlunoNome.TabIndex = 1
        '
        'btnConfirmaNome
        '
        Me.btnConfirmaNome.Location = New System.Drawing.Point(391, 178)
        Me.btnConfirmaNome.Name = "btnConfirmaNome"
        Me.btnConfirmaNome.Size = New System.Drawing.Size(60, 21)
        Me.btnConfirmaNome.TabIndex = 2
        Me.btnConfirmaNome.Text = "OK"
        Me.btnConfirmaNome.UseVisualStyleBackColor = True
        '
        'btnPesquisaAluno
        '
        Me.btnPesquisaAluno.Location = New System.Drawing.Point(325, 178)
        Me.btnPesquisaAluno.Name = "btnPesquisaAluno"
        Me.btnPesquisaAluno.Size = New System.Drawing.Size(60, 21)
        Me.btnPesquisaAluno.TabIndex = 3
        Me.btnPesquisaAluno.Text = "Pesquisa"
        Me.btnPesquisaAluno.UseVisualStyleBackColor = True
        '
        'btnDeletarAluno
        '
        Me.btnDeletarAluno.Location = New System.Drawing.Point(259, 178)
        Me.btnDeletarAluno.Name = "btnDeletarAluno"
        Me.btnDeletarAluno.Size = New System.Drawing.Size(60, 21)
        Me.btnDeletarAluno.TabIndex = 4
        Me.btnDeletarAluno.Text = "Deleta"
        Me.btnDeletarAluno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Matemática : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Português : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Artes : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fisíca : "
        '
        'txtMat
        '
        Me.txtMat.Location = New System.Drawing.Point(6, 70)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(60, 20)
        Me.txtMat.TabIndex = 9
        '
        'btnLimpaNota
        '
        Me.btnLimpaNota.Location = New System.Drawing.Point(325, 183)
        Me.btnLimpaNota.Name = "btnLimpaNota"
        Me.btnLimpaNota.Size = New System.Drawing.Size(60, 21)
        Me.btnLimpaNota.TabIndex = 6
        Me.btnLimpaNota.Text = "Limpar"
        Me.btnLimpaNota.UseVisualStyleBackColor = True
        '
        'btnConfirmaNota
        '
        Me.btnConfirmaNota.Location = New System.Drawing.Point(391, 183)
        Me.btnConfirmaNota.Name = "btnConfirmaNota"
        Me.btnConfirmaNota.Size = New System.Drawing.Size(60, 21)
        Me.btnConfirmaNota.TabIndex = 5
        Me.btnConfirmaNota.Text = "OK"
        Me.btnConfirmaNota.UseVisualStyleBackColor = True
        '
        'txtPor
        '
        Me.txtPor.Location = New System.Drawing.Point(120, 70)
        Me.txtPor.Name = "txtPor"
        Me.txtPor.Size = New System.Drawing.Size(60, 20)
        Me.txtPor.TabIndex = 10
        '
        'txtArt
        '
        Me.txtArt.Location = New System.Drawing.Point(234, 70)
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New System.Drawing.Size(60, 20)
        Me.txtArt.TabIndex = 11
        '
        'txtFis
        '
        Me.txtFis.Location = New System.Drawing.Point(332, 70)
        Me.txtFis.Name = "txtFis"
        Me.txtFis.Size = New System.Drawing.Size(60, 20)
        Me.txtFis.TabIndex = 12
        '
        'dgvResultado
        '
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResultado.Location = New System.Drawing.Point(3, 16)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(474, 402)
        Me.dgvResultado.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 445)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDeletarAluno As Button
    Friend WithEvents btnPesquisaAluno As Button
    Friend WithEvents btnConfirmaNome As Button
    Friend WithEvents txtAlunoNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtFis As TextBox
    Friend WithEvents txtArt As TextBox
    Friend WithEvents txtPor As TextBox
    Friend WithEvents btnLimpaNota As Button
    Friend WithEvents btnConfirmaNota As Button
    Friend WithEvents txtMat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvResultado As DataGridView
End Class
