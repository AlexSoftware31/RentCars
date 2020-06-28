using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar_Proyect_.UsuarioForms
{
    public partial class CreateInspeccionForm : Form
    {
        RentasDesvForm rentas;
        public CreateInspeccionForm(RentasDesvForm rent)
        {
            InitializeComponent();
            this.rentas = rent;
        }
        InspeccionRepository _context = new InspeccionRepository();
        EmpleadoRepository _contextempleado = new EmpleadoRepository();
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(Convert.ToInt32(Idrenta.Text), Convert.ToInt32(Idvehiculo.Text), Convert.ToInt32(IdCliente.Text),Convert.ToInt32(cbemple.SelectedValue), cerradura.Checked, CantCombus.Text, gomaresp.Checked, Gato.Checked, cristal.Checked, GomadelateraDR.Checked, GomadelateraIz.Checked, GomatraseraIz.Checked, GomatraseraDR.Checked, dateins.Value, pintura.Checked );
                this.Close();
                
                MessageBox.Show("La Inspeccion se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
           
            if (CantCombus.Text == string.Empty)
            {
                MessageBox.Show("El cantidad combustible es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

           
           

            return true;
        }

        


        private void CantCombus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CreateInspeccionForm_Load(object sender, EventArgs e)
        {
            cbemple.ValueMember = "IdEmpleado";
            cbemple.DisplayMember = "Nombre";
            cbemple.DataSource = _contextempleado.GetEmpleados();
        }
    }
}
