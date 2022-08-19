namespace JirehBankUI
{
    partial class Registration : Form
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
            this.lblLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lblPasswordReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFNameReg = new System.Windows.Forms.TextBox();
            this.btnBackReg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtLNameReg = new System.Windows.Forms.TextBox();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.txtPhoneReg = new System.Windows.Forms.TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginBtn
            // 
            this.lblLoginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblLoginBtn.BorderColor = System.Drawing.Color.Transparent;
            this.lblLoginBtn.BorderRadius = 10;
            this.lblLoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblLoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblLoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblLoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblLoginBtn.FillColor = System.Drawing.Color.MidnightBlue;
            this.lblLoginBtn.Font = new System.Drawing.Font("Rockwell Nova", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLoginBtn.Location = new System.Drawing.Point(318, 350);
            this.lblLoginBtn.Name = "lblLoginBtn";
            this.lblLoginBtn.Size = new System.Drawing.Size(237, 29);
            this.lblLoginBtn.TabIndex = 25;
            this.lblLoginBtn.Text = "Register";
            this.lblLoginBtn.Tile = true;
            this.lblLoginBtn.Click += new System.EventHandler(this.lblLoginBtn_Click);
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordReg.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPasswordReg.Location = new System.Drawing.Point(33, 301);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(94, 25);
            this.lblPasswordReg.TabIndex = 23;
            this.lblPasswordReg.Text = "Password";
            this.lblPasswordReg.Click += new System.EventHandler(this.lblPasswordReg_Click);
            // 
            // lblPhoneReg
            // 
            this.lblPhoneReg.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneReg.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneReg.Location = new System.Drawing.Point(33, 247);
            this.lblPhoneReg.Name = "lblPhoneReg";
            this.lblPhoneReg.Size = new System.Drawing.Size(145, 25);
            this.lblPhoneReg.TabIndex = 20;
            this.lblPhoneReg.Text = "Phone Number";
            this.lblPhoneReg.Click += new System.EventHandler(this.lblPhoneReg_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(33, 193);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Location = new System.Drawing.Point(215, 195);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(451, 23);
            this.txtEmailReg.TabIndex = 21;
            this.txtEmailReg.TextChanged += new System.EventHandler(this.txtEmailReg_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(33, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 25);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Last Name";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblEmailReg
            // 
            this.lblEmailReg.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailReg.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailReg.Location = new System.Drawing.Point(33, 94);
            this.lblEmailReg.Name = "lblEmailReg";
            this.lblEmailReg.Size = new System.Drawing.Size(109, 25);
            this.lblEmailReg.TabIndex = 15;
            this.lblEmailReg.Text = "First Name";
            this.lblEmailReg.Click += new System.EventHandler(this.lblEmailReg_Click);
            // 
            // txtFNameReg
            // 
            this.txtFNameReg.Location = new System.Drawing.Point(215, 94);
            this.txtFNameReg.Name = "txtFNameReg";
            this.txtFNameReg.Size = new System.Drawing.Size(451, 23);
            this.txtFNameReg.TabIndex = 17;
            this.txtFNameReg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBackReg
            // 
            this.btnBackReg.BorderRadius = 10;
            this.btnBackReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackReg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackReg.FillColor = System.Drawing.Color.Navy;
            this.btnBackReg.FillColor2 = System.Drawing.Color.Navy;
            this.btnBackReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackReg.ForeColor = System.Drawing.Color.White;
            this.btnBackReg.Location = new System.Drawing.Point(12, 12);
            this.btnBackReg.Name = "btnBackReg";
            this.btnBackReg.Size = new System.Drawing.Size(52, 24);
            this.btnBackReg.TabIndex = 26;
            this.btnBackReg.Text = "Back";
            this.btnBackReg.Click += new System.EventHandler(this.btnBackReg_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.lblPassword);
            this.guna2Panel1.Controls.Add(this.btnBackReg);
            this.guna2Panel1.Controls.Add(this.lblEmailReg);
            this.guna2Panel1.Controls.Add(this.lblEmail);
            this.guna2Panel1.Controls.Add(this.lblPasswordReg);
            this.guna2Panel1.Controls.Add(this.lblPhoneReg);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 450);
            this.guna2Panel1.TabIndex = 27;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(200, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(600, 63);
            this.guna2Panel2.TabIndex = 28;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // txtLNameReg
            // 
            this.txtLNameReg.Location = new System.Drawing.Point(215, 144);
            this.txtLNameReg.Name = "txtLNameReg";
            this.txtLNameReg.Size = new System.Drawing.Size(451, 23);
            this.txtLNameReg.TabIndex = 29;
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Location = new System.Drawing.Point(215, 301);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.Size = new System.Drawing.Size(451, 23);
            this.txtPasswordReg.TabIndex = 30;
            // 
            // txtPhoneReg
            // 
            this.txtPhoneReg.Location = new System.Drawing.Point(215, 247);
            this.txtPhoneReg.Name = "txtPhoneReg";
            this.txtPhoneReg.Size = new System.Drawing.Size(451, 23);
            this.txtPhoneReg.TabIndex = 31;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhoneReg);
            this.Controls.Add(this.txtPasswordReg);
            this.Controls.Add(this.txtLNameReg);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblLoginBtn);
            this.Controls.Add(this.txtEmailReg);
            this.Controls.Add(this.txtFNameReg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button lblLoginBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasswordReg;
        private TextBox txtPasswordReg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneReg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private TextBox txtEmailReg;
        private TextBox txtPhoneReg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmailReg;
        private TextBox txtFNameReg;
        private Guna.UI2.WinForms.Guna2GradientButton btnBackReg;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private TextBox txtLNameReg;
        private TextBox textBox1;
    }
}