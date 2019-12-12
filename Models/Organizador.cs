using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class Organizador
    {
        [Key]
        public int IdOrganizador { get; set; }
        public int IdTipoOrganizador { get; set; }
        public int IdEvento { get; set; }
        public int IdAcademico { get; set; }
    }
}
