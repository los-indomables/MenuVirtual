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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnContenedor = New System.Windows.Forms.Panel()
        Me.PnMenu = New System.Windows.Forms.Panel()
        Me.Lblebidas = New System.Windows.Forms.Label()
        Me.btnAjuste = New System.Windows.Forms.Button()
        Me.BtnComentario = New System.Windows.Forms.Button()
        Me.BtnMesero = New System.Windows.Forms.Button()
        Me.BtnOrden = New System.Windows.Forms.Button()
        Me.BtnPostres = New System.Windows.Forms.Button()
        Me.BtnBebidas = New System.Windows.Forms.Button()
        Me.BtnComida = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PnMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAjuste)
        Me.Panel1.Controls.Add(Me.BtnComentario)
        Me.Panel1.Controls.Add(Me.BtnMesero)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(259, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 54)
        Me.Panel1.TabIndex = 7
        '
        'PnContenedor
        '
        Me.PnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnContenedor.Location = New System.Drawing.Point(259, 54)
        Me.PnContenedor.Name = "PnContenedor"
        Me.PnContenedor.Size = New System.Drawing.Size(1025, 557)
        Me.PnContenedor.TabIndex = 8
        '
        'PnMenu
        '
        Me.PnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PnMenu.Controls.Add(Me.BtnOrden)
        Me.PnMenu.Controls.Add(Me.BtnPostres)
        Me.PnMenu.Controls.Add(Me.BtnBebidas)
        Me.PnMenu.Controls.Add(Me.BtnComida)
        Me.PnMenu.Controls.Add(Me.Lblebidas)
        Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenu.ForeColor = System.Drawing.Color.White
        Me.PnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnMenu.Name = "PnMenu"
        Me.PnMenu.Size = New System.Drawing.Size(259, 611)
        Me.PnMenu.TabIndex = 5
        '
        'Lblebidas
        '
        Me.Lblebidas.AutoSize = True
        Me.Lblebidas.BackColor = System.Drawing.Color.Transparent
        Me.Lblebidas.Font = New System.Drawing.Font("Clarendon", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblebidas.Location = New System.Drawing.Point(89, 28)
        Me.Lblebidas.Name = "Lblebidas"
        Me.Lblebidas.Size = New System.Drawing.Size(82, 26)
        Me.Lblebidas.TabIndex = 0
        Me.Lblebidas.Text = "Menu"
        '
        'btnAjuste
        '
        Me.btnAjuste.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjuste.BackColor = System.Drawing.Color.Transparent
        Me.btnAjuste.FlatAppearance.BorderSize = 0
        Me.btnAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjuste.Image = CType(resources.GetObject("btnAjuste.Image"), System.Drawing.Image)
        Me.btnAjuste.Location = New System.Drawing.Point(959, -5)
        Me.btnAjuste.Name = "btnAjuste"
        Me.btnAjuste.Size = New System.Drawing.Size(63, 61)
        Me.btnAjuste.TabIndex = 2
        Me.btnAjuste.UseVisualStyleBackColor = False
        '
        'BtnComentario
        '
        Me.BtnComentario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnComentario.BackColor = System.Drawing.Color.Transparent
        Me.BtnComentario.FlatAppearance.BorderSize = 0
        Me.BtnComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComentario.Font = New System.Drawing.Font("Clarendon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComentario.Image = Global.MenuVirtual.My.Resources.Resources.charlar1
        Me.BtnComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComentario.Location = New System.Drawing.Point(604, 3)
        Me.BtnComentario.Name = "BtnComentario"
        Me.BtnComentario.Size = New System.Drawing.Size(170, 53)
        Me.BtnComentario.TabIndex = 1
        Me.BtnComentario.Text = "Comentar"
        Me.BtnComentario.UseVisualStyleBackColor = False
        '
        'BtnMesero
        '
        Me.BtnMesero.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnMesero.BackColor = System.Drawing.Color.Transparent
        Me.BtnMesero.FlatAppearance.BorderSize = 0
        Me.BtnMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMesero.Font = New System.Drawing.Font("Clarendon", 12.0!)
        Me.BtnMesero.Image = Global.MenuVirtual.My.Resources.Resources.camarero
        Me.BtnMesero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMesero.Location = New System.Drawing.Point(780, -1)
        Me.BtnMesero.Name = "BtnMesero"
        Me.BtnMesero.Size = New System.Drawing.Size(186, 61)
        Me.BtnMesero.TabIndex = 0
        Me.BtnMesero.Text = "Pedir ayuda"
        Me.BtnMesero.UseVisualStyleBackColor = False
        '
        'BtnOrden
        '
        Me.BtnOrden.BackColor = System.Drawing.Color.Transparent
        Me.BtnOrden.FlatAppearance.BorderSize = 0
        Me.BtnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrden.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnOrden.Image = CType(resources.GetObject("BtnOrden.Image"), System.Drawing.Image)
        Me.BtnOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrden.Location = New System.Drawing.Point(0, 424)
        Me.BtnOrden.Name = "BtnOrden"
        Me.BtnOrden.Size = New System.Drawing.Size(251, 73)
        Me.BtnOrden.TabIndex = 3
        Me.BtnOrden.Text = "Orden"
        Me.BtnOrden.UseVisualStyleBackColor = False
        '
        'BtnPostres
        '
        Me.BtnPostres.BackColor = System.Drawing.Color.Transparent
        Me.BtnPostres.FlatAppearance.BorderSize = 0
        Me.BtnPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPostres.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnPostres.Image = Global.MenuVirtual.My.Resources.Resources.muffin
        Me.BtnPostres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPostres.Location = New System.Drawing.Point(0, 322)
        Me.BtnPostres.Name = "BtnPostres"
        Me.BtnPostres.Size = New System.Drawing.Size(256, 79)
        Me.BtnPostres.TabIndex = 2
        Me.BtnPostres.Text = "Postres"
        Me.BtnPostres.UseVisualStyleBackColor = False
        '
        'BtnBebidas
        '
        Me.BtnBebidas.BackColor = System.Drawing.Color.Transparent
        Me.BtnBebidas.FlatAppearance.BorderSize = 0
        Me.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBebidas.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnBebidas.Image = Global.MenuVirtual.My.Resources.Resources.limonada
        Me.BtnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBebidas.Location = New System.Drawing.Point(4, 207)
        Me.BtnBebidas.Name = "BtnBebidas"
        Me.BtnBebidas.Size = New System.Drawing.Size(249, 80)
        Me.BtnBebidas.TabIndex = 2
        Me.BtnBebidas.Text = "Bebidas"
        Me.BtnBebidas.UseVisualStyleBackColor = False
        '
        'BtnComida
        '
        Me.BtnComida.BackColor = System.Drawing.Color.Transparent
        Me.BtnComida.FlatAppearance.BorderSize = 0
        Me.BtnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComida.Font = New System.Drawing.Font("Clarendon", 14.25!)
        Me.BtnComida.Image = Global.MenuVirtual.My.Resources.Resources.plato4
        Me.BtnComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComida.Location = New System.Drawing.Point(3, 118)
        Me.BtnComida.Name = "BtnComida"
        Me.BtnComida.Size = New System.Drawing.Size(253, 83)
        Me.BtnComida.TabIndex = 1
        Me.BtnComida.Text = "Comida"
        Me.BtnComida.UseVisualStyleBackColor = False
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
        Me.Panel1.ResumeLayout(False)
        Me.PnMenu.ResumeLayout(False)
        Me.PnMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnMenu As Panel
    Friend WithEvents Lblebidas As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnContenedor As Panel
    Friend WithEvents BtnComida As Button
    Friend WithEvents BtnPostres As Button
    Friend WithEvents BtnBebidas As Button
    Friend WithEvents BtnComentario As Button
    Friend WithEvents BtnMesero As Button
    Friend WithEvents BtnOrden As Button
    Friend WithEvents btnAjuste As Button
End Class
