using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlWeb.Models
{
    public class DatosPersonales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDatosPersonales { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string ApellidoPaterno { get; set; }

        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string ApellidoMaterno { get; set; } = "";

        [Required(ErrorMessage = "El {0} campo es requerido.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeNacimiento { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public int DeletedId { get; set; }
        public DateTime Deleted { get; set; }

        public int CreatedById { get; set; }
        public Usuario CreatedBy { get; set; }

        public int UpdatedById { get; set; }
        public Usuario UpdatedBy { get; set; }

        public int DeletedById { get; set; }
        public Usuario DeletedBy { get; set; }

    }
}
