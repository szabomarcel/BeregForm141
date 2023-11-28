using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppLogin
{
    public partial class FormVasarlas : Form
    {
        public FormVasarlas()
        {
            InitializeComponent();
        }

        private void button_termek_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT termek.termek_nev FROM termek WHERE termek.termek_nev=@termek_nev");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox_Termek.Text = dr[0].ToString(); // [0] for <column_1>
            }
            /*Program.command.CommandText = "SELECT termek.termek_nev FROM termek WHERE termek.termek_nev=@termek_nev";
            Program.command.Parameters.AddWithValue("@termek_nev", listBox_Termek.Text);
            Program.command.Parameters.Clear();*/
        }

        private void button_ujrendeles_Click(object sender, EventArgs e)
        {
            FormVasarlas newForm = new FormVasarlas();
            listBox_Termek.Items.Clear();
            // Az új űrlap megjelenítése
            newForm.Show();
        }

        private void button_Megvasarlas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "valaki valaminek a zövege|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";
            if (listBox_Termek.SelectedIndex != -1)
            {
                string selectedProduct = listBox_Termek.SelectedItem.ToString();
                listBox_Termek.Items.Remove(selectedProduct);
            }
            else
            {
                MessageBox.Show("Válasszon ki egy terméket a vásárláshoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
