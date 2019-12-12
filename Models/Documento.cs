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
        public string NombreDocumento { get; set; }
        public string DescripcionDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string FormatoDocumento { get; set; }
    }
}
