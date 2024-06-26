using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace Ayuda_para_la_T3_Moanso
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listar();
        }
        public void listar() {

            dataGridView1.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
