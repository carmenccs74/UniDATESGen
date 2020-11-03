

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
 *      Definition of the class ResultadoCEN
 *
 */
public partial class ResultadoCEN
{
private IResultadoCAD _IResultadoCAD;

public ResultadoCEN()
{
        this._IResultadoCAD = new ResultadoCAD ();
}

public ResultadoCEN(IResultadoCAD _IResultadoCAD)
{
        this._IResultadoCAD = _IResultadoCAD;
}

public IResultadoCAD get_IResultadoCAD ()
{
        return this._IResultadoCAD;
}

public int Mostrar (int p_busqueda)
{
        ResultadoEN resultadoEN = null;
        int oid;

        //Initialized ResultadoEN
        resultadoEN = new ResultadoEN ();

        if (p_busqueda != -1) {
                // El argumento p_busqueda -> Property busqueda es oid = false
                // Lista de oids idResultado
                resultadoEN.Busqueda = new UniDATESGenNHibernate.EN.UniDATES.BusquedaEN ();
                resultadoEN.Busqueda.IdBusqueda = p_busqueda;
        }

        //Call to ResultadoCAD

        oid = _IResultadoCAD.Mostrar (resultadoEN);
        return oid;
}

public void Destroy (int idResultado
                     )
{
        _IResultadoCAD.Destroy (idResultado);
}
}
}
