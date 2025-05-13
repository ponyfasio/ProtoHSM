using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class RecepcionCompra
    {
        public int RecepcionID { get; set; }
        public int CompraID { get; set; }
        public int MedicamentoID { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int CantidadRecibida { get; set; }
        public int AlmacenID { get; set; }
        public decimal TemperaturaRecepcion { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int UsuarioID { get; set; }
    }

}
