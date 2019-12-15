using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Datos personales")]
        //public int DatosPersonalesId { get; set; }
        public  DatosPersonales DatosPersonales { get; set; }

        //[Display(Name = "Academico")]
        //public int AcademicoId { get; set; }
        public Academico Academico { get; set; }

        //[Display(Name = "Estudiante")]
        //public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(45, ErrorMessage = "Solo se admiten {0} carácteres.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(255, ErrorMessage = "Solo se admiten {0} carácteres.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<Role_Usuario> Role_Usuarios { get; set; }

        public List<DatosPersonales> DatosPersonalesCList { get; set; }

        public List<DatosPersonales> DatosPersonalesUList { get; set; }

        public List<DatosPersonales> DatosPersonalesDList { get; set; }


        public List<string> permisos()
        {
            var roles = this.Role_Usuarios.Where(x => x.UsuarioId == this.Id).ToList();
            List<string> permisos = new List<string>();
            //foreach (var rol in roles)
            //{
            //    var role_permiso = rol.Role.Role_Permiso.Where(x => x.RoleId == rol.Id);
            //    foreach (var item in role_permiso)
            //    {
            //        permisos.Add(item.Permiso.Clave);
            //    }
            //}

            return permisos;
        }

        public string email()
        {
            return Email;
        }
        //public bool hasPermiso(string clave)
        //{
        //    //"evento-create"

        //    var roles = this.Role_Usuarios.Where(x => x.UsuarioId);
        //    //this Roles_Usuario.Where("IdUsuario",this.IdUsuario);
        //    //List<Role>
        //    ListSet<string> permisosClaves = { };
        //    foreach (var role in roles)
        //    {
        //        var permisos = role.Role_Permiso.where(x => x.RoleId == role.RoleId);
        //        foreach (var permiso in permisos)
        //        {
        //            permisosClaves.add(permiso.clave);
        //        }
        //    }
        //    return permisosClaves.contains(clave);

        //    //List<Permiso> TreeSet<Permiso> HashSet<Permiso>
        //    /*
        //        {"permiso-create","permiso-update","usuario-create"}
        //        return list.exists(clave);
        //    */

        //    return false;
        //}
    }

}
