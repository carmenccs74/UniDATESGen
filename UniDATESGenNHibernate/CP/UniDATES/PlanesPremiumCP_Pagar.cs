
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



/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CP.UniDATES_PlanesPremium_Pagar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CP.UniDATES
{
public partial class PlanesPremiumCP : BasicCP
{
public UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN Pagar (UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum p_idPlan, float p_precio, string p_descripcion, string p_nombre, int p_idUsuario)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CP.UniDATES_PlanesPremium_Pagar) ENABLED START*/



        IPlanesPremiumCAD planesPremiumCAD = null;
        PlanesPremiumCEN planesPremiumCEN = null;
        UsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        UniDATESGenNHibernate.EN.UniDATES.PlanesPremiumEN result = null;




        try
        {
                SessionInitializeTransaction ();
                planesPremiumCAD = new PlanesPremiumCAD (session);
                planesPremiumCEN = new PlanesPremiumCEN (planesPremiumCAD);



                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);



                UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum oid;
                //Initialized PlanesPremiumEN
                PlanesPremiumEN planesPremiumEN;
                planesPremiumEN = new PlanesPremiumEN ();
                planesPremiumEN.IdPlan = p_idPlan;



                planesPremiumEN.Precio = p_precio;



                planesPremiumEN.Descripcion = p_descripcion;



                planesPremiumEN.Nombre = p_nombre;



                //Call to PlanesPremiumCAD



                oid = planesPremiumCAD.Pagar (planesPremiumEN);



                UsuarioEN usuarioEN = usuarioCEN.ReadOID (p_idUsuario);
                usuarioEN.Premium = true;



                usuarioCAD.ModifyDefault (usuarioEN);



                result = planesPremiumCAD.ReadOIDDefault (oid);





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
        return result;




        /*PROTECTED REGION END*/
}
}
}
