using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Aseguradora
    {
        public int AseguradoraID { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }

}
