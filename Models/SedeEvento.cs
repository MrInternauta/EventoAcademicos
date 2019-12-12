using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class SedeEvento
    {
        [Key]
        public int IdSedeEvento { get; set; }
        public string NombreSedeEvento { get; set; }
        public string DescripcionSedeEvento { get; set; }

    }
}
