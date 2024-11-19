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
        <asp:Label ID="Label1" runat="server" Text="Ingrese la fecha"></asp:Label>
        <asp:TextBox ID="TBFecha" runat="server"></asp:TextBox>
        <br />
        </div>
        <div class="mb-3">
        <%--estado--%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese el estado"></asp:Label>
        <asp:TextBox ID="TBEstado" runat="server"></asp:TextBox>
        <br />
            </div>
            <div class="mb-3">
        <%--Total--%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese el total"></asp:Label>
        <asp:TextBox ID="TBTotal" runat="server"></asp:TextBox>
        <br />
                </div>
                <div class="mb-3">
        <%--Clientes--%>
        <asp:Label ID="Label7" runat="server" Text="Seleccione el cliente"></asp:Label>
        <asp:DropDownList ID="DDLClients" runat="server"></asp:DropDownList>
        <br />
                    </div>
        <div class="mb-3 text-center">
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />
            </div>
        <div class="mt-4">
        <%--Lista de productos--%>
        <asp:GridView ID="GVOrders" runat="server" OnSelectedIndexChanged="GVComments_SelectedIndexChanged" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ped_id" HeaderText="Id" />
                <asp:BoundField DataField="ped_fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="ped_estado" HeaderText="estado" />
                <asp:BoundField DataField="ped_total" HeaderText="total" />
                <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente" />
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
        </div>


</asp:Content>
