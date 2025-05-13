using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class SolicitudFarmaciaDTO
    {
        public int DetalleID { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Paciente { get; set; }
        public string Cama { get; set; }
        public string Medico { get; set; }
        public string Enfermera { get; set; }
        public string Medicamento { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }

    }
}
