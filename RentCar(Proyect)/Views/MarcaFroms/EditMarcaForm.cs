﻿using System;
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
    public partial class EditMarcaForm : Form
    {
        MarcaForm marca;
        public EditMarcaForm(MarcaForm marc)
        {
            InitializeComponent();
            this.marca = marc;
        }
        MarcaRepository _context = new MarcaRepository();


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool IsValid()
        {
            if (txtdescripcion.Text == string.Empty)
            {
                MessageBox.Show("Descripcion es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescripcion.Focus();
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
                _context.Edit(Convert.ToInt32(txtId.Text), txtdescripcion.Text,  rdstatus.Checked);

                this.Close();
                MessageBox.Show("La marca fue editada con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                marca.MarcaDataGrid.DataSource = _context.Getlist();
            }
        }
    }
}
