using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    public class Laptop
    {
        [Key]
        public string CodigoLaptop { get; set; }
        public string CodigoMarca { get; set; }

        public string CodigoModelo { get; set; }

        public string CodigoColaborador { get; set; }

        public string NumeroSerie { get; set; }

        public string HostName { get; set; }

        public string CodigoEstadoLaptop { get; set; }

    }
}
