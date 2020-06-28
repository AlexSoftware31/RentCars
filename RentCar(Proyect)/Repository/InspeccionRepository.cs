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
    public class InspeccionRepository
    {
       

       
        SqlConnection Consql = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);

        public DataTable Getlist()
        {

            SqlCommand query = new SqlCommand("select I.IdInspeccion, V.Descripcion, C.Nombre, I.TieneCerradura, I.CantCombustible, I.TieneGomaRepuesta, I.TieneGato, I.TieneRoturaCristal, I.EstadoGomaDelanteraIzq, I.EstadoGomaDelanteraDer, I.EstadoGomaTraseraIzq, I.EstadoGomaTraseraDer, I.Fecha, I.EstadoPintura ,E.Nombre, I.Estado  FROM Inspeccion I INNER JOIN RentasDesvolucion R on I.IdRenta = R.IdRenta INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente", Consql);
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

            SqlCommand query = new SqlCommand("select I.IdInspeccion, V.Descripcion, C.Nombre, I.TieneCerradura, I.CantCombustible, I.TieneGomaRepuesta, I.TieneGato, I.TieneRoturaCristal, I.EstadoGomaDelanteraIzq, I.EstadoGomaDelanteraDer, I.EstadoGomaTraseraIzq, I.EstadoGomaTraseraDer, I.Fecha, I.EstadoPintura ,E.Nombre, I.Estado  FROM Inspeccion I INNER JOIN RentasDesvolucion R on I.IdRenta = R.IdRenta INNER  JOIN Empleados E on R.IdEmpleado = E.IdEmpleado INNER JOIN Vehiculos V on  R.IdVehiculo = V.IdVehiculo INNER JOIN Clientes C on R.IdCliente = C.IdCliente where V.Descripcion like '" + text+ "%'   or  C.Nombre like '" + text+ "%' or E.Nombre like '" + text + "%'  ", Consql);
            
            DataTable dt = new DataTable();

            Consql.Open();
            SqlDataReader sdr = query.ExecuteReader();
            dt.Load(sdr);
            Consql.Close();



            return dt;
        }

        public void Create(int IdRenta, int IdVehiculo, int IdCliente, int IdEmpleado, bool Cerradura, string CantidadCombustible,bool GomaResp, bool TGato, bool cristalroto, bool gomadelaizq, bool gomadelDr, bool gomatraIzq, bool gomatraDdr, DateTime Fecha, bool pintura)
        {
            try
            {
                bool Status = true;
                SqlCommand query = new SqlCommand("insert into Inspeccion values (@IdRenta, @IdVehiculo,@IdCliente,@IdEmpleado, @Cerradura,@CantidadCombus,@Gomarespuesta,@TGato,@Cristalroto,@GomaDelanteraIzq,@GomadelanteraDR,@GomaTransceraIzq,@GomaTransceraDr,@Fecha,@Pintura,@Status)", Consql)
                {
                    CommandType = CommandType.Text
                };
                query.Parameters.AddWithValue("@IdRenta", IdRenta);
                query.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
                query.Parameters.AddWithValue("@IdCliente", IdCliente);
                query.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                query.Parameters.AddWithValue("@Cerradura", Cerradura);
                query.Parameters.AddWithValue("@CantidadCombus", CantidadCombustible);
                query.Parameters.AddWithValue("@Gomarespuesta", GomaResp);
                query.Parameters.AddWithValue("@TGato", TGato);
                query.Parameters.AddWithValue("@Cristalroto", cristalroto);
                query.Parameters.AddWithValue("@GomaDelanteraIzq", gomadelaizq);
                query.Parameters.AddWithValue("@GomadelanteraDR", gomadelDr);
                query.Parameters.AddWithValue("@GomaTransceraIzq", gomatraIzq);
                query.Parameters.AddWithValue("@GomaTransceraDr", gomatraDdr);
                query.Parameters.AddWithValue("@Fecha", Fecha);
                query.Parameters.AddWithValue("@Pintura", pintura);
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
                SqlCommand query = new SqlCommand("delete from Inspeccion where IdInspeccion = @ID", Consql);
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
