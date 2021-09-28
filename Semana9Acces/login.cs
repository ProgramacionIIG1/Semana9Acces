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
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Documents\\Userss.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbCommand com2 = new OleDbCommand();
        OleDbDataReader dtr;
        OleDbDataReader lector;
        bd based = new bd();
        Inicio ini = new Inicio();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Contraseña FROM Usuario WHERE Usuarios='" + textBox1.Text + "'";
            try
            {
                dtr = com.ExecuteReader();
                if (dtr.HasRows)
                {
                    while (dtr.Read())
                    {
                        if (dtr.GetValue(0).ToString() == textBox3.Text)
                        {
                            com2.Connection = con;
                            com2.CommandType = CommandType.Text;
                            com2.CommandText = "SELECT Nivel FROM Usuario WHERE Usuarios='" + textBox1.Text + "'";
                            lector = com2.ExecuteReader();
                            if (lector.HasRows)
                            {

                                while (lector.Read())
                                {
                                    try
                                    {

                                 
                                        if (lector.GetValue(0).ToString() == textBox2.Text)
                                        {

                                            switch (Convert.ToInt32(textBox2.Text))
                                            {
                                                case 1:
                                                    based.Show();
                                                    this.Close();
                                                    break;
                                                case 2:
                                                    ini.Show();
                                                    this.Close();
                                                    break;

                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("Paremetros incorrectos");
                                        }
                                    }
                                    catch (OleDbException k)
                                    {
                                        MessageBox.Show(k.ToString());
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Contrasena incorrecta");
                            }
                        }
                    }
                }
            }

            catch (OleDbException k)
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
