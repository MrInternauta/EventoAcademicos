using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico_Evento
    {
        public int Id { get; set; }
        public int AcademicoId { get; set; }
        public Academico Academico { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
