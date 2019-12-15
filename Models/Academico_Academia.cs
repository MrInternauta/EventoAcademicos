using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico_Academia
    {
        public int Id { get; set; }

        [Display(Name = "Academico")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int AcademicoId { get; set; }
        public Academico Academico { get; set; }


        [Display(Name = "Academia")]
        [Required(ErrorMessage = "La {0} es requerido.")]
        public int AcademiaId { get; set; }
        public Academia Academia { get; set; }
    }
}
