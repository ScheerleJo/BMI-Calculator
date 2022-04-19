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
        string path;
        string password, email, name, gender, data1, data2, data3, data4, data5;
        public Junge(string vorname1, string username1)
        {
            InitializeComponent();
            cbKnochen.SelectedIndex = 0;
            prename = vorname1;
            username = username1;
            path = @"" + Environment.CurrentDirectory + "/Benutzerprofile/" + username + ".txt";
            Userdaten load = new Userdaten();
            load = load.load(path);
            password = load.password;
            email = load.email;
            name = load.nachname;
            gender = load.geschlecht;
            data1 = load.daten1;
            data2 = load.daten2;
            data3 = load.daten3;
            data4 = load.daten4;
            data5 = load.daten5;
            
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

           /* if()
            {
                data1 = bmi.ToString("0.00");
            }
            else if()
            {
                data2 = bmi.ToString("0.00");
            }
            else if()
            {
                data3 = bmi.ToString("0.00");
            }
            else if()
            {
                data4 = bmi.ToString("0.00");
            }
            else if()
            {
                data5 = bmi.ToString("0.00");
            }
            MessageBox.Show(data1 + "\n" + data2 + "\n" + data3 + "\n" + data4 + "\n" + data5);*/
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

        public void Junge_Load(object sender, EventArgs e)
        {
            Userdaten save = new Userdaten();
            save.daten1 = data1;
            save.daten2 = data2;
            save.daten3 = data3;
            save.daten4 = data4;
            save.daten5 = data5;
            save.name = prename;
            save.nachname = name;
            save.username = username;
            save.email = email;
            save.password = password;
            save.geschlecht = gender;
            save.save(path);
        }
    }
}
/*         
 *                     if (data1 == "" && bmi.ToString("0.00") != data5 && data1 != "" && data5 !="")
            {
                data1 = bmi.ToString("0.00");
            }
            else if (data2 == "" && bmi.ToString("0.00") != data1)
            {
                data2 = bmi.ToString("0.00");
            }
            else if (data3 == "" && bmi.ToString("0.00") != data2)
            {
                data3 = bmi.ToString("0.00");
            }
            else if(data4 == "" && bmi.ToString("0.00") != data3)
            {
                data4 = bmi.ToString("0.00");
            }
            else if(data5 == "" && bmi.ToString("0.00") != data4)
            {
                data5 = bmi.ToString("0.00");
            }
 *         
 *         
 *         
 *         
 *         
 *         
 *         
 *         
 *         
 *         
 *         lbError.Text = "";
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
