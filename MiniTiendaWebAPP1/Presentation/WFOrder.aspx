<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFOrder.aspx.cs" Inherits="Presentation.WPOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de ordenes</h1>
    <div>
        <%--ID--%>
        <asp:HiddenField ID="HFOrderId" runat="server" />

        <%--fecha--%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese la fecha"></asp:Label>
        <asp:TextBox ID="TBFecha" runat="server"></asp:TextBox>
        <br />

        <%--estado--%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese el estado"></asp:Label>
        <asp:TextBox ID="TBEstado" runat="server"></asp:TextBox>
        <br />

        <%--Total--%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese el total"></asp:Label>
        <asp:TextBox ID="TBTotal" runat="server"></asp:TextBox>
        <br />

        <%--Clientes--%>
        <asp:Label ID="Label7" runat="server" Text="Seleccione el cliente"></asp:Label>
        <asp:DropDownList ID="DDLClients" runat="server"></asp:DropDownList>
        <br />


        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />

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



</asp:Content>
