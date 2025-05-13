using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Visita
    {
        public int VisitaID { get; set; }
        public int PacienteID { get; set; }
        public string TipoVisita { get; set; } // "Urgencia", "Ingreso Hospitalario", "Consulta Externa"
        public string Padecimiento { get; set; }

        public string? Procedimiento { get; set; }
        public string Cama {  get; set; }
        public DateTime FechaHoraIngreso { get; set; }
        public DateTime? FechaHoraAlta { get; set; }
    }

}
