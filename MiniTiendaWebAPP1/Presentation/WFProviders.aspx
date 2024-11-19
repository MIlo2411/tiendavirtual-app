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
            <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del proveedor" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control"  Placeholder="Ingrese el nombre"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Contacto --%>
            <asp:Label ID="Label2" runat="server" Text="Ingrese el contacto del proveedor" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBDContacto" runat="server" CssClass="form-control"  Placeholder="Ingrese el contacto"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- telefono --%>
            <asp:Label ID="Label5" runat="server" Text="Ingrese el telefono" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBTelefono" runat="server" CssClass="form-control"  Placeholder="Ingrese el telefono"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- dirrecion --%>
            <asp:Label ID="Label4" runat="server" Text="Ingrese la direccion" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBDireccion" runat="server" CssClass="form-control"  Placeholder="Ingrese la direccion"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Botones de acción --%>
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>


            <br />
        </div>
        <%-- Lista de provedores --%>
        <div class="mt-4">
            <asp:GridView ID="GVProvedores" runat="server" OnSelectedIndexChanged="GVProvedores_SelectedIndexChanged" CssClass="table table-striped table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="prov_id" HeaderText="ID Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_contacto" HeaderText="Contacto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_telefono" HeaderText="Telefono" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="prov_direccion" HeaderText="Direccion" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
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
