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

using Microsoft.Office.Interop.Excel;

namespace RentCar_Proyect_
{
    public partial class RentasDesvForm : Form
    {
        public RentasDesvForm()
        {
            InitializeComponent();
        }
        RentasDesvRepository _context = new RentasDesvRepository();
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
            RentaDesvDataGrid.DataSource = _context.Getlist();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateRentDesvForm Create = new CreateRentDesvForm(this);

            Create.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (RentaDesvDataGrid.SelectedRows.Count > 0)
            {
                _context.Desvolucion(Convert.ToInt32(RentaDesvDataGrid.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(RentaDesvDataGrid.CurrentRow.Cells[11].Value.ToString()));

                MessageBox.Show("Desvolucion con exito", "Desvolucion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RentaDesvDataGrid.DataSource = _context.Getlist();
               
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la renta que desea realizar la desvolucion", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            RentaDesvDataGrid.Rows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RentaDesvDataGrid.SelectedRows.Count > 0)
            {
                Id = Convert.ToInt32(RentaDesvDataGrid.CurrentRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta renta?", "Eliminar", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    _context.Delete(Id);

                    MessageBox.Show("La renta fue eliminado con exito!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    RentaDesvDataGrid.DataSource = _context.Getlist();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la renta que quiere eliminar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            RentaDesvDataGrid.DataSource = _context.Search(txtsearch.Text);
        }


        private void RentasDesvForm_Load(object sender, EventArgs e)
        {
            RentaDesvDataGrid.DataSource = _context.Getlist();

            RentaDesvDataGrid.Columns[0].HeaderText = "Codigo";
            RentaDesvDataGrid.Columns[1].HeaderText = "Empleado";
            RentaDesvDataGrid.Columns[2].HeaderText = "Vehiculo";
            RentaDesvDataGrid.Columns[3].HeaderText = "Cliente";
            RentaDesvDataGrid.Columns[4].HeaderText = "Fecha Renta";
            RentaDesvDataGrid.Columns[5].HeaderText = "Fecha Desvolucion";
            RentaDesvDataGrid.Columns[10].Visible = false;
            RentaDesvDataGrid.Columns[11].Visible = false;
            RentaDesvDataGrid.Columns[12].Visible = false;
            FechaRenta.Format = DateTimePickerFormat.Custom;
            FechaRenta.CustomFormat = "yyyy-MM-dd";

            FechaDesvolucion.Format = DateTimePickerFormat.Custom;
            FechaDesvolucion.CustomFormat = "yyyy-MM-dd";
        }

        private void FechaRenta_ValueChanged(object sender, EventArgs e)
        {
            RentaDesvDataGrid.DataSource = _context.SearchByFechaRenta(FechaRenta.Text);
        }

        private void FechaDesvolucion_ValueChanged(object sender, EventArgs e)
        {
            RentaDesvDataGrid.DataSource = _context.SearchByFechaDevolucion(FechaDesvolucion.Text);
        }

        
        public void Exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Exportaraexcel(RentaDesvDataGrid);
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            if (RentaDesvDataGrid.SelectedRows.Count > 0)
            {
                CreateInspeccionForm inspeccion = new CreateInspeccionForm(this);

                inspeccion.Idrenta.Text = RentaDesvDataGrid.CurrentRow.Cells[0].Value.ToString();
                inspeccion.IdCliente.Text = RentaDesvDataGrid.CurrentRow.Cells[12].Value.ToString();
                inspeccion.Idvehiculo.Text = RentaDesvDataGrid.CurrentRow.Cells[11].Value.ToString();
                inspeccion.Show();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la renta que quiere inspeccionar", "Seleccionar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
