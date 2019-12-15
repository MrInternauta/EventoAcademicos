using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Role_Permiso
    {
        public int Id { get; set; }
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Display(Name = "Permiso")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int PermisoId { get; set; }
        public Permiso Permiso { get; set; }
    }
}
