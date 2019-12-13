using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class TipoOrganizador
    {
        [Key]
        public int IdTipoOrganizador { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(15, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string  Descripcion { get; set; }

    }
}
