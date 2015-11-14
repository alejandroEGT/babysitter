using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Login : System.Web.UI.Page
{
    public sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            borrarCache();
        }
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
                mensajeAlerta("faltan datos");
            }
            else
            {
                string rut = TxtRut.Text;
                string Rut = rut.Substring(0, rut.Length - 2);
                String cv = rut.Substring(rut.Length - 1, 1);
                

                SqlDataReader verifica_Admin = sql.consulta("exec loginAdmin " +Rut+ ","+cv+",'" + TxtClave.Text + "'");
                if (verifica_Admin.Read())
                {
                    Session["rutA"] = verifica_Admin[0].ToString();
                    Session["passA"] = verifica_Admin[10].ToString();
                    Response.Redirect("Admin_index.aspx");
                }
                else
                {
                    mensajeAlerta("Error, No estas registrado");

                }
            }
        }
        catch (Exception) { }
    }
    public void borrarCache()
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
    }
}