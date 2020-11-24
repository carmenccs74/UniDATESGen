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

        [Display(Prompt = "Fecha de alta del usuario", Description = "Fecha de alta del usuario", Name = "Fecha de alta")]
        [Required(ErrorMessage = "Debe indicar una fecha para el usuario")]
        [StringLength(maximumLength: 50, ErrorMessage = "La fecha no puede tener más de 50 caracteres")]

        public DateTime FechaAlta { get; set; }

        [Display(Prompt = "Foto del usuario", Description = "Foto de perfil del usuario", Name = "Foto perfil")]
        [Required(ErrorMessage = "Debe indicar una foto de perfil para el usuario")]
        [StringLength(maximumLength: 200, ErrorMessage = "La foto no puede tener más de 200 caracteres")]

        public String Foto { get; set; }



    }
}