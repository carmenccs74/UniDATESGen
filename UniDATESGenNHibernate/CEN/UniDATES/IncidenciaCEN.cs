

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
 *      Definition of the class IncidenciaCEN
 *
 */
public partial class IncidenciaCEN
{
private IIncidenciaCAD _IIncidenciaCAD;

public IncidenciaCEN()
{
        this._IIncidenciaCAD = new IncidenciaCAD ();
}

public IncidenciaCEN(IIncidenciaCAD _IIncidenciaCAD)
{
        this._IIncidenciaCAD = _IIncidenciaCAD;
}

public IIncidenciaCAD get_IIncidenciaCAD ()
{
        return this._IIncidenciaCAD;
}

public int New_ (UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum p_motivo, Nullable<DateTime> p_fecha, int p_usuarioDenunciante, int p_usuarioDenunciado, int p_administrador)
{
        IncidenciaEN incidenciaEN = null;
        int oid;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();
        incidenciaEN.Motivo = p_motivo;

        incidenciaEN.Fecha = p_fecha;


        if (p_usuarioDenunciante != -1) {
                // El argumento p_usuarioDenunciante -> Property usuarioDenunciante es oid = false
                // Lista de oids idIncidencia
                incidenciaEN.UsuarioDenunciante = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                incidenciaEN.UsuarioDenunciante.IdUsuario = p_usuarioDenunciante;
        }


        if (p_usuarioDenunciado != -1) {
                // El argumento p_usuarioDenunciado -> Property usuarioDenunciado es oid = false
                // Lista de oids idIncidencia
                incidenciaEN.UsuarioDenunciado = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                incidenciaEN.UsuarioDenunciado.IdUsuario = p_usuarioDenunciado;
        }


        if (p_administrador != -1) {
                // El argumento p_administrador -> Property administrador es oid = false
                // Lista de oids idIncidencia
                incidenciaEN.Administrador = new UniDATESGenNHibernate.EN.UniDATES.AdministradorEN ();
                incidenciaEN.Administrador.IdAdministrador = p_administrador;
        }

        //Call to IncidenciaCAD

        oid = _IIncidenciaCAD.New_ (incidenciaEN);
        return oid;
}

public void Modify (int p_Incidencia_OID, UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum p_motivo, Nullable<DateTime> p_fecha)
{
        IncidenciaEN incidenciaEN = null;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();
        incidenciaEN.IdIncidencia = p_Incidencia_OID;
        incidenciaEN.Motivo = p_motivo;
        incidenciaEN.Fecha = p_fecha;
        //Call to IncidenciaCAD

        _IIncidenciaCAD.Modify (incidenciaEN);
}

public void Destroy (int idIncidencia
                     )
{
        _IIncidenciaCAD.Destroy (idIncidencia);
}

public System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> DameDenuncias (int ? p_idAdministrador)
{
        return _IIncidenciaCAD.DameDenuncias (p_idAdministrador);
}
public IncidenciaEN ReadOID (int idIncidencia
                             )
{
        IncidenciaEN incidenciaEN = null;

        incidenciaEN = _IIncidenciaCAD.ReadOID (idIncidencia);
        return incidenciaEN;
}

public System.Collections.Generic.IList<IncidenciaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IncidenciaEN> list = null;

        list = _IIncidenciaCAD.ReadAll (first, size);
        return list;
}
}
}
