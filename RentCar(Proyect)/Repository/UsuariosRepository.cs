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
    public class UsuariosRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("Select * from Usuarios", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("Select * from Usuarios where Nombre like '"+text+"%' or Usuario like '"+text+ "%'  or IdUsuario like '"+text+"%' ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(string Name, string User, string Pass, string TipoUser)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into Usuarios values (@Nombre, @Usuario, @Pass, @TipoUser)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Usuario", User);
                query.Parameters.AddWithValue("@Pass", Pass);
                query.Parameters.AddWithValue("@TipoUser", TipoUser);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Edit(int Id , string Name, string User, string Pass, string TipoUser)
        {
            try
            {
                SqlCommand query = new SqlCommand("update  Usuarios set Nombre=@Nombre, Usuario=@Usuario, Passw=@Pass,TipoUsuario=@TipoUser where IdUsuario= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Nombre", Name);
                query.Parameters.AddWithValue("@Usuario", User);
                query.Parameters.AddWithValue("@Pass", Pass);
                query.Parameters.AddWithValue("@TipoUser", TipoUser);
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
                SqlCommand query = new SqlCommand("delete from Usuarios where IdUsuario = @ID", Consql);
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
