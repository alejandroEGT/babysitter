using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MasterCliente : System.Web.UI.MasterPage
{
    public sql sql = new sql();
    public string nombre;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            borrarCache();
            llenarDatos();
        }
    }

    public void llenarDatos()
    {
        try
        {


            SqlDataReader llena = sql.consulta("exec misDatos " + Session["rutC"] + "");
            if (llena.Read())
            {
                TxtNombre.Text = llena[2].ToString();
                Txtap.Text = llena[3].ToString();
                TxtAm.Text = llena[4].ToString();
                Txtcelu.Text = llena[8].ToString();
                Txtcalle.Text = llena[13].ToString();
                TxtNum.Text = llena[14].ToString();
                Txtvp.Text = llena[15].ToString();
                TxtCorreo.Text = llena[6].ToString();
                TxtPass.Attributes.Add("value", llena[11].ToString().ToUpperInvariant());
                DropRegion.DataTextField = HttpUtility.HtmlDecode(Session["rutC"].ToString());
                DropProv.SelectedValue = llena[16].ToString();
                DropComuna.SelectedValue = llena[16].ToString();

            }

        }
        catch (Exception) { }
    }
    public void borrarCache(){
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
    }
}
