using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Cobro
    {
        public int CobroID { get; set; }
        public int VisitaID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaHoraCobro { get; set; }
        public int UsuarioID { get; set; }
    }

}
