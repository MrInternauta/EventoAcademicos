using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public int IdUsuario { get; set; }
        public string Matricula { get; set; }

        //------------ Este ya se encontraba en la clase -----------------
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
