using System.Drawing;

namespace WindowsFormsApp2
{
    partial class HydroPod
    {
        Color sgreen = Color.FromArgb(141, 198, 63);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydroPod));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UVBar = new System.Windows.Forms.TrackBar();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.COMPORT = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.TempBar = new System.Windows.Forms.TrackBar();
            this.WaterBar = new System.Windows.Forms.TrackBar();
            this.TestTimer = new System.Windows.Forms.Timer(this.components);
            this.Header = new System.Windows.Forms.Label();
            this.onoff = new System.Windows.Forms.Button();
            this.HumidBar = new System.Windows.Forms.TrackBar();
            this.PortListener = new System.IO.Ports.SerialPort(this.components);
            this.WaterLabel = new System.Windows.Forms.Label();
            this.HumidLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.UVlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UVBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UVBar
            // 
            this.UVBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UVBar.LargeChange = 4;
            this.UVBar.Location = new System.Drawing.Point(586, 81);
            this.UVBar.Maximum = 20;
            this.UVBar.Name = "UVBar";
            this.UVBar.Size = new System.Drawing.Size(260, 45);
            this.UVBar.TabIndex = 1;
            this.UVBar.Value = 10;
            this.UVBar.ValueChanged += new System.EventHandler(this.UVBar_ValueChanged);
            // 
            // buttonOn
            // 
            this.buttonOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOn.Location = new System.Drawing.Point(880, 396);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(10, 10);
            this.buttonOn.TabIndex = 2;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Visible = false;
            // 
            // buttonOff
            // 
            this.buttonOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOff.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOff.Location = new System.Drawing.Point(880, 412);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(10, 10);
            this.buttonOff.TabIndex = 3;
            this.buttonOff.Text = "Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Visible = false;
            // 
            // COMPORT
            // 
            this.COMPORT.BackColor = System.Drawing.Color.White;
            this.COMPORT.DropDownHeight = 150;
            this.COMPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPORT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COMPORT.FormattingEnabled = true;
            this.COMPORT.IntegralHeight = false;
            this.COMPORT.ItemHeight = 13;
            this.COMPORT.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.COMPORT.Location = new System.Drawing.Point(769, 11);
            this.COMPORT.Name = "COMPORT";
            this.COMPORT.Size = new System.Drawing.Size(121, 21);
            this.COMPORT.TabIndex = 4;
            this.COMPORT.TextChanged += new System.EventHandler(this.COMPORT_TextChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PortLabel.Location = new System.Drawing.Point(726, 11);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(42, 20);
            this.PortLabel.TabIndex = 5;
            this.PortLabel.Text = "Port:";
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(725, 35);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(161, 20);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.UseMnemonic = false;
            // 
            // TempBar
            // 
            this.TempBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TempBar.LargeChange = 4;
            this.TempBar.Location = new System.Drawing.Point(203, 81);
            this.TempBar.Maximum = 20;
            this.TempBar.Name = "TempBar";
            this.TempBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TempBar.Size = new System.Drawing.Size(45, 260);
            this.TempBar.TabIndex = 7;
            this.TempBar.Value = 10;
            this.TempBar.ValueChanged += new System.EventHandler(this.TempBar_ValueChanged);
            // 
            // WaterBar
            // 
            this.WaterBar.BackColor = System.Drawing.SystemColors.Window;
            this.WaterBar.LargeChange = 4;
            this.WaterBar.Location = new System.Drawing.Point(16, 81);
            this.WaterBar.Maximum = 20;
            this.WaterBar.Name = "WaterBar";
            this.WaterBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.WaterBar.Size = new System.Drawing.Size(45, 260);
            this.WaterBar.TabIndex = 9;
            this.WaterBar.Value = 10;
            this.WaterBar.ValueChanged += new System.EventHandler(this.WaterBar_ValueChanged);
            // 
            // TestTimer
            // 
            this.TestTimer.Enabled = true;
            this.TestTimer.Interval = 5000;
            this.TestTimer.Tick += new System.EventHandler(this.TestTimer_Tick);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Header.Location = new System.Drawing.Point(4, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(270, 51);
            this.Header.TabIndex = 10;
            this.Header.Text = "HYDROPOD";
            // 
            // onoff
            // 
            this.onoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onoff.BackgroundImage")));
            this.onoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.onoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onoff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onoff.Location = new System.Drawing.Point(12, 493);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(49, 28);
            this.onoff.TabIndex = 11;
            this.onoff.UseVisualStyleBackColor = true;
            this.onoff.Click += new System.EventHandler(this.onoff_Click);
            // 
            // HumidBar
            // 
            this.HumidBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HumidBar.LargeChange = 4;
            this.HumidBar.Location = new System.Drawing.Point(109, 81);
            this.HumidBar.Maximum = 20;
            this.HumidBar.Name = "HumidBar";
            this.HumidBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.HumidBar.Size = new System.Drawing.Size(45, 260);
            this.HumidBar.TabIndex = 12;
            this.HumidBar.Value = 10;
            // 
            // PortListener
            // 
            this.PortListener.PortName = "COM3";
            // 
            // WaterLabel
            // 
            this.WaterLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WaterLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterLabel.Location = new System.Drawing.Point(12, 344);
            this.WaterLabel.Name = "WaterLabel";
            this.WaterLabel.Size = new System.Drawing.Size(90, 20);
            this.WaterLabel.TabIndex = 14;
            this.WaterLabel.Text = "WaterLevel";
            // 
            // HumidLabel
            // 
            this.HumidLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HumidLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidLabel.Location = new System.Drawing.Point(105, 344);
            this.HumidLabel.Name = "HumidLabel";
            this.HumidLabel.Size = new System.Drawing.Size(90, 20);
            this.HumidLabel.TabIndex = 15;
            this.HumidLabel.Text = "Humidity";
            // 
            // TempLabel
            // 
            this.TempLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TempLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.Location = new System.Drawing.Point(199, 344);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(90, 20);
            this.TempLabel.TabIndex = 17;
            this.TempLabel.Text = "Temprature";
            // 
            // UVlabel
            // 
            this.UVlabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UVlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UVlabel.Location = new System.Drawing.Point(583, 115);
            this.UVlabel.Name = "UVlabel";
            this.UVlabel.Size = new System.Drawing.Size(264, 20);
            this.UVlabel.TabIndex = 18;
            this.UVlabel.Text = "UV Light Slider";
            this.UVlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(852, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "On / Off";
            // 
            // HydroPod
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(899, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UVlabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.HumidLabel);
            this.Controls.Add(this.WaterLabel);
            this.Controls.Add(this.HumidBar);
            this.Controls.Add(this.onoff);
            this.Controls.Add(this.COMPORT);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.WaterBar);
            this.Controls.Add(this.TempBar);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.UVBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(915, 587);
            this.MinimumSize = new System.Drawing.Size(915, 587);
            this.Name = "HydroPod";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UVBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar UVBar;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.ComboBox COMPORT;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TrackBar TempBar;
        private System.Windows.Forms.TrackBar WaterBar;
        private System.Windows.Forms.Timer TestTimer;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button onoff;
        private System.Windows.Forms.TrackBar HumidBar;
        private System.IO.Ports.SerialPort PortListener;
        private System.Windows.Forms.Label WaterLabel;
        private System.Windows.Forms.Label HumidLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label UVlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

