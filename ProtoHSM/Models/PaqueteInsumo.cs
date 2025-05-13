using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class PaqueteInsumo
    {
        public int PaqueteInsumoID { get; set; }
        public int PaqueteID { get; set; }
        public int MedicamentoID { get; set; }
        public int CantidadIncluida { get; set; }
    }

}
