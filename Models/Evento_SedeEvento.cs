using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Evento_SedeEvento
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        public int SedeEventoId { get; set; }
        public SedeEvento SedeEvento { get; set; }
    }
}
