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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void BtLogIn_Click(object sender, EventArgs e)
        {
            string path = @"" + Environment.CurrentDirectory; 
            string path2 = path + "/Benutzerprofile/Usernames.txt";
            if (File.Exists(path2))
            {
                LogIn login = new LogIn();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Es ist niemand registriert!", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtRegister_Click(object sender, EventArgs e)
        {

            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Um letzte Ergebnisse zu speichern musst du dich registrieren", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gast guest = new Gast();
            guest.Show();
            this.Hide();            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}