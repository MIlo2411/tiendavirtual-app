<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Gestion de productos</h1>
<div>
    <%-- ID Producto Oculto --%>
<asp:HiddenField ID="HFProductId" runat="server" />

<%-- Nombre del Producto --%>
<asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del producto"></asp:Label>
<asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
<br />

<%-- Descripción --%>
<asp:Label ID="Label2" runat="server" Text="Ingrese la descripción"></asp:Label>
<asp:TextBox ID="TBDescription" runat="server"></asp:TextBox>
<br />

<%-- Precio --%>
<asp:Label ID="Label5" runat="server" Text="Ingrese el precio"></asp:Label>
<asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
<br />

<%-- Cantidad --%>
<asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad"></asp:Label>
<asp:TextBox ID="TBStock" runat="server"></asp:TextBox>
<br />

<%-- Imagen --%>
<asp:Label ID="Label3" runat="server" Text="Ingrese una imagen"></asp:Label>
<asp:TextBox ID="TBtImg" runat="server"></asp:TextBox>
<br />

<%-- Proveedor --%>
<asp:Label ID="Label7" runat="server" Text="Seleccione el proveedor"></asp:Label>
<asp:DropDownList ID="DDLProviders" runat="server"></asp:DropDownList>
<br />

<<<<<<< HEAD
<%-- Categoría --%>
<asp:Label ID="Label6" runat="server" Text="Seleccione la categoría"></asp:Label>
<asp:DropDownList ID="DDLCategories" runat="server"></asp:DropDownList>
<br />
=======
    <%--Lista de productos--%>
    <asp:GridView ID="GVProducts" runat="server">
        <Columns>   
            <asp:BoundField DataField="pro_id" HeaderText=""  />
            <asp:BoundField DataField="pro_nombre" HeaderText=""  />
            <asp:BoundField DataField="pro_descripcion" HeaderText=""  />
            <asp:BoundField DataField="pro_precio" HeaderText=""  />
            <asp:BoundField DataField="pro_stock" HeaderText=""  />
            <asp:BoundField DataField="pro_imagen" HeaderText=""  />
            <asp:BoundField DataField="tbl_proveedores_prov_id" HeaderText=""  />
            <asp:BoundField DataField="tbl_categoria_cat_id" HeaderText=""  />
            
        </Columns>
    </asp:GridView>
>>>>>>> 880f6094283c914010a7e901a161ca49b51b3778

<%-- Botones de acción --%>
<asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
<asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
<asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
<br />

<%-- Lista de productos --%>
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

</asp:Content>
