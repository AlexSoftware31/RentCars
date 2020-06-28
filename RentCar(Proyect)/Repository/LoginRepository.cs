using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace RentCar_Proyect_
{
    public class LoginRepository
    {

        
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public void Loguear(string usuario, string pass)
        {
            try
            {
                Consql.Open();
                SqlCommand query = new SqlCommand("select Nombre, TipoUsuario from Usuarios WHERE Usuario= @Usuario and Passw= @Pass", Consql);
                query.Parameters.AddWithValue("@Usuario", usuario);
                query.Parameters.AddWithValue("@Pass", pass);

                SqlDataAdapter sda = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    new Login().Hide();

                    if (dt.Rows[0][1].ToString() == "Admin" ) 
                    {
                        
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "User")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Consql.Close();
            }
        }
    }
}
