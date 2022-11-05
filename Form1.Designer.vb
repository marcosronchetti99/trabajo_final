<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agenda
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lstDato = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btmAgregar = New System.Windows.Forms.Button()
        Me.btmEditar = New System.Windows.Forms.Button()
        Me.btmEliminar = New System.Windows.Forms.Button()
        Me.btmBuscar = New System.Windows.Forms.Button()
        Me.btmLeer = New System.Windows.Forms.Button()
        Me.btmGuardar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agenda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 67)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(309, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(133, 110)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(309, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(133, 148)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(309, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'lstDato
        '
        Me.lstDato.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDato.FormattingEnabled = True
        Me.lstDato.ItemHeight = 14
        Me.lstDato.Location = New System.Drawing.Point(58, 210)
        Me.lstDato.Name = "lstDato"
        Me.lstDato.Size = New System.Drawing.Size(640, 172)
        Me.lstDato.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Telefono"
        '
        'btmAgregar
        '
        Me.btmAgregar.BackColor = System.Drawing.Color.Aqua
        Me.btmAgregar.Location = New System.Drawing.Point(58, 389)
        Me.btmAgregar.Name = "btmAgregar"
        Me.btmAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btmAgregar.TabIndex = 11
        Me.btmAgregar.Text = "Agregar"
        Me.btmAgregar.UseVisualStyleBackColor = False
        '
        'btmEditar
        '
        Me.btmEditar.Location = New System.Drawing.Point(139, 389)
        Me.btmEditar.Name = "btmEditar"
        Me.btmEditar.Size = New System.Drawing.Size(75, 23)
        Me.btmEditar.TabIndex = 12
        Me.btmEditar.Text = "Editar"
        Me.btmEditar.UseVisualStyleBackColor = True
        '
        'btmEliminar
        '
        Me.btmEliminar.Location = New System.Drawing.Point(220, 389)
        Me.btmEliminar.Name = "btmEliminar"
        Me.btmEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btmEliminar.TabIndex = 13
        Me.btmEliminar.Text = "Eliminar"
        Me.btmEliminar.UseVisualStyleBackColor = True
        '
        'btmBuscar
        '
        Me.btmBuscar.Location = New System.Drawing.Point(539, 386)
        Me.btmBuscar.Name = "btmBuscar"
        Me.btmBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btmBuscar.TabIndex = 14
        Me.btmBuscar.Text = "Buscar"
        Me.btmBuscar.UseVisualStyleBackColor = True
        '
        'btmLeer
        '
        Me.btmLeer.Location = New System.Drawing.Point(704, 294)
        Me.btmLeer.Name = "btmLeer"
        Me.btmLeer.Size = New System.Drawing.Size(75, 23)
        Me.btmLeer.TabIndex = 15
        Me.btmLeer.Text = "Leer"
        Me.btmLeer.UseVisualStyleBackColor = True
        '
        'btmGuardar
        '
        Me.btmGuardar.Location = New System.Drawing.Point(704, 255)
        Me.btmGuardar.Name = "btmGuardar"
        Me.btmGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btmGuardar.TabIndex = 16
        Me.btmGuardar.Text = "Guardar"
        Me.btmGuardar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(365, 389)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(168, 20)
        Me.txtbuscar.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(301, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Buscar"
        '
        'Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 432)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btmGuardar)
        Me.Controls.Add(Me.btmLeer)
        Me.Controls.Add(Me.btmBuscar)
        Me.Controls.Add(Me.btmEliminar)
        Me.Controls.Add(Me.btmEditar)
        Me.Controls.Add(Me.btmAgregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstDato)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Agenda"
        Me.Text = "Agenda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lstDato As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btmAgregar As Button
    Friend WithEvents btmEditar As Button
    Friend WithEvents btmEliminar As Button
    Friend WithEvents btmBuscar As Button
    Friend WithEvents btmLeer As Button
    Friend WithEvents btmGuardar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label8 As Label
End Class
