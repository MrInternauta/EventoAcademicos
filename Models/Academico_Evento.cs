using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico_Evento
    {
        public int Id { get; set; }

        [Display(Name = "Academico")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int AcademicoId { get; set; }
        public Academico Academico { get; set; }

        [Display(Name = "Evento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
