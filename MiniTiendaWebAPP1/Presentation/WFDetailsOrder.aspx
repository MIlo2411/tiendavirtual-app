<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFDetailsOrder.aspx.cs" Inherits="Presentation.WFDetailsOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--ID--%>
            <asp:HiddenField ID="HFDetailsOrdersID" runat="server" />

            <%--Cantidad--%>
            <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad"></asp:Label>
            <asp:TextBox ID="TBQuantity" runat="server"></asp:TextBox>
            <br />

            <%--Precio--%>
            <asp:Label ID="Label5" runat="server" Text="Ingrese el precio"></asp:Label>
            <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
            <br />

            <%--pedido--%>
            <asp:Label ID="Label6" runat="server" Text="Seleccione el pedido"></asp:Label>
            <asp:DropDownList ID="DDLOrders" runat="server"></asp:DropDownList>
            <br />

            <%--producto--%>
            <asp:Label ID="Label7" runat="server" Text="Seleccione el producto"></asp:Label>
            <asp:DropDownList ID="DDLProducts" runat="server"></asp:DropDownList>
            <br />

            <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
            <br />

            <%--Lista de productos--%>
            <asp:GridView ID="GVDetailsOrders" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVDetailsOrders_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="det_id" HeaderText="ID" />
                    <asp:BoundField DataField="det_cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="det_precio" HeaderText="Precio" />
                    <asp:BoundField DataField="tbl_pedidos_ped_id" HeaderText="ID-Pedido" />
                    <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="ID-Producto" />

                    <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
