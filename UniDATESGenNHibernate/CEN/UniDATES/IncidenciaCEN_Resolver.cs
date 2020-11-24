
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Incidencia_Resolver) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class IncidenciaCEN
{
public void Resolver (int p_oid, string p_resolucion)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Incidencia_Resolver) ENABLED START*/

        // Write here your custom code...

        IncidenciaEN en = _IIncidenciaCAD.ReadOIDDefault (p_oid);

        en.Resolucion = p_resolucion;

        _IIncidenciaCAD.ModifyDefault (en);

        /*PROTECTED REGION END*/
}
}
}
