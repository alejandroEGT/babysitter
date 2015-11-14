
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    public sql sql = new sql();
    
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public void mensajeAlerta(String texto)
    {
        String t = texto;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('" + t + "');</script>");
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