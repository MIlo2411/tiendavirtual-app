<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFComments.aspx.cs" Inherits="Presentation.WFComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Gestion de carrito</h1>

    <div>
        <%--Id--%>
        <asp:HiddenField ID="HFCommentId" runat="server" />

        <%--Commentario--%>
        <asp:Label ID="Lbl1" runat="server" Text="Ingrese el comentario"></asp:Label>
        <asp:TextBox ID="TBComment" runat="server"></asp:TextBox>
        <br />

        <%--Clasificacion--%>
        <asp:Label ID="Lbl2" runat="server" Text="Ingrese la clasificacion"></asp:Label>
        <asp:TextBox ID="TBCalification" runat="server"></asp:TextBox>

        <%--Fecha--%>
        <asp:Label ID="Lbl4" runat="server" Text="Ingrese la fecha"></asp:Label>
        <asp:TextBox ID="TBFecha" runat="server"></asp:TextBox>
        <br />

        <%--productos--%>
        <asp:Label ID="Lbl6" runat="server" Text="Seleccione el producto"></asp:Label>
        <asp:DropDownList ID="DDLProducts" runat="server"></asp:DropDownList>
        <br />

        <%--Clientes--%>
        <asp:Label ID="Lbl7" runat="server" Text="Seleccione el cliente"></asp:Label>
        <asp:DropDownList ID="DDLClients" runat="server"></asp:DropDownList>
        <br />

        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />

        <%--Lista de Productos--%>
        <asp:GridView ID="GVComments" runat="server" OnSelectedIndexChanged="GVComments_SelectedIndexChanged" AutoGenerateColumns="False">
            <columns>
                <asp:BoundField DataField="com_id" HeaderText="Id" />
                <asp:BoundField DataField="com_comentario" HeaderText="Comentario" />
                <asp:BoundField DataField="com_calificacion" HeaderText="Calificacion" />
                <asp:BoundField DataField="com_fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="Producto" />
                <asp:BoundField DataField="tbl_clientes_cli_id" HeaderText="Cliente" />
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>

            </columns>
        </asp:GridView>


    </div>
</asp:Content>
