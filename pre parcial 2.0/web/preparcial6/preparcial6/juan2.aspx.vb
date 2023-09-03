Imports System.Data
Imports ad
Public Class juan2
    Inherits System.Web.UI.Page
    Dim oDs As New DataSet
    Dim O_Casos As New Class2
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            CargarGrilla()

        End If
    End Sub

    Protected Sub btnCargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_agregar.Click
        If txt_nombre.Text <> Nothing Then
            oDs = New DataSet
            O_Casos = New Class2

            O_Casos.CargarCasos(txt_nombre.Text)
            MsgBox("Se agrego con exito", vbInformation, "Carga Exitosa")
            CargarGrilla()

        Else
            MsgBox("Complete los datos", vbInformation, "Cargar Nombre")
        End If
    End Sub
    Private Sub CargarGrilla()
        oDs = New DataSet
        O_Casos = New Class2


        ''
        oDs = O_Casos.MostrarTodo
        With grv_provincias
            .DataSource = oDs.Tables(0)
            .DataBind()
        End With
    End Sub

    Protected Sub btn_modificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_modificar.Click
        If txt_nombre.Text <> Nothing Then
            oDs = New DataSet
            O_Casos = New Class2
            O_Casos.modificaranimal(txt_id.Text, txt_nombre.Text)
            MsgBox("ciudad modificada con exito", vbInformation, "modificacion con exito")
            CargarGrilla()
        Else
            MsgBox("complete todos los campos", vbInformation, "campos vacios")
        End If
    End Sub

    Protected Sub btn_eliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_eliminar.Click
        If txt_id.Text <> Nothing Then
            oDs = New DataSet
            O_Casos = New Class2
            O_Casos.eliminar(txt_id.Text)
            MsgBox("ID eliminada", vbInformation, "Eliminacion Exitosa")
            CargarGrilla()
        Else

            MsgBox("Ingrese un ID", vbInformation, "Campos Vacios")

        End If
    End Sub

    Protected Sub btn_mostrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_mostrartodo.Click
        CargarGrilla()
    End Sub

    Protected Sub btn_consultarid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_consultar.Click
        If txt_id.Text <> Nothing Then
            oDs = New DataSet
            O_Casos = New Class2
            oDs = O_Casos.ConsultarIDAnimal(txt_id.Text)
            With grv_provincias
                .DataSource = oDs.Tables(0)
                .DataBind()
            End With
        Else
            MsgBox("Ingrese un ID", vbInformation, "Campos Vacios")
        End If
    End Sub

End Class