
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_BloquearAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void BloquearAdmin (int p_oid)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_BloquearAdmin) ENABLED START*/

        // Write here your custom code...

        UsuarioEN us = _IUsuarioCAD.ReadOIDDefault (p_oid);

        us.Bloqueado = true;

        _IUsuarioCAD.ModifyDefault (us);

        /*PROTECTED REGION END*/
}
}
}
