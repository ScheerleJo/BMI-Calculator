namespace bmirechnerGUI
{
    partial class Passwortvergessen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btZurück = new System.Windows.Forms.Button();
            this.btCode = new System.Windows.Forms.Button();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbUserCode = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btVerify = new System.Windows.Forms.Button();
            this.lbPassword1 = new System.Windows.Forms.Label();
            this.lbPassword2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordproof = new System.Windows.Forms.TextBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.lbAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mailadresse:";
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(165, 27);
            this.tbVorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(181, 22);
            this.tbVorname.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(165, 58);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(165, 90);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(181, 22);
            this.tbMail.TabIndex = 5;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(16, 128);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(123, 50);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Schließen";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btZurück
            // 
            this.btZurück.Location = new System.Drawing.Point(296, 128);
            this.btZurück.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btZurück.Name = "btZurück";
            this.btZurück.Size = new System.Drawing.Size(123, 50);
            this.btZurück.TabIndex = 7;
            this.btZurück.Text = "Zurück";
            this.btZurück.UseVisualStyleBackColor = true;
            this.btZurück.Click += new System.EventHandler(this.btZurück_Click);
            // 
            // btCode
            // 
            this.btCode.Location = new System.Drawing.Point(147, 128);
            this.btCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCode.Name = "btCode";
            this.btCode.Size = new System.Drawing.Size(141, 50);
            this.btCode.TabIndex = 8;
            this.btCode.Text = "Verifizierungscode senden";
            this.btCode.UseVisualStyleBackColor = true;
            this.btCode.Click += new System.EventHandler(this.btCode_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(28, 204);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(108, 17);
            this.lbCode.TabIndex = 9;
            this.lbCode.Text = "Code eingeben:";
            // 
            // tbUserCode
            // 
            this.tbUserCode.Location = new System.Drawing.Point(165, 201);
            this.tbUserCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserCode.Name = "tbUserCode";
            this.tbUserCode.Size = new System.Drawing.Size(121, 22);
            this.tbUserCode.TabIndex = 10;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(28, 182);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 11;
            // 
            // btVerify
            // 
            this.btVerify.Location = new System.Drawing.Point(296, 201);
            this.btVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(123, 28);
            this.btVerify.TabIndex = 12;
            this.btVerify.Text = "Verifizieren";
            this.btVerify.UseVisualStyleBackColor = true;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // lbPassword1
            // 
            this.lbPassword1.AutoSize = true;
            this.lbPassword1.Location = new System.Drawing.Point(32, 256);
            this.lbPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword1.Name = "lbPassword1";
            this.lbPassword1.Size = new System.Drawing.Size(112, 17);
            this.lbPassword1.TabIndex = 13;
            this.lbPassword1.Text = "neues Passwort:";
            // 
            // lbPassword2
            // 
            this.lbPassword2.AutoSize = true;
            this.lbPassword2.Location = new System.Drawing.Point(5, 292);
            this.lbPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword2.Name = "lbPassword2";
            this.lbPassword2.Size = new System.Drawing.Size(139, 17);
            this.lbPassword2.TabIndex = 14;
            this.lbPassword2.Text = "Passwort bestätigen:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(165, 252);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(121, 22);
            this.tbPassword.TabIndex = 15;
            // 
            // tbPasswordproof
            // 
            this.tbPasswordproof.Location = new System.Drawing.Point(165, 288);
            this.tbPasswordproof.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPasswordproof.Name = "tbPasswordproof";
            this.tbPasswordproof.Size = new System.Drawing.Size(121, 22);
            this.tbPasswordproof.TabIndex = 16;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(296, 271);
            this.cbShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(88, 38);
            this.cbShow.TabIndex = 24;
            this.cbShow.Text = "Passwort\r\nanzeigen";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(16, 321);
            this.btEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(400, 39);
            this.btEnter.TabIndex = 25;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // lbAusgabe
            // 
            this.lbAusgabe.AutoSize = true;
            this.lbAusgabe.Location = new System.Drawing.Point(17, 372);
            this.lbAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAusgabe.Name = "lbAusgabe";
            this.lbAusgabe.Size = new System.Drawing.Size(12, 17);
            this.lbAusgabe.TabIndex = 26;
            this.lbAusgabe.Text = " ";
            // 
            // Passwortvergessen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 188);
            this.Controls.Add(this.lbAusgabe);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.tbPasswordproof);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword2);
            this.Controls.Add(this.lbPassword1);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.tbUserCode);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.btCode);
            this.Controls.Add(this.btZurück);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(447, 432);
            this.MinimumSize = new System.Drawing.Size(447, 235);
            this.Name = "Passwortvergessen";
            this.Text = "Passwortvergessen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btZurück;
        private System.Windows.Forms.Button btCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox tbUserCode;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.Label lbPassword1;
        private System.Windows.Forms.Label lbPassword2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordproof;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label lbAusgabe;
    }
}