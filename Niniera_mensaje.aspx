<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNiñera.master" AutoEventWireup="true" CodeFile="Niniera_mensaje.aspx.cs" Inherits="Niniera_mensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="borde">
        <h3>Mensajes</h3>
    </div>
    
    <%
        
        /*System.Data.SqlClient.SqlDataReader contacto;

        contacto = sql.consulta("select s.runCliente, concat(p.nombres,' ',p.apellidoPaterno)as nombre, "+
       " p.correoElectronico from tServicio s "+
       " inner join tPersona p on p.run = s.runCliente where runNiñera  = "+Session["rutN"].ToString());
       */
    %>
    <div class="textoIndex">
            <div class="row">
                <div class="col-md-8">
                    <strong>Contacto</strong>
                            
                    <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="343px">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="zzz" ShowHeader="True" Text="Botón" />
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
                    </div>
                <div class="col-md-4 ">
                    <strong>Contenido del mensaje</strong>
                    
                    <div class="textoMensaje">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                             <p>
                            <asp:Label id="lblNombreCliente" runat="server" /></p>
                        <p><asp:Label id="lblcorreo" runat="server" /></p>
                        <p><asp:Label id="lblfechas" runat="server" /></p>
                            </ContentTemplate>

                    </asp:UpdatePanel>
                    </div>
                </div>
            </div>

        
      

         


    </div>
</asp:Content>

