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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ergebnis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Knochenbau:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gewicht in kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Größe in cm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Geschlecht:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(182, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 22);
            this.tbName.TabIndex = 22;
            // 
            // tbGroesse
            // 
            this.tbGroesse.Location = new System.Drawing.Point(182, 65);
            this.tbGroesse.Name = "tbGroesse";
            this.tbGroesse.Size = new System.Drawing.Size(165, 22);
            this.tbGroesse.TabIndex = 23;
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(182, 93);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(165, 22);
            this.tbGewicht.TabIndex = 24;
            // 
            // tbAlter
            // 
            this.tbAlter.Location = new System.Drawing.Point(182, 121);
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Size = new System.Drawing.Size(165, 22);
            this.tbAlter.TabIndex = 25;
            // 
            // cbGeschlecht
            // 
            this.cbGeschlecht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeschlecht.FormattingEnabled = true;
            this.cbGeschlecht.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbGeschlecht.Location = new System.Drawing.Point(182, 149);
            this.cbGeschlecht.Name = "cbGeschlecht";
            this.cbGeschlecht.Size = new System.Drawing.Size(165, 24);
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
            this.cbKnochen.Location = new System.Drawing.Point(182, 179);
            this.cbKnochen.Name = "cbKnochen";
            this.cbKnochen.Size = new System.Drawing.Size(165, 24);
            this.cbKnochen.TabIndex = 27;
            // 
            // btBerechne
            // 
            this.btBerechne.Location = new System.Drawing.Point(182, 220);
            this.btBerechne.Name = "btBerechne";
            this.btBerechne.Size = new System.Drawing.Size(165, 46);
            this.btBerechne.TabIndex = 28;
            this.btBerechne.Text = "BMI Errechnen";
            this.btBerechne.UseVisualStyleBackColor = true;
            this.btBerechne.Click += new System.EventHandler(this.btBerechne_Click);
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(182, 285);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(271, 151);
            this.rtbAusgabe.TabIndex = 29;
            this.rtbAusgabe.Text = "";
            // 
            // Gast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 482);
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
            this.MaximumSize = new System.Drawing.Size(818, 521);
            this.MinimumSize = new System.Drawing.Size(818, 521);
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
    }
}