    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]

        [Column("IdDatosPersonales")]
        [Display(Name = "Datos personales")]
        public int DatosPersonalesId { get; set; } = -1;
        public DatosPersonales DatosPersonales { get; set; }

        public int IdAcademico { get; set; } = -1;
        public Academico Academico { get; set; }

        public int IdEstudiante { get; set; } = -1;
        public Estudiante Estudiante { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        
        public string Password { get; set; }
        public List<Role_Usuario> Role_Usuarios { get; set; }

    }
}
