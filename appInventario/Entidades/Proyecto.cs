using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    [Table("PROYECTO)]
    public class Proyecto
    {
        [Key]
        [Column("CO_PROYECTO")]
        public string CodigoProyecto { get; set; }

        [Column("TX_NOMBRE_PROYECTO")]
        public string NombreProyecto { get; set; }

        public ICollection<Maestro> EstadosColaboradores { get; set; }


    }
}
