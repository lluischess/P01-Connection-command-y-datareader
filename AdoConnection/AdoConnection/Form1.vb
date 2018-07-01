Imports System.Data
Imports System.Data.SqlClient


Public Class Form1
    Private con As SqlConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conexio amb la base de dades de sqlexpress
        con = New SqlConnection
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=MAGATZEM;Trusted_Connection=True;"
        Try
            con.Open()
        Catch
            MsgBox("problema en el servidor de base de datos")
        End Try

        If con.State = ConnectionState.Closed Then
            MsgBox("tanquem")
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' visualització dels empleats
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        Dim id, apellido, nom As String
        Dim whereFet As Boolean = False

        command = New SqlCommand
        command.Connection = con
        command.CommandText = "select idempleado, apellidos, nombre, cargo, fechanacimiento from empleados"


        If rbtId.Checked Then
            command.CommandText = command.CommandText + " order by idempleado"
        Else
            command.CommandText = command.CommandText + " order by apellidos"
        End If


        reader = command.ExecuteReader
        ListBox1.Items.Clear()

        While reader.Read()
            id = reader("idempleado").ToString
            nom = reader("nombre").ToString
            apellido = reader("apellidos").ToString


            ListBox1.Items.Add(id + " | " + nom + " | " + apellido)
        End While

        reader.Close()



    End Sub

    Public Sub refrescar()
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        Dim id, apellido, nom As String
        Dim whereFet As Boolean = False

        command = New SqlCommand
        command.Connection = con
        command.CommandText = "select idempleado, apellidos, nombre, cargo, fechanacimiento from empleados"


        If rbtId.Checked Then
            command.CommandText = command.CommandText + " order by idempleado"
        Else
            command.CommandText = command.CommandText + " order by apellidos"
        End If


        reader = command.ExecuteReader
        ListBox1.Items.Clear()

        While reader.Read()
            id = reader("idempleado").ToString
            nom = reader("nombre").ToString
            apellido = reader("apellidos").ToString


            ListBox1.Items.Add(id + " | " + nom + " | " + apellido)
        End While

        reader.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Lectura de dades per els camps
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        Dim id As String = ListBox1.Items.Item(ListBox1.SelectedIndex)
        id = id.Split("|")(0)
        Dim whereFet As Boolean = False

        command = New SqlCommand
        command.Connection = con
        command.CommandText = "select idempleado, apellidos, nombre, cargo, fechanacimiento from empleados where idempleado =" & id

        reader = command.ExecuteReader

        While reader.Read
            tbid.Text = reader(0).ToString
            tbape.Text = reader(1).ToString
            tbNom.Text = reader(2).ToString
            tbcargo.Text = reader(3).ToString
            tbfecha.Text = reader(4).ToString


        End While

        reader.Close()
        command.Dispose()


    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim command As SqlCommand

        command = New SqlCommand()
        command.Connection = con
        command.CommandText = String.Format("update empleados set apellidos = '{0}' where idempleado = {1}", tbNom.Text, tbid.Text)

        If command.ExecuteNonQuery() = 0 Then
            MsgBox("No s'ha fet l'actualtizació perque el id de producte no existeix")
        Else
            MsgBox("Tot actualitzat!!")
        End If

        command.CommandText = String.Format("update empleados set nombre = '{0}' where idempleado = {1}", tbape.Text, tbid.Text)
        If command.ExecuteNonQuery() = 0 Then
            MsgBox("No s'ha fet l'actualtizació perque el id de producte no existeix")
        Else
            MsgBox("Refresca les dades")
        End If


        refrescar()

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim fecha As Boolean = IsDate(tbfecha.Text)
        If fecha = False Then

            MsgBox("La fecha no es valida" + vbNewLine +
        "Este es el formato correcto 'dia/mes/año'.")
        Else
            Dim command As SqlCommand
            command = New SqlCommand
            command.Connection = con

            command.CommandText = String.Format("INSERT INTO Empleados (Apellidos, Nombre, Cargo, FechaNacimiento) VALUES ('{0}', '{1}', '{2}', NULL)", tbape.Text, tbNom.Text, tbcargo.Text, tbfecha.Text)

            If command.ExecuteNonQuery() = 0 Then
                MsgBox("Hi ha problemas amb les dades")
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            Else
                MsgBox("Empleat afagit!")
            End If
        End If

        refrescar()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim id As String = ListBox1.Items.Item(ListBox1.SelectedIndex)
        id = id.Split("|")(0)

        Dim command As SqlCommand
        command = New SqlCommand
        command.Connection = con
        command.CommandText = "DELETE Empleados WHERE idEmpleado = " & id

        If command.ExecuteNonQuery() = 0 Then
            MsgBox("Error ")
            ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex
        Else
            MsgBox("S'ha eliminat correctament! " + id)
        End If

    End Sub
End Class
