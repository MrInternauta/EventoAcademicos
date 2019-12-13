using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        public int IdFacultad { get; set; } = -1;
        public Facultad Facultad { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(10, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Matricula { get; set; }
    }
}
