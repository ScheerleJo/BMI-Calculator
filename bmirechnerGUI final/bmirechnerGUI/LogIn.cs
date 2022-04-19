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

namespace bmirechnerGUI
{
    public partial class LogIn : Form
    {
        public string vorname { get; private set; }
        public string username { get; private set;}
        public LogIn()
        {
            InitializeComponent();
            tbPasswort.PasswordChar = '*';
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            tbUsername.BackColor = SystemColors.Window;
            tbPasswort.BackColor = SystemColors.Window;

            Userdaten save = new Userdaten();
            string vorname = save.name;
            string path = @"" + Environment.CurrentDirectory;
            string path2 = path + "/Benutzerprofile/";
            string username = tbUsername.Text;
            string password = tbPasswort.Text;
            string geschlecht;
            string text;



            StreamReader sr02 = new StreamReader(path2 + "Usernames.txt");
            if (username == "" | username == " " | username == "  ")
            {                
                tbUsername.BackColor = Color.Red;
                lbError.Text = "Bitte gib deinen Benutzername ein!";
            }
            else if (password == "" | password == " " | password == "  ")
            {
                tbPasswort.BackColor = Color.Red;
                lbError.Text = "Bitte gib dein Passwort ein";
            }
            else
            {
                while (sr02.Peek() != -1)
                {
                    text = sr02.ReadLine();
                    if (text == username)
                    {
                        save = save.load(path2 + username + ".txt");

                        if (password == save.password)
                        {
                            geschlecht = save.geschlecht;
                            lbError.Text = "Herzlich Willkommen " + username + "!";
                            MessageBox.Show("Willkommen!");

                            if (geschlecht == "Männlich")
                            {
                                Junge maennlich = new Junge(vorname, username);
                                maennlich.Show();
                                this.Close();
                            }
                            else
                            {
                                Mädchen weiblich = new Mädchen(vorname, username);
                                weiblich.Show();
                                this.Close();
                            }

                            goto Exit;
                        }
                        else
                        {
                            lbError.Text = "Das eingegebene Passwort ist falsch!";
                        }
                    }
                    else
                    {
                        lbError.Text = "Der Benutzername ist nicht vorhanden!";
                    }
                }                

            Exit:
                sr02.Dispose();
                sr02.Close();                
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Main_Menu mainmenu = new Main_Menu();
            mainmenu.Show();
            this.Close();
        }

        private void CbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                tbPasswort.PasswordChar = default;
            }
            else
            {
                tbPasswort.PasswordChar = '*';
            }
        }

        private void btPwvergessen_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            int usernamecheck;

            if(username == "" | username == " " | username == "  " | Int32.TryParse(username, out usernamecheck))
            {
                lbError.Text = "Bitte gib deinen Benutzernamen ein!";
                tbUsername.BackColor = Color.Red;
            }
            else
            {
                string path = @"" + Environment.CurrentDirectory;
                string path2 = path + "/Benutzerprofile/";
                string text;
                bool usernameproof;

                StreamReader usernamechecki = new StreamReader(path2 + "Usernames.txt", true);
                while (usernamechecki.Peek() != -1)
                {
                    text = usernamechecki.ReadLine();
                    if (text == username)
                    {
                        usernameproof = true;
                        usernamechecki.Dispose();
                        usernamechecki.Close();
                        goto Exit;
                    }
                }
                usernameproof = false;
                usernamechecki.Dispose();
                usernamechecki.Close();
            Exit:
                if(usernameproof == true)
                {
                    Passwortvergessen pwvergessenform = new Passwortvergessen(username);
                    pwvergessenform.Show();
                    this.Close();
                }
                else
                {
                    lbError.Text = "Der Benutzername ist nicht vergeben";
                }
            }
            

            
        }
    }
}
