namespace PAS_Desktop_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            close_btn = new Button();
            dataGridView1 = new DataGridView();
            back_btn = new Button();
            userName = new Label();
            task_txbx = new Label();
            money_txbx = new Label();
            label1 = new Label();
            product_txbx = new TextBox();
            label2 = new Label();
            reciever_txbx = new TextBox();
            label3 = new Label();
            ammount_nud = new NumericUpDown();
            recipt_dgv = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Ammount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Product_Raw = new DataGridViewTextBoxColumn();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            add_btn = new Button();
            remove_btn = new Button();
            buy_btn = new Button();
            clear_btn = new Button();
            total_lbl = new Label();
            provider_txbx = new TextBox();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            priceAdd_nud = new NumericUpDown();
            seller_dgv = new DataGridView();
            ProductSell = new DataGridViewTextBoxColumn();
            AmmountSell = new DataGridViewTextBoxColumn();
            PriceSell = new DataGridViewTextBoxColumn();
            label6 = new Label();
            productAdd_txbx = new TextBox();
            label8 = new Label();
            clear2_btn = new Button();
            sell_btn = new Button();
            label9 = new Label();
            remove2_btn = new Button();
            ammountAdd_txbx = new NumericUpDown();
            add2_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipt_dgv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceAdd_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seller_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammountAdd_txbx).BeginInit();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Red;
            close_btn.ForeColor = Color.White;
            close_btn.Location = new Point(1693, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(43, 46);
            close_btn.TabIndex = 2;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(889, 607);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.Moccasin;
            back_btn.Location = new Point(1598, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(89, 46);
            back_btn.TabIndex = 4;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Swis721 BT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            userName.Location = new Point(907, 12);
            userName.Name = "userName";
            userName.Size = new Size(262, 57);
            userName.TabIndex = 5;
            userName.Text = "Hello User";
            // 
            // task_txbx
            // 
            task_txbx.AutoSize = true;
            task_txbx.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            task_txbx.Location = new Point(907, 69);
            task_txbx.Name = "task_txbx";
            task_txbx.Size = new Size(284, 39);
            task_txbx.TabIndex = 6;
            task_txbx.Text = "What are we verb?";
            task_txbx.Click += task_txbx_Click;
            // 
            // money_txbx
            // 
            money_txbx.AutoSize = true;
            money_txbx.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            money_txbx.Location = new Point(907, 580);
            money_txbx.Name = "money_txbx";
            money_txbx.Size = new Size(191, 39);
            money_txbx.TabIndex = 7;
            money_txbx.Text = "Your money";
            money_txbx.Click += money_txbx_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 39);
            label1.Name = "label1";
            label1.Size = new Size(176, 29);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // product_txbx
            // 
            product_txbx.Location = new Point(0, 71);
            product_txbx.Name = "product_txbx";
            product_txbx.Size = new Size(476, 39);
            product_txbx.TabIndex = 9;
            product_txbx.TextChanged += product_txbx_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 122);
            label2.Name = "label2";
            label2.Size = new Size(122, 29);
            label2.TabIndex = 10;
            label2.Text = "Ammount";
            // 
            // reciever_txbx
            // 
            reciever_txbx.Location = new Point(182, 154);
            reciever_txbx.Name = "reciever_txbx";
            reciever_txbx.Size = new Size(531, 39);
            reciever_txbx.TabIndex = 12;
            reciever_txbx.TextChanged += reciever_txbx_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(579, 122);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 13;
            label3.Text = "To Whom?";
            label3.Visible = false;
            // 
            // ammount_nud
            // 
            ammount_nud.Location = new Point(0, 154);
            ammount_nud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ammount_nud.Name = "ammount_nud";
            ammount_nud.Size = new Size(176, 39);
            ammount_nud.TabIndex = 14;
            ammount_nud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ammount_nud.ValueChanged += ammount_nud_ValueChanged;
            // 
            // recipt_dgv
            // 
            recipt_dgv.AllowUserToAddRows = false;
            recipt_dgv.AllowUserToDeleteRows = false;
            recipt_dgv.BackgroundColor = Color.White;
            recipt_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recipt_dgv.Columns.AddRange(new DataGridViewColumn[] { Product, Ammount, Price, From, Product_Raw });
            recipt_dgv.Location = new Point(182, 199);
            recipt_dgv.Name = "recipt_dgv";
            recipt_dgv.ReadOnly = true;
            recipt_dgv.RowHeadersWidth = 82;
            recipt_dgv.RowTemplate.Height = 41;
            recipt_dgv.Size = new Size(531, 202);
            recipt_dgv.TabIndex = 15;
            recipt_dgv.CellClick += recipt_dgv_CellClick;
            recipt_dgv.CellContentClick += recipt_dgv_CellContentClick;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 10;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 210;
            // 
            // Ammount
            // 
            Ammount.HeaderText = "Ammount";
            Ammount.MinimumWidth = 15;
            Ammount.Name = "Ammount";
            Ammount.ReadOnly = true;
            Ammount.Width = 120;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 15;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 120;
            // 
            // From
            // 
            From.HeaderText = "From";
            From.MinimumWidth = 10;
            From.Name = "From";
            From.ReadOnly = true;
            From.Visible = false;
            From.Width = 200;
            // 
            // Product_Raw
            // 
            Product_Raw.HeaderText = "Product_Raw";
            Product_Raw.MinimumWidth = 10;
            Product_Raw.Name = "Product_Raw";
            Product_Raw.ReadOnly = true;
            Product_Raw.Visible = false;
            Product_Raw.Width = 200;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(182, 117);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(156, 36);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "For myself";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(344, 117);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 36);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "As a gift";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(0, 199);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(176, 46);
            add_btn.TabIndex = 18;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.Location = new Point(0, 251);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(176, 46);
            remove_btn.TabIndex = 19;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = true;
            remove_btn.Click += remove_btn_Click;
            // 
            // buy_btn
            // 
            buy_btn.Location = new Point(0, 355);
            buy_btn.Name = "buy_btn";
            buy_btn.Size = new Size(176, 46);
            buy_btn.TabIndex = 20;
            buy_btn.Text = "Buy";
            buy_btn.UseVisualStyleBackColor = true;
            buy_btn.Click += buy_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(0, 303);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(176, 46);
            clear_btn.TabIndex = 21;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Location = new Point(182, 404);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(128, 32);
            total_lbl.TabIndex = 22;
            total_lbl.Text = "Total Price:";
            // 
            // provider_txbx
            // 
            provider_txbx.Location = new Point(482, 71);
            provider_txbx.Name = "provider_txbx";
            provider_txbx.Size = new Size(231, 39);
            provider_txbx.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(482, 39);
            label4.Name = "label4";
            label4.Size = new Size(72, 29);
            label4.TabIndex = 24;
            label4.Text = "From";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(recipt_dgv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(provider_txbx);
            groupBox1.Controls.Add(product_txbx);
            groupBox1.Controls.Add(total_lbl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(clear_btn);
            groupBox1.Controls.Add(reciever_txbx);
            groupBox1.Controls.Add(buy_btn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(remove_btn);
            groupBox1.Controls.Add(ammount_nud);
            groupBox1.Controls.Add(add_btn);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(961, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 435);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buyyer";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(priceAdd_nud);
            groupBox2.Controls.Add(seller_dgv);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(productAdd_txbx);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(clear2_btn);
            groupBox2.Controls.Add(sell_btn);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(remove2_btn);
            groupBox2.Controls.Add(ammountAdd_txbx);
            groupBox2.Controls.Add(add2_btn);
            groupBox2.Location = new Point(961, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(713, 435);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seller";
            // 
            // priceAdd_nud
            // 
            priceAdd_nud.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            priceAdd_nud.Location = new Point(182, 154);
            priceAdd_nud.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            priceAdd_nud.Name = "priceAdd_nud";
            priceAdd_nud.Size = new Size(531, 39);
            priceAdd_nud.TabIndex = 22;
            // 
            // seller_dgv
            // 
            seller_dgv.AllowUserToAddRows = false;
            seller_dgv.AllowUserToDeleteRows = false;
            seller_dgv.BackgroundColor = Color.White;
            seller_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seller_dgv.Columns.AddRange(new DataGridViewColumn[] { ProductSell, AmmountSell, PriceSell });
            seller_dgv.Location = new Point(182, 199);
            seller_dgv.Name = "seller_dgv";
            seller_dgv.ReadOnly = true;
            seller_dgv.RowHeadersWidth = 82;
            seller_dgv.RowTemplate.Height = 41;
            seller_dgv.Size = new Size(531, 202);
            seller_dgv.TabIndex = 15;
            seller_dgv.CellClick += seller_dgv_CellClick;
            seller_dgv.CellContentClick += seller_dgv_CellContentClick;
            // 
            // ProductSell
            // 
            ProductSell.HeaderText = "Product";
            ProductSell.MinimumWidth = 10;
            ProductSell.Name = "ProductSell";
            ProductSell.ReadOnly = true;
            ProductSell.Width = 210;
            // 
            // AmmountSell
            // 
            AmmountSell.HeaderText = "Ammount";
            AmmountSell.MinimumWidth = 15;
            AmmountSell.Name = "AmmountSell";
            AmmountSell.ReadOnly = true;
            AmmountSell.Width = 120;
            // 
            // PriceSell
            // 
            PriceSell.HeaderText = "Price";
            PriceSell.MinimumWidth = 15;
            PriceSell.Name = "PriceSell";
            PriceSell.ReadOnly = true;
            PriceSell.Width = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 39);
            label6.Name = "label6";
            label6.Size = new Size(176, 29);
            label6.TabIndex = 8;
            label6.Text = "Product Name";
            // 
            // productAdd_txbx
            // 
            productAdd_txbx.Location = new Point(0, 71);
            productAdd_txbx.Name = "productAdd_txbx";
            productAdd_txbx.Size = new Size(713, 39);
            productAdd_txbx.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 122);
            label8.Name = "label8";
            label8.Size = new Size(122, 29);
            label8.TabIndex = 10;
            label8.Text = "Ammount";
            // 
            // clear2_btn
            // 
            clear2_btn.Location = new Point(0, 251);
            clear2_btn.Name = "clear2_btn";
            clear2_btn.Size = new Size(176, 46);
            clear2_btn.TabIndex = 21;
            clear2_btn.Text = "Clear";
            clear2_btn.UseVisualStyleBackColor = true;
            clear2_btn.Click += clear2_btn_Click;
            // 
            // sell_btn
            // 
            sell_btn.Location = new Point(0, 355);
            sell_btn.Name = "sell_btn";
            sell_btn.Size = new Size(176, 46);
            sell_btn.TabIndex = 20;
            sell_btn.Text = "Sell";
            sell_btn.UseVisualStyleBackColor = true;
            sell_btn.Click += sell_btn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(182, 122);
            label9.Name = "label9";
            label9.Size = new Size(72, 29);
            label9.TabIndex = 13;
            label9.Text = "Price";
            label9.Visible = false;
            // 
            // remove2_btn
            // 
            remove2_btn.Location = new Point(0, 303);
            remove2_btn.Name = "remove2_btn";
            remove2_btn.Size = new Size(176, 46);
            remove2_btn.TabIndex = 19;
            remove2_btn.Text = "Remove";
            remove2_btn.UseVisualStyleBackColor = true;
            remove2_btn.Click += remove2_btn_Click;
            // 
            // ammountAdd_txbx
            // 
            ammountAdd_txbx.Location = new Point(0, 154);
            ammountAdd_txbx.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ammountAdd_txbx.Name = "ammountAdd_txbx";
            ammountAdd_txbx.Size = new Size(176, 39);
            ammountAdd_txbx.TabIndex = 14;
            ammountAdd_txbx.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // add2_btn
            // 
            add2_btn.Location = new Point(0, 199);
            add2_btn.Name = "add2_btn";
            add2_btn.Size = new Size(176, 46);
            add2_btn.TabIndex = 18;
            add2_btn.Text = "Add";
            add2_btn.UseVisualStyleBackColor = true;
            add2_btn.Click += add2_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1748, 631);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(money_txbx);
            Controls.Add(task_txbx);
            Controls.Add(userName);
            Controls.Add(back_btn);
            Controls.Add(dataGridView1);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipt_dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceAdd_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)seller_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammountAdd_txbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private DataGridView dataGridView1;
        private Button back_btn;
        private Label userName;
        private Label task_txbx;
        private Label money_txbx;
        private Label label1;
        private TextBox product_txbx;
        private Label label2;
        private TextBox reciever_txbx;
        private Label label3;
        private NumericUpDown ammount_nud;
        private DataGridView recipt_dgv;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button add_btn;
        private Button remove_btn;
        private Button buy_btn;
        private Button clear_btn;
        private Label total_lbl;
        private TextBox provider_txbx;
        private Label label4;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Ammount;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Product_Raw;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView seller_dgv;
        private Label label6;
        private TextBox productAdd_txbx;
        private Label label8;
        private Button clear2_btn;
        private Button sell_btn;
        private Label label9;
        private Button remove2_btn;
        private NumericUpDown ammountAdd_txbx;
        private Button add2_btn;
        private NumericUpDown priceAdd_nud;
        private DataGridViewTextBoxColumn ProductSell;
        private DataGridViewTextBoxColumn AmmountSell;
        private DataGridViewTextBoxColumn PriceSell;
    }
}