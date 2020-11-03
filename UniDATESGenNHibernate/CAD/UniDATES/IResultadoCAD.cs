
using System;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATESGenNHibernate.CAD.UniDATES
{
public partial interface IResultadoCAD
{
ResultadoEN ReadOIDDefault (int idResultado
                            );

void ModifyDefault (ResultadoEN resultado);

System.Collections.Generic.IList<ResultadoEN> ReadAllDefault (int first, int size);



int Mostrar (ResultadoEN resultado);

void Destroy (int idResultado
              );
}
}
