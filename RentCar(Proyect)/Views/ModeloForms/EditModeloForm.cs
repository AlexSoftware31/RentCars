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
    public partial class EditModeloForm : Form
    {
        ModeloForm modelo;
        public EditModeloForm(ModeloForm model)
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Edit(Convert.ToInt32(txtId.Text),Convert.ToInt32(CbMarcas.SelectedValue), txtdescripcion.Text,  rdstatus.Checked);

                this.Close();
                MessageBox.Show("El modelo fue editado con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                modelo.ModeloDataGrid.DataSource = _context.Getlist();
            }
        }

        private void EditModeloForm_Load(object sender, EventArgs e)
        {
            CbMarcas.ValueMember = "IdMarca";
            CbMarcas.DisplayMember = "Descripcion";
            CbMarcas.DataSource = _contextmarca.GetMarcas();

            CbMarcas.SelectedValue = IdM.Text;
        }
    }
}
