<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFPay.aspx.cs" Inherits="Presentation.WFPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="text-center mb-4">Gestion de pagos</h1>

    <div class="container">
        <div class="mb-3">

            <%-- ID Producto Oculto --%>
            <asp:HiddenField ID="HFPagos" runat="server" />

        </div>
        <div class="mb-3">
            <%-- Monto --%>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el Monto" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBmonto" runat="server" CssClass="form-control"  Placeholder="Ingrese el monto"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%-- fecha --%>
            <asp:Label ID="Label2" runat="server" Text="Ingrese la fecha de pago" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBfecha" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            <br />

        </div>
        <div class="mb-3">
            <%-- metodo pago --%>
            <asp:Label ID="Label5" runat="server" Text="Ingrese el metodo de pago" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TBPago" runat="server" CssClass="form-control"  Placeholder="Ingrese el pago"></asp:TextBox>
            <br />


        </div>

        <div class="mb-3">
            <asp:Label ID="Label6" runat="server" Text="categoria" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DDLPedidos" runat="server" CssClass="form-select"></asp:DropDownList>
            <br />
        </div>
        <div class="mb-3 text-center">

            <%-- Botones de acción --%>
            <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
            <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success"></asp:Label>


            <br />
        </div>

        <%-- Lista de provedores --%>
        <div class="mt-4">
            <asp:GridView ID="GVPagos" runat="server" OnSelectedIndexChanged="GVPagos_SelectedIndexChanged" CssClass="table table-striped table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="pag_id" HeaderText="ID Pago" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pag_monto" HeaderText="Monto" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pag_fecha" HeaderText="Fecha" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="pag_metodo_pago" HeaderText="Metodo de Pago" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                    <asp:BoundField DataField="tbl_pedidos_ped_id" HeaderText="Pedidos" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
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
