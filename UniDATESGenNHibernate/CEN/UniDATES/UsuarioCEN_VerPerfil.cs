
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_VerPerfil) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void VerPerfil (int p_oid)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_VerPerfil) ENABLED START*/

        // Write here your custom code...

        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (p_oid);


        /*PROTECTED REGION END*/
}
}
}
