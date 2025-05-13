using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Medico
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Especialidad { get; set; }
        public string CedulaProfesional { get; set; }
        public string? Telefono { get; set; }
       
    }
}
