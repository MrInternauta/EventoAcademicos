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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string Nombre { get; set; }

        [Display(Name ="Apellido Paterno")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string ApellidoPaterno { get; set; }


        [Display(Name = "Apellido Materno")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        public string ApellidoMaterno { get; set; } = "";

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeNacimiento { get; set; }

        [Display(Name = "Fecha de creación")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Fecha de actualización")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

        [Display(Name = "Fecha de borrado")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Deleted { get; set; }


        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        [Display(Name = "Creador")]
        public int CreatedById { get; set; }
        public Usuario CreatedBy { get; set; }

        [Display(Name = "Actualizador")]
        public int UpdatedById { get; set; }
        public Usuario UpdatedBy { get; set; }

        [Display(Name = "Eliminador")]
        public int DeletedById { get; set; }
        public Usuario DeletedBy { get; set; }

    }
}
