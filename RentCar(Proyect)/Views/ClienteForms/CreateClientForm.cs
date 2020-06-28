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
    public partial class CreateClientForm : Form
    {
        ClientesForm client;
        public CreateClientForm(ClientesForm cli)
        {
            InitializeComponent();
            this.client = cli;
        }
        ClientesRepository _context = new ClientesRepository();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(txtName.Text, txtlastname.Text, txtnumtarj.Text, txtLimit.Text, cbtypeperson.Text, rdstatus.Checked);
                this.Close();
                client.ClientDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("El cliente se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        { 
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (txtlastname.Text == string.Empty)
            {
                MessageBox.Show("Apellido es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlastname.Focus();
                return false;
            }
           
            if (cbtypeperson.Text == string.Empty || cbtypeperson.Text == "Seleccionar...")
            {
                MessageBox.Show("Se debe seleccionar Tipo de persona es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtnumtarj.Text == string.Empty)
            {
                MessageBox.Show("El numero de tarjeta es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumtarj.Focus();
                return false;
            }


            return true;
        }

        private void txtLimit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreateClientForm_Load(object sender, EventArgs e)
        {

        }

        private void txtnumtarj_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
