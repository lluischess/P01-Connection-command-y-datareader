# P01-Connection-command-y-datareader
practica de vb.net + ADO 
Realizar la siguiente aplicación utilizando la tecnología ado.net

 Se quiere hacer una pequeña gestión de la tabla Empleados de la base de datos llamada ALMACÉN

Las características de esta gestión son las siguientes:

1. Se mostrará en un ListBox todos los empleados existentes ordenados por su identificador o por su apellido según indique el usuario. Habrá mostrar en el ListBox el identificador, el nombre y los apellidos.

 2. Según el elemento activo, ver el siguiente punto, se mostrará para cada registro la siguiente información en formato tabular (textbox, ComboBox, checkbox ...):

    IdEmpleado: Mostrar en un textbox donde el usuario no pueda escribir.
    Apellidos: Mostrar en un textbox
    Número: Mostrar en un textbox
    Cargo: Mostrar en un textbox
    FechaNacimiento: Mostrar en un textbox

 3. Debido a que el DataReader sólo deja mover hacia adelante, cuando se cargue la información en el ListBox se pondrá como registro activo (elemento seleccionado en el ListBox) el primer registro y cada vez que se haga un click en otro elemento necesario activar este trabajador como activo y mostrar sus datos.

Conjuntamente con los datos del bloque 2 se mostrarán tres botones que permitirán realizar las siguientes acciones:

    ELIMINAR: Se eliminará el registro activo, una vez eliminado actualizará el ListBox y situaremos como registro activo el primer registro.
    MODIFICAR: Se modificará el registro con los datos de los textbox y ComboBox del apartado 2. Cuando se haya hecho la actualización Debe actualizar ListBox y situaremos como registro activo el mismo registro en el que se estaba.
    INSERTAR: Habrá generar un nuevo registro en el almacén teniendo en cuenta que el identificador se autonumérico, la asigna la base de datos. Una vez insertado nos situaremos en el último registro que se el nuevo.
    
      Try
            Dim fecha As Date = CDate(txtFechaNacimiento.Text)
            fechaNacimiento = fecha.Year & "-" & fecha.Month & "-" & fecha.Day
        Catch ex As Exception
            MsgBox("Campo incorrecto", MsgBoxStyle.Critical, "Error")
        End Try


      ---

            update = "Update Empleados set nombre='{1}', apellidos='{2}', cargo='{3}', FechaNacimiento='{4}', Jefe={5} where idEmpleado={0};"
            update = String.Format(update, txtIdEmpleado.Text, txtNombre.Text, txtApellido.Text, txtCargo.Text, fechaNacimiento, jefe)
            com.CommandText = update
            Try
                If com.ExecuteNonQuery() = 0 Then
                    MsgBox("No se ha actualizado el empleado", MsgBoxStyle.Critical, "Error")
                End If
            Catch ex As Exception
                MsgBox("Error de la base de datos", MsgBoxStyle.Critical, "Error")
            End Try
