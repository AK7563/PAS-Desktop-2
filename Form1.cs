using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS_Desktop_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QNDK4VF9\\MSSQLSERVER05;Initial Catalog=myAssHurts;Integrated Security=True");
        private void search_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select idNum, firstName As firstName, lastName As lastName, grade from Table_1", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            String username, password;
            username = username_txbx.Text;
            password = password_txbx.Text;

            String cmd = "Select username, password from AccountInfo where username Like '" + username + "' AND password Like '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if ((Application.OpenForms["Form3"] as Form2) == null)
                {
                    Form2 OpenForm = new Form2(username);
                    OpenForm.Show();
                    this.Hide();
                }
            }
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            String search = "Select username, password from AccountInfo where username Like '" + username_txbx.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                SqlCommand cmd = new SqlCommand("Insert Into AccountInfo(username, password, ballance) Values (@username, @password, @ballance)", conn);
                cmd.Parameters.AddWithValue("username", username_txbx.Text);
                cmd.Parameters.AddWithValue("password", password_txbx.Text);
                cmd.Parameters.AddWithValue("ballance", 50000);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if ((Application.OpenForms["Form3"] as Form2) == null)
            {
                Form2 OpenForm = new Form2(username_txbx.Text);
                OpenForm.Show();
                this.Hide();
            }
        }
    }
}