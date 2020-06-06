using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    public class Maestro
    {
        [Key]
        public string CodigoMaestro { get; set; }
        public string CodigoTabla { get; set; }
        public string Valor { get; set; }

    }
}
