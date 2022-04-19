namespace bmirechnerGUI
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btLogIn = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btGuest = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(12, 12);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(231, 39);
            this.btLogIn.TabIndex = 0;
            this.btLogIn.Text = "Anmelden";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.BtLogIn_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(12, 57);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(231, 39);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Registrieren";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // btGuest
            // 
            this.btGuest.Location = new System.Drawing.Point(12, 102);
            this.btGuest.Name = "btGuest";
            this.btGuest.Size = new System.Drawing.Size(231, 39);
            this.btGuest.TabIndex = 2;
            this.btGuest.Text = "Als Gast nutzen";
            this.btGuest.UseVisualStyleBackColor = true;
            this.btGuest.Click += new System.EventHandler(this.btGuest_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 148);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 39);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Schließen";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Location = new System.Drawing.Point(142, 147);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(100, 39);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.Text = "Minimieren";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 212);
            this.ControlBox = false;
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btGuest);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 251);
            this.MinimumSize = new System.Drawing.Size(270, 251);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btGuest;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMinimize;
    }
}