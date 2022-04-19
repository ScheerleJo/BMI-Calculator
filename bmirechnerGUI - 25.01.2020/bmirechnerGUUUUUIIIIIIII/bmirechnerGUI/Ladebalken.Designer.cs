namespace bmirechnerGUI
{
    partial class Ladebalken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progbar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.timeNo1 = new System.Windows.Forms.Timer(this.components);
            this.timeNo2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progbar1
            // 
            this.progbar1.Location = new System.Drawing.Point(13, 13);
            this.progbar1.Maximum = 1000;
            this.progbar1.Name = "progbar1";
            this.progbar1.Size = new System.Drawing.Size(466, 36);
            this.progbar1.Step = 1;
            this.progbar1.TabIndex = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbStatus.Location = new System.Drawing.Point(22, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(12, 15);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = " ";
            // 
            // timeNo1
            // 
            this.timeNo1.Tick += new System.EventHandler(this.timeNo1_Tick);
            // 
            // timeNo2
            // 
            this.timeNo2.Enabled = true;
            this.timeNo2.Interval = 500;
            this.timeNo2.Tick += new System.EventHandler(this.timeNo2_Tick);
            // 
            // Ladebalken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 64);
            this.ControlBox = false;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.progbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ladebalken";
            this.Text = "Ladebalken";
            this.Load += new System.EventHandler(this.Ladebalken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progbar1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Timer timeNo1;
        private System.Windows.Forms.Timer timeNo2;
    }
}