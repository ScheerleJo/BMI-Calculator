namespace bmirechnerGUI
{
    partial class Mädchen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mädchen));
            this.tbCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.chartBmi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tbCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tabPage1);
            this.tbCntrl.Controls.Add(this.tabPage2);
            this.tbCntrl.Location = new System.Drawing.Point(9, 10);
            this.tbCntrl.Margin = new System.Windows.Forms.Padding(2);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(582, 366);
            this.tbCntrl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btBack);
            this.tabPage1.Controls.Add(this.btMinimize);
            this.tabPage1.Controls.Add(this.btClose);
            this.tabPage1.Controls.Add(this.pictureBox1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bmi-Rechner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(95, 325);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 14;
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(98, 176);
            this.rtbAusgabe.Margin = new System.Windows.Forms.Padding(2);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(225, 142);
            this.rtbAusgabe.TabIndex = 11;
            this.rtbAusgabe.Text = "";
            // 
            // btBerechnen
            // 
            this.btBerechnen.Location = new System.Drawing.Point(98, 120);
            this.btBerechnen.Margin = new System.Windows.Forms.Padding(2);
            this.btBerechnen.Name = "btBerechnen";
            this.btBerechnen.Size = new System.Drawing.Size(226, 40);
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
            this.cbKnochen.Location = new System.Drawing.Point(98, 88);
            this.cbKnochen.Margin = new System.Windows.Forms.Padding(2);
            this.cbKnochen.Name = "cbKnochen";
            this.cbKnochen.Size = new System.Drawing.Size(226, 21);
            this.cbKnochen.TabIndex = 9;
            // 
            // tbAlter
            // 
            this.tbAlter.Location = new System.Drawing.Point(98, 65);
            this.tbAlter.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Size = new System.Drawing.Size(226, 20);
            this.tbAlter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ergebnis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Knochenbau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gewicht in kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Größe in cm:";
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(98, 41);
            this.tbGewicht.Margin = new System.Windows.Forms.Padding(2);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(226, 20);
            this.tbGewicht.TabIndex = 1;
            // 
            // tbGroesse
            // 
            this.tbGroesse.Location = new System.Drawing.Point(98, 18);
            this.tbGroesse.Margin = new System.Windows.Forms.Padding(2);
            this.tbGroesse.Name = "tbGroesse";
            this.tbGroesse.Size = new System.Drawing.Size(226, 20);
            this.tbGroesse.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartBmi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(574, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verlauf";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartBmi
            // 
            chartArea7.Name = "ChartArea1";
            this.chartBmi.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartBmi.Legends.Add(legend7);
            this.chartBmi.Location = new System.Drawing.Point(5, 5);
            this.chartBmi.Name = "chartBmi";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "BMI";
            this.chartBmi.Series.Add(series7);
            this.chartBmi.Size = new System.Drawing.Size(564, 330);
            this.chartBmi.TabIndex = 0;
            this.chartBmi.Text = "chart1";
            this.chartBmi.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 300);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(485, 73);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(67, 36);
            this.btBack.TabIndex = 35;
            this.btBack.Text = "Zurück zum Hauptmenü";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click_1);
            // 
            // btMinimize
            // 
            this.btMinimize.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.Location = new System.Drawing.Point(485, 44);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(67, 23);
            this.btMinimize.TabIndex = 34;
            this.btMinimize.Text = "Minimieren";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(485, 15);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(67, 23);
            this.btClose.TabIndex = 33;
            this.btClose.Text = "Schließen";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // Mädchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 392);
            this.Controls.Add(this.tbCntrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(618, 431);
            this.MinimumSize = new System.Drawing.Size(618, 431);
            this.Name = "Mädchen";
            this.Text = "Weiblich";
            this.tbCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.Button btBerechnen;
        private System.Windows.Forms.ComboBox cbKnochen;
        private System.Windows.Forms.TextBox tbAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbGroesse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBmi;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
    }
}