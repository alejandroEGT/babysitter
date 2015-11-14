<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNiñera.master" AutoEventWireup="true" CodeFile="Niñera_index.aspx.cs" Inherits="Niñera_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="borde"><H3>MI PERFIL</H3></div>
   <div class="textoIndex">
      
       <div class="row">
           <div class="col-md-3 well">
               <img src="#" alt="foto perfil" />
           </div>
           <div class="col-md-4">
               <h3>Nombre de la Niñera</h3>
           </div>
           <div class=" col-md-offset-2 col-md-2">
               <a href="#modalDatos" role="button" class="btn btn-large btn-primary" data-toggle="modal">Actualizar Datos</a>
           </div>
       </div>
       <div class="row">
           <div class=" col-md-offset-2 col-md-8 well">
               datos de la niñera.
           </div>

       </div>



       <div id="modalDatos" class="modal fade">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                    <h4 class="modal-title">Datos</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="bodyModal"></div>
                                    
                                            <div class="row">
                                                    <div class="col-md-4">
                                                       <strong>Nombre:</strong> <asp:TextBox ID="TxtNombre" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <strong>Apellido Paterno:</strong> <asp:TextBox ID="Txtap" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                         <strong>Apellido Materno:</strong> <asp:TextBox ID="TxtAm" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                                    </div>
                                                 </div>
                                          <div class="row">
                                            <div class="col-md-4">
                                                <strong>N° Celular:</strong> <asp:TextBox ID="Txtcelu" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4">
                                                <strong>Calle:</strong> <asp:TextBox ID="Txtcalle" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4">
                                                <strong>Numero:</strong> <asp:TextBox ID="TxtNum" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                            </div>
                                        </div>
        
                                        <div class="row">
                                            <div class="col-md-4">
                                                <strong>Villa/Poblacion:</strong> <asp:TextBox ID="Txtvp" class="Txt" runat="server" MaxLength="50"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4">
                                               <p><strong>Region:</strong></p><asp:DropDownList ID="DropRegion" runat="server"></asp:DropDownList>
                                            </div>
                                            <div class="col-md-4">
                                                <p><strong>Provincia:</strong></p> <asp:DropDownList ID="DropProv" runat="server"></asp:DropDownList>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-4">
                                                 <p><strong>Comuna:</strong></p> <asp:DropDownList ID="DropComuna" runat="server"></asp:DropDownList>
                                            </div>
                                            <div class="col-md-4">
                                                 <strong>Correo:</strong> <asp:TextBox ID="TxtCorreo" Class="Txt" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4">
                                                <strong>Clave:</strong> <asp:TextBox ID="TxtPass" Class="Txt" runat="server" TextMode="Password"></asp:TextBox>
                                            </div>

                                    </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                    <button type="button" class="btn btn-primary">Guardar</button>
                                </div>
                            </div>
                        </div>
                    </div>

   </div>
</asp:Content>

