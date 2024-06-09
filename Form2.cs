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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QNDK4VF9\\MSSQLSERVER05;Initial Catalog=myAssHurts;Integrated Security=True");
        private string currentUser;
        public Form2(string currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            money_lbl.Text = "Your Balence: IDR " + bindAcc(this.currentUser);
            HelloUser_lbl.Text = "Hello " + this.currentUser;
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
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form3) == null)
            {
                Form3 OpenForm = new Form3(false, currentUser);
                OpenForm.Show();
                this.Hide();

            }
        }

        private void seller_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form3) == null)
            {
                Form3 OpenForm = new Form3(true, currentUser);
                OpenForm.Show();
                this.Hide();
            }
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form4) == null)
            {
                Form4 OpenForm = new Form4(currentUser);
                OpenForm.Show();
                this.Hide();
            }
        }

        private void money_lbl_Click(object sender, EventArgs e)
        {

        }

        private void HelloUser_lbl_Click(object sender, EventArgs e)
        {

        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form3"] as Form1) == null)
            {
                Form1 OpenForm = new Form1();
                OpenForm.Show();
                this.Hide();
            }
        }
    }
}
