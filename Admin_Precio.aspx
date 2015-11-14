<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_Precio.aspx.cs" Inherits="Admin_Precio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%
        
        verPrecio = sql.consulta("select descripcionPrecio from tPrecioNiniera");
        if (verPrecio.Read()) 
        {
            valor = verPrecio[0].ToString();
        }
         %>
    <div class="textoIndex">
        
        <h3><strong>Precio de niñera</strong></h3>
        <hr />
    
        <h4><p>Precio por hora $ :  <asp:TextBox ID="TxtPrecio" CssClass="Txt" runat="server" TextMode="Number"></asp:TextBox>
            <small>Valor para todas las niñeras <%=valor %>.</small>
        </p></h4>
        <br />
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Ingresar / Actualizar" OnClick="Button1_Click" />
    </div>

</asp:Content>

