<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="text-center mb-4">Gestion de productos</h1>
    <div class="container">
        <div class="mb-3">
            <%-- ID Producto Oculto --%>
            <asp:HiddenField ID="HFProductId" runat="server" />
            

        </div>
        <div class="mb-3">
            <%-- Nombre del Producto --%>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%-- Descripción --%>
            <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
            <asp:TextBox ID="TBDescription" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Precio --%>
            <asp:Label ID="Label5" runat="server" Text="Precio"></asp:Label>
            <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Cantidad --%>
            <asp:Label ID="Label4" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="TBStock" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Imagen --%>
            <asp:Label ID="Label3" runat="server" Text="Imagen"></asp:Label>
            <asp:TextBox ID="TBtImg" runat="server"></asp:TextBox>
            <br />
        </div>

        <div class="mb-3">
        <asp:DropDownList ID="DDLCategories" runat="server"></asp:DropDownList>
<asp:DropDownList ID="DDLProviders" runat="server"></asp:DropDownList>
            </div>
       
                    <div class="mb-3 text-center">
            <%-- Botones de acción --%>
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
            <br />
        </div>

        <%-- Lista de productos --%>
        <div class="mt-4">
            <asp:GridView ID="GVProducts" runat="server" OnSelectedIndexChanged="GVProducts_SelectedIndexChanged" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="pro_id" HeaderText="ID Producto" />
                    <asp:BoundField DataField="pro_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="pro_descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="pro_precio" HeaderText="Precio" />
                    <asp:BoundField DataField="pro_stock" HeaderText="Cantidad" />
                    <asp:BoundField DataField="pro_imagen" HeaderText="Imagen" />
                    <asp:BoundField DataField="tbl_proveedores_prov_id" HeaderText="Proveedor" />
                    <asp:BoundField DataField="tbl_categoria_cat_id" HeaderText="Categoría" />

                    <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" />
                    <asp:CommandField ShowDeleteButton="True" DeleteText="Eliminar" />
                </Columns>
            </asp:GridView>

        </div>
    </div>

</asp:Content>
