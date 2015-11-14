using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BabySitters;

public partial class registro_Clente : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            llenarDrops();
        }
    }

    public void llenarDrops()
    {
        sql.llenaDropDown(DropEstado,"select*from tEstado where idEstado not like '%2%'","tEstado","descripcionEstado","idEstado");
        sql.llenaDropDown(DropRegion, "select * from tRegion", "tRegion", "descripcion", "idRegion");
        sql.llenaDropDown(DropProvincia, "select * from tProvincia", "tProvincia", "descripcionprovincia", "idProvincia");
        sql.llenaDropDown(DropComuna, "select*from tComuna", "tComuna", "descripcionComuna", "idComuna");
    }

    public void mensajeAlerta(String texto) 
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('"+t+"');</script>");
    }

    public void Btn_Ingresar_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtRut.Text.Equals("") || TxtCV.Text.Equals("") || TxtNombre.Text.Equals("") || TxtAP.Text.Equals("") || TxtAM.Text.Equals("") || TxtFechaNac.Text.Equals("") ||
                 TxtCelu.Text.Equals("") || TxtCalle.Text.Equals("") || TxtNum.Text.Equals("") || TxtVillaP.Text.Equals("") || TxtCorreo.Text.Equals("") || TxtClave.Text.Equals("")||
                DropRegion.SelectedIndex.Equals(0)||DropComuna.SelectedIndex.Equals(0)||DropProvincia.SelectedIndex.Equals(0))
            {
                /*esta condicion no muestra nada porque en javascript ya esta en alerta*/
            }
            else
            {
                if(clsFunciones.ValidaRut(TxtRut.Text+"-"+TxtCV.Text))
                { 
                    int rut = int.Parse(TxtRut.Text), cv = int.Parse(TxtCV.Text), celu = int.Parse(TxtCelu.Text),
                       num = int.Parse(TxtNum.Text), region = int.Parse(DropRegion.SelectedValue.ToString()), prov = int.Parse(DropProvincia.SelectedValue),
                       comuna = int.Parse(DropComuna.SelectedValue), estado = int.Parse(DropEstado.SelectedValue);
                    string nom = TxtNombre.Text, ap = TxtAP.Text, am = TxtAM.Text, calle = TxtCalle.Text, villaP = TxtVillaP.Text,
                        correo = TxtCorreo.Text, clave = TxtClave.Text, fnac = TxtFechaNac.Text;

                    Cliente c = new Cliente(rut, cv, celu, num, region, prov, comuna, estado, nom, ap, am, calle, villaP, correo, clave, fnac);

                    SqlDataReader verificarCliente = sql.consulta("select run from tPersona where run = "+c.muestraRut());

                    if (verificarCliente.Read())
                    {

                        mensajeAlerta("error, usuario ya esta en el sistema");
                    }
                    else
                    {
                        sql.consulta("exec ingresarCliente " + c.muestraRut() + "," + c.muestraCV() + ",'" + c.muestraNombre() + "','" + c.muestraAP() + "','" + c.muestraAM() + "','" + c.muestraFechaNac() + "'," + c.muestraCelular() + ",'" + c.muestraCalle() + "'," + c.muestraNumero() + ",'" + c.muestraVillaP() + "'," + c.muestraIdRegion() + "," + c.muestraidProv() + "," + c.muestraIdCom() + "," + c.muestraIdEstado() + ",'" + c.muestraCorreo() + "','" + c.muestraClave() + "'");
                        mensajeAlerta("usuario ingresado ");
                    }
               }
            }
            
        }
        catch (Exception) { }
        
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
        try
        {
            DropComuna.Items.Insert(0, new ListItem("-Seleccione-", ""));

        }
        catch (Exception) { }
    }
    protected void DropRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        sql.llenaDropDown(DropProvincia, "select * from tProvincia where idRegion=" + DropRegion.SelectedValue.ToString(), "tProvincia", "descripcionProvincia", "idProvincia");
    }
    protected void DropProvincia_SelectedIndexChanged(object sender, EventArgs e)
    {
        sql.llenaDropDown(DropComuna, "select * from tComuna where idProvincia=" + DropProvincia.SelectedValue.ToString(), "tComuna", "descripcionComuna", "idComuna");
    }
}