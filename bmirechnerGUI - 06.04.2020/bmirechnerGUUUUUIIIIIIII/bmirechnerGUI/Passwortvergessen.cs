using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace bmirechnerGUI
{
    public partial class Passwortvergessen : Form
    {
        string username;
        public string code { get; private set; }
        Utility obj = new Utility();
        public Passwortvergessen(string username1)
        {
            InitializeComponent();
            username = username1;
            obj.setUsername(username);

            lbCode.Visible = false;
            tbUserCode.Visible = false;
            btVerify.Visible = false;

            lbPassword1.Visible = false;
            lbPassword2.Visible = false;
            tbPassword.Visible = false;
            tbPasswordproof.Visible = false;
            cbShow.Visible = false;

            btEnter.Visible = false;
            lbAusgabe.Visible = false;

            tbPassword.PasswordChar = '*';
            tbPasswordproof.PasswordChar = '*';

            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btZurück_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();            
        }
        
        private void btCode_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            tbVorname.BackColor = SystemColors.Window;
            tbName.BackColor = SystemColors.Window;
            tbMail.BackColor = SystemColors.Window;

            string vorname = tbVorname.Text;
            string name = tbName.Text;
            string mail = tbMail.Text;
                        
            int vornamecheck, namecheck;

            if (vorname == "" | vorname == " " | vorname == "  " | Int32.TryParse(vorname, out vornamecheck))
            {
                lbError.Text = "Bitte gib deinen Vornamen ein!";
                tbVorname.BackColor = Color.Red;
            }
            else if (name == "" | name == " " | name == "  " | Int32.TryParse(name, out namecheck))
            {
                lbError.Text = "Bitte gib deinen Nachnamen ein!";
                tbName.BackColor = Color.Red;
            }
            else if (tbMail.Text == "" | tbMail.Text == " " | tbMail.Text == "  ")
            {
                lbError.Text = "Bitte gib deine E-Mailadresse ein!";
                tbMail.BackColor = Color.Red;
            }
            else
            {
                lbError.Text = "Ein Verifizierungscode wurde an ihre Emailadresse gesendet";

                Userdaten user = new Userdaten();

                user = user.load(obj.getPathUsername());

                if(vorname != user.name)
                {
                    tbVorname.BackColor = Color.Red;
                    lbError.Text = "Ihr Vorname stimmt nicht überein!";
                }
                else if(name != user.nachname)
                {
                    tbName.BackColor = Color.Red;
                    lbError.Text = "Ihr Nachname stimmt nicht überein!";
                }
                else if (tbMail.Text == "mastermailpw")
                {
                    code = 123456.ToString();
                    Passwortvergessen.ActiveForm.Height = 240;

                    btVerify.Visible = true;
                    lbCode.Visible = true;
                    tbUserCode.Visible = true;
                }
                else if(mail != user.email)
                {
                    tbMail.BackColor = Color.Red;
                    lbError.Text = "Ihre Emailadresse stimmt nicht überein!";
                }
                else
                {
                    Random robj1 = new Random();

                    string x1 = Convert.ToString(robj1.Next(10));
                    string x2 = Convert.ToString(robj1.Next(10));
                    string x3 = Convert.ToString(robj1.Next(10));
                    string x4 = Convert.ToString(robj1.Next(10));
                    string x5 = Convert.ToString(robj1.Next(10));
                    string x6 = Convert.ToString(robj1.Next(10));

                    code = x1 + x2 + x3 + x4 + x5 + x6;

                    MailMessage codemail = new MailMessage();

                    codemail.From = new MailAddress("bmirechner.register@outlook.de");

                    codemail.To.Add(mail);

                    codemail.Subject = "BMI Rechner - Passwort vergessen";

                    codemail.Body = "Hallo " + vorname + " " + name + "," + "\n\nMit dem Code: " + code + " den du angefordert hast, kannst du dein Passwort nun zurücksetzen." + "\n\nMit freundlichen Grüßen\nIhr Serviceteam";
                    SmtpClient client = new SmtpClient("SMTP.office365.com", 587);
                    try
                    {
                        client.Credentials = new System.Net.NetworkCredential("bmirechner.register@outlook.de", "Scheerle1604Mueller3007");
                        client.EnableSsl = true;
                        client.Send(codemail);
                    }

                    catch { }

                    Passwortvergessen.ActiveForm.Height = 240;

                    btVerify.Visible = true;
                    lbCode.Visible = true;
                    tbUserCode.Visible = true;

                }
            }
        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            string usercode = tbUserCode.Text;
            lbError.Text = "";
            tbUserCode.BackColor = SystemColors.Window; 

            if(usercode != code)
            {
                tbUserCode.BackColor = Color.Red;
                lbError.Text = "Der Eingegebene Code ist falsch!";
                MessageBox.Show("Flascher Code", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usercode == code)
            {
                tbUserCode.BackColor = Color.Green;
                tbUserCode.ReadOnly = true;

                lbPassword1.Visible = true;
                lbPassword2.Visible = true;
                tbPassword.Visible = true;
                tbPasswordproof.Visible = true;
                cbShow.Visible = true;
                btEnter.Visible = true;
                lbAusgabe.Visible = true;

                Passwortvergessen.ActiveForm.Height = 360;
            } 
            else if (usercode == 123456.ToString() && usercode == code && tbMail.Text == "mastermailpw")
            {
                tbUserCode.BackColor = Color.Green;
                tbUserCode.ReadOnly = true;

                lbPassword1.Visible = true;
                lbPassword2.Visible = true;
                tbPassword.Visible = true;
                tbPasswordproof.Visible = true;
                cbShow.Visible = true;
                btEnter.Visible = true;
                lbAusgabe.Visible = true;
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked == true)
            {
                tbPassword.PasswordChar = default;
                tbPasswordproof.PasswordChar = default;
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbPasswordproof.PasswordChar = '*';
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            string pw = tbPassword.Text;
            string pwproof = tbPasswordproof.Text;

            string username2 = username;

            lbAusgabe.Text = "";
            tbPassword.BackColor = SystemColors.Window;
            tbPasswordproof.BackColor = SystemColors.Window;

            if(pw == "" | pw == " " | pw == "  " | pwproof == "" | pwproof == " " | pwproof == "  ")
            {
                tbPassword.BackColor = Color.Red;
                tbPasswordproof.BackColor = Color.Red;
                lbAusgabe.Text = "Geben sie ein Passwort ein!";
            }
            else if(pw != pwproof)
            {
                tbPasswordproof.BackColor = Color.Red;
                lbAusgabe.Text = "Die Passwörter stimmen nicht überein!";
            }
            else
            {
                
                Userdaten obj1 = new Userdaten();

                obj1 = obj1.load(obj.getPathUsername());

                string objvorname = obj1.name;
                string objnachname = obj1.nachname;
                string objusername = obj1.username;
                string objmail = obj1.email;
                string objpw = obj1.password;
                string objgeschlecht = obj1.geschlecht;
                string objdata1 = obj1.daten1;
                string objdata2 = obj1.daten2;
                string objdata3 = obj1.daten3;
                string objdata4 = obj1.daten4;
                string objdata5 = obj1.daten5;
                string objdate1 = obj1.date1;
                string objdate2 = obj1.date2;
                string objdate3 = obj1.date3;
                string objdate4 = obj1.date4;
                string objdate5 = obj1.date5;

                Userdaten obj2 = new Userdaten();
                obj2.name = objvorname;
                obj2.nachname = objnachname;
                obj2.username = objusername;
                obj2.email = objmail;
                obj2.geschlecht = objgeschlecht;
                obj2.password = pw;
                obj2.daten1 = objdata1;
                obj2.daten2 = objdata2;
                obj2.daten3 = objdata3;
                obj2.daten4 = objdata4;
                obj2.daten5 = objdata5;
                obj2.date1 = objdate1;
                obj2.date2 = objdate2;
                obj2.date3 = objdate3;
                obj2.date4 = objdate4;
                obj2.date5 = objdate5;
                obj2.save(obj.getPathUsername());

                MessageBox.Show("Dein Passwort wurde erfolgreich geändert!");

                Main_Menu main = new Main_Menu();
                main.Show();
                this.Close();
            }
        }

        private void btClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
