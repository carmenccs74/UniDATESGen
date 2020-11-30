using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATES.Models;

namespace UniDATES.Assemblers
{
    public class UsuariosRegistradosAssembler
    {
        public UsuarioViewModel ConvertENToModelUI(UsuarioEN en)
        {
            UsuarioViewModel usu = new UsuarioViewModel();
            usu.Nombre = en.Nombre;
            usu.FechaAlta = (DateTime)en.FechaAlta;
            usu.Foto = en.Foto;

            return usu;
        }

        public IList<UsuarioViewModel> ConvertListENTomModel(IList<UsuarioEN> ens)
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