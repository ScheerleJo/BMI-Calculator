using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmirechnerGUI
{
    public partial class Gast : Form
    {
        public Gast()
        {
            InitializeComponent();
            cbGeschlecht.SelectedIndex = 0;
            cbKnochen.SelectedIndex = 0;
        }

        private void btBerechne_Click(object sender, EventArgs e)
        {
            string comment = "";
            int alter = Convert.ToInt32(tbAlter.Text);
            double geschlecht;
            double idealgewicht, bmi, abweichung;
            double groesse = Convert.ToDouble(tbGroesse.Text) / 100;
            double gewicht = Convert.ToDouble(tbGewicht.Text);

            Bmi obj = new Bmi();

            switch (cbGeschlecht.SelectedIndex)
            {
                case 0: geschlecht = 1; break;
                case 1: geschlecht = 0.95; break;
                default: geschlecht = 1; break;
            }
            obj.setAlter(alter);
            obj.setGewicht(gewicht);
            obj.setGroesse(groesse);
            obj.setGeschlecht(geschlecht);
            obj.setKnochen(cbKnochen.SelectedIndex);
            abweichung = obj.errechneAbweichung();

            idealgewicht = obj.errechneIdealgewicht();
            bmi = obj.errechneBmi();

            if (abweichung < 10 && abweichung > -10)
            {
                comment = "Idealgewicht";
            }
            else if (abweichung >= 10 && abweichung < 30)
            {
                comment = "Leichtes Übergewicht";
            }
            else if (abweichung >= 30)
            {
                comment = "Starkes Übergewicht";
            }
            else if (abweichung <= -10 && abweichung > -30)
            {
                comment = "Leichtes Untergewicht";
            }
            else if (abweichung <= -30)
            {
                comment = "Starkes Untergewicht";
            }
            rtbAusgabe.Text = "Hallo " + tbName.Text + ", deine Auswertung:\n\nBMI:\t\t" + bmi.ToString("0.00") + "\nIdealgewicht:\t" + idealgewicht.ToString("0.00") + "\nAbweichung:\t" + abweichung.ToString("0.00") + "%\nKommentar:\t" + comment;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Register guest = new Register();
            guest.Show();
            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Main_Menu guest = new Main_Menu();
            guest.Show();
            this.Hide();
        }

        private void CbGeschlecht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGeschlecht.Text == "Männlich")
            {
                pbMan.Visible = true;
                pbWomen.Visible = false;
            }
            else if(cbGeschlecht.Text == "Weiblich")
            {
                pbMan.Visible = false;
                pbWomen.Visible = true;
            }
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}