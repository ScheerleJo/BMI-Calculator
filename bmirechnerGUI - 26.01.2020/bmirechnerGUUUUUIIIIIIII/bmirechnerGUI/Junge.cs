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
        Utility obj = new Utility();
        Bmi bmiclass = new Bmi();
        string prename;
        string username;
        string password, email, name, gender;
        double data1, data2, data3, data4, data5;
        string date1 = "", date2 = "", date3 = "", date4 = "", date5 = "";

        public Junge(string vorname1, string username1)
        {
            InitializeComponent();
            cbKnochen.SelectedIndex = 0;
            prename = vorname1;
            username = username1;
            obj.setUsername(username);
            Userdaten load = new Userdaten();
            load = load.load(obj.getPath() + "\\" + username + ".txt");
            password = load.password;
            email = load.email;
            name = load.nachname;
            gender = load.geschlecht;
            if (load.daten1 != "")
            {
                date1 = load.date1;
                data1 = Convert.ToDouble(load.daten1);
                chartBmi.Series["BMI"].Points.AddXY(date1, data1);
            }
            if (load.daten2 != "")
            {
                date2 = load.date2;
                data2 = Convert.ToDouble(load.daten2);
                chartBmi.Series["BMI"].Points.AddXY(date2, data2);
            }
            if (load.daten3 != "")
            {
                date3 = load.date3;
                data3 = Convert.ToDouble(load.daten3);
                chartBmi.Series["BMI"].Points.AddXY(date3, data3);
            }
            if (load.daten4 != "")
            {
                date4 = load.date4;
                data4 = Convert.ToDouble(load.daten4);
                chartBmi.Series["BMI"].Points.AddXY(date4, data4);
            }
            if (load.daten5 != "")
            {
                date5 = load.date5;
                data5 = Convert.ToDouble(load.daten5);
                chartBmi.Series["BMI"].Points.AddXY(date5, data5);
            }
        }

        private void btBerechnen_Click(object sender, EventArgs e)
        {
            int ageproof;
            double sizeproof, weightproof;
            
            lbError.Text = "";
            tbAlter.BackColor = SystemColors.Window;
            tbGroesse.BackColor = SystemColors.Window;
            tbGewicht.BackColor = SystemColors.Window;
            if (!Double.TryParse(tbGroesse.Text, out sizeproof) || tbGroesse.Text == "" || tbGroesse.Text == " " || tbGroesse.Text == "  ")
            {
                tbGroesse.BackColor = Color.Red;
                lbError.Text = "Bitte gib deine Größe an";
            }
            else if (sizeproof < 100 && sizeproof > 220)
            {
                tbGroesse.BackColor = Color.Red;
                lbError.Text = "Bitte gib deine Richtige Größe an";
            }
            else if (!Double.TryParse(tbGewicht.Text, out weightproof) || tbGewicht.Text == "" || tbGewicht.Text == " " || tbGewicht.Text == "  ")
            {
                tbGewicht.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Gewicht an";
            }
            else if (weightproof < 30 && weightproof > 200)
            {
                tbGewicht.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Richtiges Gewicht an";
            }
            else if (!Int32.TryParse(tbAlter.Text, out ageproof) || tbAlter.Text == "" || tbAlter.Text == " " || tbAlter.Text == "  ")
            {
                tbAlter.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Alter ein";
            }
            else if (ageproof > 110)
            {
                tbAlter.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Richtiges alter ein";
            }
            else
            {
                string comment = "";
                int alter = Convert.ToInt32(tbAlter.Text);
                double gewicht = Convert.ToDouble(tbGewicht.Text);
                double genderfactor = 1;
                double idealgewicht, bmi, abweichung; double groesse = Convert.ToDouble(tbGroesse.Text) / 100;

                bmiclass.setAlter(alter);
                bmiclass.setGewicht(gewicht);
                bmiclass.setGroesse(groesse);
                bmiclass.setGeschlecht(genderfactor);
                bmiclass.setKnochen(cbKnochen.SelectedIndex);
                abweichung = bmiclass.errechneAbweichung();
                idealgewicht = bmiclass.errechneIdealgewicht();
                bmi = bmiclass.errechneBmi();

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
                rtbAusgabe.Text = "Hallo " + prename + ", deine Auswertung:\n\nBMI:\t\t" + bmi.ToString("0.00") + "\nIdealgewicht:\t" + idealgewicht.ToString("0.00") + "\nAbweichung:\t" + abweichung.ToString("0.00") + "%\nKommentar:\t" + comment;
                
                if(data1.ToString() == "" || (data1.ToString() != "" && data5.ToString() != "" && data1 != data5 && Convert.ToDouble(date1) < Convert.ToDouble(date2)))
                {
                    date1 = obj.nowDate();
                    data1 = bmi;
                    chartBmi.Series["BMI"].Points.AddXY(date1, data1);
                }
                else if(data2.ToString() == "" || data2.ToString() != "" && data1.ToString() != "" && data2 != data1 && Convert.ToDouble(date2) < Convert.ToDouble(date3))
                {
                    date2 = obj.nowDate();
                    data2 = bmi;
                    chartBmi.Series["BMI"].Points.AddXY(date2, data2);
                }
                else if(data3.ToString() == "" || data3.ToString() != "" && data2.ToString() != "" && data3 != data2 && Convert.ToDouble(date3) < Convert.ToDouble(date4))
                {
                    date3 = obj.nowDate();
                    data3 = bmi;
                    chartBmi.Series["BMI"].Points.AddXY(date3, data3);
                }
                else if (data4.ToString() == "" || data4.ToString() != "" && data3.ToString() != "" && data4 != data3 && Convert.ToDouble(date3) < Convert.ToDouble(date4))
                {
                    date4 = obj.nowDate();
                    data4 = bmi;
                    chartBmi.Series["BMI"].Points.AddXY(date4, data4);
                }
                else
                {
                    date5 = obj.nowDate();
                    data5 = bmi;
                    chartBmi.Series["BMI"].Points.AddXY(date5, data5);
                }

                //Abspeichern der neuen Userdaten
                Userdaten save = new Userdaten();
                save.name = prename;
                save.nachname = name;
                save.username = username;
                save.email = email;
                save.password = password;
                save.geschlecht = "Männlich";
                save.date1 = date1;
                save.date2 = date1;
                save.date3 = date1;
                save.date4 = date1;
                save.date5 = date1; 
                save.daten1 = data1.ToString();
                save.daten2 = data1.ToString();
                save.daten3 = data1.ToString();
                save.daten4 = data1.ToString();
                save.daten5 = data1.ToString();
                save.save(obj.getPathUsername());
                MessageBox.Show(obj.getPathUsername());
            }
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