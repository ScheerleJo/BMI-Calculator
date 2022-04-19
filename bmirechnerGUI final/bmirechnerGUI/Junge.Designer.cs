namespace bmirechnerGUI
{
    partial class Junge
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
            this.tbCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btExit = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.btBerechnen = new System.Windows.Forms.Button();
            this.cbKnochen = new System.Windows.Forms.ComboBox();
            this.tbAlter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.tbGroesse = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tabPage1);
            this.tbCntrl.Controls.Add(this.tabPage2);
            this.tbCntrl.Location = new System.Drawing.Point(12, 12);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(776, 450);
            this.tbCntrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btExit);
            this.tabPage1.Controls.Add(this.btBack);
            this.tabPage1.Controls.Add(this.lbError);
            this.tabPage1.Controls.Add(this.rtbAusgabe);
            this.tabPage1.Controls.Add(this.btBerechnen);
            this.tabPage1.Controls.Add(this.cbKnochen);
            this.tabPage1.Controls.Add(this.tbAlter);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbGewicht);
            this.tabPage1.Controls.Add(this.tbGroesse);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bmi-Rechner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(608, 332);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(105, 58);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Schließen";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(470, 332);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(111, 58);
            this.btBack.TabIndex = 13;
            this.btBack.Text = "Zurück zum\r\nHauptmenü";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(130, 401);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 12;
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(130, 217);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(299, 174);
            this.rtbAusgabe.TabIndex = 11;
            this.rtbAusgabe.Text = "";
            // 
            // btBerechnen
            // 
            this.btBerechnen.Location = new System.Drawing.Point(130, 148);
            this.btBerechnen.Name = "btBerechnen";
            this.btBerechnen.Size = new System.Drawing.Size(165, 49);
            this.btBerechnen.TabIndex = 10;
            this.btBerechnen.Text = "BMI Errechnen";
            this.btBerechnen.UseVisualStyleBackColor = true;
            this.btBerechnen.Click += new System.EventHandler(this.btBerechnen_Click);
            // 
            // cbKnochen
            // 
            this.cbKnochen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKnochen.FormattingEnabled = true;
            this.cbKnochen.Items.AddRange(new object[] {
            "Leicht",
            "Mittel",
            "Schwer"});
            this.cbKnochen.Location = new System.Drawing.Point(130, 108);
            this.cbKnochen.Name = "cbKnochen";
            this.cbKnochen.Size = new System.Drawing.Size(165, 24);
            this.cbKnochen.TabIndex = 9;
            // 
            // tbAlter
            // 
            this.tbAlter.Location = new System.Drawing.Point(130, 80);
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Size = new System.Drawing.Size(165, 22);
            this.tbAlter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ergebnis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Knochenbau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gewicht in kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Größe in cm:";
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(130, 51);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(165, 22);
            this.tbGewicht.TabIndex = 1;
            // 
            // tbGroesse
            // 
            this.tbGroesse.Location = new System.Drawing.Point(130, 22);
            this.tbGroesse.Name = "tbGroesse";
            this.tbGroesse.Size = new System.Drawing.Size(165, 22);
            this.tbGroesse.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verlauf";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Junge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.tbCntrl);
            this.MaximumSize = new System.Drawing.Size(818, 521);
            this.MinimumSize = new System.Drawing.Size(818, 521);
            this.Name = "Junge";
            this.Text = "Männlich";
            this.Load += new System.EventHandler(this.Junge_Load);
            this.tbCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbGroesse;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.Button btBerechnen;
        private System.Windows.Forms.ComboBox cbKnochen;
        private System.Windows.Forms.TextBox tbAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btBack;
    }
}