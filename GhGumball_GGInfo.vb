Imports Grasshopper.Kernel

Public Class GhGumball_GGInfo
    Inherits GH_AssemblyInfo

    Public Overrides ReadOnly Property Name() As String
        Get
            Return "GhGumball_GG"
        End Get
    End Property
    Public Overrides ReadOnly Property Icon As System.Drawing.Bitmap
        Get
            'Return a 24x24 pixel bitmap to represent this GHA library.
            Return Nothing
        End Get
    End Property
    Public Overrides ReadOnly Property Description As String
        Get
            'Return a short string describing the purpose of this GHA library.
            Return ""
        End Get
    End Property
    Public Overrides ReadOnly Property Id As System.Guid
        Get
            Return New System.Guid("531ef79c-991e-45d0-a2f0-1c16fdb81ffa")
        End Get
    End Property

    Public Overrides ReadOnly Property AuthorName As String
        Get
            Return "Daniel Abalde"
        End Get
    End Property
    Public Overrides ReadOnly Property AuthorContact As String
        Get
            Return "dga_3@hotmail.com"
        End Get
    End Property
End Class
