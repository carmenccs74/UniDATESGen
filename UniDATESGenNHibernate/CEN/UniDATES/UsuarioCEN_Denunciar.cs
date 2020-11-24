
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_Denunciar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void Denunciar (int p_oid, int p_idUsuDenunciar, Nullable<DateTime> p_fecha, UniDATESGenNHibernate.Enumerated.UniDATES.MotivoIncidenciaEnum p_motivo, int p_Administrador)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_Denunciar) ENABLED START*/

        UsuarioEN usuDenunciado = _IUsuarioCAD.ReadOIDDefault (p_idUsuDenunciar);

        usuDenunciado.Denunciado = true;

        IncidenciaCEN incidenciaCEN = new IncidenciaCEN ();

        incidenciaCEN.New_ (p_motivo, p_fecha, p_oid, p_idUsuDenunciar, p_Administrador);

        _IUsuarioCAD.ModifyDefault (usuDenunciado);

        /*PROTECTED REGION END*/
}
}
}
