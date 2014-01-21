Public Class Patito



    Private nombreN As String


    Public Sub New(ByVal Nm As String)
        nombreN = Nm
    End Sub



    Property nombreP() As String
        Get
            Return nombreN
        End Get
        Set(ByVal value As String)
            nombreN = value
        End Set
    End Property


End Class
