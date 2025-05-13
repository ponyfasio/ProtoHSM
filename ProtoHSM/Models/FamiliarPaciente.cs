using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class FamiliarPaciente
    {
        public int PacienteID { get; set; } // Solo necesario para actualización o lectura

        public string Nombre { get; set; }
        public string Parentesco { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
    }

}
