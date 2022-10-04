namespace Tello_Interface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFly = new System.Windows.Forms.Button();
            this.rtbPython = new System.Windows.Forms.RichTextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblcnt = new System.Windows.Forms.Label();
            this.lblconnctd = new System.Windows.Forms.Label();
            this.lbldisco = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 29);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(225, 4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 18);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "UserType";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(73, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(680, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(251, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tello Command Center";
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(585, 35);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(75, 23);
            this.btnFly.TabIndex = 18;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // rtbPython
            // 
            this.rtbPython.Location = new System.Drawing.Point(228, 114);
            this.rtbPython.Name = "rtbPython";
            this.rtbPython.Size = new System.Drawing.Size(349, 199);
            this.rtbPython.TabIndex = 19;
            this.rtbPython.Text = "";
            this.rtbPython.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(683, 35);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 20;
            this.btnEnd.Text = "End Flight";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblcnt
            // 
            this.lblcnt.AutoSize = true;
            this.lblcnt.Location = new System.Drawing.Point(343, 9);
            this.lblcnt.Name = "lblcnt";
            this.lblcnt.Size = new System.Drawing.Size(70, 13);
            this.lblcnt.TabIndex = 19;
            this.lblcnt.Text = "Connecting...";
            // 
            // lblconnctd
            // 
            this.lblconnctd.AutoSize = true;
            this.lblconnctd.Location = new System.Drawing.Point(343, 9);
            this.lblconnctd.Name = "lblconnctd";
            this.lblconnctd.Size = new System.Drawing.Size(59, 13);
            this.lblconnctd.TabIndex = 20;
            this.lblconnctd.Text = "Connected";
            // 
            // lbldisco
            // 
            this.lbldisco.AutoSize = true;
            this.lbldisco.Location = new System.Drawing.Point(343, 9);
            this.lbldisco.Name = "lbldisco";
            this.lbldisco.Size = new System.Drawing.Size(73, 13);
            this.lbldisco.TabIndex = 21;
            this.lbldisco.Text = "Disconnected";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.rtbPython);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.RichTextBox rtbPython;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblconnctd;
        private System.Windows.Forms.Label lblcnt;
        private System.Windows.Forms.Label lbldisco;
    }
}