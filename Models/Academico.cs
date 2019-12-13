using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico
    {
        [Key]
        public int IdAcademico { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        public int IdFacultad { get; set; } = -1;
        public Facultad Facultad { get; set; }

        public int IdOrganizador { get; set; } = -1;
        public Organizador Organizador { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(10, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NoControl { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(13, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Rfc { get; set; }
        public List<Academico_Academia> Academico_Academias { get; set; }
        public List<Academico_Evento> Academico_Eventos { get; set; }



    }

}
