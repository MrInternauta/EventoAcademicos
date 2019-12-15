using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class SedeEvento
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreSedeEvento { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La {0} es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionSedeEvento { get; set; }

        public List<Evento_SedeEvento> Evento_SedeEventos { get; set; }


    }
}
