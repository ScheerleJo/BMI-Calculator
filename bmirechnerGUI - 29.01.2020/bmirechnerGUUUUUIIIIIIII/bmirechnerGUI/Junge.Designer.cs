﻿namespace bmirechnerGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Junge));
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
            this.chartBmi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBmi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tabPage1);
            this.tbCntrl.Controls.Add(this.tabPage2);
            this.tbCntrl.Location = new System.Drawing.Point(12, 12);
            this.tbCntrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(768, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bmi-Rechner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(657, 66);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(105, 58);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Schließen";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(657, 4);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(105, 58);
            this.btBack.TabIndex = 13;
            this.btBack.Text = "Zurück zum\r\nHauptmenü";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(131, 401);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 12;
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(131, 217);
            this.rtbAusgabe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(299, 174);
            this.rtbAusgabe.TabIndex = 11;
            this.rtbAusgabe.Text = "";
            // 
            // btBerechnen
            // 
            this.btBerechnen.Location = new System.Drawing.Point(131, 148);
            this.btBerechnen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBerechnen.Name = "btBerechnen";
            this.btBerechnen.Size = new System.Drawing.Size(299, 49);
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
            this.cbKnochen.Location = new System.Drawing.Point(131, 108);
            this.cbKnochen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKnochen.Name = "cbKnochen";
            this.cbKnochen.Size = new System.Drawing.Size(299, 24);
            this.cbKnochen.TabIndex = 9;
            // 
            // tbAlter
            // 
            this.tbAlter.Location = new System.Drawing.Point(131, 80);
            this.tbAlter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAlter.Name = "tbAlter";
            this.tbAlter.Size = new System.Drawing.Size(299, 22);
            this.tbAlter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ergebnis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Knochenbau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gewicht in kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Größe in cm:";
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(131, 50);
            this.tbGewicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(299, 22);
            this.tbGewicht.TabIndex = 1;
            // 
            // tbGroesse
            // 
            this.tbGroesse.Location = new System.Drawing.Point(131, 22);
            this.tbGroesse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGroesse.Name = "tbGroesse";
            this.tbGroesse.Size = new System.Drawing.Size(299, 22);
            this.tbGroesse.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartBmi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(768, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verlauf";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartBmi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBmi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBmi.Legends.Add(legend1);
            this.chartBmi.Location = new System.Drawing.Point(7, 6);
            this.chartBmi.Margin = new System.Windows.Forms.Padding(4);
            this.chartBmi.Name = "chartBmi";
            this.chartBmi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "BMI";
            this.chartBmi.Series.Add(series1);
            this.chartBmi.Size = new System.Drawing.Size(752, 406);
            this.chartBmi.TabIndex = 0;
            this.chartBmi.Text = "chartBMI";
            // 
            // Junge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.tbCntrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 520);
            this.MinimumSize = new System.Drawing.Size(818, 520);
            this.Name = "Junge";
            this.Text = "Männlich";
            this.tbCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBmi)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBmi;
    }
}