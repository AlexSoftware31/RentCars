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
    public class CombustibleRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("Select * from TipoCombustibles", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable GetCombustibles()
        {

            SqlCommand query = new SqlCommand("Select IdTipoCombustible, Descripcion from TipoCombustibles where Estado = 'True'", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("Select * from TipoCombustibles where Descripcion like '" + text+"%'   or IdTipoCombustible like '"+text+ "%'  ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(string Descripcion,  bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into TipoCombustibles values (@Descripcion,  @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@Descripcion", Descripcion);
                query.Parameters.AddWithValue("@Status", Status);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Edit(int Id , string Descripcion,  bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("update TipoCombustibles set Descripcion=@Descripcion, Estado= @Status where IdTipoCombustible= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Descripcion", Descripcion);
                query.Parameters.AddWithValue("@Status", Status);
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
                SqlCommand query = new SqlCommand("delete from TipoCombustibles where IdTipoCombustible = @ID", Consql);
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
