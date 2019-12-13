using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ControlWeb.Models
{
    public class Permiso
    {
        [Key]
        public int IdPermiso { get; set; }
        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(15, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Descripcion { get; set; }

        public List<Role_Permiso> Role_Permiso { get; set; }

    }
}
