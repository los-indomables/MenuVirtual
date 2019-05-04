<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComentar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMal = New System.Windows.Forms.Button()
        Me.BtnRegular = New System.Windows.Forms.Button()
        Me.BtnBien = New System.Windows.Forms.Button()
        Me.BtnExelente = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(39, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(522, 42)
        Me.TextBox1.TabIndex = 0
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(123, 77)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviar.TabIndex = 1
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(432, 77)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnMal)
        Me.Panel1.Controls.Add(Me.BtnRegular)
        Me.Panel1.Controls.Add(Me.BtnBien)
        Me.Panel1.Controls.Add(Me.BtnExelente)
        Me.Panel1.Location = New System.Drawing.Point(12, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 111)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Regular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bien"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Exelente"
        '
        'BtnMal
        '
        Me.BtnMal.FlatAppearance.BorderSize = 0
        Me.BtnMal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMal.Image = Global.MenuVirtual.My.Resources.Resources.triste
        Me.BtnMal.Location = New System.Drawing.Point(453, 18)
        Me.BtnMal.Name = "BtnMal"
        Me.BtnMal.Size = New System.Drawing.Size(70, 64)
        Me.BtnMal.TabIndex = 3
        Me.BtnMal.UseVisualStyleBackColor = True
        '
        'BtnRegular
        '
        Me.BtnRegular.FlatAppearance.BorderSize = 0
        Me.BtnRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegular.Image = Global.MenuVirtual.My.Resources.Resources.sorprendido
        Me.BtnRegular.Location = New System.Drawing.Point(320, 18)
        Me.BtnRegular.Name = "BtnRegular"
        Me.BtnRegular.Size = New System.Drawing.Size(70, 64)
        Me.BtnRegular.TabIndex = 2
        Me.BtnRegular.UseVisualStyleBackColor = True
        '
        'BtnBien
        '
        Me.BtnBien.FlatAppearance.BorderSize = 0
        Me.BtnBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBien.Image = Global.MenuVirtual.My.Resources.Resources.feliz2
        Me.BtnBien.Location = New System.Drawing.Point(197, 18)
        Me.BtnBien.Name = "BtnBien"
        Me.BtnBien.Size = New System.Drawing.Size(70, 64)
        Me.BtnBien.TabIndex = 1
        Me.BtnBien.UseVisualStyleBackColor = True
        '
        'BtnExelente
        '
        Me.BtnExelente.FlatAppearance.BorderSize = 0
        Me.BtnExelente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExelente.Image = Global.MenuVirtual.My.Resources.Resources.feliz
        Me.BtnExelente.Location = New System.Drawing.Point(68, 18)
        Me.BtnExelente.Name = "BtnExelente"
        Me.BtnExelente.Size = New System.Drawing.Size(70, 64)
        Me.BtnExelente.TabIndex = 0
        Me.BtnExelente.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.BtnEnviar)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Location = New System.Drawing.Point(12, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 107)
        Me.Panel2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Clarendon", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Comentario"
        '
        'FrmComentar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmComentar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valoracion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMal As Button
    Friend WithEvents BtnRegular As Button
    Friend WithEvents BtnBien As Button
    Friend WithEvents BtnExelente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
End Class
