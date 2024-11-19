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
            <asp:Label ID="Label1" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control"  Placeholder="Ingrese el nombre"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%-- Descripción --%>
            <asp:Label ID="Label2" runat="server" Text="Descripción" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBDescription" runat="server" CssClass="form-control"  Placeholder="Ingrese la descripcion"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Precio --%>
            <asp:Label ID="Label5" runat="server" Text="Precio" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBPrice" runat="server" CssClass="form-control"  Placeholder="Ingrese el precio"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Cantidad --%>
            <asp:Label ID="Label4" runat="server" Text="Cantidad" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBStock" runat="server" CssClass="form-control"  Placeholder="Ingrese la cantidad"></asp:TextBox>
            <br />
        </div>
        <div class="mb-3">
            <%-- Imagen --%>
            <asp:Label ID="Label3" runat="server" Text="Imagen" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBtImg" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>

        <div class="mb-3">
            <asp:DropDownList ID="DDLCategories" runat="server" CssClass="form-select"></asp:DropDownList>
            <asp:DropDownList ID="DDLProviders" runat="server" CssClass="form-select"></asp:DropDownList>
        </div>

        <div class="mb-3 text-center">
            <%-- Botones de acción --%>
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
            <br />
        </div>

        <%-- Lista de productos --%>
        <div class="mt-4">
            <asp:GridView ID="GVProducts" runat="server" OnSelectedIndexChanged="GVProducts_SelectedIndexChanged" CssClass="table table-striped table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="pro_id" HeaderText="ID Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pro_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pro_descripcion" HeaderText="Descripción" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pro_precio" HeaderText="Precio" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pro_stock" HeaderText="Cantidad" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pro_imagen" HeaderText="Imagen" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_proveedores_prov_id" HeaderText="Proveedor" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_categoria_cat_id" HeaderText="Categoría" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />

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
