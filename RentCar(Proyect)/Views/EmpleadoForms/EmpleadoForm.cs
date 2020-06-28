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
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }
        EmpleadoRepository _context = new EmpleadoRepository();
        public int Id;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void UpdateData()
        {
            EmpleaDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
          CreateEmpleadoForm Create = new CreateEmpleadoForm(this);

            Create.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EmpleaDataGrid.SelectedRows.Count > 0)
            {
                EditEmpleadoForm edit = new EditEmpleadoForm(this);

                edit.txtId.Text = EmpleaDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtName.Text = EmpleaDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.txtcedula.Text = EmpleaDataGrid.CurrentRow.Cells[2].Value.ToString();
                edit.TLaborar.Text = EmpleaDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.PorComision.Text = EmpleaDataGrid.CurrentRow.Cells[4].Value.ToString();
                edit.dateIngreso.Text = EmpleaDataGrid.CurrentRow.Cells[5].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(EmpleaDataGrid.CurrentRow.Cells[6].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que quiere editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EmpleaDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmpleaDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(EmpleaDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El empleado fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    EmpleaDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el usuario que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            EmpleaDataGrid.DataSource = _context.Search(txtsearch.Text);
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            EmpleaDataGrid.DataSource = _context.Getlist();

            EmpleaDataGrid.Columns[0].HeaderText = "Codigo";
            EmpleaDataGrid.Columns[3].HeaderText = "Tanda laboral";
            EmpleaDataGrid.Columns[4].HeaderText = "Porciento por comision";
            EmpleaDataGrid.Columns[5].HeaderText = "Fecha de ingreso";
        }
    }
}
