using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    
        public class PacienteComboDTO
        {
            public int PacienteID { get; set; }
            public string Nombre { get; set; }
            public string CURP { get; set; }    // <— nueva propiedad
        }
    


}
