using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    [Table("COLABORADOR_PROYECTO")]
    public class Colaborador_Proyecto
    {
        [Column("CO_PROYECTO")]
        public string CodigoProyecto { get; set; }
        
        [Column("CO_COLABORADOR")]
        public string CodigoColaborador { get; set; }
        
        [Column("CO_ROL")]
        public string CodigoRol { get; set; }


    }
}
