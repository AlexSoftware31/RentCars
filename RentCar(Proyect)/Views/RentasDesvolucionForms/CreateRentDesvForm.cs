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
    public partial class CreateRentDesvForm : Form
    {
        RentasDesvForm rentas;
        public CreateRentDesvForm(RentasDesvForm rent)
        {
            InitializeComponent();
            this.rentas = rent;
        }
        RentasDesvRepository _context = new RentasDesvRepository();
        VehiculoRepository _contextvehiculo = new VehiculoRepository();
        ClientesRepository _contextclientes = new ClientesRepository();
        EmpleadoRepository _contextempleado = new EmpleadoRepository();
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(Convert.ToInt32(cbemplea.SelectedValue), Convert.ToInt32(cbvehiculo.SelectedValue), Convert.ToInt32(cbclient.SelectedValue), daterenta.Value, datedesv.Value, txtmonto.Text, txtcantidad.Text, txtcomentario.Text);
                this.Close();
                rentas.RentaDesvDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("La renta se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
           
            if (txtcantidad.Text == string.Empty)
            {
                MessageBox.Show("El cantidad de dias es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcantidad.Focus();
                return false;
            }

            if (txtmonto.Text == string.Empty)
            {
                MessageBox.Show("El MontoxDias es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmonto.Focus();
                return false;
            }
           

            return true;
        }

        

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreateRentDesvForm_Load(object sender, EventArgs e)
        {
            

            cbemplea.ValueMember = "IdEmpleado";
            cbemplea.DisplayMember = "Nombre";
            cbemplea.DataSource = _contextempleado.GetEmpleados();

            cbvehiculo.ValueMember = "IdVehiculo";
            cbvehiculo.DisplayMember = "Descripcion";
            cbvehiculo.DataSource = _contextvehiculo.GetVehiculos();

            cbclient.ValueMember = "IdCliente";
            cbclient.DisplayMember = "Nombre";
            cbclient.DataSource = _contextclientes.GetClientes();
        }
    }
}
