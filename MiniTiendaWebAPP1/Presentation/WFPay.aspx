<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFPay.aspx.cs" Inherits="Presentation.WFPay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Pagos</h1>
    <div>

        <%-- ID Producto Oculto --%>
        <asp:HiddenField ID="HFPagos" runat="server" />

        <%-- Monto --%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el Monto"></asp:Label>
        <asp:TextBox ID="TBmonto" runat="server"></asp:TextBox>
        <br />

        <%-- fecha --%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese la fecha de pago"></asp:Label>
        <asp:TextBox ID="TBfecha" runat="server"></asp:TextBox>
        <br />

        <%-- metodo pago --%>
        <asp:Label ID="Label5" runat="server" Text="Ingrese el metodo de pago"></asp:Label>
        <asp:TextBox ID="TBPago" runat="server"></asp:TextBox>
        <br />

        <%--Pedidos--%>
        <asp:Label ID="Label6" runat="server" Text="Seleccione la categoria"></asp:Label>
        <asp:DropDownList ID="DDLPedidos" runat="server"></asp:DropDownList>
        <br />


        <%-- Botones de acción --%>
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>


        <br />

        <%-- Lista de provedores --%>
        <asp:GridView ID="GVPagos" runat="server" OnSelectedIndexChanged="GVPagos_SelectedIndexChanged" AutoGenerateColumns="False">
            <columns>
                <asp:BoundField DataField="pag_id" HeaderText="ID Pago" />
                <asp:BoundField DataField="pag_monto" HeaderText="Monto" />
                <asp:BoundField DataField="pag_fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="pag_metodo_pago" HeaderText="Metodo de Pago" />
                <asp:BoundField DataField="tbl_pedidos_ped_id" HeaderText="Pedidos" />
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </columns>
        </asp:GridView>


    </div>
</asp:Content>
