using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RentCar_Proyect_
{
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();

            lbNombre.Text = nombre;
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 65;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Mine2.Visible = true;
            Max.Visible = false;
        }

        private void Mine2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Mine2.Visible = false;
            Max.Visible = true;
        }

        private void Mini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new UsuariosForm());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new ClientesForm());
        }

        private void EmpleaBtn_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new EmpleadoForm());
        }

        private void btnTipoVeh_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new TipoVehiculoForm());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new MarcaForm());
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new ModeloForm());
        }

        private void btnCombustible_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new CombustibleForm());
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new VehiculoForm());
        }

        private void btnrentadesv_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new RentasDesvForm());
        }

        private void btninspeccion_Click(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
            AbrirFormInPanel(new InspeccionForm());
        }
    }
}
