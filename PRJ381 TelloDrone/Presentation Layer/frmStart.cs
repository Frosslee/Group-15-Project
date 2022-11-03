using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ381_TelloDrone.Presentation_Layer
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            StartTimer();

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
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }

        System.Windows.Forms.Timer t = null;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSession_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
