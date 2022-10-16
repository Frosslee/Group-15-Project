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
    public partial class frmHome : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        public static string usrname;
        private SqlConnection cn;
        private Timer t;

        public frmHome()
        {
            InitializeComponent();
            StartTimer();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();
            cmd = new SqlCommand("select level from LoginTable where username='" + usrname + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int level = Convert.ToInt32(dr[0]);
                if (level == 0)
                {
                 lblType.Text = "User";
                 lblType.ForeColor = Color.Turquoise;
                 lblUser.ForeColor = Color.Turquoise;
                }
                else
                {
                 lblType.Text = "Admin";
                 lblType.ForeColor = Color.Yellow;
                 lblUser.ForeColor = Color.Yellow;
                }
                
            }



             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }



        private void frmHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = usrname;
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
    }
}
