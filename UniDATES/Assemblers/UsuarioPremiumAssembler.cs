using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATES.Models;

namespace UniDATES.Assemblers
{
    public class UsuarioPremiumAssembler
    {
        public UsuarioViewModel ConvertENToModelUI(UsuarioEN en) {
            UsuarioViewModel usuPrem = new UsuarioViewModel();
            usuPrem.Nombre = en.Nombre;
            usuPrem.FechaAlta = (DateTime)en.FechaAlta;
            usuPrem.Foto = en.Foto;

            return usuPrem;
        }

        public IList<UsuarioViewModel> ConvertListENTomModel(IList<UsuarioEN> ens) {
            IList<UsuarioViewModel> usus = new List<UsuarioViewModel>();
            foreach (UsuarioEN en in ens) {
                usus.Add(ConvertENToModelUI(en));
            }


            return usus;
        }
    }
}