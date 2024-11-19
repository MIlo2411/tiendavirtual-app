<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCategory.aspx.cs" Inherits="Presentation.WFCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center mb-4">Gestion de categorias</h1>

<div class="container">
    <div class="mb-3">

    <!-- HiddenField para almacenar el ID de la categoría seleccionada -->
    <asp:HiddenField ID="HFCategoryId" runat="server" />
    
        
             </div>
            <div class="mb-3">
    <!-- Nombre de la Categoría -->
    <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de la categoría:"></asp:Label>
    <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    <br />
                 </div>
                <div class="mb-3">
    <!-- Descripción de la Categoría -->
    <asp:Label ID="Label2" runat="server" Text="Descripcion de la categoría:"></asp:Label>
    <asp:TextBox ID="TBDescripcion" runat="server"></asp:TextBox>
    <br />
                     </div>
                    <div class="mb-3 text-center">
    <!-- Botones para guardar y actualizar categorías -->
    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
    <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
                         </div>
                        <div class="mt-4">
    <asp:GridView ID="GVCategories" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVCategories_SelectedIndexChanged" OnRowDeleting="GVCategories_RowDeleting" DataKeyNames="cat_id">
        <Columns>
            <asp:BoundField DataField="cat_id" HeaderText="Id" />
            <asp:BoundField DataField="cat_nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="cat_descripcion" HeaderText="Descripcion" />
            <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
 </div>
</div>
</asp:Content>
