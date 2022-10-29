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
    public partial class frmLogin : Form
    {

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private Timer t;

        public frmLogin()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            StartTimer();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text != string.Empty || tbxUsername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + tbxUsername.Text + "' and password='" + tbxPassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    frmHome.usrname = tbxUsername.Text;
                    frmHome home = new frmHome();
                    home.ShowDialog();
                    
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            frmStart st = new frmStart();
            st.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show();
            this.Close();
        }

       
    }
}
