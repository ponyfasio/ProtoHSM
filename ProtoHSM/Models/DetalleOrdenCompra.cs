using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class DetalleOrdenCompra
    {
        public int DetalleID { get; set; }
        public int OrdenCompraID { get; set; }
        public int MedicamentoID { get; set; }
        public int CantidadSolicitada { get; set; }
    }

}
