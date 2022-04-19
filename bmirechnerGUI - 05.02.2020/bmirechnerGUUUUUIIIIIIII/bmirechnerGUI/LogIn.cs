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
        public string username { get; private set;}
        Utility obj = new Utility();
        public LogIn()
        {
            InitializeComponent();
            tbPasswort.PasswordChar = '*'; 

            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            tbUsername.BackColor = SystemColors.Window;
            tbPasswort.BackColor = SystemColors.Window;

            Userdaten save = new Userdaten();
            string vorname = save.name;
            string username = tbUsername.Text;
            string password = tbPasswort.Text;
            string geschlecht;
            string text;
            obj.setUsername(username);

            StreamReader sr02 = new StreamReader(obj.getPath2());
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
                        save = save.load(obj.getPathUsername());

                        if (password == save.password)
                        {
                            tbPasswort.BackColor = SystemColors.Window;
                            tbUsername.BackColor = SystemColors.Window;

                            geschlecht = save.geschlecht;
                            lbError.Text = "Herzlich Willkommen " + username + "!";
                            MessageBox.Show("Willkommen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                            

                            if (geschlecht == "Männlich")
                            {
                                Junge maennlich = new Junge(username);
                                maennlich.Show();
                                this.Close();
                            }
                            else
                            {
                                Mädchen weiblich = new Mädchen(username);
                                weiblich.Show();
                                this.Close();
                            }
                            goto Exit;
                        }
                        else
                        {
                            tbPasswort.BackColor = Color.Red;
                            lbError.Text = "Das eingegebene Passwort ist falsch!";
                            goto Exit;
                        }
                    }
                    else
                    {
                        tbUsername.BackColor = Color.Red;
                        lbError.Text = "Der Benutzername ist nicht vorhanden!";
                    }
                }                     
            }
        Exit:
            sr02.Dispose();
            sr02.Close();
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
                string text;
                bool usernameproof;

                StreamReader usernamechecki = new StreamReader(obj.getPath2(), true);
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

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
