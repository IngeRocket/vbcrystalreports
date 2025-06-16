Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CrystalDecisions
Public Class Form1

    Private conectate As SqlConnection

    Private Sub cargarLista()
        Dim L As SqlCommand
        Dim query As String

        query = "select usu_id, usu_nombre, area_puesto from usuario join area on usu_area = area_id order by area_puesto"
        conectate.Open()
        L = New SqlCommand(query, conectate)
        L.CommandType = CommandType.Text
        L.CommandTimeout = 3600

        Dim sda As SqlDataReader = L.ExecuteReader



        conectate.Close()

        Dim objInforme As New reporteTejido
        Crv_visor.ReportSource = objInforme


    End Sub

    Private Sub cargarGrupos()



        'Creacion de tabla usuario de la cual su estructura se encuentra dentro del dataset
        Dim tablausuario As DatosConsulta.usuarioDataTable()
        'Creacion de la tabla Area de la cual su estructura se encuentra dentro del dataset
        Dim tablaArea As DatosConsulta.areaDataTable()




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectate = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Escritorio").ConnectionString)
        Try
            'conectate.Open()

            'conectate.Close()
            'cargarLista()
            'cargarGrupos()

            'Dim objInforme As New reporteTejido
            'Dim documento As reporteTejido
            'documento = New reporteTejido
            'Crv_visor.ReportSource = documento

            'ObtenerTablaUsuario()
            Procedimiento()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ObtenerTablaUsuario()

        conectate = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Escritorio").ConnectionString)
        Dim ds As New DatosConsulta

        Try
            conectate.Open()
            Dim L As SqlCommand
            Dim query As String

            query = "select * from usuario where usu_area = 0"
            Dim Adapadaor As SqlDataAdapter = New SqlDataAdapter(query, conectate)
            Adapadaor.Fill(ds, "usuario")

            query = "select * from area"
            Adapadaor = New SqlDataAdapter(query, conectate)
            Adapadaor.Fill(ds, "area")

            conectate.Close()
            Dim objInforme As New reporteTejido
            objInforme.SetDataSource(ds)
            Crv_visor.ReportSource = objInforme

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ObtenerTablaArea(ByRef tablaArea As DatosConsultaTableAdapters.areaTableAdapter)
        conectate = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Escritorio").ConnectionString)
        Dim tabla As DataTable = New DataTable
        Try
            conectate.Open()
            Dim comando As SqlCommand
            Dim sqlCmd As String = "select area_id, area_puesto from area"

            comando = New SqlCommand(sqlCmd, conectate)
            comando.CommandTimeout = 3600
            comando.CommandType = CommandType.Text

            Dim lector As SqlDataReader = comando.ExecuteReader
            tabla.Load(lector)

            conectate.Close()

            Dim objInforme As New reporteTejido
            objInforme.SetDataSource(tabla)
            Crv_visor.ReportSource = objInforme

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Procedimiento()
        Try
            conectate = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Escritorio").ConnectionString)
            Dim ds As New DatosConsulta

            Dim L As SqlCommand
            Dim query As String

            query = "exec sp_datos"
            Dim Adapadaor As SqlDataAdapter = New SqlDataAdapter(query, conectate)
            Adapadaor.Fill(ds, "sp_datos")
            MsgBox("Todo Bien", MessageBoxIcon.Information + MessageBoxButtons.YesNo, "Aviso")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class