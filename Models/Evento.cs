using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraInicio { get; set; } 

    }
}
