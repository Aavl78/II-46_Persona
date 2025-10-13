Public Class FormPersona
    Inherits System.Web.UI.Page
    Public persona As New Persona()
    Protected dbHelper As New DataBaseHelper()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs)
        persona.Nombre = Txt_nombre.Text
        persona.Apellido = Txt_apellido.Text
        persona.Edad = Txt_edad.Text
        Lbl_mensaje.Text = dbHelper.create(persona)
        Gv_personas.DataBind()
    End Sub

    Protected Sub Gv_personas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Try
            Dim id As Integer = Convert.ToInt32(Gv_personas.DataKeys(e.RowIndex).Value)
            dbHelper.delete(id)
            e.Cancel = True
            Gv_personas.DataBind()
        Catch ex As Exception
            Lbl_mensaje.Text = "Error al eliminar la persona:" & ex.Message
        End Try
    End Sub




    Protected Sub Gv_personas_RowEditing(sender As Object, e As GridViewEditEventArgs)

    End Sub

    Protected Sub Gv_personas_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs)
        Gv_personas.EditIndex = -1
        Gv_personas.DataBind()
    End Sub

    Protected Sub Gv_personas_RowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim id As Integer = Convert.ToInt32(Gv_personas.DataKeys(e.RowIndex).Value)
        Dim Persona As Persona = New Persona With {
        .Nombre = e.NewValues("Nombre"),
        .Apellido = e.NewValues("Apellido"),
        .Edad = e.NewValues("Edad"),
        .Id = id
        }
        dbHelper.Update(Persona)
        e.Cancel = True
        Gv_personas.EditIndex = -1
        Gv_personas.DataBind()
    End Sub

    Protected Sub Gv_personas_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim id As Integer = Convert.ToInt32(Gv_personas.DataKeys(e.Equals(id)))
        Dim Persona As Persona = New Persona()
    End Sub
End Class