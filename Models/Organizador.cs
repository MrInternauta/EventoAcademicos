using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Organizador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [Display(Name = "Tipo de Organizador")]
        public int IdTipoOrganizador { get; set; }
        public TipoOrganizador TipoOrganizador { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [Display(Name = "Evento")]
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [Display(Name = "Academico")]
        public int AcademicoId { get; set; }
        public Academico Academico { get; set; }

    }
}
