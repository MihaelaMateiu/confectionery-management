
namespace proiect
{
    partial class login_form
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
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.user_lb = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.new_client_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(200, 340);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(256, 24);
            this.username_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(200, 419);
            this.password_tb.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(256, 24);
            this.password_tb.TabIndex = 1;
            // 
            // user_lb
            // 
            this.user_lb.AutoSize = true;
            this.user_lb.BackColor = System.Drawing.Color.Transparent;
            this.user_lb.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lb.Location = new System.Drawing.Point(89, 340);
            this.user_lb.Name = "user_lb";
            this.user_lb.Size = new System.Drawing.Size(91, 21);
            this.user_lb.TabIndex = 2;
            this.user_lb.Text = "Username";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(336, 525);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(151, 61);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // new_client_btn
            // 
            this.new_client_btn.BackColor = System.Drawing.Color.Transparent;
            this.new_client_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_client_btn.Location = new System.Drawing.Point(677, 353);
            this.new_client_btn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.new_client_btn.Name = "new_client_btn";
            this.new_client_btn.Size = new System.Drawing.Size(219, 66);
            this.new_client_btn.TabIndex = 4;
            this.new_client_btn.Text = "Create New Account";
            this.new_client_btn.UseVisualStyleBackColor = false;
            this.new_client_btn.Click += new System.EventHandler(this.new_client_btn_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(89, 420);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(89, 21);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Location = new System.Drawing.Point(321, 36);
            this.logo_pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(379, 248);
            this.logo_pictureBox.TabIndex = 7;
            this.logo_pictureBox.TabStop = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 621);
            this.Controls.Add(this.logo_pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.new_client_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.user_lb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "login_form";
            this.ShowIcon = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label user_lb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button new_client_btn;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logo_pictureBox;
    }
}

