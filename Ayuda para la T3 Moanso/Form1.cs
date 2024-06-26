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
            listar();
        }
        public void listar()
        {

            dataGridView1.DataSource = logr;
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

        }
    }
}
