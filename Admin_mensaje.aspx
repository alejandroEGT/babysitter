<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_mensaje.aspx.cs" Inherits="Admin_mensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde">
        <h3>Mensajes</h3>
    </div>
    <div class="textoIndex">
        <div class="row">
                <div class="col-md-4">
                    <strong>Contacto</strong>
                        <div class="mensajes">
                           


                        </div>
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

