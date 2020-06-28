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
    public partial class CreateVehiculoForm : Form
    {
        VehiculoForm vehiculo;
        public CreateVehiculoForm(VehiculoForm vehi)
        {
            InitializeComponent();
            this.vehiculo = vehi;
        }
        VehiculoRepository _context = new VehiculoRepository();
        TipoVehiculoRepository _contextTipo = new TipoVehiculoRepository();
        MarcaRepository _contextmarca = new MarcaRepository();
        ModeloRepository _contextmodel = new ModeloRepository();
        CombustibleRepository _contextcombustible = new CombustibleRepository();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(txtDescrip.Text, txtchasis.Text, txtmotor.Text, txtplaca.Text, Convert.ToInt32(Cbveh.SelectedValue), Convert.ToInt32(Cbmarca.SelectedValue), Convert.ToInt32(Cbmodelo.SelectedValue),txtcolor.Text, txtyear.Text, cbtrans.Text, Convert.ToInt32(Cbcomb.SelectedValue), rdstatus.Checked);
                this.Close();
                vehiculo.VehiculoDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("El vehiculo se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
           
            if (txtyear.Text == string.Empty)
            {
                MessageBox.Show("El año del vehiculo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyear.Focus();
                return false;
            }
            if (txtcolor.Text == string.Empty)
            {
                MessageBox.Show("El color del vehiculo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcolor.Focus();
                return false;
            }
            if (txtplaca.Text == string.Empty)
            {
                MessageBox.Show("El numero placa del vehiculo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Focus();
                return false;
            }
            if (txtmotor.Text == string.Empty)
            {
                MessageBox.Show("El numero mortor del vehiculo es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmotor.Focus();
                return false;
            }
            if (txtchasis.Text == string.Empty)
            {
                MessageBox.Show("Numero de chasis es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtchasis.Focus();
                return false;
            }
            if (txtDescrip.Text == string.Empty)
            {
                MessageBox.Show("La descripcion del vehiculo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescrip.Focus();
                return false;
            }
            if (cbtrans.Text == string.Empty || cbtrans.Text == "Seleccionar...")
            {
                MessageBox.Show("Se debe seleccionar Tipo de transmision es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

      

        private void CreateClientForm_Load(object sender, EventArgs e)
        {

        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreateVehiculoForm_Load(object sender, EventArgs e)
        {
            Cbmarca.ValueMember = "IdMarca";
            Cbmarca.DisplayMember = "Descripcion";
            Cbmarca.DataSource = _contextmarca.GetMarcas();

            Cbveh.ValueMember = "IdTipoVehiculo";
            Cbveh.DisplayMember = "Descripcion";
            Cbveh.DataSource = _contextTipo.GetTipoVehiculos();

            Cbcomb.ValueMember = "IdTipoCombustible";
            Cbcomb.DisplayMember = "Descripcion";
            Cbcomb.DataSource = _contextcombustible.GetCombustibles();
        }

        private void Cbmarca_SelectedValueChanged(object sender, EventArgs e)
        {
            Cbmodelo.ValueMember = "IdModelo";
            Cbmodelo.DisplayMember = "Descripcion";
            Cbmodelo.DataSource = _contextmodel.GetModelos(Convert.ToInt32(Cbmarca.SelectedValue));
        }
    }
}
