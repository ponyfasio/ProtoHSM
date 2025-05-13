using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class NotaMedica
    {
        public int NotaMedicaID { get; set; }
        public int VisitaID { get; set; }
        public DateTime FechaHora { get; set; }
        public string Notas { get; set; }
        public int UsuarioID { get; set; }
    }

}
