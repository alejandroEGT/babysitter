<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_verClientes.aspx.cs" Inherits="Admin_verClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center><h3><strong>Lista de Clientes</strong></h3></center>

    <asp:GridView ID="GridClientes" runat="server" AutoGenerateColumns="False" DataKeyNames="run" DataSourceID="SqlDataSource1" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="1116px" Height="122px">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="run" HeaderText="run" ReadOnly="True" SortExpression="run" />
            <asp:BoundField DataField="dv" HeaderText="dv" SortExpression="dv" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="apellido paterno" HeaderText="apellido paterno" SortExpression="apellido paterno" />
            <asp:BoundField DataField="apellido materno" HeaderText="apellido materno" SortExpression="apellido materno" />
            <asp:BoundField DataField="fecha de nacimiento" dataformatstring="{0:dd/MMMM/yyyy}" HeaderText="fecha de nacimiento" SortExpression="fecha de nacimiento" />
            <asp:BoundField DataField="e-mail" HeaderText="e-mail" SortExpression="e-mail" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BdBabysittersConnectionString %>" SelectCommand="select run, dv, nombres,apellidoPaterno as 'apellido paterno',apellidoPaterno as 'apellido materno', fechaNacimiento as 'fecha de nacimiento'
,correoElectronico as 'e-mail', telefono from tPersona p 
inner join tCliente c on p.run=c.runCliente"></asp:SqlDataSource>

</asp:Content>

