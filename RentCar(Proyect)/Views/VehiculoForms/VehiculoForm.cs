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
    public partial class VehiculoForm : Form
    {
        public VehiculoForm()
        {
            InitializeComponent();
        }
        VehiculoRepository _context = new VehiculoRepository();
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
            VehiculoDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateVehiculoForm Create = new CreateVehiculoForm(this);

            Create.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VehiculoDataGrid.SelectedRows.Count > 0)
            {
                EditVehiculoForm edit = new EditVehiculoForm(this);

                edit.txtId.Text = VehiculoDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtDescrip.Text = VehiculoDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.txtchasis.Text = VehiculoDataGrid.CurrentRow.Cells[2].Value.ToString();
                edit.txtmotor.Text = VehiculoDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.txtplaca.Text = VehiculoDataGrid.CurrentRow.Cells[4].Value.ToString();
                edit.txtIdtipo.Text = VehiculoDataGrid.CurrentRow.Cells[15].Value.ToString();
                edit.txtidmarca.Text = VehiculoDataGrid.CurrentRow.Cells[13].Value.ToString();
                edit.txtmodel.Text = VehiculoDataGrid.CurrentRow.Cells[14].Value.ToString();
                edit.txtidcomb.Text = VehiculoDataGrid.CurrentRow.Cells[16].Value.ToString();
                edit.txtcolor.Text = VehiculoDataGrid.CurrentRow.Cells[8].Value.ToString();
                edit.txtyear.Text = VehiculoDataGrid.CurrentRow.Cells[9].Value.ToString();
                edit.cbtrans.Text = VehiculoDataGrid.CurrentRow.Cells[10].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(VehiculoDataGrid.CurrentRow.Cells[12].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que quiere editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            VehiculoDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VehiculoDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(VehiculoDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este vehiculo?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El vehiculo fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    VehiculoDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el vehiculo que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            VehiculoDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

        private void VehiculoForm_Load(object sender, EventArgs e)
        {
            VehiculoDataGrid.DataSource = _context.Getlist();

            VehiculoDataGrid.Columns[0].HeaderText = "Codigo";
            VehiculoDataGrid.Columns[2].HeaderText = "N°Chasis";
            VehiculoDataGrid.Columns[3].HeaderText = "N°Motor";
            VehiculoDataGrid.Columns[4].HeaderText = "N°Placa";
            VehiculoDataGrid.Columns[5].HeaderText = "Tipo";
            VehiculoDataGrid.Columns[6].HeaderText = "Marca";
            VehiculoDataGrid.Columns[7].HeaderText = "Modelo";
            VehiculoDataGrid.Columns[9].HeaderText = "Año";
            VehiculoDataGrid.Columns[11].HeaderText = "Combustible";

            VehiculoDataGrid.Columns[13].Visible = false;
            VehiculoDataGrid.Columns[14].Visible = false;
            VehiculoDataGrid.Columns[15].Visible = false;
            VehiculoDataGrid.Columns[16].Visible = false;
        }
    }
}
