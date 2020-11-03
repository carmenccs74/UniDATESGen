

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
 *      Definition of the class BusquedaCEN
 *
 */
public partial class BusquedaCEN
{
private IBusquedaCAD _IBusquedaCAD;

public BusquedaCEN()
{
        this._IBusquedaCAD = new BusquedaCAD ();
}

public BusquedaCEN(IBusquedaCAD _IBusquedaCAD)
{
        this._IBusquedaCAD = _IBusquedaCAD;
}

public IBusquedaCAD get_IBusquedaCAD ()
{
        return this._IBusquedaCAD;
}

public int Buscar (int p_usuario)
{
        BusquedaEN busquedaEN = null;
        int oid;

        //Initialized BusquedaEN
        busquedaEN = new BusquedaEN ();

        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idBusqueda
                busquedaEN.Usuario = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                busquedaEN.Usuario.IdUsuario = p_usuario;
        }

        //Call to BusquedaCAD

        oid = _IBusquedaCAD.Buscar (busquedaEN);
        return oid;
}
}
}
