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
    public partial class CombustibleForm : Form
    {
        public CombustibleForm()
        {
            InitializeComponent();
        }
        CombustibleRepository _context = new CombustibleRepository();
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
            CombusDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateCombustibleForm Create = new CreateCombustibleForm(this);

            Create.Show();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (CombusDataGrid.SelectedRows.Count > 0)
            {
                EditCombustibleForm edit = new EditCombustibleForm(this);

                edit.txtId.Text = CombusDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtdescripcion.Text = CombusDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(CombusDataGrid.CurrentRow.Cells[2].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que desea editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CombusDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CombusDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(CombusDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta Combustible?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El tipo de combustible fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    CombusDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el tipo de combustible que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            CombusDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

        

       

        private void CombustibleForm_Load(object sender, EventArgs e)
        {
            CombusDataGrid.DataSource = _context.Getlist();

            CombusDataGrid.Columns[0].HeaderText = "Codigo";
        }
    }
}
