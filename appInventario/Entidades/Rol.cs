﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    [Table("ROL")]
    public class Rol
    {
        [Key]
        [Column("CO_ROL")]
        public string CodigoRol { get; set; }

        [Column("TX_NOMBRE_ROL")]
        public string NombreRol { get; set; }

        public ICollection<Colaborador> Colaboradores { get; set; }

        

    }
}
