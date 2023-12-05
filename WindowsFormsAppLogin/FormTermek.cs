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
    public partial class FormTermek : Form
    {
        string mod = null;
        //int termekid = 0;
        Termek kivalasztotTermek = null;
        public FormTermek(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void FormTermek_Load(object sender, EventArgs e)
        {
            if (Program.formVasarlas.listBoxTermek.SelectedItem > 0)
            {
                kivalasztotTermek = (Termek)Program.listBoxTermek.SelectedItem;
            }
            switch (mod)
            {
                case "új":
                    this.Text = "Új termék hozzáadása";
                    //button_muvelet.Text = "Új termék felvétele!";
                    adatokBetolteseMezokben();
                    break;
                case "mosítás":
                    this.Text = "A termék modósítása";
                    //button_muvelet.Text = "A termék modósítása!";
                    adatokBetolteseMezokben();
                    break;
                case "törlés":
                    this.Text = "A termék törlése";
                    //button_muvelet.Text = "A termék törlése!";
                    adatokBetolteseMezokben();
                    break;
                default:
                    break;
            }
        }

        private void adatokBetolteseMezokben()
        {
            textBox_id.Text = kivalasztotTermek.termek_id.ToString();
            textBox_nev.Text = kivalasztotTermek.termek_nev.ToString();
            numericUpDown_ar.Value = kivalasztotTermek.ar;
            numericUpDown_db.Value = kivalasztotTermek.db;
        }
    }
}
