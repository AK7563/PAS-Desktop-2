namespace PAS_Desktop_2
{
    partial class Form4
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
            label1 = new Label();
            acc_txbx = new TextBox();
            pass_txbx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pay_btn = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(100, 98);
            label1.Name = "label1";
            label1.Size = new Size(237, 39);
            label1.TabIndex = 0;
            label1.Text = "Insert Account";
            // 
            // acc_txbx
            // 
            acc_txbx.Location = new Point(37, 140);
            acc_txbx.Name = "acc_txbx";
            acc_txbx.Size = new Size(361, 39);
            acc_txbx.TabIndex = 1;
            // 
            // pass_txbx
            // 
            pass_txbx.Location = new Point(37, 249);
            pass_txbx.Name = "pass_txbx";
            pass_txbx.Size = new Size(361, 39);
            pass_txbx.TabIndex = 3;
            pass_txbx.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(90, 207);
            label2.Name = "label2";
            label2.Size = new Size(260, 39);
            label2.TabIndex = 2;
            label2.Text = "Insert Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(90, 328);
            label3.Name = "label3";
            label3.Size = new Size(257, 39);
            label3.TabIndex = 4;
            label3.Text = "Insert Ammount";
            // 
            // pay_btn
            // 
            pay_btn.BackColor = Color.Yellow;
            pay_btn.Font = new Font("Swis721 BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pay_btn.Location = new Point(141, 474);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(150, 46);
            pay_btn.TabIndex = 6;
            pay_btn.Text = "Pay";
            pay_btn.UseVisualStyleBackColor = false;
            pay_btn.Click += pay_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-23, 526);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(480, 300);
            dataGridView1.TabIndex = 7;
            dataGridView1.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Location = new Point(37, 370);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(361, 39);
            numericUpDown1.TabIndex = 8;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(333, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(89, 46);
            back_btn.TabIndex = 9;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(434, 593);
            Controls.Add(back_btn);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(pay_btn);
            Controls.Add(label3);
            Controls.Add(pass_txbx);
            Controls.Add(label2);
            Controls.Add(acc_txbx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox acc_txbx;
        private TextBox pass_txbx;
        private Label label2;
        private Label label3;
        private Button pay_btn;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Button back_btn;
    }
}