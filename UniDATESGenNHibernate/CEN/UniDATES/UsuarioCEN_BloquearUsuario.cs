
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_BloquearUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void BloquearUsuario (int p_oid, int idUsuBloquear)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_BloquearUsuario) ENABLED START*/

        UsuarioEN usuBloquea = _IUsuarioCAD.ReadOIDDefault (p_oid);

        UsuarioEN usuBloqueado = _IUsuarioCAD.ReadOIDDefault (idUsuBloquear);

        usuBloqueado.Bloqueado = true;

        usuBloquea.UsuariosBloqueados = usuBloquea.UsuariosBloqueados + usuBloqueado.Nombre;

        _IUsuarioCAD.ModifyDefault (usuBloquea);
        _IUsuarioCAD.ModifyDefault (usuBloqueado);

        /*PROTECTED REGION END*/
}
}
}
