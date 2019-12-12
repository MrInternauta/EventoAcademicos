using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
    }
}
