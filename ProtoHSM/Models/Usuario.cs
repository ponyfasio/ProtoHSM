using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public int RolID { get; set; }
        public bool Activo { get; set; }
    }

}
