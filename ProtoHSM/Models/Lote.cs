using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Lote
    {
        public int LoteID { get; set; }
        public int MedicamentoID { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int CantidadDisponible { get; set; }
        public int AlmacenID { get; set; }
        public decimal TemperaturaActual { get; set; }
        public decimal TemperaturaAlmacenamientoMin { get; set; }
        public decimal TemperaturaAlmacenamientoMax { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
