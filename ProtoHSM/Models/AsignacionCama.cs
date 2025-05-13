using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class AsignacionCama
    {
        public int AsignacionID { get; set; }
        public int VisitaID { get; set; }
        public int CamaID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public int UsuarioID { get; set; }
        public bool RequiereAislamiento { get; set; }
        public string TipoCondicion { get; set; } // Ej: "Aislamiento Viral"
    }

}
