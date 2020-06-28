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
    public class VehiculoRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("Select V.IdVehiculo, V.Descripcion, V.NumChasis,V.NumMotor,V.NumPlaca, TV.Descripcion, M.Descripcion, MD.Descripcion,V.Color, V.Yearr, V.TipoTransmision, TC.Descripcion, V.Estado, V.IdMarca, V.IdModelo, V.IdTipoVehiculo, V.IdTipoCombustible from Vehiculos V INNER JOIN TipoVehiculos TV on V.IdTipoVehiculo = TV.IdTipoVehiculo INNER JOIN Marcas M on V.IdMarca = M.IdMarca INNER JOIN Modelos MD on V.IdModelo = MD.IdModelo INNER JOIN TipoCombustibles TC on V.IdTipoCombustible = TC.IdTipoCombustible", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable Search(string text)
        {

            SqlCommand query = new SqlCommand("Select V.IdVehiculo, V.Descripcion, V.NumChasis,V.NumMotor,V.NumPlaca, TV.Descripcion, M.Descripcion, MD.Descripcion,V.Color, V.Yearr, V.TipoTransmision, TC.Descripcion, V.Estado, V.IdMarca, V.IdModelo, V.IdTipoVehiculo, V.IdTipoCombustible from Vehiculos V INNER JOIN TipoVehiculos TV on V.IdTipoVehiculo = TV.IdTipoVehiculo INNER JOIN Marcas M on V.IdMarca = M.IdMarca INNER JOIN Modelos MD on V.IdModelo = MD.IdModelo INNER JOIN TipoCombustibles TC on V.IdTipoCombustible = TC.IdTipoCombustible where V.IdVehiculo like '" + text+"%' or V.Descripcion like '"+text+ "%'  or V.NumPlaca like '"+text+ "%' or TV.Descripcion like '" + text + "%'or M.Descripcion like '" + text + "%' or MD.Descripcion like '" + text + "%' or V.Yearr like '" + text + "%' ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public DataTable GetVehiculos()
        {

            SqlCommand query = new SqlCommand("Select IdVehiculo, Descripcion from Vehiculos where Estado = 'True'", Consql);
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }
        public void Create(string Descripcion, string  NumChasis, string NumMotor, string NumPlaca, int IdTipoVehiculo, int IdMarca, int IdModelo, string Color, string year, string TipoTransmision, int IdTipoCombustible, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("insert into Vehiculos values (@Descripcion, @NumChasis, @NumMotor, @NumPlaca, @IdTipoVehiculo,@IdMarca,@IdModelo,@Color,@Year,@TipoTrans,@IdCombustible, @Status)", Consql)
                {
                    CommandType = CommandType.Text
                };

                query.Parameters.AddWithValue("@Descripcion", Descripcion);
                query.Parameters.AddWithValue("@NumChasis", NumChasis);
                query.Parameters.AddWithValue("@NumMotor", NumMotor);
                query.Parameters.AddWithValue("@NumPlaca", NumPlaca);
                query.Parameters.AddWithValue("@IdTipoVehiculo", IdTipoVehiculo);
                query.Parameters.AddWithValue("@IdMarca", IdMarca);
                query.Parameters.AddWithValue("@IdModelo", IdModelo);
                query.Parameters.AddWithValue("@Color", Color);
                query.Parameters.AddWithValue("@Year", year);
                query.Parameters.AddWithValue("@TipoTrans", TipoTransmision);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@IdCombustible", IdTipoCombustible);

                Consql.Open();
                query.ExecuteNonQuery();
                Consql.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Edit(int Id , string Descripcion, string NumChasis, string NumMotor, string NumPlaca, int IdTipoVehiculo, int IdMarca, int IdModelo, string Color, string year, string TipoTransmision, int IdTipoCombustible, bool Status)
        {
            try
            {
                SqlCommand query = new SqlCommand("update  Vehiculos set Descripcion=@Descripcion, NumChasis=@NumChasis, NumMotor=@NumMotor,NumPlaca=@NumPlaca, IdTipoVehiculo=@IdTipoVehiculo,IdMarca=@IdMarca,IdModelo=@IdModelo,Color=@Color,Yearr=@Year,TipoTransmision=@TipoTrans,IdTipoCombustible=@IdCombustible, Estado=@Status where IdVehiculo= @ID", Consql);
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@Descripcion", Descripcion);
                query.Parameters.AddWithValue("@NumChasis", NumChasis);
                query.Parameters.AddWithValue("@NumMotor", NumMotor);
                query.Parameters.AddWithValue("@NumPlaca", NumPlaca);
                query.Parameters.AddWithValue("@IdTipoVehiculo", IdTipoVehiculo);
                query.Parameters.AddWithValue("@IdMarca", IdMarca);
                query.Parameters.AddWithValue("@IdModelo", IdModelo);
                query.Parameters.AddWithValue("@Color", Color);
                query.Parameters.AddWithValue("@Year", year);
                query.Parameters.AddWithValue("@TipoTrans", TipoTransmision);
                query.Parameters.AddWithValue("@Status", Status);
                query.Parameters.AddWithValue("@IdCombustible", IdTipoCombustible);
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
                SqlCommand query = new SqlCommand("delete from Vehiculos where IdVehiculo = @ID", Consql);
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
