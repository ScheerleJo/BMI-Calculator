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
    public partial class Ladebalken : Form
    {
        public Ladebalken()
        {
            InitializeComponent();
        }

        public int b = 1;

        private void Ladebalken_Load(object sender, EventArgs e)
        {
            timeNo1.Start();

            timeNo2.Start();
        }

        private void timeNo1_Tick(object sender, EventArgs e)
        {
            Random randobj = new Random();
            int a = randobj.Next(1, 5);

            if (progbar1.Value == 1000)
            {
                timeNo1.Stop();

                Ladebalken.ActiveForm.Hide();

                Main_Menu mainobj = new Main_Menu();

                mainobj.Show();
            }
            else if (progbar1.Value <= 1000)
            {
                progbar1.Value = progbar1.Value + 20;

                if (a == 1)
                {
                    timeNo1.Interval = 100;
                }
                else if (a == 2)
                {
                    timeNo1.Interval = 50;
                }
                else if (a == 3)
                {
                    timeNo1.Interval = 10;
                }
                else if (a == 4)
                {
                    timeNo1.Interval = 5;
                }
            }
        }

        private void timeNo2_Tick(object sender, EventArgs e)
        {
            if (b == 1)
            {
                lbStatus.Text = "Dateien werden geladen .";
                b = b + 1;
            }
            else if (b == 2)
            {
                lbStatus.Text = "Dateien werden geladen . .";
                b = b + 1;
            }
            else if (b == 3)
            {
                lbStatus.Text = "Dateien werden geladen . . .";
                b = b + 1;
            }
            else if (b == 4)
            {
                lbStatus.Text = "Dateien werden geladen . . . .";
                b = 1;
            }
        }
    }
}
