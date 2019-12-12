using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlWeb.Models
{
    public class TipoOrganizador
    {
        [Key]
        public int IdTipoOrganizador { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }

    }
}
