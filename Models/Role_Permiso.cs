using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Role_Permiso
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int PermisoId { get; set; }
        public Permiso Permiso { get; set; }
    }
}
