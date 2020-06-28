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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        UsuariosRepository _context = new UsuariosRepository();
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
            UserDataGrid.DataSource = _context.Getlist();

            UserDataGrid.Columns[0].HeaderText = "Codigo";
            UserDataGrid.Columns[3].HeaderText = "Contraseña";
        }

        public void UpdateData()
        {
            UserDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateUserForm Create = new CreateUserForm(this);

            Create.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(UserDataGrid.SelectedRows.Count>0)
            {
                EditUserForm edit = new EditUserForm(this);
                
                edit.txtId.Text = UserDataGrid.CurrentRow.Cells[0].Value.ToString();
                edit.txtNombre.Text = UserDataGrid.CurrentRow.Cells[1].Value.ToString();
                edit.txtUserName.Text = UserDataGrid.CurrentRow.Cells[2].Value.ToString();
                edit.txtpass.Text = UserDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.txtpassconfi.Text = UserDataGrid.CurrentRow.Cells[3].Value.ToString();
                edit.TiposUsuario.Text = UserDataGrid.CurrentRow.Cells[4].Value.ToString();


                edit.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el campo que quiere editar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UserDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(UserDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("El usuario fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    UserDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar el usuario que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            UserDataGrid.DataSource = _context.Search(txtsearch.Text);
        }
    }
}
