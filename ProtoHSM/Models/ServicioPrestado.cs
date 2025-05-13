using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class ServicioPrestado
    {
        public int ServicioPrestadoID { get; set; }
        public int VisitaID { get; set; }
        public string TipoServicio { get; set; }
        public string Descripcion { get; set; }
        public bool EsParteDePaquete { get; set; }
        public decimal Costo { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaServicio { get; set; }
    }

}
