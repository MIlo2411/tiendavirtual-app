<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFClient.aspx.cs" Inherits="Presentation.WFClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestionar Clientes</h1>
    <div>
        <!-- HiddenField para almacenar el ID del Cliente seleccionado -->

        <asp:HiddenField ID="HFClienteId" runat="server" />

        <!-- Nombre del Cliente -->
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
        <br />
        <!-- Apellido del Cliente -->
        <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="TBApellido" runat="server"></asp:TextBox>
        <br />
        <!-- Correo de cliente -->
        <asp:Label ID="Label5" runat="server" Text="correo:"></asp:Label>
        <asp:TextBox ID="TBCorreo" runat="server"></asp:TextBox>
        <br />
        <!-- Contraseña de cliente -->
        <asp:Label ID="Label6" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="TBContrasena" runat="server"></asp:TextBox>
        <br />
        <!-- Direccion de envio -->
        <asp:Label ID="Label3" runat="server" Text="Dirección:"></asp:Label>
        <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
        <br />
        <!-- Telefono del Cliente -->
        <asp:Label ID="Label4" runat="server" Text="Teléfono:"></asp:Label>
        <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
        <br />
       
        <!-- Botones para guardar y actualizar clientes -->
        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />

        <asp:GridView ID="GVClientes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged"
            OnRowDeleting="GVClientes_RowDeleting" DataKeyNames="cli_id">
            <columns>
                <asp:BoundField DataField="cli_id" HeaderText="ID" />
                <asp:BoundField DataField="cli_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="cli_apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="cli_correo" HeaderText="Correo" />
                <asp:BoundField DataField="cli_contrasena" HeaderText="Contrasena" />
                <asp:BoundField DataField="cli_direccion_envio" HeaderText="Direccion" />
                <asp:BoundField DataField="cli_telefono" HeaderText="Teléfono" />
                


                <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />
            </columns>
        </asp:GridView>

    </div>
</asp:Content>
