<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_Estados.aspx.cs" Inherits="Admin_Estados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="textoIndex">

        <h3><strong>Estados</strong></h3>
        <hr />
       
        
                <p><strong>Estado:</strong> <asp:TextBox ID="TxtEstado" runat="server"></asp:TextBox></p>
                <br />
                <p><asp:Button ID="Btn_ingresar" class="btn btn-primary" runat="server" Text="Ingresar / Actualizar" OnClick="Btn_ingresar_Click" /></p>
            
                <asp:GridView ID="GridEstados" OnRowDataBound="GridEstados_RowDataBound" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="None" DataKeyNames="idEstado" OnSelectedIndexChanged="GridEstados_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="idEstado" HeaderText="idEstado" SortExpression="idEstado" ReadOnly="True" />
                        <asp:BoundField DataField="descripcionEstado" HeaderText="descripcionEstado" SortExpression="descripcionEstado" />
                        <asp:ButtonField ButtonType="Button" CommandName="Select" Text="borrar" />
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
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BdBabysittersConnectionString %>" SelectCommand="select * from tEstado"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BdBabysittersConnectionString %>" SelectCommand="select descripcionEstado from tEstado "></asp:SqlDataSource>
            
        
        
    </div>
</asp:Content>

