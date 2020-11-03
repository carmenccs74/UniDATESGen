
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IFiltrosCAD
{
FiltrosEN ReadOIDDefault (int idFiltros
                          );

void ModifyDefault (FiltrosEN filtros);

System.Collections.Generic.IList<FiltrosEN> ReadAllDefault (int first, int size);




int New_ (FiltrosEN filtros);

void Modify (FiltrosEN filtros);


void Destroy (int idFiltros
              );
}
}
