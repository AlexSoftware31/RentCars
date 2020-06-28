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
    public class ModeloRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("select MD.IdModelo, M.Descripcion, MD.Descripcion, MD.IdMarca, MD.Estado from Modelos MD INNER JOIN Marcas M on MD.IdMarca = M.IdMarca", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public DataTable GetModelos(int IdMarca)
        {

            SqlCommand query = new SqlCommand("Select IdModelo, Descripcion from Modelos where IdMarca=@IdMarca and Estado = 'True'", Consql);
            query.Parameters.AddWithValue("@IdMarca", IdMarca);

            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("select MD.IdModelo, M.Descripcion, MD.Descripcion, MD.IdMarca, MD.Estado from Modelos MD INNER JOIN Marcas M on MD.IdMarca = M.IdMarca where M.Descripcion like '" + text+"%'   or MD.IdModelo like '"+text+ "%' or MD.Descripcion like '" + text + "%'  ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(int IdMarca, string Descripcion,  bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into Modelos values (@IdMarca ,@Descripcion,  @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };
                query.Parameters.AddWithValue("@IdMarca", IdMarca);
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


        public void Edit(int Id, int IdMarca, string Descripcion,  bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("update  Modelos set IdMarca=@IdMarca, Descripcion=@Descripcion, Estado= @Status where IdModelo= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Descripcion", Descripcion);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@IdMarca", IdMarca);
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
                SqlCommand query = new SqlCommand("delete from Modelos where IdModelo = @ID", Consql);
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
