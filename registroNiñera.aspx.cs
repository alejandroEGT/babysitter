using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using BabySitters;


public partial class registroNiñera : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            llenarDrops();
           
        }

    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
    }
    public void llenarDrops()
    {
        try
        {
            sql.llenaDropDown(DropRegion, "select * from tRegion", "tRegion", "descripcion", "idRegion");
            sql.llenaDropDown(DropProvincia, "select * from tProvincia", "tProvincia", "descripcionprovincia", "idProvincia");
            sql.llenaDropDown(DropComuna, "select*from tComuna", "tComuna", "descripcionComuna", "idComuna");
            sql.llenaDropDown(DropEstado, "select*from tEstado where idEstado not like '%3%'", "tEstado", "descripcionEstado", "idEstado");
        }catch(Exception){}
    }


    protected void DropRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
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
    protected void CheckEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void Btn_Ingresar_Click(object sender, EventArgs e)
    {
        try
        {
            if (TxtRut.Text.Equals("") || TxtCV.Text.Equals("") || TxtNombre.Text.Equals("") || TxtAP.Text.Equals("") ||
                TxtAM.Text.Equals("") || TxtFechaNac.Text.Equals("") || TxtDescrip.Text.Equals("") || TxtCalle.Text.Equals("") ||
                TxtNum.Text.Equals("") || TxtVillaP.Text.Equals("") || TxtCelu.Text.Equals("") || TxtCarrera.Text.Equals("") || 
                TxtCestudio.Text.Equals("") || FileFoto.HasFile.Equals("")|| DropRegion.SelectedIndex.Equals(0)|| DropProvincia.SelectedIndex.Equals(0)||
                DropComuna.SelectedIndex.Equals(0))
            {
                mensajeAlerta("faltan campos por llenar");
            }
            else
            {
                    Boolean fileOK = false;
                    string fullPath = Path.Combine(Server.MapPath("~/imagenes/fotoNiñera"), FileFoto.FileName); ;
                    if (FileFoto.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(FileFoto.FileName).ToLower();
                        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                        for (int i = 0; i < allowedExtensions.Length; i++)
                        {
                            if (fileExtension == allowedExtensions[i])
                            {
                                fileOK = true;
                            }
                        }
                    }

                    if (fileOK)
                    {
                        if (clsFunciones.ValidaRut(TxtRut.Text + "-" + TxtCV.Text))
                        {

                            int rut = int.Parse(TxtRut.Text), cv = int.Parse(TxtCV.Text), numero = int.Parse(TxtNum.Text),
                            region = int.Parse(DropRegion.SelectedValue), provin = int.Parse(DropProvincia.SelectedValue),
                            comuna = int.Parse(DropComuna.SelectedValue), celu = int.Parse(TxtCelu.Text), estado = int.Parse(DropEstado.SelectedValue);
                            string nombre = TxtNombre.Text.Trim(), ap = TxtAP.Text.Trim(), am = TxtAM.Text.Trim(),
                            descrip = TxtDescrip.Text.Trim(), calle = TxtCalle.Text.Trim(), villaP = TxtVillaP.Text.Trim(), carrera = TxtCarrera.Text.Trim(),
                            CEstudio = TxtCestudio.Text.Trim(), correo = TxtCorreo.Text.Trim(), clave = TxtClave.Text.Trim(), fotoPerfli = "imagenes/fotoNiñera/" + FileFoto.FileName;
                            string fnac = TxtFechaNac.Text;
                            //Niñera n = new Niñera(rut,cv,celu,numero,region,provin,comuna,estado,nombre,ap,am,fnac,descrip,calle,villaP,carrera,CEstudio,correo,clave,fotoPerfli);

                            SqlDataReader verificaNiñera = sql.consulta("select run from tPersona where run =" + rut);

                            if (verificaNiñera.Read())
                            {
                                mensajeAlerta("error,Persona ya existente");
                            }
                            else
                            {

                                sql.consulta("exec ingresarNiñera " + rut + "," + cv + ",'" + nombre + "','" + ap + "','" + am + "','" + fnac + "','" + descrip + "','" + calle + "'," + numero + ",'" + villaP + "'," + region + "," + provin + "," + comuna + "," + celu + ",'" + carrera + "','" + CEstudio + "'," + estado + ",'" + correo + "','" + clave + "','" + fotoPerfli + "'");

                                mensajeAlerta("Usuario Registrado");
                                FileFoto.SaveAs(fullPath);//guarda la direccion completa de la foto en una carpeta
                            }
                        }
                        else {
                            mensajeAlerta("Rut no Valido!!!!");
                        }
                    
                    }
                    else
                    {
                        mensajeAlerta("Ingrese una foto de usted");
                    }

            }
        }catch(Exception){}
               
    
    }
    protected void FileFoto_Load(object sender, EventArgs e)
    {

    }
    protected void DropEstado_SelectedIndexChanged(object sender, EventArgs e)
    {

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
}
