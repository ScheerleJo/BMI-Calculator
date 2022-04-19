namespace bmirechnerGUI
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.btPwvergessen = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(104, 24);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(123, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(104, 55);
            this.tbPasswort.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(123, 20);
            this.tbPasswort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benutername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort:";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(245, 50);
            this.cbShow.Margin = new System.Windows.Forms.Padding(2);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(69, 30);
            this.cbShow.TabIndex = 4;
            this.cbShow.Text = "Passwort\r\nanzeigen";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.CbShow_CheckedChanged);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(24, 93);
            this.btEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(82, 41);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Einloggen";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(211, 93);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(88, 41);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "Zurück";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(24, 140);
            this.lbError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 7;
            // 
            // btPwvergessen
            // 
            this.btPwvergessen.Location = new System.Drawing.Point(112, 93);
            this.btPwvergessen.Name = "btPwvergessen";
            this.btPwvergessen.Size = new System.Drawing.Size(94, 41);
            this.btPwvergessen.TabIndex = 8;
            this.btPwvergessen.Text = "Passwort vergessen";
            this.btPwvergessen.UseVisualStyleBackColor = true;
            this.btPwvergessen.Click += new System.EventHandler(this.btPwvergessen_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.Location = new System.Drawing.Point(247, 25);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(67, 23);
            this.btMinimize.TabIndex = 29;
            this.btMinimize.Text = "Minimieren";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(247, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(67, 23);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Schließen";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 170);
            this.ControlBox = false;
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPwvergessen);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(332, 209);
            this.MinimumSize = new System.Drawing.Size(332, 209);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btPwvergessen;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
    }
}