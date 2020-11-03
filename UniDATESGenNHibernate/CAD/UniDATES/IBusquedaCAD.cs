
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IBusquedaCAD
{
BusquedaEN ReadOIDDefault (int idBusqueda
                           );

void ModifyDefault (BusquedaEN busqueda);

System.Collections.Generic.IList<BusquedaEN> ReadAllDefault (int first, int size);



int Buscar (BusquedaEN busqueda);
}
}
