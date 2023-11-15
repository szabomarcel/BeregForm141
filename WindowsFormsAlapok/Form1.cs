using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "vesszővel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "orszagok.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Orszagoklista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Maximum_Minimum.SelectedIndex = 0;
            string kiindulasiFajl = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "orszagok.csv";
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes(kiindulasiFajl);
            }
        }

        private void Adatbetoltes(string file)
        {
            listBox_Orszagoklista.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Orszagoklista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_TeruletekAtlaga_Click(object sender, EventArgs e)
        {
            atlagszamitas();
            atlagszamitas2();
        }

        private void atlagszamitas2()
        {
            double atlag = listBox_Orszagoklista.Items.Cast<Orszag>().ToList().Average(a => a.Terulet);
        }

        private void atlagszamitas()
        {
            double atlag = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                atlag += item.Terulet;
            }
            atlag = atlag / listBox_Orszagoklista.Items.Count;
            MessageBox.Show($"Az országok átlaga: {atlag.ToString("#,##0.00")}", "Az országok átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Megszamolas_Click(object sender, EventArgs e)
        {
            if (listBox_Orszagoklista.SelectedIndex < 0)
            {
                return;
            }
            if (listBox_Orszagoklista.SelectedIndex >= 0)
            {
                Orszag kivalasztottOrszag = (Orszag)listBox_Orszagoklista.SelectedItem;
                bool nagyobbTerulet = kivalasztottOrszag.Terulet > 100000;

                MessageBox.Show($"{kivalasztottOrszag.OrszagNev} {(nagyobbTerulet ? "nagyobb" : "legfeljebb")} 100.000 területű.",
                                nagyobbTerulet ? "Nagyobb terület" : "Legfeljebb 100.000 terület",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt ország.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*f (radioButton_LegfeljebbSzazEzer.Checked)
            {
                szamolLegfeljebbSzazezer();
            }
            else
            {
                szamolSzazezerFelet();
            }*/
        }

        private void szamolSzazezerFelet()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet > 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"100.000 felet= {db}", "adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void szamolLegfeljebbSzazezer()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet<=100000)
                {
                    db++;   
                }
            }
            MessageBox.Show($"Maximum 100.000 = {db}","adatok",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_Kiiras_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "valaki valaminek a zövege|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                string eredmenyfajl = saveFileDialog.FileName;
                //textBox_EredmenyFajlNeve.Text = eredmenyfajl;
                textBox_EredmenyFajlNeve.Text = Path.GetFileName(eredmenyfajl);
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyfajl))
                    {
                        sw.WriteLine("Ez az eredmény!");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Valami nem oké!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void button_Maximum_Minimum_Valasztas_Click(object sender, EventArgs e)
        {
            //-- Listbocban vagy a legnagyobb vagy a legkisebb területű országot választja ki
            if (comboBox_Maximum_Minimum.SelectedIndex==0)
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                foreach (Orszag item in listBox_Orszagoklista.Items)
                {
                    //double kicsi = double.MaxValue;
                    if(keresettErtek > item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                    }
                }
                MessageBox.Show($"Minimum {keresettOrszag.OrszagNev} területe: {keresettOrszag.Terulet}");
            }
            else
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                foreach (Orszag item in listBox_Orszagoklista.Items)
                {
                    //double kicsi = double.MaxValue;
                    if (keresettErtek < item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                    }
                }
                MessageBox.Show($"Maximum {keresettOrszag.OrszagNev} területe: {keresettOrszag.Terulet}");
            }
        }

        private void button_Kereses_Click(object sender, EventArgs e)
        {
            int i;
            string s;
            s = "Checked items:\n";

            for (i = 0; i < listBox_Orszagoklista.Items.Count; i++)
            {
                if (listBox_Orszagoklista.SelectedIndex != (i))
                {
                    s = s + "Item " + (i + 1).ToString() + " = " + listBox_Orszagoklista.Items[i].ToString() + "\n";
                }
            }

            MessageBox.Show(s);
            //textBox_KeresettOrszag
            /*if (String.IsNullOrWhiteSpace(textBox_KeresettOrszag.Text))
            {
                listBox_Orszagoklista.SelectedIndex = 0;
            }*/
        }

        private void szinvaltoztatas(object sender, EventArgs e)
        {
            textBox_KeresettOrszag.BackColor = Color.Aqua;
        }

        private void textBox_KeresettOrszag_MouseLeave(object sender, EventArgs e)
        {
            textBox_KeresettOrszag.BackColor = DefaultBackColor;
        }
    }
}
