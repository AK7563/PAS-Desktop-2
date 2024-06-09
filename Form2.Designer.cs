namespace PAS_Desktop_2
{
    partial class Form2
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
            close_btn = new Button();
            customer_btn = new Button();
            seller_btn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            money_lbl = new Label();
            HelloUser_lbl = new Label();
            payment_btn = new Button();
            logOut_btn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.Location = new Point(891, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(43, 46);
            close_btn.TabIndex = 1;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // customer_btn
            // 
            customer_btn.Location = new Point(576, 434);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(240, 169);
            customer_btn.TabIndex = 2;
            customer_btn.Text = "Customer";
            customer_btn.UseVisualStyleBackColor = true;
            customer_btn.Click += customer_btn_Click;
            // 
            // seller_btn
            // 
            seller_btn.Location = new Point(251, 434);
            seller_btn.Name = "seller_btn";
            seller_btn.Size = new Size(240, 169);
            seller_btn.TabIndex = 3;
            seller_btn.Text = "Seller";
            seller_btn.UseVisualStyleBackColor = true;
            seller_btn.Click += seller_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 705);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(logOut_btn);
            panel2.Controls.Add(money_lbl);
            panel2.Controls.Add(HelloUser_lbl);
            panel2.Controls.Add(close_btn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 165);
            panel2.TabIndex = 5;
            // 
            // money_lbl
            // 
            money_lbl.AutoSize = true;
            money_lbl.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            money_lbl.ForeColor = Color.White;
            money_lbl.Location = new Point(6, 114);
            money_lbl.Name = "money_lbl";
            money_lbl.Size = new Size(201, 39);
            money_lbl.TabIndex = 1;
            money_lbl.Text = "Your Money:";
            money_lbl.Click += money_lbl_Click;
            // 
            // HelloUser_lbl
            // 
            HelloUser_lbl.AutoSize = true;
            HelloUser_lbl.Font = new Font("Swis721 BT", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            HelloUser_lbl.ForeColor = Color.White;
            HelloUser_lbl.Location = new Point(6, 12);
            HelloUser_lbl.Name = "HelloUser_lbl";
            HelloUser_lbl.Size = new Size(377, 82);
            HelloUser_lbl.TabIndex = 0;
            HelloUser_lbl.Text = "Hello User";
            HelloUser_lbl.Click += HelloUser_lbl_Click;
            // 
            // payment_btn
            // 
            payment_btn.Location = new Point(907, 434);
            payment_btn.Name = "payment_btn";
            payment_btn.Size = new Size(240, 169);
            payment_btn.TabIndex = 6;
            payment_btn.Text = "Payment";
            payment_btn.UseVisualStyleBackColor = true;
            payment_btn.Click += payment_btn_Click;
            // 
            // logOut_btn
            // 
            logOut_btn.Location = new Point(756, 12);
            logOut_btn.Name = "logOut_btn";
            logOut_btn.Size = new Size(129, 46);
            logOut_btn.TabIndex = 2;
            logOut_btn.Text = "Log Out";
            logOut_btn.UseVisualStyleBackColor = true;
            logOut_btn.Click += logOut_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 705);
            Controls.Add(payment_btn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(seller_btn);
            Controls.Add(customer_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button close_btn;
        private Button customer_btn;
        private Button seller_btn;
        private Panel panel1;
        private Panel panel2;
        private Button payment_btn;
        private Label HelloUser_lbl;
        private Label money_lbl;
        private Button logOut_btn;
    }
}