using System.Data;

namespace ProtoHSM.Farmacia
{
    public partial class nuevaCompra : Form
    {
        private DataTable dt;


        public nuevaCompra()
        {
            dt = new DataTable();
            dt.Columns.Add("Insumo", typeof(string));
            dt.Columns.Add("Lote", typeof(string));
            dt.Columns.Add("F.Caducidad", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(float));
            InitializeComponent();
        }


        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textCant.Text.Trim(), out int cantidad) &&
                !string.IsNullOrWhiteSpace(textInsumo.Text))
            {

                dt.Rows.Add(textInsumo.Text, textLote.Text, textCaducidad.Text, textCant.Text, textPrecio.Text);
                listaInsumos.DataSource = dt;
                textInsumo.Clear();
                textLote.Clear();
                textCaducidad.Clear();
                textPrecio.Clear();
                textCant.Text = "1";
                textInsumo.Select();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida y un nombre de insumo.");
            }
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra agregada correctamente en Almacen.");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

