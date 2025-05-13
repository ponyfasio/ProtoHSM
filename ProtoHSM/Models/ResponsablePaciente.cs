using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class ResponsablePaciente
    {
        public int ResponsableID { get; set; }
        public int PacienteID { get; set; }
        public string NombreCompleto { get; set; }
        public string Parentesco { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
    }

}
