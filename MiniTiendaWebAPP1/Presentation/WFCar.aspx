<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCar.aspx.cs" Inherits="Presentation.WFCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="text-center mb-4">Gestion de carrito</h1>

    <div class="container">
        <div class="mb-3">
            <!-- HiddenField para almacenar el ID del carrito seleccionado -->
            <asp:HiddenField ID="HFCarId" runat="server" />
            <asp:DropDownList ID="DDLClientes" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DDLProductos" runat="server"></asp:DropDownList>
        </div>

        <div class="mb-3">
            <!-- Cantidad del Carrito -->
            <asp:Label ID="LabelCantidad" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="TBCantidad" runat="server"></asp:TextBox>
            <br />
        </div>

        <div class="mb-3 text-center">
            <!-- Botones para guardar y actualizar carritos -->
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
        </div>

        <div class="mt-4">
            <asp:GridView ID="GVCarrito" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVCarrito_SelectedIndexChanged1">
                <Columns>
                    <asp:BoundField DataField="car_id" HeaderText="ID" runat="server" />
                    <asp:BoundField DataField="car_cantidad" HeaderText="Cantidad" runat="server" />
                    <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="Producto ID" runat="server" />
                    <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente ID" runat="server" />
                    <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" runat="server" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
