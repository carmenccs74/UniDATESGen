
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_DesbloquearAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void DesbloquearAdmin (int p_oid)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_DesbloquearAdmin) ENABLED START*/

        // Write here your custom code...

        UsuarioEN us = _IUsuarioCAD.ReadOIDDefault (p_oid);

        us.Bloqueado = false;

        _IUsuarioCAD.ModifyDefault (us);

        /*PROTECTED REGION END*/
}
}
}
