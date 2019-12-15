using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlWeb.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del evento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(50, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string NombreEvento { get; set; }


        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "la {0} es requerido.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEvento { get; set; }


        [Display(Name = "Descripción")]
        [StringLength(100, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string DescripcionEvento { get; set; } = "";


        [Display(Name = "Fecha final")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }


        public List<Academico_Evento> Academico_Eventos { get; set; }
        public List<Evento_SedeEvento> Evento_SedeEventos { get; set; }
        public List<Evento_Documento> Evento_Documentos { get; set; }




    }
}
