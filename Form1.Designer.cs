namespace PAS_Desktop_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            close_btn = new Button();
            signUp_btn = new Button();
            logIn_btn = new Button();
            password_txbx = new TextBox();
            username_txbx = new TextBox();
            username1 = new Label();
            password1 = new Label();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.Location = new Point(558, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(43, 46);
            close_btn.TabIndex = 0;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // signUp_btn
            // 
            signUp_btn.Location = new Point(12, 474);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(294, 46);
            signUp_btn.TabIndex = 1;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = true;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // logIn_btn
            // 
            logIn_btn.Location = new Point(312, 474);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(289, 46);
            logIn_btn.TabIndex = 2;
            logIn_btn.Text = "Log In";
            logIn_btn.UseVisualStyleBackColor = true;
            logIn_btn.Click += logIn_btn_Click;
            // 
            // password_txbx
            // 
            password_txbx.Location = new Point(100, 309);
            password_txbx.Name = "password_txbx";
            password_txbx.Size = new Size(401, 39);
            password_txbx.TabIndex = 3;
            password_txbx.UseSystemPasswordChar = true;
            // 
            // username_txbx
            // 
            username_txbx.Location = new Point(100, 159);
            username_txbx.Name = "username_txbx";
            username_txbx.Size = new Size(401, 39);
            username_txbx.TabIndex = 4;
            // 
            // username1
            // 
            username1.AutoSize = true;
            username1.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username1.Location = new Point(206, 117);
            username1.Name = "username1";
            username1.Size = new Size(170, 39);
            username1.TabIndex = 5;
            username1.Text = "Username";
            // 
            // password1
            // 
            password1.AutoSize = true;
            password1.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password1.Location = new Point(206, 267);
            password1.Name = "password1";
            password1.Size = new Size(165, 39);
            password1.TabIndex = 6;
            password1.Text = "Password";
            password1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(613, 531);
            Controls.Add(password1);
            Controls.Add(username1);
            Controls.Add(username_txbx);
            Controls.Add(password_txbx);
            Controls.Add(logIn_btn);
            Controls.Add(signUp_btn);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private Button signUp_btn;
        private Button logIn_btn;
        private TextBox password_txbx;
        private TextBox username_txbx;
        private Label username1;
        private Label password1;
    }
}