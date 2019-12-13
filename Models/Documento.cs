using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Documento
    {
        [Key]
        public int IdDocumento { get; set;}

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreDocumento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionDocumento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string TipoDocumento { get; set; }

        public string FormatoDocumento { get; set; }
        public List<Evento_Documento> Evento_Documentos { get; set; }

    }
}
