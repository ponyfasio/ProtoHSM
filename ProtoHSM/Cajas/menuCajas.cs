using BrightIdeasSoftware;

namespace ProtoHSM.Cajas
{
    public partial class menuCajas : Form
    {
        public class Articulo
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }

        public class Comanda
        {
            public string Folio { get; set; }
            public List<Articulo> Articulos { get; set; } = new();
        }

        public class Paciente
        {
            public string Nombre { get; set; }
            public List<Comanda> Comandas { get; set; } = new();
        }

        public class Nodo
        {
            public string Tipo { get; set; } // "Paciente", "Comanda", "Articulo"
            public string Nombre { get; set; }
            public string Extra { get; set; } // Folio, Precio en texto
            public decimal Total { get; set; } // Para cálculos numéricos reales
            public List<Nodo> Hijos { get; set; } = new();
        }


        private List<Nodo> GenerarDatos()
        {
            var lista = new List<Nodo>();

            var p1 = new Nodo { Tipo = "Paciente", Nombre = "Juan Pérez" };

            var c1 = new Nodo { Tipo = "Comanda", Nombre = "CMD-001" };
            c1.Hijos.Add(new Nodo { Tipo = "Articulo", Nombre = "Gasas", Extra = "$100", Total = 100 });
            c1.Hijos.Add(new Nodo { Tipo = "Articulo", Nombre = "Ibuprofeno", Extra = "$80", Total = 80 });
            c1.Total = c1.Hijos.Sum(h => h.Total);
            c1.Extra = $"${c1.Total}";

            var c2 = new Nodo { Tipo = "Comanda", Nombre = "CMD-002" };
            c2.Hijos.Add(new Nodo { Tipo = "Articulo", Nombre = "Jeringa", Extra = "$20", Total = 20 });
            c2.Total = c2.Hijos.Sum(h => h.Total);
            c2.Extra = $"${c2.Total}";

            p1.Hijos.Add(c1);
            p1.Hijos.Add(c2);
            p1.Total = p1.Hijos.Sum(h => h.Total);
            p1.Extra = $"${p1.Total}";

            lista.Add(p1);

            var p2 = new Nodo { Tipo = "Paciente", Nombre = "Luisa Gómez" };

            var c3 = new Nodo { Tipo = "Comanda", Nombre = "CMD-003" };
            c3.Hijos.Add(new Nodo { Tipo = "Articulo", Nombre = "Paracetamol", Extra = "$60", Total = 60 });
            c3.Hijos.Add(new Nodo { Tipo = "Articulo", Nombre = "Venda", Extra = "$30", Total = 30 });
            c3.Total = c3.Hijos.Sum(h => h.Total);
            c3.Extra = $"${c3.Total}";

            p2.Hijos.Add(c3);
            p2.Total = p2.Hijos.Sum(h => h.Total);
            p2.Extra = $"${p2.Total}";

            lista.Add(p2);

            return lista;
        }



        public menuCajas()
        {
            

      
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuentaPaciente cuenta= new cuentaPaciente();
            cuenta.ShowDialog();

        }
    }
}
