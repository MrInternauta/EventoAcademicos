using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Role_Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }



    }
}
