
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Cita_Aceptar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class CitaCEN
{
public void Aceptar (int p_Cita_OID, bool p_aceptada)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Cita_Aceptar_customized) ENABLED START*/

        CitaEN citaEN = null;



        //Initialized CitaEN
        //citaEN = new CitaEN ();
        citaEN = _ICitaCAD.ReadOID (p_Cita_OID);
        citaEN.Aceptada = p_aceptada;


        //Call to CitaCAD

        _ICitaCAD.Aceptar (citaEN);


        /*PROTECTED REGION END*/
}
}
}
