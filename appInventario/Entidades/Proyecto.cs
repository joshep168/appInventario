using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    public class Proyecto
    {
        [Key]
        public string CodigoProyecto { get; set; }
        public string NombreProyecto { get; set; }

    }
}
