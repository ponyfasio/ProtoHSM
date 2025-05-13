using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class TarifaAseguradora
    {
        public int TarifaID { get; set; }
        public int AseguradoraID { get; set; }
        public string TipoCargo { get; set; } // "Insumo", "Servicio", "Honorario", "Dieta"
        public decimal Factor { get; set; }
    }

}
