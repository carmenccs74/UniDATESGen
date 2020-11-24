
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Cita_New_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class CitaCEN
{
public int New_ (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, int p_usuarioSolicitante, int p_usuarioReceptor, bool p_aceptada)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Cita_New__customized) START*/

        CitaEN citaEN = null;

        int oid;

        //Initialized CitaEN
        citaEN = new CitaEN ();
        citaEN.Objetivo = p_objetivo;


        if (p_usuarioSolicitante != -1) {
                citaEN.UsuarioSolicitante = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                citaEN.UsuarioSolicitante.IdUsuario = p_usuarioSolicitante;
        }


        if (p_usuarioReceptor != -1) {
                citaEN.UsuarioReceptor = new UniDATESGenNHibernate.EN.UniDATES.UsuarioEN ();
                citaEN.UsuarioReceptor.IdUsuario = p_usuarioReceptor;
        }

        citaEN.Aceptada = p_aceptada;

        //Call to CitaCAD

        oid = _ICitaCAD.New_ (citaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
