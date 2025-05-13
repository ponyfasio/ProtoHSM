using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Compra
    {
        public int CompraID { get; set; }
        public int OrdenCompraID { get; set; }
        public DateTime FechaCompra { get; set; }
        public int UsuarioID { get; set; }
    }

}
