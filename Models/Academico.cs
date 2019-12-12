using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Academico
    {
        [Key]
        public int IdAcademico { get; set; }
        public int IdFacultad { get; set; }
        public string NoControl { get; set; }
        public string Rfc { get; set; }

        //--------- Esto ya lo tenía la clase creada ------------
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }

}
