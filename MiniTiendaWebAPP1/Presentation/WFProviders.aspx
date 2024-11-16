<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProviders.aspx.cs" Inherits="Presentation.WFProviders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de provedores</h1>
    <div>

        <%-- ID Producto Oculto --%>
        <asp:HiddenField ID="HFProvedores" runat="server" />

        <%-- Nombre del Producto --%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del proveedor"></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
        <br />

        <%-- Contacto --%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese el contacto del proveedor"></asp:Label>
        <asp:TextBox ID="TBDContacto" runat="server"></asp:TextBox>
        <br />

        <%-- telefono --%>
        <asp:Label ID="Label5" runat="server" Text="Ingrese el telefono"></asp:Label>
        <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
        <br />

        <%-- dirrecion --%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese la direccion"></asp:Label>
        <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
        <br />

        <%-- Botones de acción --%>
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>


        <br />

        <%-- Lista de provedores --%>
        <asp:GridView ID="GVProvedores" runat="server" OnSelectedIndexChanged="GVProvedores_SelectedIndexChanged" AutoGenerateColumns="False">
            <columns>
                <asp:BoundField DataField="prov_id" HeaderText="ID Producto" />
                <asp:BoundField DataField="prov_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="prov_contacto" HeaderText="Contacto" />
                <asp:BoundField DataField="prov_telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="prov_direccion" HeaderText="Direccion" />
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </columns>
        </asp:GridView>


    </div>

</asp:Content>
