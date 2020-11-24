
using System;
using System.Text;
using UniDATESGenNHibernate.CEN.UniDATES;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.Exceptions;


/*
 * Clase PlanesPremium:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class PlanesPremiumCAD : BasicCAD, IPlanesPremiumCAD
{
public PlanesPremiumCAD() : base ()
{
}

public PlanesPremiumCAD(ISession sessionAux) : base (sessionAux)
{
}



public PlanesPremiumEN ReadOIDDefault (UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum idPlan
                                       )
{
        PlanesPremiumEN planesPremiumEN = null;

        try
        {
                SessionInitializeTransaction ();
                planesPremiumEN = (PlanesPremiumEN)session.Get (typeof(PlanesPremiumEN), idPlan);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return planesPremiumEN;
}

public System.Collections.Generic.IList<PlanesPremiumEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PlanesPremiumEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PlanesPremiumEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PlanesPremiumEN>();
                        else
                                result = session.CreateCriteria (typeof(PlanesPremiumEN)).List<PlanesPremiumEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PlanesPremiumEN planesPremium)
{
        try
        {
                SessionInitializeTransaction ();
                PlanesPremiumEN planesPremiumEN = (PlanesPremiumEN)session.Load (typeof(PlanesPremiumEN), planesPremium.IdPlan);

                planesPremiumEN.Precio = planesPremium.Precio;


                planesPremiumEN.Descripcion = planesPremium.Descripcion;


                planesPremiumEN.Nombre = planesPremium.Nombre;


                session.Update (planesPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum Pagar (PlanesPremiumEN planesPremium)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (planesPremium);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return planesPremium.IdPlan;
}

public void Modify (PlanesPremiumEN planesPremium)
{
        try
        {
                SessionInitializeTransaction ();
                PlanesPremiumEN planesPremiumEN = (PlanesPremiumEN)session.Load (typeof(PlanesPremiumEN), planesPremium.IdPlan);

                planesPremiumEN.Precio = planesPremium.Precio;


                planesPremiumEN.Descripcion = planesPremium.Descripcion;


                planesPremiumEN.Nombre = planesPremium.Nombre;

                session.Update (planesPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum idPlan
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PlanesPremiumEN planesPremiumEN = (PlanesPremiumEN)session.Load (typeof(PlanesPremiumEN), idPlan);
                session.Delete (planesPremiumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in PlanesPremiumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
