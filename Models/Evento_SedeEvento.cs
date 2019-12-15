using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Evento_SedeEvento
    {
        public int Id { get; set; }

        [Display(Name = "Evento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(55, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        [Display(Name = "Sede del evento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(55, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public int SedeEventoId { get; set; }
        public SedeEvento SedeEvento { get; set; }
    }
}
