using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana9Acces
{
    public partial class bd : Form
    {
        public bd()
        {
            InitializeComponent();
        }

        private void bd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'userssDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.userssDataSet.Usuario);

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.UpdateQuery(txtUsuario.Text, txtContraseña.Text, Convert.ToInt32(txtNivel), Convert.ToInt32(txtID));
            this.usuarioTableAdapter.Fill(this.userssDataSet.Usuario);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.DeleteQuery(Convert.ToInt32(txtID.Text));
            this.usuarioTableAdapter.Fill(this.userssDataSet.Usuario);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.usuarioTableAdapter.Insertardatos(Convert.ToInt32(txtID.Text),txtUsuario.Text,txtContraseña.Text,Convert.ToInt32(txtNivel.Text));
            this.usuarioTableAdapter.Fill(this.userssDataSet.Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
