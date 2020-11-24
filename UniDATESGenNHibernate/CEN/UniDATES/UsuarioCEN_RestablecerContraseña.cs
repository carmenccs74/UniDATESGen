
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_RestablecerContraseña) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void RestablecerContraseña (int p_oid, string nuevaContra)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_RestablecerContraseña) ENABLED START*/
        UsuarioEN usuarioEN = _IUsuarioCAD.ReadOIDDefault (p_oid);

        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (nuevaContra);

        _IUsuarioCAD.ModifyDefault (usuarioEN);
        /*PROTECTED REGION END*/
}
}
}
