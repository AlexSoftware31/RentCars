using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar_Proyect_.UsuarioForms
{
    public partial class EditEmpleadoForm : Form
    {
        EmpleadoForm empleado;
        public EditEmpleadoForm(EmpleadoForm emple)
        {
            InitializeComponent();
            this.empleado = emple;
        }
        EmpleadoRepository _context = new EmpleadoRepository();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (PorComision.Text == string.Empty)
            {
                MessageBox.Show("El porciento por comision es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PorComision.Focus();
                return false;
            }

            if (TLaborar.Text == "Seleccionar..." || TLaborar.Text == string.Empty)
            {
                MessageBox.Show("Se debe seleccionar la tanda laborar es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (IsValidDrCedula(txtcedula.Text)) { 
                _context.Edit(Convert.ToInt32(txtId.Text), txtName.Text, txtcedula.Text, TLaborar.Text, Convert.ToInt32(PorComision.Value), dateIngreso.Value, rdstatus.Checked);

                this.Close();
                MessageBox.Show("El empleado fue editado con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empleado.EmpleaDataGrid.DataSource = _context.Getlist();
                }
                else
                {
                    MessageBox.Show("La cedula es invalida, coloque un identificacion valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcedula.Focus();
                }
            }
        }

        public static bool IsValidDrCedula(string drCedula)
        {
            // Valid format?
            if (drCedula.Equals(null))
            {
                return false;
            }
            else
            {
                drCedula = Regex.Replace(drCedula, "[^0-9]", string.Empty); // Only keep #s.
                if (drCedula.Equals(null) || !drCedula.Length.Equals(11) || long.Parse(drCedula).Equals(0))
                {
                    return false;
                }
            }

            // Validate.
            int sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                int n = ((i + 1) % 2 != 0 ? 1 : 2) * int.Parse(drCedula.Substring(i, 1));
                sum += (n <= 9 ? n : n % 10 + 1);
            }
            int dig = ((10 - sum % 10) % 10);
            return (dig.Equals(int.Parse(drCedula.Substring(10, 1))) ? true : false);
        }
    }
}
