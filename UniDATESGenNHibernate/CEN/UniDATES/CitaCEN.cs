

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
 *      Definition of the class CitaCEN
 *
 */
public partial class CitaCEN
{
private ICitaCAD _ICitaCAD;

public CitaCEN()
{
        this._ICitaCAD = new CitaCAD ();
}

public CitaCEN(ICitaCAD _ICitaCAD)
{
        this._ICitaCAD = _ICitaCAD;
}

public ICitaCAD get_ICitaCAD ()
{
        return this._ICitaCAD;
}

public void Rechazar (int idCita
                      )
{
        _ICitaCAD.Rechazar (idCita);
}

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> DameChats (string usu_nombre)
{
        return _ICitaCAD.DameChats (usu_nombre);
}
public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.CitaEN> DamePendientes (string usu_nombre)
{
        return _ICitaCAD.DamePendientes (usu_nombre);
}
public CitaEN ReadOID (int idCita
                       )
{
        CitaEN citaEN = null;

        citaEN = _ICitaCAD.ReadOID (idCita);
        return citaEN;
}

public System.Collections.Generic.IList<CitaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CitaEN> list = null;

        list = _ICitaCAD.ReadAll (first, size);
        return list;
}
}
}
