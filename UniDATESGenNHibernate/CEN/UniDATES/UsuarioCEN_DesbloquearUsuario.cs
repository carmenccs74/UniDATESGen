
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_DesbloquearUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void DesbloquearUsuario (int p_oid, int idUsuDesbloquear)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_DesbloquearUsuario) ENABLED START*/

        UsuarioEN usuDesbloquea = _IUsuarioCAD.ReadOIDDefault (p_oid);

        UsuarioEN usuDesbloqueado = _IUsuarioCAD.ReadOIDDefault (idUsuDesbloquear);

        usuDesbloqueado.Bloqueado = false;

        if (usuDesbloquea.UsuariosBloqueados == usuDesbloqueado.Nombre) {
                usuDesbloquea.UsuariosBloqueados = "";
        }

        _IUsuarioCAD.ModifyDefault (usuDesbloquea);
        _IUsuarioCAD.ModifyDefault (usuDesbloqueado);

        /*PROTECTED REGION END*/
}
}
}
