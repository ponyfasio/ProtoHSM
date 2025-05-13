using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class AtencionPaquete
    {
        public int AtencionPaqueteID { get; set; }
        public int VisitaID { get; set; }
        public int PaqueteID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int UsuarioID { get; set; }
    }

}
