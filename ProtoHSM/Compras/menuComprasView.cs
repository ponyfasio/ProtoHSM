using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoHSM.Compras
{
    public partial class menuComprasView : Form
    {
        private Controller controller;
        public menuComprasView(Controller _controller)
        {
            InitializeComponent();
            this.controller = _controller;
        }

        private void buttonProveedor_Click(object sender, EventArgs e)
        {
           
            nuevoProveedorView newSupplier = new nuevoProveedorView(controller);
            this.Hide();
            newSupplier.ShowDialog();
            this.Show();
        }
    }
}
