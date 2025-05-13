using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Dieta
    {
        public int DietaID { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public decimal CostoAproximado { get; set; }
    }

}
