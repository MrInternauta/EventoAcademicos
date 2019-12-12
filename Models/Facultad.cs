using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Facultad
    {
       [Key]
        public int IdFacultad { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
