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
    public partial class TipoVehiculoForm : Form
    {
        public TipoVehiculoForm()
        {
            InitializeComponent();
        }
        TipoVehiculoRepository _context = new TipoVehiculoRepository();
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
            TipoVehDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateTipoVehiculoForm Create = new CreateTipoVehiculoForm(this);

            Create.Show();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TipoVehDataGrid.SelectedRows.Count > 0)
            {
                EditTipoVehiculoForm edit = new EditTipoVehiculoForm(this);

                edit.txtId.Text = TipoVehDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtdescripcion.Text = TipoVehDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(TipoVehDataGrid.CurrentRow.Cells[2].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que desea editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TipoVehDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TipoVehDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(TipoVehDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este tipo de vehiculo?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El tipo de vehiculo fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    TipoVehDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar tipo de vehiculo que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            TipoVehDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

        private void TipoVehiculoForm_Load(object sender, EventArgs e)
        {
            TipoVehDataGrid.DataSource = _context.Getlist();

            TipoVehDataGrid.Columns[0].HeaderText = "Codigo";

        }
    }
}
