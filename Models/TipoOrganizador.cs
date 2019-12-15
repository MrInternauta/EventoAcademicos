using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class TipoOrganizador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(55, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La {0} es requerido.")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Descripcion { get; set; }

    }
}
