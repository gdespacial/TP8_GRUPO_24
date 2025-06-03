<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="Vistas.ListadoDeSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado De Sucursales<br />
            Busqueda: Ingrese Id Sucursal:
            <asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" ValidationGroup="1" OnClick="btnFiltrar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnQuitarFiltro" runat="server" Text="Mostrar Todos" ValidationGroup="2" OnClick="btnQuitarFiltro_Click" />
            <asp:RequiredFieldValidator ID="rfvIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Ingrese una sucursal" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="rgxIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Ingrese solo numeros" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="1"></asp:RegularExpressionValidator>
        </div>
        <asp:GridView ID="gvSucursales" runat="server">
        </asp:GridView>
        <p>
            <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado De Sucursales</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        </p>
        <div>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
