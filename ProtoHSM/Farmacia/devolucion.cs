using System.Data;

namespace ProtoHSM.Farmacia
{
    public partial class devolucion : Form
    {
        private DataTable dt;
        public devolucion()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Insumo", typeof(string));
            dt.Columns.Add("Lote", typeof(string));
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insumo devuelto correctamente.");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textCantidad.Text, textInsumo.Text, textLote.Text);
            listaInsumos.DataSource = dt;
            textLote.Clear(); textInsumo.Clear(); textCantidad.Clear();
            textCantidad.Select();
        }
    }
}
