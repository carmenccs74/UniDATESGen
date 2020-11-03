

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.Exceptions;

using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;


namespace UniDATESGenNHibernate.CEN.UniDATES
{
/*
 *      Definition of the class PlanesPremiumCEN
 *
 */
public partial class PlanesPremiumCEN
{
private IPlanesPremiumCAD _IPlanesPremiumCAD;

public PlanesPremiumCEN()
{
        this._IPlanesPremiumCAD = new PlanesPremiumCAD ();
}

public PlanesPremiumCEN(IPlanesPremiumCAD _IPlanesPremiumCAD)
{
        this._IPlanesPremiumCAD = _IPlanesPremiumCAD;
}

public IPlanesPremiumCAD get_IPlanesPremiumCAD ()
{
        return this._IPlanesPremiumCAD;
}

public int New_ (float p_precio, string p_descripcion, string p_nombre)
{
        PlanesPremiumEN planesPremiumEN = null;
        int oid;

        //Initialized PlanesPremiumEN
        planesPremiumEN = new PlanesPremiumEN ();
        planesPremiumEN.Precio = p_precio;

        planesPremiumEN.Descripcion = p_descripcion;

        planesPremiumEN.Nombre = p_nombre;

        //Call to PlanesPremiumCAD

        oid = _IPlanesPremiumCAD.New_ (planesPremiumEN);
        return oid;
}

public void Modify (int p_PlanesPremium_OID, float p_precio, string p_descripcion, string p_nombre)
{
        PlanesPremiumEN planesPremiumEN = null;

        //Initialized PlanesPremiumEN
        planesPremiumEN = new PlanesPremiumEN ();
        planesPremiumEN.IdPlan = p_PlanesPremium_OID;
        planesPremiumEN.Precio = p_precio;
        planesPremiumEN.Descripcion = p_descripcion;
        planesPremiumEN.Nombre = p_nombre;
        //Call to PlanesPremiumCAD

        _IPlanesPremiumCAD.Modify (planesPremiumEN);
}

public void Destroy (int idPlan
                     )
{
        _IPlanesPremiumCAD.Destroy (idPlan);
}
}
}
