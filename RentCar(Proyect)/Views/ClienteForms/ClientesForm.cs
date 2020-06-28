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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        ClientesRepository _context = new ClientesRepository();
        public int Id;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            ClientDataGrid.DataSource = _context.Getlist();

            ClientDataGrid.Columns[0].HeaderText = "Codigo";
            ClientDataGrid.Columns[3].HeaderText = "No.Tarjeta";
            ClientDataGrid.Columns[4].HeaderText = "Limite de credito";
            ClientDataGrid.Columns[5].HeaderText = "Tipo de persona";
        }

        public void UpdateData()
        {
            ClientDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateClientForm Create = new CreateClientForm(this);

            Create.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ClientDataGrid.SelectedRows.Count > 0)
            {
                EditClientForm edit = new EditClientForm(this);

                edit.txtId.Text = ClientDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtName.Text = ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.txtlastname.Text = ClientDataGrid.CurrentRow.Cells[2].Value.ToString();
                edit.txtnumtarj.Text = ClientDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.txtLimit.Text = ClientDataGrid.CurrentRow.Cells[4].Value.ToString();
                edit.cbtypeperson.Text = ClientDataGrid.CurrentRow.Cells[5].Value.ToString();
                edit.rdstatus.Checked = Convert.ToBoolean(ClientDataGrid.CurrentRow.Cells[6].Value.ToString());

                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que quiere editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ClientDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ClientDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(ClientDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El cliente fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    ClientDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el usuario que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ClientDataGrid.DataSource = _context.Search(txtsearch.Text);
        }
    }
}
