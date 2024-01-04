namespace AttendanceV2
{
    partial class LoginForm
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Check_showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 649);
            this.panel1.TabIndex = 0;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(170, 83);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(117, 44);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login";
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_email.Location = new System.Drawing.Point(174, 179);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(213, 29);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email/Username:";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(174, 280);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(135, 29);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // input_email
            // 
            this.input_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_email.Location = new System.Drawing.Point(179, 221);
            this.input_email.Margin = new System.Windows.Forms.Padding(4);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(347, 31);
            this.input_email.TabIndex = 1;
            // 
            // input_password
            // 
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.Location = new System.Drawing.Point(179, 321);
            this.input_password.Margin = new System.Windows.Forms.Padding(4);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(347, 31);
            this.input_password.TabIndex = 2;
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_login.ForeColor = System.Drawing.Color.White;
            this.Btn_login.Location = new System.Drawing.Point(179, 433);
            this.Btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(347, 48);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Check_showPass
            // 
            this.Check_showPass.AutoSize = true;
            this.Check_showPass.Location = new System.Drawing.Point(179, 375);
            this.Check_showPass.Margin = new System.Windows.Forms.Padding(4);
            this.Check_showPass.Name = "Check_showPass";
            this.Check_showPass.Size = new System.Drawing.Size(197, 29);
            this.Check_showPass.TabIndex = 3;
            this.Check_showPass.Text = "Show Password";
            this.Check_showPass.UseVisualStyleBackColor = true;
            this.Check_showPass.CheckedChanged += new System.EventHandler(this.Check_showPass_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceSystem.Properties.Resources.study;
            this.pictureBox1.Location = new System.Drawing.Point(762, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(702, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            this.label1.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(819, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            this.label2.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(919, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Schedule";
            this.label3.Click += new System.EventHandler(this.label_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Check_showPass);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.CheckBox Check_showPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

