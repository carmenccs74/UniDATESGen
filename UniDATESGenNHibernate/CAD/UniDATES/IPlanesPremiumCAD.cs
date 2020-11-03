
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IPlanesPremiumCAD
{
PlanesPremiumEN ReadOIDDefault (int idPlan
                                );

void ModifyDefault (PlanesPremiumEN planesPremium);

System.Collections.Generic.IList<PlanesPremiumEN> ReadAllDefault (int first, int size);




int New_ (PlanesPremiumEN planesPremium);

void Modify (PlanesPremiumEN planesPremium);


void Destroy (int idPlan
              );
}
}
