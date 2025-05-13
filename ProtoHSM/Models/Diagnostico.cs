using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Diagnostico
    {
        public int DiagnosticoID { get; set; }
        public int VisitaID { get; set; }
        public string CodigoCIE10 { get; set; }
        public string Descripcion { get; set; }
        public string TipoDiagnostico { get; set; } // Ej: "Ingreso", "Egreso", "Secundario"
    }

}
