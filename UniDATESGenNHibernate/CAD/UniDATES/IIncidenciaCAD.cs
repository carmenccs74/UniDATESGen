
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


System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.IncidenciaEN> DameDenuncias (int ? p_idAdministrador);


IncidenciaEN ReadOID (int idIncidencia
                      );


System.Collections.Generic.IList<IncidenciaEN> ReadAll (int first, int size);
}
}
