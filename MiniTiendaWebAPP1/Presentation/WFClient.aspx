<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClient.aspx.cs" Inherits="Presentation.WFClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Clientes</h1>
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-md-4">
                <!-- HiddenField para almacenar el ID del Cliente seleccionado -->
                <asp:HiddenField ID="HFClienteId" runat="server" />
                <!-- Nombre del Cliente -->
                <asp:Label ID="Label1" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control" Placeholder="Ingrese el nombre"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Apellido del Cliente -->
                <asp:Label ID="Label2" runat="server" Text="Apellido:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBApellido" runat="server" CssClass="form-control" Placeholder="Ingrese el apellido"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Correo de cliente -->
                <asp:Label ID="Label5" runat="server" Text="correo:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBCorreo" runat="server" CssClass="form-control" Placeholder="Ingrese el correo"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Contraseña de cliente -->
                <asp:Label ID="Label6" runat="server" Text="Contraseña:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBContrasena" runat="server" CssClass="form-control" Placeholder="Ingrese la caontraseña"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Direccion de envio -->
                <asp:Label ID="Label3" runat="server" Text="Dirección:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBDireccion" runat="server" CssClass="form-control" Placeholder="Ingrese la direccion"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
               
                <!-- Telefono del Cliente -->
                <asp:Label ID="Label4" runat="server" Text="Teléfono:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TBTelefono" runat="server" CssClass="form-control" Placeholder="Ingrese el telefono"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- id de la tarjeta-->
    <asp:Label ID="Label7" runat="server" Text="tarjeta:" CssClass="form-label"></asp:Label>
    <asp:TextBox ID="TBtarjeta" runat="server" CssClass="form-control" Placeholder="Ingrese el id de la tarjeta"></asp:TextBox>
    <br />
</div>
            <div class="col-md-4">
            <!-- saldo -->
    <asp:Label ID="Label8" runat="server" Text="Saldo:" CssClass="form-label"></asp:Label>
    <asp:TextBox ID="TBsaldo" runat="server" CssClass="form-control" Placeholder="Ingrese el saldo"></asp:TextBox>
    <br />
</div>

        
        <div class="row mb-3">
            <div class="col text-center">
                <!-- Botones para guardar y actualizar clientes -->
                <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success mx-2" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" CssClass="btn btn-primary mx-2" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" Text="" CssClass="text-success" ForeColor="Red"></asp:Label>
                <br />
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:GridView ID="GVClientes" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged"
                    OnRowDeleting="GVClientes_RowDeleting" DataKeyNames="cli_id">
                    <Columns>
                        <asp:BoundField DataField="cli_id" HeaderText="ID" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_nombre" HeaderText="Nombre" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"  />
                        <asp:BoundField DataField="cli_apellido" HeaderText="Apellido" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center"  />
                        <asp:BoundField DataField="cli_correo" HeaderText="Correo" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_contrasena" HeaderText="Contrasena" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_direccion_envio" HeaderText="Direccion" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_telefono" HeaderText="Teléfono" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_tarjeta_id" HeaderText="Tarjeta" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                        <asp:BoundField DataField="cli_saldo" HeaderText="saldo" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />


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
    </div>
</asp:Content>
