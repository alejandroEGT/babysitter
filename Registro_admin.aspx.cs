using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BabySitters;

public partial class Registro_admin : System.Web.UI.Page
{
    sql sql =new sql();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            llenaDrop();
            
            
        }
    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }

    public void llenaDrop()
    {
        try
        {
            sql.llenaDropDown(DropRegion, "select * from tRegion", "tRegion", "descripcion", "idRegion");
            sql.llenaDropDown(DropProvincia, "select * from tProvincia", "tProvincia", "descripcionprovincia", "idProvincia");
            sql.llenaDropDown(DropComuna, "select*from tComuna", "tComuna", "descripcionComuna", "idComuna");
            sql.llenaDropDown(DropEstado, "select*from tEstado where idEstado not like '%2%'", "tEstado", "descripcionEstado", "idEstado");
        }
        catch (Exception) { }
    }
    protected void DropRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try {
        sql.llenaDropDown(DropProvincia, "select * from tProvincia where idRegion=" + DropRegion.SelectedValue.ToString(), "tProvincia", "descripcionProvincia", "idProvincia");
        }catch(Exception){}
    }
    protected void DropProvincia_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            sql.llenaDropDown(DropComuna, "select * from tComuna where idProvincia=" + DropProvincia.SelectedValue.ToString(), "tComuna", "descripcionComuna", "idComuna");
        }
        catch (Exception) { }   
    }
    protected void DropComuna_SelectedIndexChanged(object sender, EventArgs e)
    {
        try 
        {
        }catch(Exception){}
    }
    protected void DropRegion_DataBound(object sender, EventArgs e)
    {
        try
        {
            DropRegion.Items.Insert(0, new ListItem("-Seleccione-", ""));

        }
        catch (Exception) { }
    }

    protected void DropProvincia_DataBound(object sender, EventArgs e)
    {
        try
        {
            DropProvincia.Items.Insert(0, new ListItem("-Seleccione-", ""));
        }
        catch (Exception) { }
    }
    protected void DropComuna_DataBound(object sender, EventArgs e)
    {
        DropComuna.Items.Insert(0, new ListItem("-Seleccione-",""));
    }
    protected void Btn_Ingresar_Click(object sender, EventArgs e)
    {
        try 
        {

            if (TxtRut.Text.Equals("") || TxtCV.Text.Equals("") || TxtNombre.Text.Equals("") || TxtAP.Text.Equals("") || TxtAM.Text.Equals("") ||
                TxtFechaNac.Text.Equals("") || TxtCelu.Text.Equals("") || TxtCalle.Text.Equals("") || TxtNum.Text.Equals("") || TxtVillaP.Text.Equals("") ||
                DropRegion.SelectedIndex.Equals(0) || DropProvincia.SelectedIndex.Equals(0) || DropComuna.SelectedIndex.Equals("")|| TxtCorreo.Text.Equals("")||
                TxtClave.Text.Equals(""))
            {
                mensajeAlerta("faltan datos");
            }
            else {

                if (clsFunciones.ValidaRut(TxtRut.Text + "-" + TxtCV.Text))
                {
                    SqlDataReader verifica = sql.consulta("select*from tPersona where run =" + TxtRut.Text);
                    if (verifica.Read())
                    {
                        mensajeAlerta("Error, persona existente");
                    }
                    else
                    {
                        sql.consulta("exec ingresarAdmin " + TxtRut.Text + "," + TxtCV.Text + ",'" + TxtNombre.Text + "','" + TxtAP.Text + "','" + TxtAM.Text + "','" + TxtFechaNac.Text + "'," + TxtCelu.Text + ",'" + TxtCalle.Text + "'," + TxtNum.Text + ",'" + TxtVillaP.Text + "'," + DropRegion.SelectedValue + "," + DropProvincia.SelectedValue + "," + DropComuna.SelectedValue + ",'" + TxtCorreo.Text + "','" + TxtClave.Text + "'," + DropEstado.SelectedValue + "");
                        mensajeAlerta("Administrador registrado");
                    }
                }
                else {
                    mensajeAlerta("Rut no Valido!!");
                }
            
            }
        }
        catch(Exception){}
    }
}