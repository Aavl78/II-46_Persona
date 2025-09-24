Public Class Persona
    Private _nombre As String
    Private _Apellido As String
    Private _Edad As Integer

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _Edad
        End Get
        Set(value As Integer)
            _Edad = value
        End Set
    End Property

    Public Sub New(nombre As String)
        Me.Nombre = "No hay nombre"
    End Sub

    Public Sub New(nombre As String, apellido As String, edad As Integer)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Edad = edad
    End Sub

End Class
