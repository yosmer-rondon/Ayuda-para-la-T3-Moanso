using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Ayuda_para_la_T3_Moanso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {

            dataGridView1.DataSource = logHabitacion.Instancia.ListarHabitacion();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    entHabitacion h = new entHabitacion();
                    h.Numero = int.Parse(Num_habitacion.Text.Trim());
                    h.Precio = double.Parse(Precio.Text.Trim());
                    h.Estado = Estado.Text.Trim();
                    logHabitacion.Instancia.InsertarHabitacion(h);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                listar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
