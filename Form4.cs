using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS_Desktop_2
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QNDK4VF9\\MSSQLSERVER05;Initial Catalog=myAssHurts;Integrated Security=True");
        string username;
        public Form4(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            String username, password;
            username = acc_txbx.Text;
            password = pass_txbx.Text;

            String cmd = "Select username, password, ballance from AccountInfo where username Like '" + username + "' AND password Like '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewRow accInfo = dataGridView1.Rows[0];
            int balence;
            try
            {
                balence = (int)accInfo.Cells["ballance"].Value;
                balence += (int)numericUpDown1.Value;

                SqlCommand cmd5 = new SqlCommand("Update AccountInfo Set ballance=@ballance where username=@username", conn);
                cmd5.Parameters.AddWithValue("username", accInfo.Cells["username"].Value as string);
                cmd5.Parameters.AddWithValue("ballance", balence);
                conn.Open();
                cmd5.ExecuteNonQuery();
                conn.Close();

                DialogResult dialogResult = MessageBox.Show("Money successfully inserted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                balence = 0;
                Console.WriteLine(ex.Message);

                DialogResult dialogResult = MessageBox.Show("Money failed to be inserted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            acc_txbx.Text = "";
            pass_txbx.Text = "";
            numericUpDown1.Value = 0;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form2) == null)
            {
                Form2 OpenForm = new Form2(this.username);
                OpenForm.Show();
                this.Close();
                this.Hide();
            }
        }
    }
}
