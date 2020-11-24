
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UniDATESGenNHibernate.Exceptions;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;


/*PROTECTED REGION ID(usingUniDATESGenNHibernate.CEN.UniDATES_Usuario_EditarPerfil) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UniDATESGenNHibernate.CEN.UniDATES
{
public partial class UsuarioCEN
{
public void EditarPerfil (int p_Usuario_OID, string p_nombre, string p_apellidos, String p_contraseña, string p_email, int p_telefono, UniDATESGenNHibernate.Enumerated.UniDATES.SexoEnum p_sexo, UniDATESGenNHibernate.Enumerated.UniDATES.OrientacionSexualEnum p_orientaciónSexual)
{
        /*PROTECTED REGION ID(UniDATESGenNHibernate.CEN.UniDATES_Usuario_EditarPerfil_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.IdUsuario = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);
        usuarioEN.Email = p_email;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Sexo = p_sexo;
        usuarioEN.OrientaciónSexual = p_orientaciónSexual;
        //Call to UsuarioCAD

        _IUsuarioCAD.EditarPerfil (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
