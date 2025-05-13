using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class PrecioMedicamentoDTO
    {
        public int PrecioMedicamentoID { get; set; }
        public int MedicamentoID { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Comentario { get; set; }
    }

}
