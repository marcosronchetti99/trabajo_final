Imports System.IO
Public Class Agenda
    Dim NomArchivo As String
    Dim Ubicacion As String
    Dim HayCambios As Boolean


    Private Sub btmAgregar_Click(sender As Object, e As EventArgs) Handles btmAgregar.Click
        Dim aux As String
        txtNombre.Text = Mid(txtNombre.Text, 1, 20)
        txtDireccion.Text = Mid(txtDireccion.Text, 1, 50)
        txtTelefono.Text = Mid(txtTelefono.Text, 1, 10)
        aux = txtNombre.Text & Space(20 - Len(txtNombre.Text)) & "" & txtDireccion.Text & Space(50 - Len(txtDireccion.Text)) & txtTelefono.Text & Space(10 - Len(txtTelefono.Text))
        lstDato.Items.Add(aux)
        txtNombre.Text = ""
        txtNombre.Focus()
        txtDireccion.Text = ""
        txtDireccion.Focus()
        txtTelefono.Text = ""
        txtTelefono.Focus()
    End Sub

    Private Sub btmEditar_Click(sender As Object, e As EventArgs) Handles btmEditar.Click
        If lstDato.SelectedItem = Nothing Then
            MsgBox("debe seleccionar un item", vbCritical)
            Exit Sub
        End If
        txtNombre.Text = Mid(lstDato.SelectedItem.ToString, 1, 20)
        txtDireccion.Text = Mid(lstDato.SelectedItem.ToString, 1, 50)
        txtTelefono.Text = Mid(lstDato.SelectedItem.ToString, 1, 10)
        lstDato.Items.Remove(lstDato.SelectedItem.ToString)
    End Sub

    Private Sub btmEliminar_Click(sender As Object, e As EventArgs) Handles btmEliminar.Click
        Dim opc As Integer
        If lstDato.SelectedItem = Nothing Then
            opc = MsgBox("seguro que quiere ", vbYesNo)
            Exit Sub

        End If
        lstDato.Items.Remove(lstDato.SelectedItem.ToString)
    End Sub

    Private Sub btmBuscar_Click(sender As Object, e As EventArgs) Handles btmBuscar.Click
        If txtbuscar.Visible() = True Then
            txtbuscar.Visible() = False
        Else
            txtbuscar.Visible() = True
        End If
    End Sub

    Private Sub btmGuardar_Click(sender As Object, e As EventArgs) Handles btmGuardar.Click
        If Me.lstDato.Text = "" Then
            MsgBox("debe contener al menos un caractar", vbCritical, "ingrese informacion")
            Exit Sub
        End If
        Me.Guardar(Ubicacion & NomArchivo)
    End Sub

    Private Sub btmLeer_Click(sender As Object, e As EventArgs) Handles btmLeer.Click
        Dim opc As Integer

        If HayCambios Then
            opc = MsgBox("no se han guardado los ultimos cambios desea guardarlos?", vbYesNo + vbCritical)
            If opc = vbYes Then
                Me.Guardar(Ubicacion & NomArchivo)
            End If
        End If
        Me.Leer(Ubicacion & NomArchivo)
    End Sub

    Sub Guardar(Archivo As String)
        Dim GrabarArchivo As New StreamWriter(Archivo)
        GrabarArchivo.Write(Me.lstDato.Text)
        GrabarArchivo.Close()
        MsgBox("archivo grabado correctamente", vbInformation)
        HayCambios = False
        lstDato.Focus()
    End Sub

    Sub Leer(Archivo As String)
        Dim leerArchivo As New StreamReader(Archivo)
        Me.lstDato.Text = leerArchivo.ReadLine
        leerArchivo.Close()
    End Sub

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomArchivo = "trabajo_final"  ' nombre fisico del archivo 
        Ubicacion = "D:\gui_final\"  ' ubicacion donde sera almacenado
        Me.btmLeer.Visible = False
        Me.btmGuardar.Visible = False

    End Sub


End Class
