using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_PartesNacionales : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            llenadrop();
        }
       

    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
    public void llenadrop()
    {
        sql.llenaDropDown(DropRegion,"select*from tRegion","tRegion","descripcion","idRegion");
        sql.llenaDropDown(DropRegio, "select*from tRegion", "tRegion", "descripcion", "idRegion");
        sql.llenaDropDown(DropProvi, "select*from tProvincia", "tProvincia", "descripcionProvincia", "idProvincia");
        sql.llenaDropDown(DropComuna, "select*from tComuna", "tComuna", "descripcionComuna", "idComuna");
        
    }
    public void vaciarTXT() 
    {
        TxtComuna.Text = "";
        TxtProvincia.Text = "";
        Txtregion.Text = "";
    }
    protected void ButtonRegion_Click(object sender, EventArgs e)
    {
        try 
        {
            if (Txtregion.Text.Equals(""))
            {
                mensajeAlerta("Ingrese region");
            }
            else
            {
                sql.consulta("exec ingresarRegion '"+ Txtregion.Text+"'");
                llenadrop();
                vaciarTXT();
            }
            
        }
        catch(Exception){}
    }
    protected void ButtonProv_Click(object sender, EventArgs e)
    {
        try
        {
            if(TxtProvincia.Text.Equals(""))
            {
                mensajeAlerta("Ingrese provincia");
            }
            else{
                sql.consulta("exec ingresarprovincia '" + TxtProvincia.Text + "', " + DropRegio.SelectedValue);
                llenadrop();
                vaciarTXT();
            }
        }
        catch (Exception) { }
    }
    protected void ButtonComuna_Click(object sender, EventArgs e)
    {
        try
        {
            if(TxtComuna.Text.Equals(""))
            {
                mensajeAlerta("Ingrese Comuna");
            }
            else{
                sql.consulta("exec ingresarComuna '" + TxtComuna.Text + "'," + DropProvi.SelectedValue);
                llenadrop();
                vaciarTXT();
            }
        }
        catch (Exception) { }
    }
}