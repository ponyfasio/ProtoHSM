using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using ProtoHSM.Cajas;
using ProtoHSM.Compras;
using ProtoHSM.Farmacia;
using ProtoHSM.Models;

namespace ProtoHSM
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\HSM;Database=HospitalSanMarcos;User Id=sa;Password=476362;TrustServerCertificate=True;";
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textUser.Text.Trim().ToLower();
            string password = textPass.Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Pass", password);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            UsuarioID = reader.GetInt32(0),
                            Nombres = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            RolID = reader.GetInt32(3)
                        };

                        // Aquí creas el controlador principal
                        Controller controller = new Controller();
                        controller.IniciarSesion(usuario);
                        // Abres la ventana que le corresponde según su rol
                        this.Hide();
                        AbrirMenuPorRol(controller);
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
        }


        private void AbrirMenuPorRol(Controller controller)
        {
            int rolID = controller.UsuarioActual.RolID;

            Form menu = rolID switch
            {
               // 1 => new menuAdmin(controller),
                2 => new admisionMenu(controller),
                3 => new menuFarmacia(controller),
               // 4 => new menuAdmision(controller),
               // 5 => new menuCajas(controller),
               
            };

            if (menu != null)
            {
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Rol no autorizado.");
            }
        }

        public void cargaAvisos()
        {
            string query = "EXEC ObtenerAvisosImportantesActivos";
            using (SqlConnection conn = new SqlConnection(controller.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string titulo = reader["Titulo"].ToString();
                    string mensaje = reader["Mensaje"].ToString();
                    string fecha = Convert.ToDateTime(reader["FechaPublicacion"]).ToString("dd/MM/yyyy");
                    string importancia = reader["Importancia"].ToString();

                    string aviso = $"[{importancia}] {titulo} ({fecha})\n→ {mensaje}";
                    listAvisos.Items.Add(aviso);
                }
            }
        }
        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string numero = "524497168370"; // Incluye el código de país (52 para México)
            string mensaje = Uri.EscapeDataString("Hola, este es un mensaje desde mi app en C#!");

            string url = $"https://wa.me/{numero}?text={mensaje}";

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Necesario para abrir en navegador moderno
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir WhatsApp Web: " + ex.Message);
            }
        }
    }
}
