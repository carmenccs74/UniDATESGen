
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.Exceptions;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Incidencia_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class IncidenciaCEN
{
public int New_ (UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum p_motivo, Nullable<DateTime> p_fecha, int p_usuarioDenunciante, int p_usuarioDenunciado)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Incidencia_new__customized) START*/

        IncidenciaEN incidenciaEN = null;

        int oid;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();
        incidenciaEN.Motivo = p_motivo;

        incidenciaEN.Fecha = p_fecha;


        if (p_usuarioDenunciante != -1) {
                incidenciaEN.UsuarioDenunciante = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                incidenciaEN.UsuarioDenunciante.IdUsuario = p_usuarioDenunciante;
        }


        if (p_usuarioDenunciado != -1) {
                incidenciaEN.UsuarioDenunciado = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                incidenciaEN.UsuarioDenunciado.IdUsuario = p_usuarioDenunciado;
        }

        //Call to IncidenciaCAD

        oid = _IIncidenciaCAD.New_ (incidenciaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
