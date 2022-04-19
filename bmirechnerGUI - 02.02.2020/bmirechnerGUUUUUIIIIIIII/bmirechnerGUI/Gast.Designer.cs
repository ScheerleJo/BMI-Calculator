namespace bmirechnerGUI
{
    partial class Gast
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGroesse = new System.Windows.Forms.TextBox();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.tbAlter = new System.Windows.Forms.TextBox();
            this.cbGeschlecht = new System.Windows.Forms.ComboBox();
            this.cbKnochen = new System.Windows.Forms.ComboBox();
            this.btBerechne = new System.Windows.Forms.Button();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ergebnis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Knochenbau:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gewicht in kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Größe in cm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Geschlecht:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(136, 30);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 20);
            this.tbName.TabIndex = 22;
            // 
            // tbGroesse
            // 
            this.tbGroesse.Location = new System.Drawing.Point(136, 53);
            this.tbGroesse.Margin = new System.Windows.Forms.Padding(2);
            this.tbGroesse.Name = "tbGroesse";
            this.tbGroesse.Size = new System.Drawing.Size(125, 20);
            this.tbGroesse.TabIndex = 23;
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(136, 76);
            this.tbGewicht.Margin = new System.Windows.Forms.Padding(2);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(125, 20);
            this.tbGewicht.TabIndex = 24;
            // 
            // tbAlter
            // 
            this.tbAlter.Location = new System.Drawing.Point(136, 98);
            this.tbAlter.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Size = new System.Drawing.Size(125, 20);
            this.tbAlter.TabIndex = 25;
            // 
            // cbGeschlecht
            // 
            this.cbGeschlecht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeschlecht.FormattingEnabled = true;
            this.cbGeschlecht.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbGeschlecht.Location = new System.Drawing.Point(136, 121);
            this.cbGeschlecht.Margin = new System.Windows.Forms.Padding(2);
            this.cbGeschlecht.Name = "cbGeschlecht";
            this.cbGeschlecht.Size = new System.Drawing.Size(125, 21);
            this.cbGeschlecht.TabIndex = 26;
            // 
            // cbKnochen
            // 
            this.cbKnochen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKnochen.FormattingEnabled = true;
            this.cbKnochen.Items.AddRange(new object[] {
            "Leicht",
            "Mittel",
            "Schwer"});
            this.cbKnochen.Location = new System.Drawing.Point(136, 145);
            this.cbKnochen.Margin = new System.Windows.Forms.Padding(2);
            this.cbKnochen.Name = "cbKnochen";
            this.cbKnochen.Size = new System.Drawing.Size(125, 21);
            this.cbKnochen.TabIndex = 27;
            // 
            // btBerechne
            // 
            this.btBerechne.Location = new System.Drawing.Point(136, 179);
            this.btBerechne.Margin = new System.Windows.Forms.Padding(2);
            this.btBerechne.Name = "btBerechne";
            this.btBerechne.Size = new System.Drawing.Size(124, 37);
            this.btBerechne.TabIndex = 28;
            this.btBerechne.Text = "BMI Errechnen";
            this.btBerechne.UseVisualStyleBackColor = true;
            this.btBerechne.Click += new System.EventHandler(this.btBerechne_Click);
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(136, 232);
            this.rtbAusgabe.Margin = new System.Windows.Forms.Padding(2);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(204, 123);
            this.rtbAusgabe.TabIndex = 29;
            this.rtbAusgabe.Text = "";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(357, 316);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(105, 38);
            this.btBack.TabIndex = 30;
            this.btBack.Text = "Zurück zum\r\nHauptmenü";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(485, 316);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(105, 38);
            this.btRegister.TabIndex = 31;
            this.btRegister.Text = "Registrieren";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // Gast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 392);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.rtbAusgabe);
            this.Controls.Add(this.btBerechne);
            this.Controls.Add(this.cbKnochen);
            this.Controls.Add(this.cbGeschlecht);
            this.Controls.Add(this.tbAlter);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.tbGroesse);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(618, 431);
            this.MinimumSize = new System.Drawing.Size(618, 431);
            this.Name = "Gast";
            this.Text = "Gast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGroesse;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbAlter;
        private System.Windows.Forms.ComboBox cbGeschlecht;
        private System.Windows.Forms.ComboBox cbKnochen;
        private System.Windows.Forms.Button btBerechne;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btRegister;
    }
}