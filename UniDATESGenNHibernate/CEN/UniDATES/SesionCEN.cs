

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.Exceptions;

using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;


namespace UniDATESGenNHibernate.CEN.UniDATES
{
/*
 *      Definition of the class SesionCEN
 *
 */
public partial class SesionCEN
{
private ISesionCAD _ISesionCAD;

public SesionCEN()
{
        this._ISesionCAD = new SesionCAD ();
}

public SesionCEN(ISesionCAD _ISesionCAD)
{
        this._ISesionCAD = _ISesionCAD;
}

public ISesionCAD get_ISesionCAD ()
{
        return this._ISesionCAD;
}

public int IniciarSesion (Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin, int p_usuario, int p_administrador)
{
        SesionEN sesionEN = null;
        int oid;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.FechaInicio = p_fechaInicio;

        sesionEN.FechaFin = p_fechaFin;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idSesion
                sesionEN.Usuario = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                sesionEN.Usuario.IdUsuario = p_usuario;
        }


        if (p_administrador != -1) {
                // El argumento p_administrador -> Property administrador es oid = false
                // Lista de oids idSesion
                sesionEN.Administrador = new UniDATESGenNHibernate.EN.UniDATES.AdministradorEN ();
                sesionEN.Administrador.IdAdministrador = p_administrador;
        }

        //Call to SesionCAD

        oid = _ISesionCAD.IniciarSesion (sesionEN);
        return oid;
}

public int IniciarSesionconHuella (Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin, int p_usuario, int p_administrador)
{
        SesionEN sesionEN = null;
        int oid;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.FechaInicio = p_fechaInicio;

        sesionEN.FechaFin = p_fechaFin;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idSesion
                sesionEN.Usuario = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                sesionEN.Usuario.IdUsuario = p_usuario;
        }


        if (p_administrador != -1) {
                // El argumento p_administrador -> Property administrador es oid = false
                // Lista de oids idSesion
                sesionEN.Administrador = new UniDATESGenNHibernate.EN.UniDATES.AdministradorEN ();
                sesionEN.Administrador.IdAdministrador = p_administrador;
        }

        //Call to SesionCAD

        oid = _ISesionCAD.IniciarSesionconHuella (sesionEN);
        return oid;
}

public void FinalizarSesion (int idSesion
                             )
{
        _ISesionCAD.FinalizarSesion (idSesion);
}

public void Modify (int p_Sesion_OID, Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        SesionEN sesionEN = null;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.IdSesion = p_Sesion_OID;
        sesionEN.FechaInicio = p_fechaInicio;
        sesionEN.FechaFin = p_fechaFin;
        //Call to SesionCAD

        _ISesionCAD.Modify (sesionEN);
}
}
}
