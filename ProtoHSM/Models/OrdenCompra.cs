using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class OrdenCompra
    {
        public int OrdenCompraID { get; set; }
        public int ProveedorID { get; set; }
        public DateTime FechaOrden { get; set; }
        public string Estado { get; set; } // "Pendiente", "Parcial", "Completa", "Cancelada"
        public int UsuarioID { get; set; }
    }

}
