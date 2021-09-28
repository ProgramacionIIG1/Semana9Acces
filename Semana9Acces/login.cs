using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



//Nathaly Milena Zelaya Caballero

namespace Semana9Acces
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Documents\\Usuario.accdb");
            try
            {
                con.Open();
                MessageBox.Show("La conexion fue exitosa");
            }
            catch (OleDbException ex )
            {
                MessageBox.Show("Error en la conexion", ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
