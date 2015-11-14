using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace BabySitters
{
    public class clsFunciones {
        private static TextInfo myTIes = new CultureInfo("es-ES", false).TextInfo;

        public static bool ValidaRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return validacion;
        }
        public bool ValidaRut(string rut, string dv)
        {
            return ValidaRut(rut + "-" + dv);
        }
        public string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }
        public Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public static Boolean ValidaCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static string ToTitulo(string Texto)
        {            
            return myTIes.ToTitleCase(Texto);
        }
        public static string ToMinuscula(string Texto)
        {
            return myTIes.ToLower(Texto);
        }
        public static string ToMayuscula(string Texto)
        {
            return myTIes.ToUpper(Texto);
        }
    }
    public class clsSql
    {
        private static string NombreServidor = "localhost";
        private static string NombreBaseDatos = "BdBabysitters";
        private string conexion = "Data Source=" + NombreServidor + ";Initial Catalog=" + NombreBaseDatos + ";Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection con;
        DataSet sqlDataset;

        public clsSql()
        {
            con = new SqlConnection(conexion);
        }

        public SqlConnection obtenerConexion()
        {
            return con;
        }
        public DataTable procedimientos(string consulta)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(consulta, con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                da.Fill(ds, "bla");
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        public SqlDataReader consulta(String sentencia)
        {
            conectar();
            try
            {

                SqlCommand comando = new SqlCommand(sentencia, con);
                SqlDataReader reader;
                reader = comando.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
            }
        }
        public void desconectar()
        {
            con.Close();
        }
        public void ejecutar(string sentencia)
        {
            conectar();
            try
            {
                SqlCommand Command = new SqlCommand(sentencia, con);
                Command.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            finally { desconectar(); }
        }

        public bool comprobarUsuario(string sentencia)
        {
            conectar();
            try
            {
                SqlCommand comando = new SqlCommand(sentencia, con);
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { desconectar(); }
        }
        //public void llenaDropDown(DropDownList dw, String sentencia, String nombre, String valor, String id)
        //{
        //    conectar();
        //    DataSet Ds = new DataSet();
        //    SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        //    Adapter.Fill(Ds, nombre);
        //    dw.DataSource = Ds.Tables[0].DefaultView;
        //    dw.DataTextField = valor;
        //    dw.DataValueField = id;
        //    dw.DataBind();
        //    desconectar();
        //}
        //public void llenarLista(ListBox dw, String sentencia, String nombre, String valor, String id)
        //{
        //    conectar();
        //    DataSet Ds = new DataSet();
        //    SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        //    Adapter.Fill(Ds, nombre);
        //    dw.DataSource = Ds.Tables[0].DefaultView;
        //    dw.DataTextField = valor;
        //    dw.DataValueField = id;
        //    dw.DataBind();
        //    desconectar();
        //}
        public String obtenerId(String sentencia)
        {
            conectar();
            try
            {
                String var = "";
                SqlCommand comando = new SqlCommand(sentencia, con);
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    var = reader.GetValue(0).ToString();
                    return var;
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception ex)
            {
                return "error";
            }
        }
        //public void llenaCheckList(CheckBoxList dw, String sentencia, String nombre, String valor, String id)
        //{
        //    conectar();
        //    DataSet Ds = new DataSet();
        //    SqlDataAdapter Adapter = new SqlDataAdapter(sentencia, con);
        //    Adapter.Fill(Ds, nombre);
        //    dw.DataSource = Ds.Tables[0].DefaultView;
        //    dw.DataTextField = valor;
        //    dw.DataValueField = id;
        //    dw.DataBind();
        //    desconectar();
        //}
        //public void llenaGrilla(GridView gv, String Consulta, String nombre)
        //{
        //    try
        //    {
        //        SqlCommand objComand = new SqlCommand(Consulta, con);
        //        SqlDataAdapter objAdapter = new SqlDataAdapter();
        //        objAdapter.SelectCommand = objComand;
        //        conectar();
        //        DataSet objDS = new DataSet();
        //        objAdapter.Fill(objDS, "usuarios");
        //        desconectar();
        //        gv.DataSource = objDS;
        //        gv.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
    }//cls Sql
    namespace Mantenedores
    {
        public class Region
        {
            private Int32 Id=0;
            private String Des="";
            public Int32 IdRegion
            {
                get { return Id; }
                set { Id = value; }
            }//IdRegion
            public String NombreRegion
            {
                get { return Des; }
                set { Des = value; }
            }//NombreRegion
            public void LimparRegion()
            {
                IdRegion=0;
                NombreRegion="";
            }//LimparRegion
            public void GuardarRegion()
            {
                if (!NombreRegion.Equals("")) { return; }
                clsSql Cn = new clsSql();
                if (IdRegion == 0)
                {
                    Cn.ejecutar("insert into tRegion values ((select (MAX(idRegion)+1) from tRegion), '" + NombreRegion + "')");                    
                }
                else {
                    Cn.ejecutar("update tRegion set descripcion = '" + NombreRegion + "' where idRegion = " + IdRegion);                    
                }
                LimparRegion();
            }//GuardarRegion
            public void EliminarRegion()
            {
                clsSql Cn = new clsSql();
                if (IdRegion != 0)
                {
                    Cn.ejecutar("delete from tRegion where idRegion = " + IdRegion);
                }                
                LimparRegion();
            }//EliminarRegion
        }//cls Region
        public class Provincia:Region 
        {
            private Int32 Id = 0;
            private String Des = "";
            public Int32 IdProvincia
            {
                get { return Id; }
                set { Id = value; }
            }//IdProvincia
            public String NombreProvincia
            {
                get { return Des; }
                set { Des = value; }
            }//NombreProvincia
            public void LimparProvincia()
            {
                IdProvincia = 0;
                NombreProvincia = "";
                LimparRegion();
            }//LimparProvincia
            public void GuardarProvincia()
            {
                clsSql Cn = new clsSql();
                if (IdRegion == 0)
                {
                    if (NombreRegion.Equals("")) { return; }
                    IdRegion = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idRegion),0) from tRegion where descripcion = '" + NombreRegion + "'"));
                }
                else {
                    IdRegion = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idRegion),0) from tRegion where idRegion = "+ IdRegion));
                }
                if (IdRegion == 0) { return; }
                if (NombreProvincia.Equals("")) { return; }                
                if (IdProvincia == 0)
                {
                    Cn.ejecutar("insert into tProvincia values ((select (MAX(idProvincia)+1) from tProvincia), '" + NombreProvincia + "', " + IdRegion + ")");
                }
                else
                {
                    Cn.ejecutar("update tProvincia set descripcionProvincia = '" + NombreProvincia + "', idRegion = " + IdRegion + " where idProvincia = " + IdProvincia);
                }
                LimparProvincia();
            }//GuardarProvincia
            public void EliminarProvincia()
            {
                clsSql Cn = new clsSql();
                if (IdProvincia != 0)
                {
                    Cn.ejecutar("delete from tProvincia where idProvincia = " + IdProvincia);
                }
                LimparProvincia();
            }//EliminarProvincia
        }//cls Provincia
        public class Comuna:Provincia
        {
            private Int32 Id_Comuna = 0;
            private String DesComuna = "";
            public Int32 IdComuna
            {
                get { return Id_Comuna; }
                set { Id_Comuna = value; }
            }//IdComuna
            public String NombreComuna
            {
                get { return DesComuna; }
                set { DesComuna = value; }
            }//NombreComuna
            public void LimparComuna()
            {
                IdComuna = 0;
                NombreComuna = "";
                LimparProvincia();               
            }//LimparComuna
            public void GuardarComuna()
            {
                clsSql Cn = new clsSql();
                if (IdProvincia == 0)
                {
                    if (NombreProvincia.Equals("")) { return; }
                    IdProvincia = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idProvincia),0)+1 from tProvincia where descripcionProvincia = '" + NombreProvincia + "'"));
                }
                else
                {
                    IdProvincia = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idProvincia),0) from tProvincia where idProvincia = " + IdProvincia));
                }
                if (IdProvincia == 0) { return; }
                if (NombreComuna.Equals("")) { return; }
                if (IdComuna == 0)
                {
                    Cn.ejecutar("insert into tComuna values ((select (MAX(idComuna)+1) from tComuna), '" + NombreComuna + "', " + IdProvincia + ")");
                }
                else
                {
                    Cn.ejecutar("update tComuna set descripcionComuna = '" + NombreComuna + "', idProvincia = " + IdProvincia + " where idComuna = " + IdComuna);
                }
                LimparComuna();
            }//GuardarComuna
            public void EliminarComuna()
            {
                clsSql Cn = new clsSql();
                if (IdProvincia != 0)
                {
                    Cn.ejecutar("delete from tComuna where idComuna = " + IdComuna);
                }
                LimparProvincia();
            }//EliminarComuna
        }//cls Comuna
        public class Direccion : Comuna 
        {
            private Int32 id_Dir = 0,Num=0;
            private string Call = "", Vill = "";
            public Int32 IdDireccion 
            {
                get { return id_Dir; }
                set { id_Dir = value; }
            }//IdDireccion
            public Int32 NumeroCasa
            {
                get { return Num; }
                set { Num = value; }
            }//NumeroCasa
            public string NombreCalle
            {
                get { return Call; }
                set { Call = value; }
            }//NombreCalle
            public string VillaPoblacion
            {
                get { return Vill; }
                set { Vill = value; }
            }//VillaPoblacion

            public void LimpiarDireccion()
            {
                IdDireccion = 0;
                NumeroCasa = 0;
                NombreCalle = "";
                VillaPoblacion = "";
                LimparComuna();
            }//LimpiarDireccion
            public void GuardarDireccion()
            {
                clsSql Cn = new clsSql();
                IdComuna = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idComuna),0) from tComuna where idComuna = " + IdComuna));                                
                if (IdComuna == 0) { return; }
                IdProvincia = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idProvincia),0) from tComuna where idComuna = " + IdComuna));
                if (IdProvincia == 0) { return; }
                IdRegion = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idRegion),0) from tProvincia where idProvincia = " + IdProvincia));
                if (IdRegion == 0) { return; }
                if (NumeroCasa==0) { return; }
                if (NombreCalle.Equals("")) { return; }
                if (VillaPoblacion.Equals("")) { return; }
                if (IdDireccion == 0)
                {
                    Cn.ejecutar("insert into tDireccion values ((select (MAX(idDireccion)+1) from tDireccion), '" + NombreCalle + "', " + NumeroCasa + ", '" + VillaPoblacion + "', " + IdRegion + ", " + IdProvincia + ", " + IdComuna + " )");
                }
                else
                {
                    Cn.ejecutar("update tDireccion set calle = '" + NombreCalle + "', numero = " + NumeroCasa + ", villaPoblacion = '" + VillaPoblacion + "', idRegion = " + IdRegion + ", idProvincia = " + IdProvincia + ", idComuna = " + IdComuna + " where idDireccion = " + IdDireccion);
                }
                LimpiarDireccion();
            }//GuardarDireccion
            public void EliminarDireccion()
            {
                if (IdDireccion == 0) { return; }
                clsSql Cn = new clsSql();
                IdDireccion = Convert.ToInt32(Cn.obtenerId("select ISNULL(max(idDireccion),0) from tDireccion where idDireccion = " + IdDireccion));
                if (IdDireccion == 0) { return; }
                Int32 Run = Convert.ToInt32(Cn.obtenerId("select ISNULL(MAX(run),0) from tPersona where idDireccion = " + IdDireccion));
                if (Run == 0)
                {
                    Cn.ejecutar("delete from tDireccion where idDireccion = " + IdDireccion);
                }
                LimpiarDireccion();
            }//EliminarDireccion
        }//cls Direccion
        public class Persona:Direccion 
        {
            private string Rut, Dv, Nom, ApPaterno, ApMaterno, Correo;
            private Int32 Run, Fono;
            private DateTime FNacto;
            public Int32 RunPersona
            {
                get { return Run; }                
            }//RunPersona
            public string DvPersona
            {
                get { return Dv; }
            }//DvPersona
            public string RutPersona
            {
                get { return Rut; }
                set { 
                        if (clsFunciones.ValidaRut(value)){
                            Rut=value;
                            string RunP = Rut;
                            RunP = RunP.ToUpper();
                            RunP = RunP.Replace(".", "");
                            RunP = RunP.Replace("-", "");
                            Run = int.Parse(RunP.Substring(0, RunP.Length - 1));
                            Dv = Convert.ToString(RunP.Substring(RunP.Length - 1, 1));
                        }else{
                            Rut="";
                            Run = 0;
                            Dv = "";
                           // MessageBox.Show("Rut Invalido");
                        }
                    }
            }//RutPersona
            public string NombresPersona
            {
                get { return Nom; }
                set { Nom = clsFunciones.ToTitulo(value); }
            }//NombrePersona
            public string ApellidoPaterno
            {
                get { return ApPaterno; }
                set { ApPaterno = clsFunciones.ToTitulo(value); }
            }//ApellidoPaterno
            public string ApellidoMaterno
            {
                get { return ApMaterno; }
                set { ApMaterno = clsFunciones.ToTitulo(value); }
            }//ApellidoMaterno
            public string CorreoElectronico
            {
                get { return Correo; }
                set
                {
                    if (clsFunciones.ValidaCorreo(value))
                    {
                        Correo = clsFunciones.ToMinuscula(value);
                    }
                    else { Correo = ""; }
                    
                }
            }//CorreoElectronico
            public Int32 TelefonoPersona
            {
                get { return Fono; }
                set { Fono = value; }
            }//TelefonoPersona
            public DateTime FechaNacimiento
            {
                get { return FNacto; }
                set { FNacto = value; }
            }//FechaNacimiento
            public void LimpiarPersona()
            {
                RutPersona="";
                NombresPersona = "";
                ApellidoPaterno = "";
                ApellidoMaterno = "";
                //FechaNacimiento = "";
                CorreoElectronico = "";
                TelefonoPersona = 0;
                LimpiarDireccion();
            }//LimpiarPersona
            public void GuardarPersona()
            {
                clsSql Cn = new clsSql();
                if (DvPersona.Equals("")) { return; }
                if (NombresPersona.Equals("")) { return; }
                if (ApellidoPaterno.Equals("")) { return; }
                if (ApellidoMaterno.Equals("")) { return; }
                //if (FechaNacimiento. == "") { return; }
                if (CorreoElectronico.Equals("")) { return; }
                if (IdDireccion == 0) { return; }
                if (TelefonoPersona == 0) { return; }

                if (RunPersona == 0)
                {
                    Cn.ejecutar("insert into tPersona values (" + RunPersona + ", '" + DvPersona + "', '" + NombresPersona + "', '" + ApellidoPaterno + "', '" + ApellidoMaterno + "', '" + FechaNacimiento.ToShortDateString() + "', '" + CorreoElectronico + "', " + IdDireccion + ", " + TelefonoPersona + " )");
                }
                else
                {
                    Cn.ejecutar("update tPersona set nombres = '" + NombresPersona + "', apellidoPaterno = '" + ApellidoPaterno + "', apellidoMaterno = '" + ApellidoMaterno + "', fechaNacimiento = " + FechaNacimiento.ToShortDateString() + ", correoElectronico = '" + CorreoElectronico + "', idDireccion = " + IdDireccion + ", telefono = " + TelefonoPersona + " where run = " + RunPersona);
                }
                LimpiarPersona();
            }//GuardarPersona
        }//cls Persona
    }
}
