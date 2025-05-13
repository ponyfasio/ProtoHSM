using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class MovimientoInventario
    {
        public int MovimientoID { get; set; }
        public int LoteID { get; set; }
        public string TipoMovimiento { get; set; } // "Entrada" o "Salida"
        public int Cantidad { get; set; }
        public int UsuarioID { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }

}
