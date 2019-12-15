using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Documento
    {
        public int Id { get; set;}
        [Display(Name = "Nombre del documento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreDocumento { get; set; }


        [Display(Name = "Descripción del documento")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionDocumento { get; set; } = "";


        [Display(Name = "Tipo del documento")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string TipoDocumento { get; set; } = "";


        [Display(Name = "Formato del documento")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string FormatoDocumento { get; set; }

        public List<Evento_Documento> Evento_Documentos { get; set; }

    }
}
