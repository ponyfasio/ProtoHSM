using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class SugerenciaLoteDTO
    {
        public int DetalleID { get; set; }
        public string Medicamento { get; set; }
        public int Cantidad { get; set; }
        public int LoteID { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Almacen { get; set; }
        public int StockDisponible { get; set; }
    }

}
