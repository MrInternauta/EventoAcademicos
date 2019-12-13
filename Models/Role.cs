using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Role
    {
        [Key]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(10, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; } = "";

        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Descripcion { get; set; } = "";
        public List<Role_Usuario> Role_Usuarios { get; set; }
        public List<Role_Permiso> Role_Permiso { get; set; }


    }
}
