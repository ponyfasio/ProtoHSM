using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class InsumoUtilizado
    {
        public int InsumoUtilizadoID { get; set; }
        public int VisitaID { get; set; }
        public int LoteID { get; set; }
        public int Cantidad { get; set; }
        public bool EsExtra { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaUso { get; set; }
    }

}
