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
        private void listBox_Termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTermekek.SelectedIndex < 0)
            {
                return;
            }
            Termek kivalasztottTermek = (Termek)listBoxTermekek.SelectedItem;
            textBox_azonosito.Text = kivalasztottTermek.termekid.ToString();
            textBox_termeknev.Text = kivalasztottTermek.termeknev;
            numericUpDown_ar.Value = kivalasztottTermek.ar;
            numericUpDown_raktarKeszlet.Value = kivalasztottTermek.db;
        }

        /*private void button_termek_Click(object sender, EventArgs e)
        {
            listBox_Termek.Items.Clear();
            Program.command.CommandText = "SELECT `termek_id`,`termek_nev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termek_nev";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //listBox_Termek.Items.Add(new Termek(dr.GetInt32("termek_id"), dr.GetString("termek_nev"), dr.GetInt32("ar"), dr.GetInt32("db")));
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/

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
            saveFileDialog.Filter = "valaki valaminek a szövege|*.txt";
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

        /*private void button_kilepes_Click(object sender, EventArgs e)
        {

        }*/

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban ki akar lépni?", "kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //System.Windows.Forms.Application.Exit();                
                System.Windows.Forms.Application.ExitThread();
            }
            else
            {
                //e.Cancel = true;
            }
        }
    }
}
