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
    public partial class InspeccionForm : Form
    {
        public InspeccionForm()
        {
            InitializeComponent();
        }
        InspeccionRepository _context = new InspeccionRepository();
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
            InspeccionDataGrid.DataSource = _context.Getlist();
        }
        



        

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            InspeccionDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (InspeccionDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(InspeccionDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este inspeccion?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El inspecion fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    InspeccionDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la marca que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            InspeccionDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

       

        private void ModeloForm_Load(object sender, EventArgs e)
        {
            InspeccionDataGrid.DataSource = _context.Getlist();

            InspeccionDataGrid.Columns[0].HeaderText = "Codigo";
            InspeccionDataGrid.Columns[1].HeaderText = "Vehiculo";
            InspeccionDataGrid.Columns[2].HeaderText = "Cliente";

            InspeccionDataGrid.Columns[14].HeaderText = "Empleado";
        }
    }
}
