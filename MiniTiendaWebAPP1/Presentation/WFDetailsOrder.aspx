<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDetailsOrder.aspx.cs" Inherits="Presentation.WFDetailsOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Gestion de carrito</h1>

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
</asp:Content>
