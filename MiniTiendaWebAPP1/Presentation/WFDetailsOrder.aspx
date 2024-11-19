<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDetailsOrder.aspx.cs" Inherits="Presentation.WFDetailsOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
     <h1 class="text-center mb-4">Gestion detalles pedidos</h1>

 <div class="container">
     <div class="mb-3">
   
    

        <%--ID--%>
        <asp:HiddenField ID="HFDetailsOrdersID" runat="server" />
         </div>
         <div class="mb-3">
        <%--Cantidad--%>
        <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad"></asp:Label>
        <asp:TextBox ID="TBQuantity" runat="server"></asp:TextBox>
        <br />

             </div>
             <div class="mb-3">
        <%--Precio--%>
        <asp:Label ID="Label5" runat="server" Text="Ingrese el precio"></asp:Label>
        <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
        <br />
                 </div>
                 <div class="mb-3">


        <%--pedido--%>
        <asp:Label ID="Label6" runat="server" Text="Seleccione el pedido"></asp:Label>
        <asp:DropDownList ID="DDLOrders" runat="server"></asp:DropDownList>
        <br />
                     </div>
                     <div class="mb-3">
        <%--producto--%>
        <asp:Label ID="Label7" runat="server" Text="Seleccione el producto"></asp:Label>
        <asp:DropDownList ID="DDLProducts" runat="server"></asp:DropDownList>
        <br />
                         </div>
                         <div class="mb-3 text-center">
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />
                             </div>
<div class="mt-4">
        <%--Lista de productos--%>
        <asp:GridView ID="GVDetailsOrders" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVDetailsOrders_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="det_id" HeaderText="ID" />
                <asp:BoundField DataField="det_cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="det_precio" HeaderText="Precio" />
                <asp:BoundField DataField="tbl_pedidos_ped_id" HeaderText="ID-Pedido" />
                <asp:BoundField DataField="tbl_productos_pro_id" HeaderText="ID-Producto" />

                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>

            </Columns>
        </asp:GridView>

    </div>
    </div>
</asp:Content>
