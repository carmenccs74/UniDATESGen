using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using UniDATESGenNHibernate.Enumerated.UniDATES;


namespace UniDATES.Models
{
    public class IncidenciaViewModel
    {
        [ScaffoldColumn(false)]

        public int IdIncidencia { get; set; }

        [Display(Prompt = "Motivo de la incidencia", Description = "Motivo de la incidencia", Name = "Motivo ")]
        [Required(ErrorMessage = "Debe indicar un motivo para la incidencia")]
        [StringLength(maximumLength: 200, ErrorMessage = "El motivo no puede tener más de 200 caracteres")]
        public MotivoIncidenciaEnum Motivo { get; set; }

        [Display(Prompt = "Fecha de la incidencia", Description = "Fecha de la incidencia", Name = "Fecha ")]
        [Required(ErrorMessage = "Debe indicar una fecha para la incidencia")]
        [StringLength(maximumLength: 50, ErrorMessage = "La fecha no puede tener más de 50 caracteres")]
        public DateTime Fecha { get; set; }

        [Display(Prompt = "Resolución de la incidencia", Description = "Resolución de la incidencia", Name = "Resolución ")]
        [Required(ErrorMessage = "Debe indicar uuna resolución para la incidencia")]
        [StringLength(maximumLength: 200, ErrorMessage = "La resolución no puede tener más de 200 caracteres")]
        public string Resolucion { get; set; }
    }
}