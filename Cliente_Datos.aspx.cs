using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
public partial class Cliente_Datos : System.Web.UI.Page
{
    sql sql= new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack){
            llenarDatos();
        }

    }
    public void llenarDatos() 
    {
        try { 
       
        
        SqlDataReader llena = sql.consulta("exec misDatos "+Session["rutC"]+"");
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
            sql.llenaDropDown(DropRegion, "exec regionPersona  " + Session["rutC"].ToString(), "tRegion", "descripcion", "idRegion");
            sql.llenaDropDown(DropProv, "exec provinciaPersona " + Session["rutC"].ToString(), "tProvincia", "descripcionProvincia", "idProvincia");
            sql.llenaDropDown(DropComuna, "exec comunapersona  " + Session["rutC"].ToString(), "tComuna", "descripcionComuna", "idComuna");
            
        }
        
        }catch(Exception){}
        }

}
