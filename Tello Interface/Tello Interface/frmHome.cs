using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Tello_Interface
{
    public partial class frmHome : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public static string usrname;
        private SqlConnection cn;
        private Timer t;

        public frmHome()
        {
            StartPosition = FormStartPosition.CenterScreen;
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
            lblcnt.Hide();
            lblconnctd.Hide();
            rtbPython.Enabled = true;
            lblUser.Text = usrname;
            btnEnd.Hide();
            rtbPython.Hide();
            
            
            // video feed
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamerabox.Items.Add(filterInfo.Name);
                cbCamerabox.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
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

        private void btnFly_Click(object sender, EventArgs e)
        {
            btnEnd.Show();
            lbldisco.Hide();
            rtbPython.Show();
            rtbPython.AppendText("\r\n" + "Attempting to connect to python tello app...");
            using (NamedPipeClientStream pipeClient =
               new NamedPipeClientStream(".", "CSServer", PipeDirection.InOut))
            {
                // Connect to the pipe or wait until the pipe is available.
                pipeClient.Connect();
                lblconnctd.Show();
                rtbPython.AppendText("\r\n" + "Connected to tello.");
                StreamWriter sw = new StreamWriter(pipeClient);
                StreamReader sr = new StreamReader(pipeClient);  
                    sw.AutoFlush = true;
                    //  Console.WriteLine("Received: " + temp);
                    string temp = sr.ReadLine();
                    rtbPython.AppendText("\r\n" + temp);
                    // Console.ReadLine()
                    sw.WriteLine("takeoff");

            }

        }

        private void run_py()
        {

            string fileName = @"C:\Users\dayzd\OneDrive - belgiumcampus.ac.za\Belgium Campus Folder\Tello-Login-Python-v.02\Tello31.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Python310\python.exe", fileName)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };
            p.Start();

        }


      

        private void btnEnd_Click(object sender, EventArgs e)
        {
            
            frmHome home = new frmHome();
            home.Show();
            this.Close();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgpCamFeed_Click(object sender, EventArgs e)
        {

        }
    }
}
