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
    public partial class CreateTipoVehiculoForm : Form
    {
        TipoVehiculoForm tipoVeh;
        public CreateTipoVehiculoForm(TipoVehiculoForm tip)
        {
            InitializeComponent();
            this.tipoVeh = tip;
        }
        TipoVehiculoRepository _context = new TipoVehiculoRepository();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(txtdescripcion.Text,  rdstatus.Checked);
                this.Close();
                tipoVeh.TipoVehDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("El tipo de vehiculo se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
           
            
            if (txtdescripcion.Text == string.Empty)
            {
                MessageBox.Show("Nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescripcion.Focus();
                return false;
            }
            
            return true;
        }

       
        private void CreateClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
