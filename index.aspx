<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="borde">
        <h3>TOP 10 MEJORES NIÑERAS</h3>
    </div>
    <div class="textoIndex">
 <%
            try
            {
                System.Data.SqlClient.SqlDataReader dr = sql.consulta("select p.run, p.nombres, p.apellidoPaterno, p.apellidoMaterno,(cast(DATEDIFF(dd,fechaNacimiento,GETDATE())/365.25 as int)) as edad,n.descripcion, n.fotoPerfil from tNiñera n inner join tPersona p on p.run = n.runNiñera");
                while (dr.Read())
                {
                    string runNiniera = dr[0].ToString();
                    string nombre = dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString();
                    string fechaNac = dr[4].ToString();
                    string desc = dr[5].ToString();
                    string fotoP = dr[6].ToString();
%>
                      <div class="TopNana well">
                            <img src="<%=fotoP%>" height="150" width="130" />
                            <h4><%=nombre%></h4>
                            <hr />
                            <p><strong>Edad:</strong><%=fechaNac+" "%>años.</p>
                            <p><%=desc%></p>
                            <a href="PerfilNiñera.aspx?idN=<%=Url_Codificada(runNiniera)%>"><input class="boton"type="button" name="name" value="Ver Perfil" /></a>
                     </div>
        
<%               }
                
          }catch (Exception) { } 
%>
        <br /><br />
    </div> 

   
</asp:Content>

