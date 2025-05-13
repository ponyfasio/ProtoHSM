using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class SolicitudDieta
    {
        public int SolicitudID { get; set; }
        public int VisitaID { get; set; }
        public int DietaID { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int UsuarioID { get; set; }
    }

}
