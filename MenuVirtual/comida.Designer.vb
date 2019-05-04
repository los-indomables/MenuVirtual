<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcomida
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcomida))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAntojitos = New System.Windows.Forms.Button()
        Me.BtnCarnes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPollos = New System.Windows.Forms.Button()
        Me.BtnMariscos = New System.Windows.Forms.Button()
        Me.BtnEnsaladas = New System.Windows.Forms.Button()
        Me.BtnInfantil = New System.Windows.Forms.Button()
        Me.BtnSandwiches = New System.Windows.Forms.Button()
        Me.BtnHamburguesas = New System.Windows.Forms.Button()
        Me.DGVComida = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVComida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAntojitos)
        Me.Panel1.Controls.Add(Me.BtnCarnes)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnPollos)
        Me.Panel1.Controls.Add(Me.BtnMariscos)
        Me.Panel1.Controls.Add(Me.BtnEnsaladas)
        Me.Panel1.Controls.Add(Me.BtnInfantil)
        Me.Panel1.Controls.Add(Me.BtnSandwiches)
        Me.Panel1.Controls.Add(Me.BtnHamburguesas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 100)
        Me.Panel1.TabIndex = 7
        '
        'btnAntojitos
        '
        Me.btnAntojitos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAntojitos.FlatAppearance.BorderSize = 0
        Me.btnAntojitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntojitos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntojitos.ForeColor = System.Drawing.Color.White
        Me.btnAntojitos.Location = New System.Drawing.Point(960, 0)
        Me.btnAntojitos.Name = "btnAntojitos"
        Me.btnAntojitos.Size = New System.Drawing.Size(135, 100)
        Me.btnAntojitos.TabIndex = 16
        Me.btnAntojitos.Text = "Antojitos"
        Me.btnAntojitos.UseVisualStyleBackColor = True
        '
        'BtnCarnes
        '
        Me.BtnCarnes.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnCarnes.FlatAppearance.BorderSize = 0
        Me.BtnCarnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarnes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarnes.ForeColor = System.Drawing.Color.White
        Me.BtnCarnes.Location = New System.Drawing.Point(831, 0)
        Me.BtnCarnes.Name = "BtnCarnes"
        Me.BtnCarnes.Size = New System.Drawing.Size(138, 100)
        Me.BtnCarnes.TabIndex = 15
        Me.BtnCarnes.Text = "Carnes"
        Me.BtnCarnes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(595, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 100)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Pasta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnPollos
        '
        Me.BtnPollos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnPollos.FlatAppearance.BorderSize = 0
        Me.BtnPollos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPollos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPollos.ForeColor = System.Drawing.Color.White
        Me.BtnPollos.Location = New System.Drawing.Point(717, 0)
        Me.BtnPollos.Name = "BtnPollos"
        Me.BtnPollos.Size = New System.Drawing.Size(123, 100)
        Me.BtnPollos.TabIndex = 13
        Me.BtnPollos.Text = "Pollos"
        Me.BtnPollos.UseVisualStyleBackColor = True
        '
        'BtnMariscos
        '
        Me.BtnMariscos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnMariscos.FlatAppearance.BorderSize = 0
        Me.BtnMariscos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMariscos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMariscos.ForeColor = System.Drawing.Color.White
        Me.BtnMariscos.Location = New System.Drawing.Point(487, 0)
        Me.BtnMariscos.Name = "BtnMariscos"
        Me.BtnMariscos.Size = New System.Drawing.Size(118, 100)
        Me.BtnMariscos.TabIndex = 12
        Me.BtnMariscos.Text = "Mariscos"
        Me.BtnMariscos.UseVisualStyleBackColor = True
        '
        'BtnEnsaladas
        '
        Me.BtnEnsaladas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnEnsaladas.FlatAppearance.BorderSize = 0
        Me.BtnEnsaladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnsaladas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnsaladas.ForeColor = System.Drawing.Color.White
        Me.BtnEnsaladas.Location = New System.Drawing.Point(384, 0)
        Me.BtnEnsaladas.Name = "BtnEnsaladas"
        Me.BtnEnsaladas.Size = New System.Drawing.Size(114, 100)
        Me.BtnEnsaladas.TabIndex = 11
        Me.BtnEnsaladas.Text = "Ensaladas"
        Me.BtnEnsaladas.UseVisualStyleBackColor = True
        '
        'BtnInfantil
        '
        Me.BtnInfantil.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnInfantil.FlatAppearance.BorderSize = 0
        Me.BtnInfantil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInfantil.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfantil.ForeColor = System.Drawing.Color.White
        Me.BtnInfantil.Location = New System.Drawing.Point(258, 0)
        Me.BtnInfantil.Name = "BtnInfantil"
        Me.BtnInfantil.Size = New System.Drawing.Size(135, 100)
        Me.BtnInfantil.TabIndex = 10
        Me.BtnInfantil.Text = "Menu Infantil"
        Me.BtnInfantil.UseVisualStyleBackColor = True
        '
        'BtnSandwiches
        '
        Me.BtnSandwiches.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSandwiches.FlatAppearance.BorderSize = 0
        Me.BtnSandwiches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSandwiches.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSandwiches.ForeColor = System.Drawing.Color.White
        Me.BtnSandwiches.Location = New System.Drawing.Point(137, 0)
        Me.BtnSandwiches.Name = "BtnSandwiches"
        Me.BtnSandwiches.Size = New System.Drawing.Size(120, 100)
        Me.BtnSandwiches.TabIndex = 9
        Me.BtnSandwiches.Text = "Sandwiches"
        Me.BtnSandwiches.UseVisualStyleBackColor = True
        '
        'BtnHamburguesas
        '
        Me.BtnHamburguesas.FlatAppearance.BorderSize = 0
        Me.BtnHamburguesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHamburguesas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHamburguesas.ForeColor = System.Drawing.Color.White
        Me.BtnHamburguesas.Location = New System.Drawing.Point(0, 0)
        Me.BtnHamburguesas.Name = "BtnHamburguesas"
        Me.BtnHamburguesas.Size = New System.Drawing.Size(145, 100)
        Me.BtnHamburguesas.TabIndex = 8
        Me.BtnHamburguesas.Text = "Hamburguesas"
        Me.BtnHamburguesas.UseVisualStyleBackColor = True
        '
        'DGVComida
        '
        Me.DGVComida.AllowUserToAddRows = False
        Me.DGVComida.AllowUserToDeleteRows = False
        Me.DGVComida.AllowUserToResizeColumns = False
        Me.DGVComida.AllowUserToResizeRows = False
        Me.DGVComida.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.DGVComida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVComida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Clarendon", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVComida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVComida.ColumnHeadersVisible = False
        Me.DGVComida.EnableHeadersVisualStyles = False
        Me.DGVComida.GridColor = System.Drawing.Color.SteelBlue
        Me.DGVComida.Location = New System.Drawing.Point(52, 106)
        Me.DGVComida.MultiSelect = False
        Me.DGVComida.Name = "DGVComida"
        Me.DGVComida.ReadOnly = True
        Me.DGVComida.RowHeadersVisible = False
        Me.DGVComida.RowHeadersWidth = 40
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGVComida.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVComida.RowTemplate.Height = 40
        Me.DGVComida.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVComida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVComida.Size = New System.Drawing.Size(852, 317)
        Me.DGVComida.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 447)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1083, 128)
        Me.Panel2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(567, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "El Salvador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(483, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "B° San Jose, Chalatenango,"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSeleccionar.FlatAppearance.BorderSize = 2
        Me.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionar.Location = New System.Drawing.Point(921, 251)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(138, 39)
        Me.BtnSeleccionar.TabIndex = 16
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(792, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Frmcomida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1083, 575)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DGVComida)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmcomida"
        Me.Text = "comida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVComida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSandwiches As Button
    Friend WithEvents BtnHamburguesas As Button
    Friend WithEvents BtnPollos As Button
    Friend WithEvents BtnMariscos As Button
    Friend WithEvents BtnEnsaladas As Button
    Friend WithEvents BtnInfantil As Button
    Friend WithEvents DGVComida As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAntojitos As Button
    Friend WithEvents BtnCarnes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSeleccionar As Button
End Class
