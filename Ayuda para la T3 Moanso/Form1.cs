using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;
using CapaEntidad;

namespace Ayuda_para_la_T3_Moanso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenarComboBoxHabitaciones();

        }
        public void listar()
        {

            dataGridView1.DataSource = logReserva.Instancia.ListarReserva();
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            string servidor = comboBox2.Text;
            string baseDatos = comboBox1.Text;
            CapaDatos.Conexion.Instancia.ser = servidor;
            CapaDatos.Conexion.Instancia.bd = baseDatos;
        }

        private void moveramancli_Click(object sender, EventArgs e)
        {
            Form3  fora = new Form3();
            fora.Show();
        }

        private void moveramanhabi_Click(object sender, EventArgs e)
        {
            Form2 foras = new Form2();
            foras.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    entReserva r = new entReserva();
                    r.Fecha = Convert.ToDateTime(dateTimePicker1.Value);
                    r.Costo = Convert.ToDouble(textBox2.Text.Trim());
                    r.Estado = textBox3.Text.Trim();
                    r.IDCliente = Convert.ToInt32(textBox4.Text.Trim());
                    r.Numero = Convert.ToInt32(comboBox3.Text.Trim());
                    logReserva.Instancia.InsertarReserva(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                listar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LlenarComboBoxHabitaciones()
        {
            try
            {
                List<entHabitacion> listaHabitaciones = logHabitacion.Instancia.ObtenerNumerosHabitacion();

                comboBox3.Items.Clear(); // Limpiar los ítems existentes

                foreach (var habitacion in listaHabitaciones)
                {
                    comboBox3.Items.Add(habitacion.Numero.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }
    }
}
