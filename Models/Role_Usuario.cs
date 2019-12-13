using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Role_Usuario
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }



    }
}
