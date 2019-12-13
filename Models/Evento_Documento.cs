using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Evento_Documento
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
    }
}
