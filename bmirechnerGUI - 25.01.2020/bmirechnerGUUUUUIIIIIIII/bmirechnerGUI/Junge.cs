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
    public partial class Junge : Form
    {
        string prename;
        string username;
        public Junge(string vorname1, string username1)
        {
            InitializeComponent();
            cbKnochen.SelectedIndex = 0;
            prename = vorname1;
            username = username1;
        }

        private void btBerechnen_Click(object sender, EventArgs e)
        {
            string comment = "";
            int alter = Convert.ToInt32(tbAlter.Text);
            double geschlecht = 1;
            double idealgewicht, bmi, abweichung;
            double groesse = Convert.ToDouble(tbGroesse.Text) / 100;
            double gewicht = Convert.ToDouble(tbGewicht.Text);

            Bmi obj = new Bmi();
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
            else if(abweichung >= 10 && abweichung < 30)
            {
                comment = "Leichtes Übergewicht";
            }
            else if (abweichung >= 30 )
            { 
                comment = "Starkes Übergewicht";
            }
            else if(abweichung <= -10 && abweichung > -30)
            {
                comment = "Leichtes Untergewicht";
            }
            else if (abweichung <= -30)
            {
                comment = "Starkes Untergewicht";
            }
            rtbAusgabe.Text = "Hallo " + prename + ", deine Auswertung:\n\nBMI:\t\t" + bmi.ToString("0.00") + "\nIdealgewicht:\t" + idealgewicht.ToString("0.00") + "\nAbweichung:\t" + abweichung.ToString("0.00") + "%\nKommentar:\t" + comment;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
             Main_Menu mainmenu = new Main_Menu();
             mainmenu.Show();
             this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
/*          lbError.Text = "";
            tbAlter.BackColor = SystemColors.Window;
            tbGroesse.BackColor = SystemColors.Window;
            if (!Int32.TryParse(tbAlter.Text, out alter) || tbAlter.Text == "" || tbAlter.Text == " " || tbAlter.Text == "  ")
            {
                tbAlter.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Alter ein";
            }
            else if(alter > 110)
            {
                tbAlter.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Richtiges alter ein";
            }
            else if(!Double.TryParse(tbGroesse.Text, out groesse) || tbGroesse.Text =="" || tbGroesse.Text == " " || tbGroesse.Text == "  ")
            {
                tbGroesse.BackColor = Color.Red;
                lbError.Text = "Bitte gib deine Größe an";
            }
            else if(groesse < 100 && groesse > 220)
            {
                tbGroesse.BackColor = Color.Red;
                lbError.Text = "Bitte gib deine Richtige Größe an";
            }
            else if(!Double.TryParse(tbGewicht.Text, out gewicht) || tbGewicht.Text =="" || tbGewicht.Text == " " || tbGewicht.Text == "  ")
            {
                tbGewicht.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Gewicht an";
            }
            else if(gewicht < 30 && gewicht > 200)
            {
                tbGewicht.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Richtiges Gewicht an";
            }
*/
