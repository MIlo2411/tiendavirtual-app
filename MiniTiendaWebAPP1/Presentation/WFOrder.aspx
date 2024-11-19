<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFOrder.aspx.cs" Inherits="Presentation.WPOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestion de Pedidos</h1>
    <div class="container">
        <div class="mb-3">
        </div>
        <div class="mb-3">
            <%--ID--%>
            <asp:HiddenField ID="HFOrderId" runat="server" />
        </div>
        <div class="mb-3">
            <%--fecha--%>
            <asp:Label ID="Label1" runat="server" Text="Ingrese la fecha" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBFecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%--estado--%>
            <asp:Label ID="Label2" runat="server" Text="Ingrese el estado" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBEstado" runat="server" CssClass="form-control"  Placeholder="Ingrese el estado"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%--Total--%>
            <asp:Label ID="Label4" runat="server" Text="Ingrese el total" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTotal" runat="server" CssClass="form-control"  Placeholder="Ingrese el total"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%--Clientes--%>
            <asp:Label ID="Label7" runat="server" Text="Seleccione el cliente" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLClients" runat="server" CssClass="form-select"></asp:DropDownList>
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
            <asp:GridView ID="GVOrders" runat="server" OnSelectedIndexChanged="GVComments_SelectedIndexChanged" CssClass="table table-striped table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ped_id" HeaderText="Id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="ped_fecha" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="ped_estado" HeaderText="estado" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="ped_total" HeaderText="total" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
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
