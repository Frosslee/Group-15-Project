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

namespace Tello_Interface
{
    public partial class frmRegister : Form
    {
        public SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection cn;
        private DataTable dt;
        private Timer t;


        private void frmRegister_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        public frmRegister()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbxConfirmPassword.Text != string.Empty || tbxPassword.Text != string.Empty || tbxUsername.Text != string.Empty)
            {
                if (tbxPassword.Text == tbxConfirmPassword.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + tbxUsername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Register();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPassword.Clear(); 
                    tbxConfirmPassword.Clear();
                   
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       // Functions
        private void Register()
        {
            dr.Close();
            cmd = new SqlCommand("insert into LoginTable(username, password, level) values(@username,@password,@level)", cn);
            cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbxPassword.Text);
            if (cbUserType.Text == "Admin")
            {
                cmd.Parameters.AddWithValue("level", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("level", 0);
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin login = new frmLogin();
            tbxPassword.Clear();
            tbxConfirmPassword.Clear();
            login.Show();
            this.Close();
        }
    }
}
