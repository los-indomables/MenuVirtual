<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.PnMenu = New System.Windows.Forms.Panel()
        Me.Lblebidas = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnContenedor = New System.Windows.Forms.Panel()
        Me.BtnComentario = New System.Windows.Forms.Button()
        Me.BtnMesero = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnBebidas = New System.Windows.Forms.Button()
        Me.BtnComida = New System.Windows.Forms.Button()
        Me.PnMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnMenu
        '
        Me.PnMenu.BackColor = System.Drawing.Color.BurlyWood
        Me.PnMenu.Controls.Add(Me.Button3)
        Me.PnMenu.Controls.Add(Me.BtnBebidas)
        Me.PnMenu.Controls.Add(Me.BtnComida)
        Me.PnMenu.Controls.Add(Me.Lblebidas)
        Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnMenu.Name = "PnMenu"
        Me.PnMenu.Size = New System.Drawing.Size(258, 611)
        Me.PnMenu.TabIndex = 5
        '
        'Lblebidas
        '
        Me.Lblebidas.AutoSize = True
        Me.Lblebidas.Font = New System.Drawing.Font("Clarendon", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblebidas.Location = New System.Drawing.Point(79, 38)
        Me.Lblebidas.Name = "Lblebidas"
        Me.Lblebidas.Size = New System.Drawing.Size(82, 26)
        Me.Lblebidas.TabIndex = 0
        Me.Lblebidas.Text = "Menu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.BtnComentario)
        Me.Panel1.Controls.Add(Me.BtnMesero)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(258, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 50)
        Me.Panel1.TabIndex = 7
        '
        'PnContenedor
        '
        Me.PnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnContenedor.Location = New System.Drawing.Point(258, 50)
        Me.PnContenedor.Name = "PnContenedor"
        Me.PnContenedor.Size = New System.Drawing.Size(1026, 561)
        Me.PnContenedor.TabIndex = 8
        '
        'BtnComentario
        '
        Me.BtnComentario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnComentario.FlatAppearance.BorderSize = 0
        Me.BtnComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComentario.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComentario.Image = CType(resources.GetObject("BtnComentario.Image"), System.Drawing.Image)
        Me.BtnComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComentario.Location = New System.Drawing.Point(671, 0)
        Me.BtnComentario.Name = "BtnComentario"
        Me.BtnComentario.Size = New System.Drawing.Size(170, 50)
        Me.BtnComentario.TabIndex = 1
        Me.BtnComentario.Text = "Comentar"
        Me.BtnComentario.UseVisualStyleBackColor = True
        '
        'BtnMesero
        '
        Me.BtnMesero.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnMesero.FlatAppearance.BorderSize = 0
        Me.BtnMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMesero.Font = New System.Drawing.Font("Clarendon", 12.0!)
        Me.BtnMesero.Image = Global.MenuVirtual.My.Resources.Resources.camarera
        Me.BtnMesero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMesero.Location = New System.Drawing.Point(840, 0)
        Me.BtnMesero.Name = "BtnMesero"
        Me.BtnMesero.Size = New System.Drawing.Size(186, 50)
        Me.BtnMesero.TabIndex = 0
        Me.BtnMesero.Text = "Pedir ayuda"
        Me.BtnMesero.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.Button3.Image = Global.MenuVirtual.My.Resources.Resources.porcion_de_tarta
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 379)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(258, 112)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Postres"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnBebidas
        '
        Me.BtnBebidas.FlatAppearance.BorderSize = 0
        Me.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBebidas.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnBebidas.Image = Global.MenuVirtual.My.Resources.Resources.taza_para_cafe1
        Me.BtnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBebidas.Location = New System.Drawing.Point(0, 249)
        Me.BtnBebidas.Name = "BtnBebidas"
        Me.BtnBebidas.Size = New System.Drawing.Size(258, 112)
        Me.BtnBebidas.TabIndex = 2
        Me.BtnBebidas.Text = "Bebidas"
        Me.BtnBebidas.UseVisualStyleBackColor = True
        '
        'BtnComida
        '
        Me.BtnComida.FlatAppearance.BorderSize = 0
        Me.BtnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComida.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnComida.Image = Global.MenuVirtual.My.Resources.Resources.plato1
        Me.BtnComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComida.Location = New System.Drawing.Point(0, 127)
        Me.BtnComida.Name = "BtnComida"
        Me.BtnComida.Size = New System.Drawing.Size(258, 112)
        Me.BtnComida.TabIndex = 1
        Me.BtnComida.Text = "Comida"
        Me.BtnComida.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.PnContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnMenu)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnMenu.ResumeLayout(False)
        Me.PnMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnMenu As Panel
    Friend WithEvents Lblebidas As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnContenedor As Panel
    Friend WithEvents BtnComida As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnBebidas As Button
    Friend WithEvents BtnComentario As Button
    Friend WithEvents BtnMesero As Button
End Class
