    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdDatosPersonales{ get; set; }
        public int IdAcademico { get; set; }
        public int IdEstudiante { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //------------ Estos elementos ya estaban en la clase 
        public string Nombre { get; set; }
        public List<Role> Roles { get; set; }
    }
}
