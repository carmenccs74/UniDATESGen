
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



System.Collections.Generic.IList<UniDATESGenNHibernate.EN.UniDATES.UsuarioEN> Elegir (UniDATESGenNHibernate.Enumerated.UniDATES.ObjetivoEnum? p_objetivoCita, string p_universidad, int? p_curso, string p_grado, string p_facultad, UniDATESGenNHibernate.Enumerated.UniDATES.GastronomiaEnum? p_gastronomia, UniDATESGenNHibernate.Enumerated.UniDATES.DeportesEnum? p_deporte, UniDATESGenNHibernate.Enumerated.UniDATES.OcioEnum? p_ocio, UniDATESGenNHibernate.Enumerated.UniDATES.GustosMusicalesEnum ? p_gustosMusicales);


int New_ (FiltrosEN filtros);

void Modify (FiltrosEN filtros);


void Destroy (int idFiltros
              );
}
}
