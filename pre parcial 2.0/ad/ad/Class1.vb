Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class Class1
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function CargarCasos(ByVal nombre As String) As Double
        Return o_Database.ExecuteScalar("Cargar_provincia", nombre)
    End Function
    Public Function MostrarTodo() As DataSet
        Return o_Database.ExecuteDataSet("provincias_buscartodos")
    End Function
    Public Function modificaranimal(ByVal ID As String, ByVal nombre As String) As Double
        Return o_Database.ExecuteScalar("Modificar_provincia", ID, nombre)
    End Function
    Public Function eliminar(ByVal ID As Integer)
        Return o_Database.ExecuteScalar("borrar_provincia", ID)
    End Function
    Public Function ConsultarIDAnimal(ByVal ID As Integer) As DataSet
        Return o_Database.ExecuteDataSet("consultar_provincia", ID)
    End Function
End Class
