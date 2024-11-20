<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCar.aspx.cs" Inherits="Presentation.WFCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="text-center mb-4">Gestion de carrito</h1>

    <div class="container">
        <div class="mb-3">
            <!-- HiddenField para almacenar el ID del carrito seleccionado -->
            <asp:HiddenField ID="HFCarId" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Cliente:" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLClientes" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />

            <asp:Label ID="Label2" runat="server" Text="producto" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLProductos" runat="server" CssClass="form-select"></asp:DropDownList>
        </div>

        <div class="mb-3">
            <!-- Cantidad del Carrito -->
            <asp:Label ID="LabelCantidad" runat="server" Text="Cantidad:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBCantidad" runat="server" CssClass="form-control"  Placeholder="Ingrese la cantidad"></asp:TextBox>
            <br />
        </div>

        <div class="mb-3 text-center">
            <!-- Botones para guardar y actualizar carritos -->
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success" ForeColor="Red"></asp:Label>
            <br />
        </div>

        <div class="mt-4">
            <asp:GridView ID="GVCarrito" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVCarrito_SelectedIndexChanged1">
                <Columns>
                    <asp:BoundField DataField="car_id" HeaderText="ID" runat="server" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="car_cantidad" HeaderText="Cantidad" runat="server" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="Producto ID" runat="server" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente ID" runat="server" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button"
                        SelectText="Seleccionar"
                        ControlStyle-CssClass="btn btn-info btn-sm" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button"
                        DeleteText="Eliminar"
                        ControlStyle-CssClass="btn btn-danger btn-sm" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
