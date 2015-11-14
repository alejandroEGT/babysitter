<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div class="borde">
               <h3>LOGIN</h3>
            </div>
             <div id="formularioRegistro">
                      <div class="row">
                        <div class=" col-md-offset-4 col-md-3">
                             <label for="ejemplo_email_1">Rut:</label>
                            <asp:TextBox class="form-control" ID="TxtRut" runat="server" placeholder="Rut" Width="226px"></asp:TextBox>
                        </div>
                     </div>
                      <div class="row">
                        <div class="col-md-offset-4 col-md-3">
                            <label for="ejemplo_password_1">Contraseña</label>
                            <asp:TextBox class="form-control" ID="TxtClave" runat="server" placeholder="Contraseña" Width="224px" TextMode="Password"></asp:TextBox>
                            <br />
                        </div>
                     </div>
                     <div class="row">                           
                          <div class="col-md-offset-5 col-md-3" >
                                <asp:Button class="btn btn-success" runat="server" Text="Entrar" OnClick="Unnamed1_Click" />
                                <br /><br />
                                <h5><a href="Registro_index.aspx">Registrate aquí</a></h5>
                                <br /><br />
                            </div>
                    </div>
    
                       
                   
               
            </div>
</asp:Content>

