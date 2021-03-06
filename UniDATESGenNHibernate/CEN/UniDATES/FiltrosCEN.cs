

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
 *      Definition of the class FiltrosCEN
 *
 */
public partial class FiltrosCEN
{
private IFiltrosCAD _IFiltrosCAD;

public FiltrosCEN()
{
        this._IFiltrosCAD = new FiltrosCAD ();
}

public FiltrosCEN(IFiltrosCAD _IFiltrosCAD)
{
        this._IFiltrosCAD = _IFiltrosCAD;
}

public IFiltrosCAD get_IFiltrosCAD ()
{
        return this._IFiltrosCAD;
}

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> Elegir (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivoCita, string p_universidad, int? p_curso, string p_grado, string p_facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum? p_deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum ? p_gustosMusicales)
{
        return _IFiltrosCAD.Elegir (p_objetivoCita, p_universidad, p_curso, p_grado, p_facultad, p_gastronomia, p_deporte, p_ocio, p_gustosMusicales);
}
public int New_ (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivoCita, string p_universidad, int p_curso, string p_grado, string p_facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum p_gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustosMusicales, int p_usuario)
{
        FiltrosEN filtrosEN = null;
        int oid;

        //Initialized FiltrosEN
        filtrosEN = new FiltrosEN ();
        filtrosEN.ObjetivoCita = p_objetivoCita;

        filtrosEN.Universidad = p_universidad;

        filtrosEN.Curso = p_curso;

        filtrosEN.Grado = p_grado;

        filtrosEN.Facultad = p_facultad;

        filtrosEN.Gastronomia = p_gastronomia;

        filtrosEN.Deporte = p_deporte;

        filtrosEN.Ocio = p_ocio;

        filtrosEN.GustosMusicales = p_gustosMusicales;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idFiltros
                filtrosEN.Usuario = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                filtrosEN.Usuario.IdUsuario = p_usuario;
        }

        //Call to FiltrosCAD

        oid = _IFiltrosCAD.New_ (filtrosEN);
        return oid;
}

public void Modify (int p_Filtros_OID, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivoCita, string p_universidad, int p_curso, string p_grado, string p_facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum p_gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum p_deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum p_gustosMusicales)
{
        FiltrosEN filtrosEN = null;

        //Initialized FiltrosEN
        filtrosEN = new FiltrosEN ();
        filtrosEN.IdFiltros = p_Filtros_OID;
        filtrosEN.ObjetivoCita = p_objetivoCita;
        filtrosEN.Universidad = p_universidad;
        filtrosEN.Curso = p_curso;
        filtrosEN.Grado = p_grado;
        filtrosEN.Facultad = p_facultad;
        filtrosEN.Gastronomia = p_gastronomia;
        filtrosEN.Deporte = p_deporte;
        filtrosEN.Ocio = p_ocio;
        filtrosEN.GustosMusicales = p_gustosMusicales;
        //Call to FiltrosCAD

        _IFiltrosCAD.Modify (filtrosEN);
}

public void Destroy (int idFiltros
                     )
{
        _IFiltrosCAD.Destroy (idFiltros);
}
}
}
