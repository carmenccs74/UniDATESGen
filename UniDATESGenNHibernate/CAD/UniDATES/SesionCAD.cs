
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
 * Clase Sesion:
 *
 */

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial class SesionCAD : BasicCAD, ISesionCAD
{
public SesionCAD() : base ()
{
}

public SesionCAD(ISession sessionAux) : base (sessionAux)
{
}



public SesionEN ReadOIDDefault (int idSesion
                                )
{
        SesionEN sesionEN = null;

        try
        {
                SessionInitializeTransaction ();
                sesionEN = (SesionEN)session.Get (typeof(SesionEN), idSesion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sesionEN;
}

public System.Collections.Generic.IList<SesionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SesionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SesionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SesionEN>();
                        else
                                result = session.CreateCriteria (typeof(SesionEN)).List<SesionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();
                SesionEN sesionEN = (SesionEN)session.Load (typeof(SesionEN), sesion.IdSesion);

                sesionEN.FechaInicio = sesion.FechaInicio;


                sesionEN.FechaFin = sesion.FechaFin;



                session.Update (sesionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int IniciarSesion (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (sesion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sesion.IdSesion;
}

public int IniciarSesionconHuella (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (sesion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sesion.IdSesion;
}

public void FinalizarSesion (int idSesion
                             )
{
        try
        {
                SessionInitializeTransaction ();
                SesionEN sesionEN = (SesionEN)session.Load (typeof(SesionEN), idSesion);
                session.Delete (sesionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Modify (SesionEN sesion)
{
        try
        {
                SessionInitializeTransaction ();
                SesionEN sesionEN = (SesionEN)session.Load (typeof(SesionEN), sesion.IdSesion);

                sesionEN.FechaInicio = sesion.FechaInicio;


                sesionEN.FechaFin = sesion.FechaFin;

                session.Update (sesionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UniDATESGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UniDATESGenNHibernate.Exceptions.DataLayerException ("Error in SesionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
