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

namespace Ayuda_para_la_T3_Moanso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            string servidor = comboBox2.Text;
            string baseDatos = comboBox1.Text;
            CapaDatos.Conexion.Instancia.ser = servidor;
            CapaDatos.Conexion.Instancia.bd = baseDatos;
            label3.Text = "se conecto correctamente";
        }
    }
}
