using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RentCar_Proyect_
{
    public class EmpleadoRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("Select * from Empleados", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("Select * from Empleados where Nombre like '" + text+"%' or Cedula like '"+text+ "%'  or IdEmpleado like '"+text+ "%' or TandaLabor like '" + text + "%' or PorcientoComision like '" + text + "%' ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(string Name, string  Cedula, string TLabor, int XComision, DateTime FechaIngreso, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into Empleados values (@Nombre, @Cedula, @Tanda, @Comision, @FechaI, @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Cedula", Cedula);
                query.Parameters.AddWithValue("@Tanda", TLabor);
                query.Parameters.AddWithValue("@Comision", XComision);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@FechaI", FechaIngreso);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetEmpleados()
        {

            SqlCommand query = new SqlCommand("Select IdEmpleado, Nombre from Empleados where Estado = 'True'", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Edit(int Id , string Name, string Cedula, string TLabor, int XComision, DateTime FechaIngreso, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("update  Empleados set Nombre=@Nombre, Cedula=@Cedula, TandaLabor=@Tanda, PorcientoComision=@Comision, FechaIngreso=@FechaI, Estado= @Status where IdEmpleado= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Cedula", Cedula);
                query.Parameters.AddWithValue("@Tanda", TLabor);
                query.Parameters.AddWithValue("@Comision", XComision);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@FechaI", FechaIngreso);
                query.Parameters.AddWithValue("@ID", Id);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Delete(int Id)
        {
            try
            {
                SqlCommand query = new SqlCommand("delete from Empleados where IdEmpleado = @ID", Consql);
                query.CommandType = CommandType.Text;

                query.Parameters.AddWithValue("@ID", Id);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();

            }
            catch
            {

            }
        }
    }
}
