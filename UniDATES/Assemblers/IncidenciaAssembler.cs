using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATES.Models;

namespace UniDATES.Assemblers
{
    public class IncidenciaAssembler
    {
        public IncidenciaViewModel ConvertENToModelUI(IncidenciaEN en)
        {
            IncidenciaViewModel incidencia = new IncidenciaViewModel();

            incidencia.IdIncidencia = en.IdIncidencia;
            incidencia.Fecha = (DateTime)en.Fecha;
            incidencia.Motivo = en.Motivo;
            incidencia.Resolucion = en.Resolucion;

            return incidencia;
        }

        public IList<IncidenciaViewModel> ConvertListENToModel(IList<IncidenciaEN> ens)
        {

            IList<IncidenciaViewModel> incidencias = new List<IncidenciaViewModel>();

            foreach (IncidenciaEN en in ens)
            {
                incidencias.Add(ConvertENToModelUI(en));
            }

            return incidencias;
        }
    }
}