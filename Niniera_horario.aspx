<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNiñera.master" AutoEventWireup="true" CodeFile="Niniera_horario.aspx.cs" Inherits="Niniera_horario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="borde"><H3>HACER MI HORARIO</H3></div>
    <div class="textoIndex">
        <div class="row well">
            <div class="col-md-4">
                <p><strong>Fecha:</strong> <asp:TextBox ID="TextBox1" CssClass="Txt" runat="server" TextMode="Date"></asp:TextBox></p>
            </div>
            <div class="col-md-4">
                <p><strong>Hora inicio:</strong> <asp:TextBox ID="TextBox2" CssClass="Txt" runat="server" TextMode="Time" Height="20px" Width="95px"></asp:TextBox></p>
            </div>
            <div class="col-md-4">
                <p><strong>Hora fin:</strong> <asp:TextBox ID="TextBox3" CssClass="Txt" runat="server" TextMode="Time" Height="20px" Width="95px"></asp:TextBox></p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <p><strong>Tarea :</strong> <asp:TextBox placeHolder="Describe tu tarea" ID="TextBox4" CssClass="Txt" runat="server"></asp:TextBox></p>
            </div>
            <div class="col-md-4">
                <asp:Button Text="Agendar" class="btn btn-success" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-11">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </div> 
</asp:Content>

