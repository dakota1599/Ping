namespace PingProject
{
    partial class PingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingApp));
            this.frequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.customLabel = new System.Windows.Forms.Label();
            this.usaLabel = new System.Windows.Forms.Label();
            this.googleLabel = new System.Windows.Forms.Label();
            this.usaActiveLabel = new System.Windows.Forms.Label();
            this.googleActiveLabel = new System.Windows.Forms.Label();
            this.customActiveLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.freqTimer = new System.Windows.Forms.Timer(this.components);
            this.pingCount = new System.Windows.Forms.Label();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frequencyTrackBar
            // 
            this.frequencyTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.frequencyTrackBar.Location = new System.Drawing.Point(5, 372);
            this.frequencyTrackBar.Maximum = 60;
            this.frequencyTrackBar.Minimum = 1;
            this.frequencyTrackBar.Name = "frequencyTrackBar";
            this.frequencyTrackBar.Size = new System.Drawing.Size(266, 69);
            this.frequencyTrackBar.TabIndex = 0;
            this.frequencyTrackBar.TickFrequency = 60;
            this.frequencyTrackBar.Value = 1;
            this.frequencyTrackBar.Scroll += new System.EventHandler(this.frequencyTrackBar_Scroll);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.ForeColor = System.Drawing.Color.White;
            this.frequencyLabel.Location = new System.Drawing.Point(65, 353);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(136, 18);
            this.frequencyLabel.TabIndex = 1;
            this.frequencyLabel.Text = "Frequency (1 Sec)";
            // 
            // ipBox
            // 
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.Location = new System.Drawing.Point(45, 183);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(110, 31);
            this.ipBox.TabIndex = 2;
            this.ipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel
            // 
            this.customLabel.AutoSize = true;
            this.customLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel.ForeColor = System.Drawing.Color.White;
            this.customLabel.Location = new System.Drawing.Point(47, 161);
            this.customLabel.Name = "customLabel";
            this.customLabel.Size = new System.Drawing.Size(107, 24);
            this.customLabel.TabIndex = 4;
            this.customLabel.Text = "Custom IP";
            // 
            // usaLabel
            // 
            this.usaLabel.AutoSize = true;
            this.usaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usaLabel.ForeColor = System.Drawing.Color.White;
            this.usaLabel.Location = new System.Drawing.Point(41, 264);
            this.usaLabel.Name = "usaLabel";
            this.usaLabel.Size = new System.Drawing.Size(115, 24);
            this.usaLabel.TabIndex = 5;
            this.usaLabel.Text = "Yahoo.com";
            // 
            // googleLabel
            // 
            this.googleLabel.AutoSize = true;
            this.googleLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleLabel.ForeColor = System.Drawing.Color.White;
            this.googleLabel.Location = new System.Drawing.Point(41, 225);
            this.googleLabel.Name = "googleLabel";
            this.googleLabel.Size = new System.Drawing.Size(124, 24);
            this.googleLabel.TabIndex = 6;
            this.googleLabel.Text = "Google.com";
            // 
            // usaActiveLabel
            // 
            this.usaActiveLabel.AutoSize = true;
            this.usaActiveLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usaActiveLabel.ForeColor = System.Drawing.Color.White;
            this.usaActiveLabel.Location = new System.Drawing.Point(161, 264);
            this.usaActiveLabel.Name = "usaActiveLabel";
            this.usaActiveLabel.Size = new System.Drawing.Size(97, 24);
            this.usaActiveLabel.TabIndex = 7;
            this.usaActiveLabel.Text = "(Inactive)";
            // 
            // googleActiveLabel
            // 
            this.googleActiveLabel.AutoSize = true;
            this.googleActiveLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleActiveLabel.ForeColor = System.Drawing.Color.White;
            this.googleActiveLabel.Location = new System.Drawing.Point(161, 225);
            this.googleActiveLabel.Name = "googleActiveLabel";
            this.googleActiveLabel.Size = new System.Drawing.Size(97, 24);
            this.googleActiveLabel.TabIndex = 8;
            this.googleActiveLabel.Text = "(Inactive)";
            // 
            // customActiveLabel
            // 
            this.customActiveLabel.AutoSize = true;
            this.customActiveLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customActiveLabel.ForeColor = System.Drawing.Color.White;
            this.customActiveLabel.Location = new System.Drawing.Point(161, 187);
            this.customActiveLabel.Name = "customActiveLabel";
            this.customActiveLabel.Size = new System.Drawing.Size(97, 24);
            this.customActiveLabel.TabIndex = 9;
            this.customActiveLabel.Text = "(Inactive)";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.startButton.Location = new System.Drawing.Point(5, 409);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(266, 40);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(719, 227);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(77, 40);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // freqTimer
            // 
            this.freqTimer.Tick += new System.EventHandler(this.repetition);
            // 
            // pingCount
            // 
            this.pingCount.AutoSize = true;
            this.pingCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingCount.ForeColor = System.Drawing.Color.White;
            this.pingCount.Location = new System.Drawing.Point(96, 317);
            this.pingCount.Name = "pingCount";
            this.pingCount.Size = new System.Drawing.Size(96, 24);
            this.pingCount.TabIndex = 12;
            this.pingCount.Text = "-- ping(s)";
            // 
            // clearLogButton
            // 
            this.clearLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.clearLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearLogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.clearLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.clearLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.clearLogButton.Location = new System.Drawing.Point(732, 455);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(92, 25);
            this.clearLogButton.TabIndex = 14;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = false;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // logListBox
            // 
            this.logListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.logListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logListBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 21;
            this.logListBox.Location = new System.Drawing.Point(280, 125);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(544, 315);
            this.logListBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PingProject.Properties.Resources.titleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(-334, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // saveLogButton
            // 
            this.saveLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.saveLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveLogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.saveLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.saveLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.saveLogButton.Location = new System.Drawing.Point(634, 455);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(92, 25);
            this.saveLogButton.TabIndex = 18;
            this.saveLogButton.Text = "Save Log";
            this.saveLogButton.UseVisualStyleBackColor = false;
            this.saveLogButton.Click += new System.EventHandler(this.saveLogButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(14, 25);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(149, 465);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 24);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Want an app?  Click Here!";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.copyrightLabel.Location = new System.Drawing.Point(13, 462);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(156, 20);
            this.copyrightLabel.TabIndex = 17;
            this.copyrightLabel.Text = "(c) Dakota Shapiro ||";
            // 
            // PingApp
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.pingCount);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.customActiveLabel);
            this.Controls.Add(this.googleActiveLabel);
            this.Controls.Add(this.usaActiveLabel);
            this.Controls.Add(this.googleLabel);
            this.Controls.Add(this.usaLabel);
            this.Controls.Add(this.customLabel);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.frequencyTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PingApp";
            this.Text = "Ping -- Version 2.1";
            this.Load += new System.EventHandler(this.PingApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar frequencyTrackBar;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label customLabel;
        private System.Windows.Forms.Label usaLabel;
        private System.Windows.Forms.Label googleLabel;
        private System.Windows.Forms.Label usaActiveLabel;
        private System.Windows.Forms.Label googleActiveLabel;
        private System.Windows.Forms.Label customActiveLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer freqTimer;
        private System.Windows.Forms.Label pingCount;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

