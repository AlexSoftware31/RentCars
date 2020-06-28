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
    public partial class CreateMarcaForm : Form
    {
        MarcaForm marca;
        public CreateMarcaForm(MarcaForm marc)
        {
            InitializeComponent();
            this.marca = marc;
        }
        MarcaRepository _context = new MarcaRepository();

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
                marca.MarcaDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("La marca se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
