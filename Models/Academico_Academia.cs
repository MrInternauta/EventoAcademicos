using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico_Academia
    {
        public int Id { get; set; }
        public int AcademicoId { get; set; }
        public Academico Academico { get; set; }
        public int AcademiaId { get; set; }
        public Academia Academia { get; set; }
    }
}
