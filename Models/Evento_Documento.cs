using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Evento_Documento
    {
        public int Id { get; set; }

        [Display(Name = "Evento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
    }
}
