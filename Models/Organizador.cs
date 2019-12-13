using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Organizador
    {
        [Key]
        public int IdOrganizador { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        public int IdTipoOrganizador { get; set; } = -1;
        public TipoOrganizador TipoOrganizador { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        public int IdEvento { get; set; } = -1;
        public Evento Evento { get; set; }

    }
}
