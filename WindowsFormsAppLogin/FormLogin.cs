using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool valid = false;
            command.CommandText = "SELECT vasarlo.jelszo FROM vasarlo WHERE vasarlo.nev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read()) 
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(textBox_jelszo.Text))
                {
                    this.Hide();
                    Program.formVasarlas.Show();
                }
                else
                {
                    MessageBox.Show("Nem jó");
                }
            }
        }
        public bool validUser(string name, string pass)
        {
            int userid = -1;
            command.CommandText = "SELECT vasarlo.jelszo FROM vasarlo WHERE vasarlo.nev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                Program.UserId = reader.GetInt32("vasarlo");
                zar();
            }
            return userid;
        }
    }
}
