using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class NotaEnfermeria
    {
        public int NotaID { get; set; }
        public int VisitaID { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioID { get; set; }
    }

}
