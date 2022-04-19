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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ladebalken));
            this.progbar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.timeNo1 = new System.Windows.Forms.Timer(this.components);
            this.timeNo2 = new System.Windows.Forms.Timer(this.components);
            this.pbCross3 = new System.Windows.Forms.PictureBox();
            this.lbCheck3 = new System.Windows.Forms.Label();
            this.pbCross1 = new System.Windows.Forms.PictureBox();
            this.lbCheck1 = new System.Windows.Forms.Label();
            this.pbCross2 = new System.Windows.Forms.PictureBox();
            this.lbCheck2 = new System.Windows.Forms.Label();
            this.pnCheck1 = new System.Windows.Forms.Panel();
            this.pbCheck1 = new System.Windows.Forms.PictureBox();
            this.pnCheck2 = new System.Windows.Forms.Panel();
            this.pbCheck2 = new System.Windows.Forms.PictureBox();
            this.pnCheck3 = new System.Windows.Forms.Panel();
            this.pbCheck3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross2)).BeginInit();
            this.pnCheck1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck1)).BeginInit();
            this.pnCheck2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck2)).BeginInit();
            this.pnCheck3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck3)).BeginInit();
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
            // pbCross3
            // 
            this.pbCross3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCross3.BackgroundImage")));
            this.pbCross3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCross3.Location = new System.Drawing.Point(11, 11);
            this.pbCross3.Name = "pbCross3";
            this.pbCross3.Size = new System.Drawing.Size(55, 50);
            this.pbCross3.TabIndex = 2;
            this.pbCross3.TabStop = false;
            // 
            // lbCheck3
            // 
            this.lbCheck3.AutoSize = true;
            this.lbCheck3.Location = new System.Drawing.Point(72, 48);
            this.lbCheck3.Name = "lbCheck3";
            this.lbCheck3.Size = new System.Drawing.Size(98, 13);
            this.lbCheck3.TabIndex = 3;
            this.lbCheck3.Text = "Programm geladen!";
            // 
            // pbCross1
            // 
            this.pbCross1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCross1.BackgroundImage")));
            this.pbCross1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCross1.Location = new System.Drawing.Point(12, 12);
            this.pbCross1.Name = "pbCross1";
            this.pbCross1.Size = new System.Drawing.Size(55, 50);
            this.pbCross1.TabIndex = 4;
            this.pbCross1.TabStop = false;
            // 
            // lbCheck1
            // 
            this.lbCheck1.AutoSize = true;
            this.lbCheck1.Location = new System.Drawing.Point(73, 49);
            this.lbCheck1.Name = "lbCheck1";
            this.lbCheck1.Size = new System.Drawing.Size(93, 13);
            this.lbCheck1.TabIndex = 5;
            this.lbCheck1.Text = "Benutzer geladen!";
            // 
            // pbCross2
            // 
            this.pbCross2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCross2.BackgroundImage")));
            this.pbCross2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCross2.Location = new System.Drawing.Point(12, 12);
            this.pbCross2.Name = "pbCross2";
            this.pbCross2.Size = new System.Drawing.Size(55, 50);
            this.pbCross2.TabIndex = 6;
            this.pbCross2.TabStop = false;
            // 
            // lbCheck2
            // 
            this.lbCheck2.AutoSize = true;
            this.lbCheck2.Location = new System.Drawing.Point(71, 49);
            this.lbCheck2.Name = "lbCheck2";
            this.lbCheck2.Size = new System.Drawing.Size(126, 13);
            this.lbCheck2.TabIndex = 7;
            this.lbCheck2.Text = "Passwörter verschlüsselt!";
            // 
            // pnCheck1
            // 
            this.pnCheck1.BackColor = System.Drawing.Color.White;
            this.pnCheck1.Controls.Add(this.pbCheck1);
            this.pnCheck1.Controls.Add(this.pbCross1);
            this.pnCheck1.Controls.Add(this.lbCheck1);
            this.pnCheck1.Location = new System.Drawing.Point(13, 55);
            this.pnCheck1.Name = "pnCheck1";
            this.pnCheck1.Size = new System.Drawing.Size(200, 72);
            this.pnCheck1.TabIndex = 8;
            // 
            // pbCheck1
            // 
            this.pbCheck1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCheck1.BackgroundImage")));
            this.pbCheck1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCheck1.Location = new System.Drawing.Point(12, 12);
            this.pbCheck1.Name = "pbCheck1";
            this.pbCheck1.Size = new System.Drawing.Size(55, 50);
            this.pbCheck1.TabIndex = 6;
            this.pbCheck1.TabStop = false;
            // 
            // pnCheck2
            // 
            this.pnCheck2.BackColor = System.Drawing.Color.White;
            this.pnCheck2.Controls.Add(this.pbCheck2);
            this.pnCheck2.Controls.Add(this.pbCross2);
            this.pnCheck2.Controls.Add(this.lbCheck2);
            this.pnCheck2.Location = new System.Drawing.Point(279, 55);
            this.pnCheck2.Name = "pnCheck2";
            this.pnCheck2.Size = new System.Drawing.Size(200, 72);
            this.pnCheck2.TabIndex = 9;
            // 
            // pbCheck2
            // 
            this.pbCheck2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCheck2.BackgroundImage")));
            this.pbCheck2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCheck2.Location = new System.Drawing.Point(12, 12);
            this.pbCheck2.Name = "pbCheck2";
            this.pbCheck2.Size = new System.Drawing.Size(55, 50);
            this.pbCheck2.TabIndex = 8;
            this.pbCheck2.TabStop = false;
            // 
            // pnCheck3
            // 
            this.pnCheck3.BackColor = System.Drawing.Color.White;
            this.pnCheck3.Controls.Add(this.pbCheck3);
            this.pnCheck3.Controls.Add(this.lbCheck3);
            this.pnCheck3.Controls.Add(this.pbCross3);
            this.pnCheck3.Location = new System.Drawing.Point(146, 133);
            this.pnCheck3.Name = "pnCheck3";
            this.pnCheck3.Size = new System.Drawing.Size(200, 72);
            this.pnCheck3.TabIndex = 10;
            // 
            // pbCheck3
            // 
            this.pbCheck3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCheck3.BackgroundImage")));
            this.pbCheck3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCheck3.Location = new System.Drawing.Point(12, 11);
            this.pbCheck3.Name = "pbCheck3";
            this.pbCheck3.Size = new System.Drawing.Size(55, 50);
            this.pbCheck3.TabIndex = 4;
            this.pbCheck3.TabStop = false;
            // 
            // Ladebalken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 219);
            this.ControlBox = false;
            this.Controls.Add(this.pnCheck3);
            this.Controls.Add(this.pnCheck2);
            this.Controls.Add(this.pnCheck1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.progbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ladebalken";
            this.Text = "Ladebalken";
            this.Load += new System.EventHandler(this.Ladebalken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCross3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross2)).EndInit();
            this.pnCheck1.ResumeLayout(false);
            this.pnCheck1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck1)).EndInit();
            this.pnCheck2.ResumeLayout(false);
            this.pnCheck2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck2)).EndInit();
            this.pnCheck3.ResumeLayout(false);
            this.pnCheck3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progbar1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Timer timeNo1;
        private System.Windows.Forms.Timer timeNo2;
        private System.Windows.Forms.PictureBox pbCross3;
        private System.Windows.Forms.Label lbCheck3;
        private System.Windows.Forms.PictureBox pbCross1;
        private System.Windows.Forms.Label lbCheck1;
        private System.Windows.Forms.PictureBox pbCross2;
        private System.Windows.Forms.Label lbCheck2;
        private System.Windows.Forms.Panel pnCheck1;
        private System.Windows.Forms.Panel pnCheck2;
        private System.Windows.Forms.Panel pnCheck3;
        private System.Windows.Forms.PictureBox pbCheck1;
        private System.Windows.Forms.PictureBox pbCheck2;
        private System.Windows.Forms.PictureBox pbCheck3;
    }
}