namespace TEST
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vrulcloginlabel = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 443);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.vrulcloginlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(93, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 64);
            this.panel2.TabIndex = 1;
            // 
            // vrulcloginlabel
            // 
            this.vrulcloginlabel.AutoSize = true;
            this.vrulcloginlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vrulcloginlabel.Font = new System.Drawing.Font("Calibri", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrulcloginlabel.Location = new System.Drawing.Point(239, 19);
            this.vrulcloginlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vrulcloginlabel.Name = "vrulcloginlabel";
            this.vrulcloginlabel.Size = new System.Drawing.Size(164, 33);
            this.vrulcloginlabel.TabIndex = 0;
            this.vrulcloginlabel.Text = "VRULC LOGIN";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(219, 298);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(147, 26);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(399, 298);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(147, 26);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(257, 143);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(117, 29);
            this.usernamelbl.TabIndex = 4;
            this.usernamelbl.Text = "Username";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(257, 216);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(111, 29);
            this.passwordlbl.TabIndex = 5;
            this.passwordlbl.Text = "Password";
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(399, 151);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(140, 22);
            this.usernametxtbox.TabIndex = 6;
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(399, 224);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(140, 22);
            this.passwordtxtbox.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(139)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(739, 443);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label vrulcloginlabel;
    }
}