using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReserva
    {
        public int IDReserva { get; set; }
        public DateTime Fecha { get; set; }
        public double Costo { get; set; }
        public string Estado { get; set; }
        public int IDCliente { get; set; }
        public int Numero { get; set; }
        public int IDhabitacion { get; set; }
    }
}
