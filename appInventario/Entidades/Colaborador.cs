using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInventario.Entidades
{
    [Table("COLABORADOR")]
    public class Colaborador
    {
        [Key]
        [Column("CO_COLABORADOR")]
        public string CodigoColaborador { get; set; }

        [Column("TX_MATRICULA")]
        public string Matricula { get; set; }
        
        [Column("TX_NOMBRE")]
        public string Nombre { get; set; }
        
        [Column("TX_APELLIDO")]
        public string Apellido { get; set; }
        
        [Column("CO_ROL_ACTUAL")]
        public string CodigoRolActual { get; set; }

        [Column("CO_ESTADO_COLABORADOR")]
        public string CodigoEstadoColaborador { get; set; }


    }
}
