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
    public partial class CreateCombustibleForm : Form
    {
        CombustibleForm combustible;
        public CreateCombustibleForm(CombustibleForm combus)
        {
            InitializeComponent();
            this.combustible = combus;
        }
        CombustibleRepository _context = new CombustibleRepository();

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
                combustible.CombusDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("El combustible se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private bool IsValid()
        {
           
            
            if (txtdescripcion.Text == string.Empty)
            {
                MessageBox.Show("Descripcion es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
