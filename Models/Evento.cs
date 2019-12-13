using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(15, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreEvento { get; set; }

        public DateTime FechaEvento { get; set; }

        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionEvento { get; set; } = "";

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HoraInicio { get; set; }
        public List<Academico_Evento> Academico_Eventos { get; set; }
        public List<Evento_SedeEvento> Evento_SedeEventos { get; set; }
        public List<Evento_Documento> Evento_Documentos { get; set; }




    }
}
