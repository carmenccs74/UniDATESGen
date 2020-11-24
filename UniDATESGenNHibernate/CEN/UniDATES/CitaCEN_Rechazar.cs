
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


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Cita_Rechazar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class CitaCEN
{
public void Rechazar (int p_Cita_OID, UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum p_objetivo, bool p_aceptada, bool p_rechazada)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Cita_Rechazar_customized) ENABLED START*/

        CitaEN citaEN = null;

        //Initialized CitaEN
        citaEN = new CitaEN ();
        citaEN.IdCita = p_Cita_OID;
        citaEN.Objetivo = p_objetivo;
        citaEN.Aceptada = false;
        citaEN.Rechazada = true;
        //Call to CitaCAD

        _ICitaCAD.Rechazar (citaEN);

        /*PROTECTED REGION END*/
}
}
}
