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
    public class RentasDesvRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("select R.IdRenta, E.Nombre, V.Descripcion, C.Nombre, R.FechaRenta, R.FechaDesvolucion, R.MontoxDias, R.CantidadDias, R.Comentario, R.Estado, R.IdEmpleado, R.IdVehiculo, R.IdCliente from RentasDesvolucion R INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("select R.IdRenta, E.Nombre, V.Descripcion, C.Nombre, R.FechaRenta, R.FechaDesvolucion, R.MontoxDias, R.CantidadDias, R.Comentario, R.Estado, R.IdEmpleado, R.IdVehiculo, R.IdCliente from RentasDesvolucion R INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente where E.Nombre like '" + text+"%' or V.Descripcion like '"+text+ "%'  or C.Nombre like '"+text+ "%' or R.IdRenta like '" + text + "%'or R.MontoxDias like '" + text + "%'or R.CantidadDias like '" + text + "%' ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public DataTable SearchByFechaRenta(string date)
        {
            string date1 = "2020-06-28";
            SqlCommand query = new SqlCommand("select R.IdRenta, E.Nombre, V.Descripcion, C.Nombre, R.FechaRenta, R.FechaDesvolucion, R.MontoxDias, R.CantidadDias, R.Comentario, R.Estado, R.IdEmpleado, R.IdVehiculo, R.IdCliente from RentasDesvolucion R INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente where R.FechaRenta  between '" + date+ "' and  '" + date1 + "' ", Consql);

            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable SearchByFechaDevolucion(string date)
        {
            string date1 = "2020-07-31";
            SqlCommand query = new SqlCommand("select R.IdRenta, E.Nombre, V.Descripcion, C.Nombre, R.FechaRenta, R.FechaDesvolucion, R.MontoxDias, R.CantidadDias, R.Comentario, R.Estado, R.IdEmpleado, R.IdVehiculo, R.IdCliente from RentasDesvolucion R INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente where R.FechaDesvolucion  between '" + date + "' and  '" + date1 + "' ", Consql);

            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(int IdEmpleado, int IdVehiculo, int IdCliente, DateTime Fecharenta, DateTime FechaDesvolucion,  string MontoxDias, string CantidasDias, string comentario)
        {
            try
            {
                bool Status = true;
                SqlCommand query = new SqlCommand("insert into RentasDesvolucion values (@IdEmpledo, @IdVehiculo,@IdCliente, @FechaRenta, @FechaDesv,@MontoxDias,@CantidadDias,@Comentario, @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@IdEmpledo", IdEmpleado);
                query.Parameters.AddWithValue("@IdCliente", IdCliente);
                query.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
                query.Parameters.AddWithValue("@FechaRenta", Fecharenta);
                query.Parameters.AddWithValue("@FechaDesv", FechaDesvolucion);
                query.Parameters.AddWithValue("@MontoxDias", MontoxDias);
                query.Parameters.AddWithValue("@CantidadDias", CantidasDias);
                query.Parameters.AddWithValue("@Comentario", comentario);
                query.Parameters.AddWithValue("@Status", Status);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();


                bool StatusV = false;
                SqlCommand query2 = new SqlCommand("update  Vehiculos set Estado=@Status  where IdVehiculo= @ID", Consql);
                query2.CommandType = CommandType.Text;
                query2.Parameters.AddWithValue("@ID", IdVehiculo);
                query2.Parameters.AddWithValue("@Status", StatusV);


                Consql.Open();
                query2.ExecuteNonQuery();
                Consql.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Desvolucion(int Id , int IdVehiculo)
        {
            try
            {
                bool Status = false;
                SqlCommand query = new SqlCommand("update RentasDesvolucion  set  Estado=@Status where IdRenta=@ID", Consql);
                query.CommandType = CommandType.Text;
                
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@ID", Id);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();

                bool StatusV = true;
                SqlCommand query2 = new SqlCommand("update  Vehiculos set Estado=@Status  where IdVehiculo= @ID", Consql);
                query2.CommandType = CommandType.Text;
                query2.Parameters.AddWithValue("@ID", IdVehiculo);
                query2.Parameters.AddWithValue("@Status", StatusV);

         
                Consql.Open();
                query2.ExecuteNonQuery();
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
                SqlCommand query = new SqlCommand("delete from RentasDesvolucion where IdRenta = @ID", Consql);
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
