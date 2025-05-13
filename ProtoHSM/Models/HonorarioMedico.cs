using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class HonorarioMedico
    {
        public int HonorarioID { get; set; }
        public int VisitaID { get; set; }
        public string Medico { get; set; }
        public string Especialidad { get; set; }
        public string Procedimiento { get; set; }
        public decimal Costo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioID { get; set; }
    }

}
