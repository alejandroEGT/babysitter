<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNiñera.master" AutoEventWireup="true" CodeFile="Niniera_Contactar.aspx.cs" Inherits="Niniera_Contactar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde"><H3>CONTACTANOS</H3></div>
    <div class="textoIndex">
       <p><strong>Asunto:</strong> <asp:TextBox placeHolder="Asunto" ID="TextBox1" CssClass="Txt" runat="server"></asp:TextBox></p>
        <p>
            <textarea id="TxtComentario" runat="server" placeholder="Escribe...."  class="Txt"></textarea>
        </p>

        <p><asp:Button class="btn btn-success" Text="Enviar" runat="server" /></p>
    </div>

</asp:Content>

