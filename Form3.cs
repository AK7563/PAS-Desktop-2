using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client.NativeInterop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS_Desktop_2
{
    public partial class Form3 : Form
    {
        private bool isSeller;
        private string currentUser;
        DataGridViewRow remover, remover2;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QNDK4VF9\\MSSQLSERVER05;Initial Catalog=myAssHurts;Integrated Security=True");

        public Form3(bool isSeller, string currentUser)
        {
            InitializeComponent();
            this.isSeller = isSeller;
            this.currentUser = currentUser;
            if (this.isSeller is true)
            {
                bind(currentUser);
                userName.Text = "Hello " + this.currentUser;
                task_txbx.Text = "What are we selling today?";
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else
            {
                bind("");
                userName.Text = "Hello " + this.currentUser;
                task_txbx.Text = "What do you want to buy?";
                reciever_txbx.Visible = false;
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
            money_txbx.Text = "IDR " + bindAcc(this.currentUser).ToString();
        }
        public int bindAcc(string currentUser)
        {
            String cmd = "Select username, ballance from AccountInfo where username Like '" + currentUser + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow userInfo = dt.Rows[0];
            return (int)userInfo["ballance"];
        }
        public void bind(string currentUser)
        {

            DataTable dt = new DataTable();
            try
            {
                if (currentUser != "")
                {
                    String username;
                    username = currentUser;

                    string cmd1 = "Select * from ProductInfo where [From] Like '" + username + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd1, conn);
                    dt.Clear();
                    da.Fill(dt);
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("Select Name as Name, Ammount as Ammount, Price as Price, [From] as [From] from ProductInfo", conn);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd1;
                    dt.Clear();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SqlCommand cmd1 = new SqlCommand("Select Name as Name, Ammount as Ammount, Price as Price, [From] as [From] from ProductInfo", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
                dt.Clear();
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DISTURBING THE PEACE
            //LOOK INTO MY EYES
            #region

            #endregion
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (isSeller is false)
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                        product_txbx.Text = selectedRow.Cells["Name"].Value.ToString();
                        provider_txbx.Text = selectedRow.Cells["From"].Value.ToString();
                        ammount_nud.Maximum = (int)selectedRow.Cells["Ammount"].Value;
                    }
                    else
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                        productAdd_txbx.Text = selectedRow.Cells["Name"].Value.ToString();
                        ammountAdd_txbx.Value = (int)selectedRow.Cells["Ammount"].Value;
                        priceAdd_nud.Value = (int)selectedRow.Cells["Price"].Value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form2) == null)
            {
                Form2 OpenForm = new Form2(currentUser);
                OpenForm.Show();
                this.Close();
                this.Hide();
            }
        }

        private void task_txbx_Click(object sender, EventArgs e)
        {

        }

        private void money_txbx_Click(object sender, EventArgs e)
        {

        }

        private void product_txbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void reciever_txbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                reciever_txbx.Visible = false;
                label3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                reciever_txbx.Visible = true;
                label3.Visible = true;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String username;
                username = currentUser;

                DataTable dt = new DataTable();
                string cmd1 = "Select * from ProductInfo where Name Like '" + product_txbx.Text + "' and [From] Like '" + provider_txbx.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd1, conn);
                dt.Clear();
                da.Fill(dt);
                DataRow dr = dt.Rows[0];

                string productName = product_txbx.Text + "[By: " + dr["From"].ToString() + "]";
                int productAmmount = ((int)ammount_nud.Value);
                int productPrice = ((int)ammount_nud.Value * (int)dr["Price"]);
                string productProvider = dr["From"].ToString();
                string productNameRaw = dr["Name"].ToString();
                int? finder = null;
                for (int i = 0; i < recipt_dgv.Rows.Count; i++)
                {
                    if (recipt_dgv.Rows[i].Cells["Product"].Value.ToString() == productName)
                    {
                        finder = i;
                        break;
                    }
                }
                if (finder is not null)
                {
                    DataGridViewRow dt1 = recipt_dgv.Rows[(int)finder];
                    recipt_dgv.Rows.RemoveAt((int)finder);
                    recipt_dgv.Rows.Add(productName, productAmmount, productPrice, productProvider, productNameRaw);
                }
                else
                {
                    recipt_dgv.Rows.Add(productName, productAmmount, productPrice, productProvider, productNameRaw);
                }

                total_lbl.Text = "Total Price: IDR " + findPrice().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ammount_nud.Value = 1;
        }

        public int findPrice()
        {

            int price = 0;
            for (int i = 0; i < recipt_dgv.Rows.Count; i++)
            {
                if (recipt_dgv.Rows[i].Cells["Price"].Value is not null)
                {
                    price += (int)(recipt_dgv.Rows[i].Cells["Price"].Value);
                }
            }
            return price;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            recipt_dgv.Rows.Clear();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + remover.Cells["Product"].Value.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    recipt_dgv.Rows.Remove(remover);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ammount_nud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recipt_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            remover = recipt_dgv.Rows[e.RowIndex];
        }

        private void recipt_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                remover = recipt_dgv.Rows[e.RowIndex];
                product_txbx.Text = remover.Cells["Product_Raw"].Value.ToString();
                provider_txbx.Text = remover.Cells["From"].Value.ToString();
                ammount_nud.Value = (int)remover.Cells["Ammount"].Value;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {


            try
            {
                for (int i = 0; i < recipt_dgv.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("Update ProductInfo Set Ammount=@Ammount where Name=@Name", conn);
                    DataGridViewRow tempData1;
                    DataGridViewRow tempData2 = recipt_dgv.Rows[i];
                    int quantity;
                    string name = tempData2.Cells["Product_Raw"].Value.ToString();
                    int? finder = null;

                    if (bindAcc(currentUser) >= findPrice())
                    {

                        #region
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            tempData1 = dataGridView1.Rows[j];
                            if (tempData1.Cells["Name"].Value.ToString().Equals(name))
                            {
                                finder = j;
                                break;
                            }
                        }
                        tempData1 = dataGridView1.Rows[(int)finder];

                        quantity = (int)tempData1.Cells["Ammount"].Value - (int)tempData2.Cells["Ammount"].Value;

                        SqlCommand cmd5 = new SqlCommand("Update AccountInfo Set ballance=@ballance where username=@username", conn);
                        cmd5.Parameters.AddWithValue("username", tempData1.Cells["From"].Value.ToString() as string);
                        cmd5.Parameters.AddWithValue("ballance", bindAcc(tempData1.Cells["From"].Value.ToString()) + (int)tempData2.Cells["Price"].Value);
                        conn.Open();
                        cmd5.ExecuteNonQuery();
                        conn.Close();

                        if (quantity <= 0)
                        {
                            SqlCommand cmd2 = new SqlCommand("DELETE FROM ProductInfo WHERE Name = @Name", conn);
                            cmd2.Parameters.AddWithValue("Name", name);
                            conn.Open();
                            cmd2.ExecuteNonQuery();
                            conn.Close();

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("Name", name as string);
                            cmd.Parameters.AddWithValue("Ammount", quantity);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        #endregion
                    }
                }
                SqlCommand cmd4 = new SqlCommand("Update AccountInfo Set ballance=@ballance where username=@username", conn);
                cmd4.Parameters.AddWithValue("username", currentUser as string);
                cmd4.Parameters.AddWithValue("ballance", bindAcc(this.currentUser) - findPrice());
                conn.Open();
                cmd4.ExecuteNonQuery();
                conn.Close();
                bind("");
                money_txbx.Text = "IDR " + bindAcc(this.currentUser).ToString();

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(recipt_dgv.Width, recipt_dgv.Height);
            recipt_dgv.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 120);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void add2_btn_Click(object sender, EventArgs e)
        {
            if (productAdd_txbx.Text is not "")
            {
                string name = productAdd_txbx.Text;
                int ammount = (int)Math.Floor(ammountAdd_txbx.Value);
                int price = (int)Math.Floor(priceAdd_nud.Value);


                int? finder = null;
                for (int i = 0; i < seller_dgv.Rows.Count; i++)
                {
                    if (seller_dgv.Rows[i].Cells["ProductSell"].Value.ToString().Equals(name))
                    {
                        finder = i;
                        break;
                    }
                }
                if (finder is not null)
                {
                    DataGridViewRow dt1 = seller_dgv.Rows[(int)finder];
                    seller_dgv.Rows.Add(name, ammount, price);
                    seller_dgv.Rows.RemoveAt((int)finder);
                }
                else
                {
                    seller_dgv.Rows.Add(name, ammount, price);
                }
            }

        }

        private void remove2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (remover2 is not null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + remover2.Cells["ProductSell"].Value.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand cmd2 = new SqlCommand("DELETE FROM ProductInfo WHERE Name = @Name", conn);
                        string remover3 = remover2.Cells["ProductSell"].Value.ToString();
                        cmd2.Parameters.AddWithValue("Name", remover3);
                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        bind(this.currentUser);
                        seller_dgv.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void seller_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            remover2 = seller_dgv.Rows[e.RowIndex];
        }

        private void seller_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            remover2 = seller_dgv.Rows[e.RowIndex];
        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            seller_dgv.Rows.Clear();
        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow tempData1, tempData2;
            for (int i = 0; i < seller_dgv.Rows.Count; i++)
            {
                tempData2 = seller_dgv.Rows[i];
                int? finder = null;
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string param1 = dataGridView1.Rows[j].Cells["Name"].Value.ToString();
                    string param2 = tempData2.Cells["ProductSell"].Value.ToString();
                    if (param1.Equals(param2))
                    {
                        finder = j;
                        break;
                    }
                }
                if (finder is not null)
                {
                    tempData1 = dataGridView1.Rows[(int)finder];
                    int quantity = (int)tempData1.Cells["Ammount"].Value + (int)tempData2.Cells["AmmountSell"].Value;
                    tempData1.Cells["Ammount"].Value = quantity;
                    tempData1.Cells["Price"].Value = (int)tempData2.Cells["PriceSell"].Value;

                    SqlCommand cmd = new SqlCommand("Update ProductInfo Set Ammount=@Ammount, Price=@Price where Name=@Name", conn);
                    cmd.Parameters.AddWithValue("Name", tempData1.Cells["Name"].Value.ToString());
                    cmd.Parameters.AddWithValue("Ammount", tempData1.Cells["Ammount"].Value);
                    cmd.Parameters.AddWithValue("Price", tempData1.Cells["Price"].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    bind(currentUser);
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO ProductInfo(Name, Ammount, Price, [From]) VALUES (@Name, @Ammount, @Price, @From)", conn);
                    cmd2.Parameters.AddWithValue("Name", productAdd_txbx.Text);
                    cmd2.Parameters.AddWithValue("Ammount", ammountAdd_txbx.Value);
                    cmd2.Parameters.AddWithValue("Price", priceAdd_nud.Value);
                    cmd2.Parameters.AddWithValue("From", this.currentUser);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    bind(this.currentUser);
                }
            }

            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
