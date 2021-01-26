namespace DegreeClock
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlClockDisplay = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlClockDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 67;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "TimeTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "TimeTextFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::DegreeClock.Properties.Settings.Default.TimeTextFont;
            this.label1.ForeColor = global::DegreeClock.Properties.Settings.Default.TimeTextColor;
            this.label1.Location = new System.Drawing.Point(2, 604);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "TimeTextFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "TimeTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::DegreeClock.Properties.Settings.Default.TimeTextFont;
            this.label2.ForeColor = global::DegreeClock.Properties.Settings.Default.TimeTextColor;
            this.label2.Location = new System.Drawing.Point(303, 604);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlClockDisplay
            // 
            this.pnlClockDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlClockDisplay.Controls.Add(this.pbClose);
            this.pnlClockDisplay.Controls.Add(this.label1);
            this.pnlClockDisplay.Controls.Add(this.label2);
            this.pnlClockDisplay.Controls.Add(this.pictureBox1);
            this.pnlClockDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClockDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlClockDisplay.Name = "pnlClockDisplay";
            this.pnlClockDisplay.Size = new System.Drawing.Size(651, 630);
            this.pnlClockDisplay.TabIndex = 2;
            this.pnlClockDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClockDisplay_Paint);
            this.pnlClockDisplay.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::DegreeClock.Properties.Resources.clock_remove_blue_extended_icons_set;
            this.pbClose.Location = new System.Drawing.Point(625, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(22, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Visible = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DegreeClock.Properties.Resources.Settings;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.chooseLocationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.ClientSize = new System.Drawing.Size(651, 630);
            this.Controls.Add(this.pnlClockDisplay);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Degree Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pnlClockDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel pnlClockDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

