Public Class About
    Inherits Page
    Public persona As New Persona()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs)
        persona.Nombre = Txt_nombre.Text
    End Sub
End Class