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
        public string Clave { get; set; }
        public string Descripcion { get; set; }
    }
}
