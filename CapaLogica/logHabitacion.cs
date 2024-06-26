﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logHabitacion _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        #endregion metodos
    }
}