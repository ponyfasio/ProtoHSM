using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoHSM.Models
{
    public class Medicamento
    {
        public int MedicamentoID { get; set; }
        public string NombreComercial { get; set; }
        public string SustanciaActiva { get; set; }
        public string Presentacion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
    }

}
