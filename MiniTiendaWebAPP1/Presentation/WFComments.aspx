<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFComments.aspx.cs" Inherits="Presentation.WFComments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 class="text-center mb-4">Gestion de comentarios</h1>

    <div class="container">
        <div class="mb-3">

            <%--Id--%>
            <asp:HiddenField ID="HFCommentId" runat="server" />
        </div>
        <div class="mb-3">
            <%--Commentario--%>
            <asp:Label ID="Lbl1" runat="server" Text="Ingrese el comentario" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBComment" runat="server" CssClass="form-control" Placeholder="Ingrese el comentario"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%--Clasificacion--%>
            <asp:Label ID="Lbl2" runat="server" Text="Ingrese la clasificacion" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBCalification" runat="server" CssClass="form-control" Placeholder="Ingrese la calificacion"></asp:TextBox>

        </div>
        <div class="mb-3">
            <%--Fecha--%>
            <asp:Label ID="Lbl4" runat="server" Text="Ingrese la fecha" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBFecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%--productos--%>
            <asp:Label ID="Lbl6" runat="server" Text="Seleccione el producto" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLProducts" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />
        </div>
        <div class="mb-3">
            <%--Clientes--%>
            <asp:Label ID="Lbl7" runat="server" Text="Seleccione el cliente" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLClients" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />

        </div>
        <div class="mb-3 text-center">
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>
            <br />

        </div>
        <div class="mt-4">
            <%--Lista de Productos--%>
            <asp:GridView ID="GVComments" runat="server" OnSelectedIndexChanged="GVComments_SelectedIndexChanged" CssClass="table table-striped table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="com_id" HeaderText="Id" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="com_comentario" HeaderText="Comentario" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="com_calificacion" HeaderText="Calificacion" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="com_fecha" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="Producto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
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
