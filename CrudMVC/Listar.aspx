<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="CrudMVC.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel runat="server" ID="pnlDatosProductos">
                <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="true">
                </asp:GridView>
                <asp:Button ID="btnNuevoProducto" Text="Nuevo Producto" runat="server" OnClick="btnNuevoProducto_Click" />
            </asp:Panel>

            <asp:Panel ID="pnlAlProducto" runat="server" Visible="false" >
                <div>
                    <asp:Label ID="lblNombreProducto" Text="Nombre Producto" runat="server" />
                    <asp:TextBox ID="txtNombreProducto" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblCantidadPrecioo" Text="Cantidad" runat="server" />
                    <asp:TextBox ID="txtCantidadPrecio" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblPrecioUnitario" Text="Precio Unitario" runat="server" />
                    <asp:TextBox ID="txtPrecioUnitario" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblUnidadStock" Text="Unidad en Stock" runat="server" />
                    <asp:TextBox ID="txtUidadStock" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblUnidadOrden" Text="Unidad en orden" runat="server" />
                    <asp:TextBox ID="txtUnidadOrden" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblReorderLevel" Text="Reorder Level" runat="server" />
                    <asp:TextBox ID="txtReordeLevel" runat="server" />
                </div>

                <div>
                    <asp:Label ID="lblDiscontinuidad" Text="Discontinuidad" runat="server" />
                    <asp:TextBox ID="txtDiscontinuidad" runat="server" />
                </div>
                <br />
                <asp:button ID="btnGuardar" text="Guardar Productos" runat="server"  OnClick="btnGuardar_Click" />

            </asp:Panel>

        </div>
    </form>
</body>
</html>
