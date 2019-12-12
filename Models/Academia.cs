using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Academia
    {
        [Key]
        public int IdAcademia { get; set; }
        public string NombreAcademia { get; set; }
    }
}
