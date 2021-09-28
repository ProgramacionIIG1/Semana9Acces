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
//Julissa Odaly Sosa Flores
//Erick Mauricio Tiznado Rodriguez
//Franklin Stanley Larin Saravia 
//Oscar Manuel López Velasquez

namespace Semana9Acces
{
    public partial class login : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\sistema\\Sistema.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dtr;
        bd based = new bd();

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT clave FROM tusuario WHERE nombre='"+ textBox1.Text + "'";
            try
            {
                dtr = com.ExecuteReader();
                if (dtr.HasRows)
                {
                    while(dtr.Read())
                        {
                        if(dtr.GetValue(0).ToString()== textBox3.Text)
                        {
                            based.Show();
                        }
                        else 
                        {
                            MessageBox.Show("Contrasena incorrecta");
                        }
                    }
                }
            }
            catch(OleDbException k)
            {
                MessageBox.Show(k.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
            }
            catch (OleDbException k)
            {
                MessageBox.Show(k.ToString());
            }
        }

    }
}
