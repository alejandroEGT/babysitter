<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_verNinieras.aspx.cs" Inherits="Admin_verNinieras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><h3><strong>Lista de Niñeras</strong></h3></center>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="Run" DataSourceID="SqlDataSource1" Width="1116px" ForeColor="Black" GridLines="None" Height="122px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <Columns>
        <asp:BoundField DataField="Run" HeaderText="Run" ReadOnly="True" SortExpression="Run" />
        <asp:BoundField DataField="CV" HeaderText="CV" SortExpression="CV" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
        <asp:BoundField DataField="Apellido Paterno" HeaderText="Apellido Paterno" SortExpression="Apellido Paterno" />
        <asp:BoundField DataField="Apellido Materno" HeaderText="Apellido Materno" SortExpression="Apellido Materno" />
        <asp:BoundField DataField="Fecha De Nacimiento" dataformatstring="{0:dd/MMMM/yyyy}" HeaderText="Fecha De Nacimiento" SortExpression="Fecha De Nacimiento" ValidateRequestMode="Disabled" />
        <asp:BoundField DataField="Correo Electronico" HeaderText="Correo Electronico" SortExpression="Correo Electronico" />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
    </Columns>
    <FooterStyle BackColor="Tan" />
    <HeaderStyle BackColor="Tan" Font-Bold="True" />
    <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" BackColor="PaleGoldenrod" />
    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    <SortedAscendingCellStyle BackColor="#FAFAE7" />
    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
    <SortedDescendingCellStyle BackColor="#E1DB9C" />
    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BdBabysittersConnectionString %>" SelectCommand="SELECT p.run AS Run, p.dv AS CV, p.nombres AS Nombre, p.apellidoPaterno AS 'Apellido Paterno', p.apellidoMaterno AS 'Apellido Materno', p.fechaNacimiento AS 'Fecha De Nacimiento', p.correoElectronico AS 'Correo Electronico', p.telefono AS Telefono FROM tPersona AS p INNER JOIN tNiñera AS n ON n.runNiñera = p.run"></asp:SqlDataSource>
    

</asp:Content>

