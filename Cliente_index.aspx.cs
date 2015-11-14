using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class indexCliente : System.Web.UI.Page
{
    public sql sql = new sql();
    public String consulta = "select n.runNiñera, p.nombres, p.apellidoPaterno,p.apellidoMaterno,(cast(DATEDIFF(dd,fechaNacimiento,GETDATE())/365.25 as int))as edad, r.descripcion, c.descripcionComuna, n.descripcion, n.fotoPerfil  from tNiñera n inner join tPersona p on p.run = n.runNiñera inner join tDireccion d on d.idDireccion = p.idDireccion inner join tRegion r on r.idRegion = d.idRegion inner join tComuna c on c.idComuna = d.idComuna";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack){
            llenarDrops();
            string query = this.consulta;
        }

    }
    public void llenarDrops()
    {
        sql.llenaDropDown(DropRegion, "select * from tRegion", "tRegion", "descripcion", "idRegion");
        sql.llenaDropDown(DropProvincia, "select * from tProvincia", "tProvincia", "descripcionprovincia", "idProvincia");
        sql.llenaDropDown(DropComuna, "select*from tComuna", "tComuna", "descripcionComuna", "idComuna");
    }

    public string verPorRegion(string stringConsulta) 
    {
        consulta = "select n.runNiñera, p.nombres," +
        "p.apellidoPaterno,p.apellidoMaterno,(cast(DATEDIFF(dd,fechaNacimiento,GETDATE())/365.25 as int))" +
        "as edad, r.descripcion, c.descripcionComuna,n.descripcion, n.fotoPerfil  from tNiñera n inner join " +
        "tPersona p on p.run = n.runNiñera inner join tDireccion d on d.idDireccion = p.idDireccion inner join " +
        "tRegion r on r.idRegion = d.idRegion inner join tComuna c on c.idComuna = d.idComuna inner join " +
        "tProvincia pro on pro.idProvincia = c.idProvincia where r.idRegion="+stringConsulta;
        return consulta;


    }
    public string verPorProvincia(string stringConsulta)
    {
        consulta="select n.runNiñera, p.nombres,"+
            "p.apellidoPaterno,p.apellidoMaterno,(cast(DATEDIFF(dd,fechaNacimiento,GETDATE())/365.25 as int))"+
            "as edad, r.descripcion, c.descripcionComuna,n.descripcion, n.fotoPerfil  from tNiñera n inner join "+
            "tPersona p on p.run = n.runNiñera inner join tDireccion d on d.idDireccion = p.idDireccion inner join "+
            "tRegion r on r.idRegion = d.idRegion inner join tComuna c on c.idComuna = d.idComuna inner join "+
            "tProvincia pro on pro.idProvincia = c.idProvincia where c.idProvincia="+stringConsulta;
        return consulta;

    }
    public string verPorComuna(string stringConsulta)
    {
        consulta = "select n.runNiñera, p.nombres,"+ 
        "p.apellidoPaterno,p.apellidoMaterno,(cast(DATEDIFF(dd,fechaNacimiento,GETDATE())/365.25 as int))"+
        "as edad, r.descripcion, c.descripcionComuna,n.descripcion, n.fotoPerfil  from tNiñera n inner join "+
        "tPersona p on p.run = n.runNiñera inner join tDireccion d on d.idDireccion = p.idDireccion inner join "+
        "tRegion r on r.idRegion = d.idRegion inner join tComuna c on c.idComuna = d.idComuna where c.idComuna=" + stringConsulta;
        return consulta;
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
        try
        {
            sql.llenaDropDown(DropProvincia, "select * from tProvincia where idRegion=" + DropRegion.SelectedValue.ToString(), "tProvincia", "descripcionProvincia", "idProvincia");
            verPorRegion(DropRegion.SelectedValue.ToString());
        }catch(Exception){}    
    }
    protected void DropProvincia_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            sql.llenaDropDown(DropComuna, "select * from tComuna where idProvincia=" + DropProvincia.SelectedValue.ToString(), "tComuna", "descripcionComuna", "idComuna");
            verPorProvincia(DropProvincia.SelectedValue.ToString());

        }catch(Exception){}
    }
    protected void DropComuna_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
          verPorComuna(DropComuna.SelectedValue.ToString());

        }catch(Exception){}
    }


    public string Url_Codificada(string cadena)
    {
        byte[] cadenaByte = new byte[cadena.Length];
        cadenaByte = System.Text.Encoding.UTF8.GetBytes(cadena);
        string encodedCadena = Convert.ToBase64String(cadenaByte);
        return encodedCadena;
    }

    public string Url_Decodificada(string cadena)
    {
        var encoder = new System.Text.UTF8Encoding();
        var utf8Decode = encoder.GetDecoder();

        byte[] cadenaByte = Convert.FromBase64String(cadena);
        int charCount = utf8Decode.GetCharCount(cadenaByte, 0, cadenaByte.Length);
        char[] decodedChar = new char[charCount];
        utf8Decode.GetChars(cadenaByte, 0, cadenaByte.Length, decodedChar, 0);
        string result = new String(decodedChar);
        return result;
    }
}