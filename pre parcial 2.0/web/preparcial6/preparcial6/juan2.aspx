<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="juan2.aspx.vb" Inherits="preparcial6.juan2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">


    .style1
    {
        width: 561px;
    }
    .style2
    {
        width: 329px;
    }
    .style3
    {
        width: 561px;
        height: 35px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 217px;">
    <tr>
        <td class="style1">
            <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
        </td>
        <td class="style2" rowspan="5">
            <asp:GridView ID="grv_provincias" runat="server" Height="161px" Width="176px">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Label ID="Label3" runat="server" Text="Provincia:"></asp:Label>
            <asp:DropDownList ID="ddl_provincias" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar" />
            <asp:Button ID="btn_mostrartodo" runat="server" Text="Mostrar todo" />
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Button ID="btn_agregar" runat="server" Text="Agregar" />
            <asp:Button ID="btn_modificar" runat="server" Text="Modificar" />
            <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
            <asp:Button ID="btn_consultar" runat="server" Text="Consultar por id " />
            <asp:Button ID="btn_consultarpr" runat="server" Text="Consultar por Ciudad" />
        </td>
    </tr>
</table>
</asp:Content>
