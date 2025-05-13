using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class PrecioCompraDTO
    {
        public int PrecioCompraID { get; set; }
        public int MedicamentoID { get; set; }
        public int? ProveedorID { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public string Comentario { get; set; }
    }

}
