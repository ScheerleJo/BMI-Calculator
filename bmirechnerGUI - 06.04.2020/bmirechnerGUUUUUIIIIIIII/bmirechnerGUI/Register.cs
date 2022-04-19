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
        Utility obj = new Utility();
        Userdaten obj1 = new Userdaten();
        public Register()
        {
            InitializeComponent();
            cbGeschlecht.SelectedIndex = 0;
            tbPasswort.MaxLength = 16;
            tbPasswort2.MaxLength = 16;
            tbPasswort.PasswordChar = '*';
            tbPasswort2.PasswordChar = '*';

            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            
            //Überprüfen ob es den Ordner Benutzerprofile bereits gibt
            Utility obj = new Utility();
            if (!File.Exists(obj.getPath()))
            {
                //erstellen eines Ordners am Dateipfad des Programms
                Directory.CreateDirectory(Path.Combine(@"" + Environment.CurrentDirectory, "Benutzerprofile"));
            } 
        }
        private void btEnter_Click(object sender, EventArgs e)
        {
            //erstellen von strings für die Überprüfungen
            string prename = tbVorname.Text;
            string name = tbNachname.Text;
            string username = tbUsername.Text;
            string email = tbMail.Text;
            string password = tbPasswort.Text;
            string passwordconfirm = tbPasswort2.Text;
            string gender = cbGeschlecht.Text;
            int prenameCheck, nameCheck;
            bool usernameproof;

            //Resetfunktion bei jedem Versuch zu registrieren
            lbError.Text = "";
            tbPasswort.BackColor = SystemColors.Window;
            tbPasswort2.BackColor = SystemColors.Window;
            tbVorname.BackColor = SystemColors.Window;
            tbNachname.BackColor = SystemColors.Window;
            tbMail.BackColor = SystemColors.Window;
            tbUsername.BackColor = SystemColors.Window;

            //Überprüfen ob es den Username schon gibt
            if (!File.Exists(obj.getPathUsername()))
            {
                usernameproof = true;
            }
            else
            {
                usernameproof = false;
            }
            
            //mögliche Fehlermeldungen beim Eingeben der persönlichen Daten 
            if (Int32.TryParse(prename, out prenameCheck) || prename == "" || prename == " " || prename == "  ")
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
                MessageBox.Show("Willkommen " + username, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                obj1.name = prename;
                obj1.nachname = name;
                obj1.username = username;
                obj1.email = email;
                obj1.password = password;
                obj1.geschlecht = gender;
                obj1.date1 = "";
                obj1.date2 = "";
                obj1.date3 = "";
                obj1.date4 = "";
                obj1.date5 = "";
                obj1.daten1 = "";
                obj1.daten2 = "";
                obj1.daten3 = "";
                obj1.daten4 = "";
                obj1.daten5 = "";
                obj1.save(obj.getPathUsername());

                //öffnen des jeweiligen Geschlechts beim BMI-Rechner
                if (gender == "Männlich")
                {
                    Junge Form = new Junge(username);
                    Form.Show();
                    this.Close();
                }
                else if (gender == "Weiblich")
                {
                    Mädchen Form = new Mädchen(username);
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
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
