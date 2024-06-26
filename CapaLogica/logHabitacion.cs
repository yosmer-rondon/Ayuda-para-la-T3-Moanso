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
        private static readonly logHabitacion _instancia = new logHabitacion();
        //privado para evitar la instanciación directa
        public static logHabitacion Instancia
        {
            get
            {
                return logHabitacion._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entHabitacion> ListarHabitacion()
        {
            return datHabitacion.Instancia.ListarHabitacion();
        }

        #endregion metodos
    }
}
