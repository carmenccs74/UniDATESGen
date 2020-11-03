
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;
using UniDATESGenNHibernate.CEN.UniDATES;



/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CP.UniDATES_UsuarioPremium_Pagar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CP.UniDATES
{
public partial class UsuarioPremiumCP : BasicCP
{
public void Pagar (int p_oid)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CP.UniDATES_UsuarioPremium_Pagar) ENABLED START*/

        IUsuarioPremiumCAD usuarioPremiumCAD = null;
        UsuarioPremiumCEN usuarioPremiumCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioPremiumCAD = new UsuarioPremiumCAD (session);
                usuarioPremiumCEN = new  UsuarioPremiumCEN (usuarioPremiumCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method Pagar() not yet implemented.");



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
