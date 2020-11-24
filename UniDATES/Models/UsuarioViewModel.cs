using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniDATES.Models
{
    public class UsuarioViewModel
    {
        [ScaffoldColumn(false)]
        public int IdUsuario{ get; set; }

        [Display(Prompt = "Nombre del usuario", Description = "Nombre del usuario", Name = "Nombre usuario")]
        [Required(ErrorMessage = "Debe indicar un nombre para el usuario")]
        [StringLength(maximumLength: 100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]

        public String Nombre { get; set; }

        [Display(Prompt = "Email del usuario", Description = "Email del usuario", Name = "Email usuario")]
        [Required(ErrorMessage = "Debe indicar un email para el usuario")]
        [StringLength(maximumLength: 100, ErrorMessage = "El email no puede tener más de 100 caracteres")]

        public String Email { get; set; }



    }
}