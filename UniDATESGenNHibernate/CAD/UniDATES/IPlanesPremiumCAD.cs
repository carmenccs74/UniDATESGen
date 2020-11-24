
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IPlanesPremiumCAD
{
PlanesPremiumEN ReadOIDDefault (UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum idPlan
                                );

void ModifyDefault (PlanesPremiumEN planesPremium);

System.Collections.Generic.IList<PlanesPremiumEN> ReadAllDefault (int first, int size);



UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum Pagar (PlanesPremiumEN planesPremium);

void Modify (PlanesPremiumEN planesPremium);


void Destroy (UniDATESGenNHibernate.Enumerated.UniDATES.PlanesPremEnum idPlan
              );
}
}
