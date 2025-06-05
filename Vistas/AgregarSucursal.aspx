<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Grupo Nro 1<br />
            Agregar Sucursal&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Nombre Sucursal:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombreSucursal" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="Ingrese un nombre" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Descripcion:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescripcionSucursal" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescripcionSucursal" runat="server" ControlToValidate="txtDescripcionSucursal" ErrorMessage="Ingrese una descripcion" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Provincia:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProvinciaSucursal" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Direccion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDireccionSucursal" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDireccionSucursal" runat="server" ControlToValidate="txtDireccionSucursal" ErrorMessage="Ingrese una Direccion" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <br />
        <br />
        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado De Sucursales</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </form>
</body>
</html>
