using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoHSM.Models;

namespace ProtoHSM.Compras
{
    public partial class nuevoProveedorView : Form
    {
        private Controller controller;
        public nuevoProveedorView(Controller _controller)
        {
            controller = _controller;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var proveedor = new Proveedor
            {
                Nombre = textNombre.Text.Trim(),
                RFC = string.IsNullOrWhiteSpace(textRFC.Text) ? null : textRFC.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(textTel.Text) ? null : textTel.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(textEmail.Text) ? null : textEmail.Text.Trim(),
                Calle = string.IsNullOrWhiteSpace(textCalle.Text) ? null : textCalle.Text.Trim(),
                NumExt = string.IsNullOrWhiteSpace(textNumExt.Text) ? null : textNumExt.Text.Trim(),
                NumInt = string.IsNullOrWhiteSpace(textNumInt.Text) ? null : textNumInt.Text.Trim(),
                Colonia = string.IsNullOrWhiteSpace(textColonia.Text) ? null : textColonia.Text.Trim(),
                ZipCode = textZipCode.Text.Trim()
            };

            try
            {
                int nuevoId = controller.RegistrarProveedor(proveedor);
                MessageBox.Show($"Proveedor registrado con Exito",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar proveedor:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
