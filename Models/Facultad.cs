using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Facultad
    {
        [Key]
        public int IdFacultad { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(10, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Clave { get; set; }
    }
}
