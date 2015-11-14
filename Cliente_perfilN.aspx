<%@ Page Title="" Language="C#" MasterPageFile="~/MasterCliente.master" AutoEventWireup="true" CodeFile="Cliente_perfilN.aspx.cs" Inherits="Cliente_perfilN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <script type="text/javascript">
      $(document).ready(function(){
      $(".btnCal").click(function(){
        $("#myModal").modal('show');
        });
     });
     </script>
    <div class="modals">
        
    </div>
    <div class="nn">
        <div class="row">
            <div class="col-md-3 ">

                    <img src="<%=fotoPerfil %>" class="img-thumbnail" height="250" width="270" />
            
            </div>
                <div class="col-md-4">
            
                    <h4><%=nombre %></h4>
                    <h4><img src="imagenes/img/u.png"/ height="23" width="30"/> <%=direccion %></h4>
                    <h5>Tiene <%=edad+" " %>años</h5>
                    <h5>Estudió <%=estudio %></h5>
                    <h5><strong>Descripcion:</strong> <%=descripcion %></h5>
                    <h5>numero de celular <%=celular %></h5>
                    <h5>Correo electrónico <strong><%=correo %></strong></h5>
            
                </div>
            <div class="col-md-5">
                
                    <h4>Tiene 12 <img src="imagenes/img/estrella.png" height="20" width="20" /><small>(Estrellas de valoración).</small></h4>
                  <strong>&nbsp;&nbsp; Votar : </strong>
                <div class="ec-stars-wrapper">
                    <asp:LinkButton ID="LinkButton2"  runat="server">&#9733;</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton6"  runat="server">&#9733;</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton5"  runat="server">&#9733;</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton4"  runat="server">&#9733;</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3"  runat="server">&#9733;</asp:LinkButton>
                </div>   
                <br /><br />
                <asp:Button Text="Comenta" class="btn btn-info" runat="server" />
                <br /><br />
               <!-- Button HTML (to Trigger Modal) -->
            <a href="#myModal" role="button" class="btn btn-large btn-primary" data-toggle="modal">Disponibilidad</a><br /><br />
                <asp:Button Text="Solicitar" class="btn btn-success" runat="server" OnClick="Unnamed1_Click" />
                <br /><br />
                <asp:Label id="label" runat="server" />
 
                    <!-- Modal HTML -->
                    <div id="myModal" class="modal fade">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                    <h4 class="modal-title">Tiempo ocupado</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="bodyModal"></div>
                                    <h4>dslskmdlksaml</h4>
                                    

                                    </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    <button type="button" class="btn btn-primary">Save changes</button>
                                </div>
                            </div>
                        </div>
                    </div>

            </div>
                
          </div>
    </div>
    <br />
</asp:Content>

