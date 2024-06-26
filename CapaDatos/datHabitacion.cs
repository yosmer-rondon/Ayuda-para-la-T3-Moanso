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
    public class datHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datHabitacion _instancia = new datHabitacion();
        //privado para evitar la instanciación directa
        public static datHabitacion Instancia
        {
            get
            {
                return datHabitacion._instancia;
            }
        }
        #endregion singleton

        #region metodos


        ////////////////////listado de habitaciones
        public List<entHabitacion> ListarHabitacion()
        {
            SqlCommand cmd = null;
            List<entHabitacion> lista = new List<entHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitacion Cli = new entHabitacion();
                    Cli.IDHabitacion = Convert.ToInt32(dr["IDHabitacion"]);
                    Cli.Numero = Convert.ToInt32(dr["Numero"]);
                    Cli.Precio = Convert.ToDouble(dr["Precio"]); 
                    Cli.Estado = Convert.ToString(dr["Estado"]); ; 
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
        #endregion metodos
    }
}
