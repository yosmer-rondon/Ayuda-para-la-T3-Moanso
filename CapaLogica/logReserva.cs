using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logReserva
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logReserva _instancia = new logReserva();
        //privado para evitar la instanciación directa
        public static logReserva Instancia
        {
            get
            {
                return logReserva._instancia;
            }
        }

        public void InsertarReserva(entReserva Cli)
        {
            datReserva.Instancia.InsertarReserva(Cli);
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entReserva> ListarReserva()
        {
            return datReserva.Instancia.ListarReserva();
        }

        #endregion metodos
    }
}
