using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Urgencia
    {
        public int UrgenciaID { get; set; }
        public int VisitaID { get; set; }
        public int NivelTriage { get; set; }
        public DateTime HoraLlegada { get; set; }
        public DateTime HoraAtencion { get; set; }
        public int UsuarioID { get; set; }
    }

}
