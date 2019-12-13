using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Academia
    {
        [Key]
        public int IdAcademia { get; set; } = -1;

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(15, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreAcademia { get; set; }

        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionAcademia { get; set; }
        public List<Academico_Academia> Academico_Academias { get; set; }

    }
}
