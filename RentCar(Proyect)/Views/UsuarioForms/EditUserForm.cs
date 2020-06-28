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
    public partial class EditUserForm : Form
    {
        UsuariosForm user;
        public EditUserForm(UsuariosForm us)
        {
            InitializeComponent();
            this.user = us;
        }
        UsuariosRepository _context = new UsuariosRepository();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private bool IsValid()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Usuario es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtpass.Text != txtpassconfi.Text)
            {
                MessageBox.Show("Las contraseña no cohiciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtpass.Text == string.Empty || txtpassconfi.Text == string.Empty)
            {
                MessageBox.Show("Las contraseña son requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (TiposUsuario.Text == string.Empty || TiposUsuario.Text == "Seleccionar...")
            {
                MessageBox.Show("Se debe seleccionar Tipo de usuario es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _context.Edit(Convert.ToInt32(txtId.Text), txtNombre.Text, txtUserName.Text, txtpass.Text, TiposUsuario.Text);

                this.Close();
                MessageBox.Show("El Usuario fue editado con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.UserDataGrid.DataSource = _context.Getlist();
            }
        }
    }
}
