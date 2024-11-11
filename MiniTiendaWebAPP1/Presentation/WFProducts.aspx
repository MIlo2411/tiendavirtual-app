<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Gestion de productos</h1>
<div>
    <%--ID--%>
    
    <asp:HiddenField ID="HFProductId" runat="server" />

    <%--    Codigo--%>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el codigo"></asp:Label>
    <asp:TextBox ID="TBCode" runat="server"></asp:TextBox>
    <br />

    <%--Descripción--%>
    <asp:Label ID="Label2" runat="server" Text="Ingrese la descripción"></asp:Label>
    <asp:TextBox ID="TBDescription" runat="server"></asp:TextBox>
    <br />

    <%--Cantidad--%>
    <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad"></asp:Label>
    <asp:TextBox ID="TBQuantity" runat="server"></asp:TextBox>
    <br />

    <%--Precio--%>
    <asp:Label ID="Label5" runat="server" Text="Ingrese el precio"></asp:Label>
    <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
    <br />

    <%--Categoria--%>
    <asp:Label ID="Label6" runat="server" Text="Seleccione la categoria"></asp:Label>
    <asp:DropDownList ID="DDLCategories" runat="server"></asp:DropDownList>
    <br />

    <%--Proveedor--%>
    <asp:Label ID="Label7" runat="server" Text="Seleccione el proveedor"></asp:Label>
    <asp:DropDownList ID="DDLProviders" runat="server"></asp:DropDownList>
   <%--<br />
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
    <br />--%>

    <%--Lista de productos--%>
    <asp:GridView ID="GVProducts" runat="server">
        <Columns>   
            <asp:BoundField DataField="pro_id" HeaderText=""  />
            <asp:BoundField DataField="pro_nombre" HeaderText=""  />
            <asp:BoundField DataField="pro_descripcion" HeaderText=""  />
            <asp:BoundField DataField="pro_precio" HeaderText=""  />
            <asp:BoundField DataField="pro_stock" HeaderText=""  />
            <asp:BoundField DataField="pro_imagen" HeaderText=""  />
            <asp:BoundField DataField="pro_categorias_cat_id" HeaderText=""  />
            <asp:BoundField DataField="tbl_proveedor_prov_id" HeaderText=""  />
            <asp:BoundField DataField="tbl_categoria_cat_id" HeaderText=""  />
            <asp:BoundField DataField="prov_nombres" HeaderText=""  />

        </Columns>
    </asp:GridView>



</div>

</asp:Content>
