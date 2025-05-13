using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string ZipCode { get; set; }


    }

}
