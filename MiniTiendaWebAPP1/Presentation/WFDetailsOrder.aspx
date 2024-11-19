<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDetailsOrder.aspx.cs" Inherits="Presentation.WFDetailsOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 class="text-center mb-4">Gestion detalles pedidos</h1>

    <div class="container">
        <div class="mb-3">



            <%--ID--%>
            <asp:HiddenField ID="HFDetailsOrdersID" runat="server" />
        </div>
        <div class="mb-3">
            <%--Cantidad--%>
            <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBQuantity" runat="server" CssClass="form-control"  Placeholder="Ingrese la cantidad"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%--Precio--%>
            <asp:Label ID="Label5" runat="server" Text="Ingrese el precio" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBPrice" runat="server" CssClass="form-control"  Placeholder="Ingrese el precio"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">


            <%--pedido--%>
            <asp:Label ID="Label6" runat="server" Text="Seleccione el pedido" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLOrders" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />
        </div>
        <div class="mb-3">
            <%--producto--%>
            <asp:Label ID="Label7" runat="server" Text="Seleccione el producto" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLProducts" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />
        </div>
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
            <br />
        </div>
        <div class="mt-4">
            <%--Lista de productos--%>
            <asp:GridView ID="GVDetailsOrders" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVDetailsOrders_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="det_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="det_cantidad" HeaderText="Cantidad" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="det_precio" HeaderText="Precio" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_pedidos_ped_id" HeaderText="ID-Pedido" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="ID-Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />

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
