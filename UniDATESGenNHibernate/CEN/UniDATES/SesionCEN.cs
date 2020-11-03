

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

public int IniciarSesion (Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        SesionEN sesionEN = null;
        int oid;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.FechaInicio = p_fechaInicio;

        sesionEN.FechaFin = p_fechaFin;

        //Call to SesionCAD

        oid = _ISesionCAD.IniciarSesion (sesionEN);
        return oid;
}

public int IniciarSesionconHuella (Nullable<DateTime> p_fechaInicio, Nullable<DateTime> p_fechaFin)
{
        SesionEN sesionEN = null;
        int oid;

        //Initialized SesionEN
        sesionEN = new SesionEN ();
        sesionEN.FechaInicio = p_fechaInicio;

        sesionEN.FechaFin = p_fechaFin;

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
