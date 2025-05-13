using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class ExpedienteMedico
    {
        public int ExpedienteID { get; set; }
        public int VisitaID { get; set; }
        public int PacienteID { get; set; }
        public DateTime FechaApertura { get; set; }
        public string MedicoResponsable { get; set; }
        public string EstadoExpediente { get; set; } // "Abierto", "Cerrado"
    }

}
