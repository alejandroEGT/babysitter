<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.master" AutoEventWireup="true" CodeFile="Admin_PartesNacionales.aspx.cs" Inherits="Admin_PartesNacionales" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="textoIndex">
        <h3><strong>Partes Nacionales</strong> </h3>
        <hr />
        <div class="row">
            <div class="col-md-4 well">
                <strong>Region: </strong>
                <asp:TextBox ID="Txtregion" class="Txt" runat="server"></asp:TextBox>
                <br /><br />
                <strong>Ver Region: </strong>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>                       
                        <asp:DropDownList class="Txt" ID="DropRegion" runat="server" AutoPostBack="True"></asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="col-md-4"><br /><br />
                <asp:Button ID="ButtonRegion" class="btn btn-primary" runat="server" Text="Guardar" OnClick="ButtonRegion_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 well">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                      <p><strong>Seleccione Region:</strong></p><asp:DropDownList ID="DropRegio" CssClass="Txt" runat="server" AutoPostBack="True"></asp:DropDownList>
                    </ContentTemplate>
                     </asp:UpdatePanel>
                
                <p><strong>Provincia: </strong></p> <asp:TextBox ID="TxtProvincia" CssClass="Txt" runat="server"></asp:TextBox>
            </div>
             <div class="col-md-4">
                 <br /><br /><br />
                <asp:Button ID="ButtonProv" class="btn btn-primary" runat="server" Text="Guardar" OnClick="ButtonProv_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 well">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                      <p><strong>Seleccione provincia:</strong></p><asp:DropDownList ID="DropProvi" CssClass="Txt" runat="server"></asp:DropDownList>
                    </ContentTemplate>
                     </asp:UpdatePanel>
                
                <p><strong>Comuna: </strong></p><asp:TextBox ID="TxtComuna" CssClass="Txt" runat="server"></asp:TextBox>


                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                      <p><strong>Ver Comuna:</strong></p><asp:DropDownList ID="DropComuna" CssClass="Txt" runat="server" AutoPostBack="True"></asp:DropDownList>
                    </ContentTemplate>
                     </asp:UpdatePanel>

            </div>
             <div class="col-md-4">
                 <br /><br /><br /><br />
                <asp:Button ID="ButtonComuna" class="btn btn-primary" runat="server" Text="Guardar" OnClick="ButtonComuna_Click" />
                 <br />
                  
            </div>
        </div>
   </div>

</asp:Content>

