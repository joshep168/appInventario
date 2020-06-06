using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    public class Rol
    {
        

        [Key]
        public string CodigoRol { get; set; }
        public string NombreRol { get; set; }
    }
}
