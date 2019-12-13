using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class SedeEvento
    {
        [Key]
        public int IdSedeEvento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreSedeEvento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionSedeEvento { get; set; }
        public List<Evento_SedeEvento> Evento_SedeEventos { get; set; }


    }
}
