Imports System.Data.SqlClient

Public Class DataBaseHelper
    Private ReadOnly ConectionString As String = ConfigurationManager.ConnectionStrings("II-46ConnectionString").ConnectionString

    Public Function create(Persona As Persona) As String
        Try
            Dim sql As String = "INSERT INTO Personas (Nombre, Apellido, Edad) VALUES(@Nombre, @Apellido, @Edad)"
            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", Persona.Nombre),
                New SqlParameter("@Apellido", Persona.Apellido),
                New SqlParameter("@Edad", Persona.Edad)
            }

            Using connection As New SqlConnection(ConectionString)
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddRange(parametros.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return "Persona creada con éxito"

    End Function


    Public Function delete(ByRef id As Integer) As String
        Try
            Dim sql As String = "DELETE FROM Personas WHERE ID = @Id"
            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@ID", id)
        }
            Using Connetion As New SqlConnection(ConectionString)
                Using command As New SqlCommand(sql, Connetion)
                    command.Parameters.AddRange(parametros.ToArray)
                    Connetion.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
        End Try
        Return "Persona Eliminada"
    End Function
    Public Function Update(ByRef Persona As Persona) As String
        Try
            Dim sql As String = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad WHERE ID = @Id"
            Dim Parametros As New List(Of SqlParameter) From {
                New SqlParameter("@ID", Persona.ID),
                New SqlParameter("@Nombre", Persona.Nombre),
                New SqlParameter("@Apellido", Persona.Apellido),
                New SqlParameter("@Edad", Persona.Edad)
            }
            Using connetion As New SqlConnection(ConectionString)
                Using Command As New SqlCommand(sql, connetion)
                    Command.Parameters.AddRange(Parametros.ToArray())
                    connetion.Open()
                    Command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return "Persona Actualizada"
    End Function


End Class
