using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppLogin
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "vasarlas";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }

        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed) 
            {

            }
        }

        private void nyit()
        {
            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Termek> getTermekek() 
        {
            List<Termek> termekek = new List<Termek>();
            command.CommandText =
            using (MySqlDateReader dr = command.)
            {
                termekek.Add(new Termek(dr.GetId32()))
            }
            return termekek;
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
            }
            zar();
            return userid;
        }
        public bool vasarlas(int termekId, int darab)
        {
            bool siker = false;
            MySql
        }
    }
}
