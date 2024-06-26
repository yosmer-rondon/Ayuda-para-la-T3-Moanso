using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaDatos
{
    public class datReserva
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datReserva _instancia = new datReserva();
        //privado para evitar la instanciación directa
        public static datReserva Instancia
        {
            get
            {
                return datReserva._instancia;
            }
        }
        #endregion singleton

        #region metodos


        ////////////////////listado de reservas
        public List<entReserva> ListarReserva()
        {
            SqlCommand cmd = null;
            List<entReserva> lista = new List<entReserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReserva Cli = new entReserva();
                    Cli.IDReserva = Convert.ToInt32(dr["IDReserva"]);
                    Cli.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Cli.Costo = Convert.ToDouble(dr["Costo"]);
                    Cli.Estado = Convert.ToString(dr["Estado"]);
                    Cli.IDCliente = Convert.ToInt32(dr["IDCliente"]);
                    Cli.Numero = Convert.ToInt32(dr["Numero"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////Insertando Habitacion
        public Boolean InsertarReserva(entReserva Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", Cli.Fecha);
                cmd.Parameters.AddWithValue("@Costo", Cli.Costo);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
                cmd.Parameters.AddWithValue("@IDCliente", Cli.IDCliente);
                cmd.Parameters.AddWithValue("@Numero", Cli.Numero);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

         #endregion metodos
    }
}
