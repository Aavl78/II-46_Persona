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
    End Sub
End Class