namespace PRJ381_TelloDrone.Presentation_Layer
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgpCamFeed = new System.Windows.Forms.PictureBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cbCamerabox = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbldisco = new System.Windows.Forms.Label();
            this.lblconnctd = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbPython = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcnt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgpCamFeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1240, 571);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 53;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1240, 522);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 52;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgpCamFeed
            // 
            this.imgpCamFeed.Location = new System.Drawing.Point(924, 137);
            this.imgpCamFeed.Name = "imgpCamFeed";
            this.imgpCamFeed.Size = new System.Drawing.Size(706, 378);
            this.imgpCamFeed.TabIndex = 51;
            this.imgpCamFeed.TabStop = false;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCamera.Location = new System.Drawing.Point(1086, 98);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(55, 16);
            this.lblCamera.TabIndex = 50;
            this.lblCamera.Text = "Camera";
            // 
            // cbCamerabox
            // 
            this.cbCamerabox.FormattingEnabled = true;
            this.cbCamerabox.Location = new System.Drawing.Point(1159, 95);
            this.cbCamerabox.Name = "cbCamerabox";
            this.cbCamerabox.Size = new System.Drawing.Size(321, 24);
            this.cbCamerabox.TabIndex = 49;
           // this.cbCamerabox.SelectedIndexChanged += new System.EventHandler(this.cbCamerabox_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(642, 98);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 48;
            this.button8.Text = "Flip";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(495, 98);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 47;
            this.button7.Text = "Land";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(46, 98);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 46;
            this.button6.Text = "Takeoff";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1575, 584);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 28);
            this.button5.TabIndex = 45;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1533, 584);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 28);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1490, 584);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1533, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(186, 98);
            this.btnFly.Margin = new System.Windows.Forms.Padding(4);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(100, 28);
            this.btnFly.TabIndex = 39;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(348, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tello Command Center";
            // 
            // lbldisco
            // 
            this.lbldisco.AutoSize = true;
            this.lbldisco.Location = new System.Drawing.Point(978, 13);
            this.lbldisco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisco.Name = "lbldisco";
            this.lbldisco.Size = new System.Drawing.Size(90, 16);
            this.lbldisco.TabIndex = 21;
            this.lbldisco.Text = "Disconnected";
            // 
            // lblconnctd
            // 
            this.lblconnctd.AutoSize = true;
            this.lblconnctd.Location = new System.Drawing.Point(978, 13);
            this.lblconnctd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconnctd.Name = "lblconnctd";
            this.lblconnctd.Size = new System.Drawing.Size(72, 16);
            this.lblconnctd.TabIndex = 20;
            this.lblconnctd.Text = "Connected";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1544, 5);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // rtbPython
            // 
            this.rtbPython.Location = new System.Drawing.Point(34, 163);
            this.rtbPython.Margin = new System.Windows.Forms.Padding(4);
            this.rtbPython.Name = "rtbPython";
            this.rtbPython.Size = new System.Drawing.Size(708, 481);
            this.rtbPython.TabIndex = 40;
            this.rtbPython.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbldisco);
            this.panel1.Controls.Add(this.lblconnctd);
            this.panel1.Controls.Add(this.lblcnt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 36);
            this.panel1.TabIndex = 37;
            // 
            // lblcnt
            // 
            this.lblcnt.AutoSize = true;
            this.lblcnt.Location = new System.Drawing.Point(457, 11);
            this.lblcnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcnt.Name = "lblcnt";
            this.lblcnt.Size = new System.Drawing.Size(83, 16);
            this.lblcnt.TabIndex = 19;
            this.lblcnt.Text = "Connecting...";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(4, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(300, 5);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(92, 24);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "UserType";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(97, 5);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 24);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(338, 98);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 28);
            this.btnEnd.TabIndex = 41;
            this.btnEnd.Text = "End Flight";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1733, 751);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgpCamFeed);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.cbCamerabox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbPython);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.imgpCamFeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgpCamFeed;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cbCamerabox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldisco;
        private System.Windows.Forms.Label lblconnctd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbPython;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcnt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnEnd;
    }
}