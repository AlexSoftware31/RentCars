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
    public class ClientesRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("Select * from Clientes", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("Select * from Clientes where Nombre like '"+text+"%' or Apellido like '"+text+ "%'  or IdCliente like '"+text+ "%' or TipoPersona like '" + text + "%' ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(string Name, string  Lastname, string Numcard, string Limit, string Typeperson, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into Clientes values (@Nombre, @Apellido, @Numcard, @Limit, @Typeperson, @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Apellido", Lastname);
                query.Parameters.AddWithValue("@Numcard", Numcard);
                query.Parameters.AddWithValue("@Typeperson", Typeperson);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@Limit", Limit);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Edit(int Id , string Name, string Lastname, string Numcard, string Limit, string Typeperson, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("update  Clientes set Nombre=@Nombre, Apellido=@Apellido, NumTarjetaCR=@Numcard,LimiteCredito=@Limit, TipoPersona=@Typeperson, Estado= @Status where IdCliente= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Apellido", Lastname);
                query.Parameters.AddWithValue("@Numcard", Numcard);
                query.Parameters.AddWithValue("@Typeperson", Typeperson);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@Limit", Limit);
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

        public DataTable GetClientes()
        {

            SqlCommand query = new SqlCommand("Select IdCliente, Nombre from Clientes where Estado = 'True'", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public void Delete(int Id)
        {
            try
            {
                SqlCommand query = new SqlCommand("delete from Clientes where IdCliente = @ID", Consql);
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
