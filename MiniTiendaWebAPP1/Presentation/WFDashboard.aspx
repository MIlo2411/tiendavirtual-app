<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFDashboard.aspx.cs" Inherits="Presentation.WFDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Bienvenido al Dashboard</h2>
    <asp:HyperLink ID="HLDashboard" runat="server" NavigateUrl="https://public.tableau.com/app/profile/jehan.frayer.vente.qui.ones/viz/DashboardTiendaVirtualentregagle/DashboardTiendaVirtual?publish=yes">
        Haz clic aquí para ir al enlace para abrir el Dashboard
    </asp:HyperLink>

</asp:Content>
