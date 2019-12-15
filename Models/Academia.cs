using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Academia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreAcademia { get; set; }

        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionAcademia { get; set; } = "";
        public List<Academico_Academia> Academico_Academias { get; set; }

    }
}
