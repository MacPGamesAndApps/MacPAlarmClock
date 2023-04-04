namespace MacPAlarmClock
{
    partial class frmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.picAlarmOff = new System.Windows.Forms.PictureBox();
            this.picAlarmOn = new System.Windows.Forms.PictureBox();
            this.dtpAlarm = new System.Windows.Forms.DateTimePicker();
            this.picFireworks = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picVolumeOff = new System.Windows.Forms.PictureBox();
            this.picVolumeOn = new System.Windows.Forms.PictureBox();
            this.picAlarmIcon = new System.Windows.Forms.PictureBox();
            this.picHourlyChime = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFireworks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHourlyChime)).BeginInit();
            this.SuspendLayout();
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Image = global::MacPAlarmClock.Properties.Resources.share_icon;
            this.picMinimize.Location = new System.Drawing.Point(328, 77);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 31);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::MacPAlarmClock.Properties.Resources.button_160595_640;
            this.picExit.Location = new System.Drawing.Point(74, 32);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(24, 26);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picBoard
            // 
            this.picBoard.BackColor = System.Drawing.Color.Transparent;
            this.picBoard.Image = global::MacPAlarmClock.Properties.Resources.blank_hanging_sign_png_4;
            this.picBoard.Location = new System.Drawing.Point(89, 60);
            this.picBoard.Margin = new System.Windows.Forms.Padding(2);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(220, 207);
            this.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoard.TabIndex = 2;
            this.picBoard.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTime.Location = new System.Drawing.Point(150, 208);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 27);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "10:20:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.BackColor = System.Drawing.Color.BurlyWood;
            this.lblAlarmTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlarmTime.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmTime.ForeColor = System.Drawing.Color.LightGreen;
            this.lblAlarmTime.Location = new System.Drawing.Point(125, 141);
            this.lblAlarmTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(93, 27);
            this.lblAlarmTime.TabIndex = 5;
            this.lblAlarmTime.Text = "10:20";
            this.lblAlarmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarmTime.Click += new System.EventHandler(this.lblAlarmTime_Click);
            // 
            // picAlarmOff
            // 
            this.picAlarmOff.BackColor = System.Drawing.Color.Transparent;
            this.picAlarmOff.Image = global::MacPAlarmClock.Properties.Resources.red_circle_no_background_svg_thumb;
            this.picAlarmOff.Location = new System.Drawing.Point(44, 319);
            this.picAlarmOff.Margin = new System.Windows.Forms.Padding(2);
            this.picAlarmOff.Name = "picAlarmOff";
            this.picAlarmOff.Size = new System.Drawing.Size(22, 25);
            this.picAlarmOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmOff.TabIndex = 6;
            this.picAlarmOff.TabStop = false;
            this.picAlarmOff.Click += new System.EventHandler(this.picAlarmOff_Click);
            // 
            // picAlarmOn
            // 
            this.picAlarmOn.BackColor = System.Drawing.Color.Transparent;
            this.picAlarmOn.Image = global::MacPAlarmClock.Properties.Resources._1194984775760075334button_green_benji_park_01_svg_thumb;
            this.picAlarmOn.Location = new System.Drawing.Point(44, 318);
            this.picAlarmOn.Margin = new System.Windows.Forms.Padding(2);
            this.picAlarmOn.Name = "picAlarmOn";
            this.picAlarmOn.Size = new System.Drawing.Size(22, 25);
            this.picAlarmOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmOn.TabIndex = 7;
            this.picAlarmOn.TabStop = false;
            this.picAlarmOn.Visible = false;
            this.picAlarmOn.Click += new System.EventHandler(this.picAlarmOn_Click);
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.CustomFormat = "HH :mm";
            this.dtpAlarm.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold);
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlarm.Location = new System.Drawing.Point(125, 141);
            this.dtpAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAlarm.MinDate = new System.DateTime(1753, 2, 10, 0, 0, 0, 0);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.ShowUpDown = true;
            this.dtpAlarm.Size = new System.Drawing.Size(106, 31);
            this.dtpAlarm.TabIndex = 8;
            this.dtpAlarm.Visible = false;
            this.dtpAlarm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpAlarm_KeyUp);
            // 
            // picFireworks
            // 
            this.picFireworks.Image = global::MacPAlarmClock.Properties.Resources.FireworksPompom4_gif_c200;
            this.picFireworks.Location = new System.Drawing.Point(394, 24);
            this.picFireworks.Margin = new System.Windows.Forms.Padding(2);
            this.picFireworks.Name = "picFireworks";
            this.picFireworks.Size = new System.Drawing.Size(145, 147);
            this.picFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFireworks.TabIndex = 9;
            this.picFireworks.TabStop = false;
            this.picFireworks.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume On";
            // 
            // picVolumeOff
            // 
            this.picVolumeOff.BackColor = System.Drawing.Color.BurlyWood;
            this.picVolumeOff.Image = global::MacPAlarmClock.Properties.Resources.red_circle_no_background_svg_thumb;
            this.picVolumeOff.Location = new System.Drawing.Point(235, 179);
            this.picVolumeOff.Margin = new System.Windows.Forms.Padding(2);
            this.picVolumeOff.Name = "picVolumeOff";
            this.picVolumeOff.Size = new System.Drawing.Size(20, 20);
            this.picVolumeOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVolumeOff.TabIndex = 11;
            this.picVolumeOff.TabStop = false;
            this.picVolumeOff.Click += new System.EventHandler(this.picVolumeOff_Click);
            // 
            // picVolumeOn
            // 
            this.picVolumeOn.BackColor = System.Drawing.Color.BurlyWood;
            this.picVolumeOn.Image = global::MacPAlarmClock.Properties.Resources._1194984775760075334button_green_benji_park_01_svg_thumb;
            this.picVolumeOn.Location = new System.Drawing.Point(235, 179);
            this.picVolumeOn.Margin = new System.Windows.Forms.Padding(2);
            this.picVolumeOn.Name = "picVolumeOn";
            this.picVolumeOn.Size = new System.Drawing.Size(20, 20);
            this.picVolumeOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVolumeOn.TabIndex = 12;
            this.picVolumeOn.TabStop = false;
            this.picVolumeOn.Visible = false;
            this.picVolumeOn.Click += new System.EventHandler(this.picVolumeOn_Click);
            // 
            // picAlarmIcon
            // 
            this.picAlarmIcon.BackColor = System.Drawing.Color.BurlyWood;
            this.picAlarmIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAlarmIcon.Image = global::MacPAlarmClock.Properties.Resources.alarm_bell_icon_4;
            this.picAlarmIcon.Location = new System.Drawing.Point(97, 141);
            this.picAlarmIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picAlarmIcon.Name = "picAlarmIcon";
            this.picAlarmIcon.Size = new System.Drawing.Size(28, 27);
            this.picAlarmIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlarmIcon.TabIndex = 13;
            this.picAlarmIcon.TabStop = false;
            this.picAlarmIcon.Visible = false;
            // 
            // picHourlyChime
            // 
            this.picHourlyChime.BackColor = System.Drawing.Color.Transparent;
            this.picHourlyChime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHourlyChime.Image = global::MacPAlarmClock.Properties.Resources.HourlyChime;
            this.picHourlyChime.Location = new System.Drawing.Point(125, 208);
            this.picHourlyChime.Margin = new System.Windows.Forms.Padding(2);
            this.picHourlyChime.Name = "picHourlyChime";
            this.picHourlyChime.Size = new System.Drawing.Size(24, 27);
            this.picHourlyChime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHourlyChime.TabIndex = 14;
            this.picHourlyChime.TabStop = false;
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MacPAlarmClock.Properties.Resources.clockImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 662);
            this.Controls.Add(this.picHourlyChime);
            this.Controls.Add(this.picAlarmIcon);
            this.Controls.Add(this.picVolumeOff);
            this.Controls.Add(this.picVolumeOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFireworks);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.dtpAlarm);
            this.Controls.Add(this.picAlarmOff);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picBoard);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picAlarmOn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClock";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFireworks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlarmIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHourlyChime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.PictureBox picAlarmOff;
        private System.Windows.Forms.PictureBox picAlarmOn;
        private System.Windows.Forms.DateTimePicker dtpAlarm;
        private System.Windows.Forms.PictureBox picFireworks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picVolumeOff;
        private System.Windows.Forms.PictureBox picVolumeOn;
        private System.Windows.Forms.PictureBox picAlarmIcon;
        private System.Windows.Forms.PictureBox picHourlyChime;
    }
}

