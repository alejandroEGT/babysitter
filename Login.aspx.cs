using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtRut.Text.Equals("") || TxtClave.Text.Equals(""))
            {
                mensajeAlerta("llene los dos campos");
            }
            else
            {
               string rut = TxtRut.Text;
               string Rut = rut.Substring(0, rut.Length-2);
                String cv = rut.Substring(rut.Length -1, 1);
                

                SqlDataReader verifica_Niñera = sql.consulta("exec logearNiñera "+Rut+","+cv+",'"+TxtClave.Text+"'");
                if (verifica_Niñera.Read())
                {
                    Session["rutN"] = verifica_Niñera[0].ToString();
                    Session["passN"] = verifica_Niñera[15].ToString();
                    Response.Redirect("Niñera_index.aspx");

                }
                SqlDataReader verifica_Cliente = sql.consulta("exec logearCliente "+Rut+","+cv+",'"+TxtClave.Text+"'");
                if (verifica_Cliente.Read())
                {
                    Session["rutC"] = verifica_Cliente[0].ToString();
                    Session["passC"] = verifica_Cliente[11].ToString();
                    Response.Redirect("Cliente_index.aspx");

                }
                else {
                    mensajeAlerta("Error, No estas registrado");

                }

            }
        }catch(Exception){}
    }
}