using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Descripción breve de Niñera
/// </summary>
public class Niñera
{
    public int rut, cv, celular, numero, idRegion, idProv, idCom, idEstado;
    public string nombre, apellidoP, apellidoM,Descrip , calle, villaP, carrera,casaEstudio ,correo, clave, fotoPerfil;
    public DateTime fechaNac;

	public Niñera(int rut, int cv, int celular, int numero, int idRegion, int idProv, int idCom, int idEstado,
       string nombre, string ap, string am, DateTime fnac, string descrip, string calle, string villaP, string carrera,
        string casaEstudio, string correo, string clave, string fotoPerfil)
	{
        this.rut = rut;
        this.cv = cv;
        this.celular = celular;
        this.numero = numero;
        this.idRegion = idRegion;
        this.idProv = idProv;
        this.idCom = idCom;
        this.idEstado = idEstado;
        this.nombre = nombre;
        this.apellidoP = ap;
        this.apellidoM = am;
        this.fechaNac = fnac;
        this.Descrip = descrip;
        this.calle = calle;
        this.villaP = villaP;
        this.carrera = carrera;
        this.casaEstudio = casaEstudio;
        this.correo = correo;
        this.clave = clave;
        this.fotoPerfil = fotoPerfil;
	}

    public void ingresaRut(int rut)
    {
        this.rut = rut;
    }
    public int muestraRut()
    {
        return rut;
    }
    public void ingresarCV(int cv)
    {
        this.cv = cv;
    }
    public int mostrarCV()
    {
        return cv;
    }
    public void ingresCelular(int celu)
    {
        this.celular = celu;
    }
    public int muestrCeluar()
    {
        return celular;
    }
    public void ingresaNumero(int numero)
    {
        this.numero = numero;
    }
    public int muestraNumero()
    {
        return numero;
    }
    public void ingresaIdRegion(int idRegion)
    {
        this.idRegion = idRegion;
    }
    public int muestraRegion()
    {
        return idRegion;
    }
    public void ingresaIdProv(int idProv)
    {
        this.idProv = idProv;
    }
    public int muestraIdProv()
    {
        return idProv;
    }
    public void ingresaIdCom(int idCom)
    {
        this.idCom = idCom;
    }
    public int muestraIdCom()
    {
        return idCom;
    }
    public void ingresaIdEstado(int idEstado)
    {
        this.idEstado = idEstado;
    }
    public int muestraIdEstado()
    {
        return idEstado;
    }
    public void ingresaNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public string muestraNombre()
    {
        return nombre;
    }
    public void ingresaApellidoP(string ap)
    {
        this.apellidoP = ap;
    }
    public string muestraApellidoP()
    {
        return apellidoP;
    }
    public void ingresaApellidoM(string am)
    {
        this.apellidoM = am;
    }
    public string muestraApellidoM()
    {
        return apellidoM;
    }
    public void ingresaFechaNac(DateTime fNac)
    {
        this.fechaNac = fNac;
    }
    public DateTime muestraFechaNac()
    {
        return fechaNac;
    }
    public void ingresaDescripcion(string descrip)
    {
        this.Descrip = descrip;
    }
    public string muestraDescripcion()
    {
        return Descrip;
    }
    public void ingresaCalle(string calle)
    {
        this.calle = calle;
    }
    public string muestraCalle()
    {
        return calle;
    }
    public void ingresaVillaP(string villaP)
    {
        this.villaP = villaP;
    }
    public string muestraVillaP()
    {
        return villaP;
    }
    public void ingresaCarrera(string carrera)
    {
        this.carrera = carrera;
    }
    public string muestraCarrera()
    {
        return carrera;
    }
    public void ingresaCasaestudio(string casaEstudio)
    {
        this.casaEstudio = casaEstudio;
    }
    public string muestraCasaestudio()
    {
        return casaEstudio;
    }
    public void ingresaCorreo(string correo)
    {
        this.correo = correo;
    }
    public string muestraCorreo()
    {
        return correo;
    }
    public void ingresaClave(string clave)
    {
        this.clave = clave;
    }
    public string muestraClave()
    {
        return clave;
    }
    public void ingresaFotoPerfil(string fotoPerfil)
    {
        this.fotoPerfil = fotoPerfil;
    }
    public string muestraFotoPerfil()
    {
        return fotoPerfil;
    }
}