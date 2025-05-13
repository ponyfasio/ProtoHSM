using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class LoteSugeridoDTO
    {
        public int LoteID { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int CantidadDisponible { get; set; }
        public string Almacen { get; set; }
    }
}
