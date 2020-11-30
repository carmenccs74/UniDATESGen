using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATES.Models;

namespace UniDATES.Assemblers
{
    public class UsuariosBloqueadosAssembler
    {

        public UsuarioViewModel ConvertENToModelUI(UsuarioEN en)
        {
            UsuarioViewModel usuBloq = new UsuarioViewModel();
            usuBloq.Nombre = en.Nombre;
            usuBloq.FechaAlta = (DateTime)en.FechaAlta;
            usuBloq.Foto = en.Foto;

            return usuBloq;
        }

        public IList<UsuarioViewModel> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            IList<UsuarioViewModel> usus = new List<UsuarioViewModel>();
            foreach (UsuarioEN en in ens)
            {
                usus.Add(ConvertENToModelUI(en));
            }

            return usus;
        }
    }
}