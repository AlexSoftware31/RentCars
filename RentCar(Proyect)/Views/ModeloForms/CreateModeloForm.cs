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
    public partial class CreateModeloForm : Form
    {
        ModeloForm modelo;
        public CreateModeloForm(ModeloForm model)
        {
            InitializeComponent();
            this.modelo = model;
        }
        ModeloRepository _context = new ModeloRepository();
        MarcaRepository _contextmarca = new MarcaRepository();
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Create(Convert.ToInt32(CbMarcas.SelectedValue) ,txtdescripcion.Text,  rdstatus.Checked);
                this.Close();
                modelo.ModeloDataGrid.DataSource = _context.Getlist();

                MessageBox.Show("El modelo se agrego con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (CbMarcas.SelectedValue == null)
            {
                MessageBox.Show("Marca es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CreateModeloForm_Load(object sender, EventArgs e)
        {
            CbMarcas.ValueMember = "IdMarca";
            CbMarcas.DisplayMember = "Descripcion";
            CbMarcas.DataSource= _contextmarca.GetMarcas();
           
        }

        private void CbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
