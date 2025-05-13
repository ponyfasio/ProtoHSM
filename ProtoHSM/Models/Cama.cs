using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Cama
    {
        public int CamaID { get; set; }
        public string Numero { get; set; }
        public int TipoCamaID { get; set; }
        public string Estado { get; set; } // Disponible, Ocupada, Requiere Limpieza, etc.
        public bool PermiteAislamiento { get; set; }
        public string Ubicacion { get; set; }
        public string Observaciones { get; set; }
    }


}
