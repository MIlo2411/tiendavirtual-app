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
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Apellido del Cliente -->
                <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="TBApellido" runat="server"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Correo de cliente -->
                <asp:Label ID="Label5" runat="server" Text="correo:"></asp:Label>
                <asp:TextBox ID="TBCorreo" runat="server"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Contraseña de cliente -->
                <asp:Label ID="Label6" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="TBContrasena" runat="server"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Direccion de envio -->
                <asp:Label ID="Label3" runat="server" Text="Dirección:"></asp:Label>
                <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
                <br />
            </div>

            <div class="col-md-4">
                <!-- Telefono del Cliente -->
                <asp:Label ID="Label4" runat="server" Text="Teléfono:"></asp:Label>
                <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
                <br />
            </div>


        </div>
        <div class="row mb-3">
            <div class="col text-center">
                <!-- Botones para guardar y actualizar clientes -->
                <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
                <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red"></asp:Label>
                <br />
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:GridView ID="GVClientes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged"
                    OnRowDeleting="GVClientes_RowDeleting" DataKeyNames="cli_id">
                    <Columns>
                        <asp:BoundField DataField="cli_id" HeaderText="ID" />
                        <asp:BoundField DataField="cli_nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="cli_apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="cli_correo" HeaderText="Correo" />
                        <asp:BoundField DataField="cli_contrasena" HeaderText="Contrasena" />
                        <asp:BoundField DataField="cli_direccion_envio" HeaderText="Direccion" />
                        <asp:BoundField DataField="cli_telefono" HeaderText="Teléfono" />



                        <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
