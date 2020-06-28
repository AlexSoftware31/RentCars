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
    public partial class MarcaForm : Form
    {
        public MarcaForm()
        {
            InitializeComponent();
        }
        MarcaRepository _context = new MarcaRepository();
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
            MarcaDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateMarcaForm Create = new CreateMarcaForm(this);

            Create.Show();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MarcaDataGrid.SelectedRows.Count > 0)
            {
                EditMarcaForm edit = new EditMarcaForm(this);

                edit.txtId.Text = MarcaDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtdescripcion.Text = MarcaDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(MarcaDataGrid.CurrentRow.Cells[2].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que desea editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MarcaDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MarcaDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(MarcaDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta marca?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("La marca fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    MarcaDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la marca que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            MarcaDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

        

        private void MarcaForm_Load(object sender, EventArgs e)
        {
            MarcaDataGrid.DataSource = _context.Getlist();

            MarcaDataGrid.Columns[0].HeaderText = "Codigo";
        }
    }
}
