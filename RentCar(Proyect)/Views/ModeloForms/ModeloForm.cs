using RentCar_Proyect_.UsuarioForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar_Proyect_
{
    public partial class ModeloForm : Form
    {
        public ModeloForm()
        {
            InitializeComponent();
        }
        ModeloRepository _context = new ModeloRepository();
        public int Id;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void UpdateData()
        {
            ModeloDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateModeloForm Create = new CreateModeloForm(this);

            Create.Show();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ModeloDataGrid.SelectedRows.Count > 0)
            {
                EditModeloForm edit = new EditModeloForm(this);

                edit.txtId.Text = ModeloDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtdescripcion.Text = ModeloDataGrid.CurrentRow.Cells[2].Value.ToString();
                edit.IdM.Text= ModeloDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(ModeloDataGrid.CurrentRow.Cells[4].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que desea editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ModeloDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ModeloDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(ModeloDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este Modelo?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El modelo fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    ModeloDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la marca que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ModeloDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

       

        private void ModeloForm_Load(object sender, EventArgs e)
        {
            ModeloDataGrid.DataSource = _context.Getlist();

            ModeloDataGrid.Columns[0].HeaderText = "Codigo";
            ModeloDataGrid.Columns[1].HeaderText = "Marca";
            ModeloDataGrid.Columns[2].HeaderText = "Descripcion modelo";

            ModeloDataGrid.Columns[3].Visible = false;
        }
    }
}
