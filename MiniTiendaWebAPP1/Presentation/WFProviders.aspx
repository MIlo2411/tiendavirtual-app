<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProviders.aspx.cs" Inherits="Presentation.WFProviders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestion de provedores</h1>
    
    <div class="container">
    <div class="mb-3">

        <%-- ID Producto Oculto --%>
        <asp:HiddenField ID="HFProvedores" runat="server" />
        
    </div>
        <div class="mb-3">

        <%-- Nombre del Producto --%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del proveedor"></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
        <br />
            </div>
            <div class="mb-3">
        <%-- Contacto --%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese el contacto del proveedor"></asp:Label>
        <asp:TextBox ID="TBDContacto" runat="server"></asp:TextBox>
        <br />
                </div>
                <div class="mb-3">
        <%-- telefono --%>
        <asp:Label ID="Label5" runat="server" Text="Ingrese el telefono"></asp:Label>
        <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
        <br />
                    </div>
                    <div class="mb-3">
        <%-- dirrecion --%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese la direccion"></asp:Label>
        <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
        <br />
                        </div>
                        <div class="mb-3">
        <%-- Botones de acción --%>
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>


        <br />
                            </div>
        <%-- Lista de provedores --%>
        <div class="mt-4">
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
    </div>

</asp:Content>
