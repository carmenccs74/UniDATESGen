
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IIncidenciaCAD
{
IncidenciaEN ReadOIDDefault (int idIncidencia
                             );

void ModifyDefault (IncidenciaEN incidencia);

System.Collections.Generic.IList<IncidenciaEN> ReadAllDefault (int first, int size);





int New_ (IncidenciaEN incidencia);

void Modify (IncidenciaEN incidencia);


void Destroy (int idIncidencia
              );
}
}
