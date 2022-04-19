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
using System.Net.Mail;

namespace bmirechnerGUI
{
    public partial class Register : Form
    {
        public string vorname { get; private set; }
        public string username { get; private set; }
        public Register()
        {
            InitializeComponent();
            cbGeschlecht.SelectedIndex = 0;
        //Passwort verschlüsseln
            tbPasswort.MaxLength = 16;
            tbPasswort2.MaxLength = 16;
            tbPasswort.PasswordChar = '*';
            tbPasswort2.PasswordChar = '*';
        }
        private void btEnter_Click(object sender, EventArgs e)
        {
            //erstellen eines Ordners am Dateipfad des Programms
            string path = @"" + Environment.CurrentDirectory;
            string path_sub = Path.Combine(path, "Benutzerprofile");
            Directory.CreateDirectory(path_sub);

            string path2 = path + "/Benutzerprofile/";

            Userdaten obj = new Userdaten();
            string vorname = tbVorname.Text;
            string name = tbNachname.Text;
            string username = tbUsername.Text;
            string email = tbMail.Text;
            string password = tbPasswort.Text;
            string passwordconfirm = tbPasswort2.Text;
            string geschlecht = cbGeschlecht.Text;
            int vornameCheck, nameCheck;

            //Resetfunktion bei jedem Versuch zu registrieren
            lbError.Text = "";
            tbPasswort.BackColor = SystemColors.Window;
            tbPasswort2.BackColor = SystemColors.Window;
            tbVorname.BackColor = SystemColors.Window;
            tbNachname.BackColor = SystemColors.Window;
            tbMail.BackColor = SystemColors.Window;
            tbUsername.BackColor = SystemColors.Window;

            //StreamReader ob es den Username schon gibt
            StreamReader userproof = new StreamReader(path2 + "Usernames.txt", true);
            string text = "";
            bool usernameproof;
            while (userproof.Peek() != -1)
            {
                text = userproof.ReadLine();
                if (text == username)
                {
                    usernameproof = false;
                    userproof.Dispose();
                    userproof.Close();
                    goto Exit;
                }
            }
            usernameproof = true;
            userproof.Dispose();
            userproof.Close();
        Exit:

            //mögliche Fehlermeldungen beim Eingeben der persönlichen Daten 
            if (Int32.TryParse(vorname, out vornameCheck) || vorname == "" || vorname == " " || vorname == "  ")
            {
                tbVorname.BackColor = Color.Red;
                lbError.Text = "Bitte gib einen gültigen Vornamen ein!";
            }
            else if (Int32.TryParse(name, out nameCheck) || name == "" || name == " " || name == "  ")
            {
                tbNachname.BackColor = Color.Red;
                lbError.Text = "Bitte gib einen gültigen Nachnamen ein!";
            }
            else if (username == "" || username == " " || username == "  ")
            {
                tbUsername.BackColor = Color.Red;
                lbError.Text = "Bitte gib einen gültigen Usernamen ein!";
            }
            else if (usernameproof == false)
            {
                tbUsername.BackColor = Color.Red;
                lbError.Text = "Der Username wird bereits verwendet!";
            }
            else if (email == "" || email == " " || email == "  ")
            {
                tbMail.BackColor = Color.Red;
                lbError.Text = "Bitte gib eine gültige Email-Adresse ein!";
            }
            else if (password == "" || password == " " || password == "  ")
            {
                tbPasswort.BackColor = Color.Red;
                lbError.Text = "Bitte gib ein gültiges Passwort ein!";
            }
            else if (password == "" || password == " " || password == "  ")
            {
                tbPasswort2.BackColor = Color.Red;
                lbError.Text = "Bitte gib ein gültiges Passwort ein!";
            }
            else if (password != passwordconfirm)
            {
                tbPasswort.BackColor = Color.Red;
                tbPasswort2.BackColor = Color.Red;
                lbError.Text = "Ihre Passwörter stimmen nicht überein!";
            }
            else
            {
                StreamWriter sw01 = new StreamWriter(path2 + "Usernames.txt", true);
                sw01.WriteLine(username);
                sw01.Flush();
                sw01.Close();

                MailMessage emailtest = new MailMessage();

                emailtest.From = new MailAddress("bmirechner.register@outlook.de");

                emailtest.To.Add(email);

                emailtest.Subject = "Neue BMI - Rechner Registrierung";

                emailtest.Body = "Hallo " + vorname + " " + name + "," +"\n\nwillkommen beim BMI - Rechner von Josia und Meik!" + "\nVielen Dank für die Registrierung mit ihrem Benutzernamen: " + username + "\n\nMit freundlichen Grüßen\nIhr Serviceteam";
                SmtpClient clienttest = new SmtpClient("SMTP.office365.com", 587);
                try
                {
                    clienttest.Credentials = new System.Net.NetworkCredential("bmirechner.register@outlook.de", "Scheerle1604Mueller3007");
                    clienttest.EnableSsl = true;
                    clienttest.Send(emailtest);
                }

                catch { }

                lbError.Text = "Willkommen!";
                MessageBox.Show("Willkommen " + username);

                obj.name = vorname;
                obj.nachname = name;
                obj.username = username;
                obj.email = email;
                obj.password = password;
                obj.geschlecht = geschlecht;
                obj.save(path2 + "\\" + username + ".txt");

                //öffnen des jeweiligen Geschlechts beim BMI-Rechner
                if (geschlecht == "Männlich")
                {
                    Junge Form = new Junge(vorname, username);
                    Form.Show();
                    this.Close();
                }
                else if (geschlecht == "Weiblich")
                {
                    Mädchen Form = new Mädchen(vorname, username);
                    Form.Show();
                    this.Close();
                }
                else
                {
                    Main_Menu mainmenu = new Main_Menu();
                    mainmenu.Show();
                    this.Close();
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
                Main_Menu mainmenu = new Main_Menu();
                mainmenu.Show();
                this.Hide();
        }

        private void cbShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPW.Checked)
            {
                tbPasswort.PasswordChar = default;
                tbPasswort2.PasswordChar = default;
            }
            else
            {
                tbPasswort.PasswordChar = '*';
                tbPasswort2.PasswordChar = '*';
            }
        }
    }
}
