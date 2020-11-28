using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATES.Models;

namespace UniDATES.Assemblers
{
    public class UsuariosDadosDeBajaAssembler
    {
        public UsuarioViewModel ConvertENToModelUI(UsuarioEN en)
        {
            UsuarioViewModel usuarioBaja = new UsuarioViewModel();
            usuarioBaja.Nombre = en.Nombre;
            usuarioBaja.FechaAlta = (DateTime)en.FechaAlta;
            usuarioBaja.Foto = en.Foto;

            return usuarioBaja;
        }

        public IList<UsuarioViewModel> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            IList<UsuarioViewModel> usuarios = new List<UsuarioViewModel>();
            foreach (UsuarioEN en in ens)
            {
                usuarios.Add(ConvertENToModelUI(en));
            }


            return usuarios;
        }
    }
}