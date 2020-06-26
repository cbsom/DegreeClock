namespace DegreeClock
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cmbDegTimeLabelFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTitleBarFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRegTimeLabelFormat = new System.Windows.Forms.ComboBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(727, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(815, 642);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the location closest to you. \r\nNeeded to determine the correct sunrise and" +
    " sunset times.";
            // 
            // fontDialog1
            // 
            this.fontDialog1.FontMustExist = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button12.Location = new System.Drawing.Point(12, 642);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(164, 28);
            this.button12.TabIndex = 16;
            this.button12.Text = "Reset to Defaults";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(693, 386);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 21);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // cmbDegTimeLabelFormat
            // 
            this.cmbDegTimeLabelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDegTimeLabelFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbDegTimeLabelFormat.FormattingEnabled = true;
            this.cmbDegTimeLabelFormat.Items.AddRange(new object[] {
            "DegTime - Time Notation (128:05:44)",
            "DegTime - Degree Notation (128° 5′ 44″)",
            "DegTime - Short Degree Notation (128° 5′)",
            "None"});
            this.cmbDegTimeLabelFormat.Location = new System.Drawing.Point(96, 497);
            this.cmbDegTimeLabelFormat.Name = "cmbDegTimeLabelFormat";
            this.cmbDegTimeLabelFormat.Size = new System.Drawing.Size(318, 24);
            this.cmbDegTimeLabelFormat.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "DegTime label format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Title bar format:";
            // 
            // cmbTitleBarFormat
            // 
            this.cmbTitleBarFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitleBarFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbTitleBarFormat.FormattingEnabled = true;
            this.cmbTitleBarFormat.Items.AddRange(new object[] {
            "DegTime - Time Notation (128:05:44)",
            "DegTime - Long Notation (128° 5′ 44″)",
            "DegTime - Short Degree Notation (128° 5′)",
            "RegTime - Long Time (12:51:32 AM)",
            "RegTime - Short Time (12:51 AM)",
            "RegTime - Long 24 Hour (00:51:32)",
            "RegTime - Short 24 Hour (00:51)",
            "None"});
            this.cmbTitleBarFormat.Location = new System.Drawing.Point(498, 591);
            this.cmbTitleBarFormat.Name = "cmbTitleBarFormat";
            this.cmbTitleBarFormat.Size = new System.Drawing.Size(318, 24);
            this.cmbTitleBarFormat.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "RegTime label format:";
            // 
            // cmbRegTimeLabelFormat
            // 
            this.cmbRegTimeLabelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegTimeLabelFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbRegTimeLabelFormat.FormattingEnabled = true;
            this.cmbRegTimeLabelFormat.Items.AddRange(new object[] {
            "RegTime - Long Time (12:51:32 AM)",
            "RegTime - Short Time (12:51 AM)",
            "RegTime - Long 24 Hour (00:51:32)",
            "RegTime - Short 24 Hour (00:51)",
            "None"});
            this.cmbRegTimeLabelFormat.Location = new System.Drawing.Point(498, 497);
            this.cmbRegTimeLabelFormat.Name = "cmbRegTimeLabelFormat";
            this.cmbRegTimeLabelFormat.Size = new System.Drawing.Size(318, 24);
            this.cmbRegTimeLabelFormat.TabIndex = 37;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = global::DegreeClock.Properties.Settings.Default.HideWindowBorder;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "HideWindowBorder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox10.Location = new System.Drawing.Point(96, 579);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(158, 21);
            this.checkBox10.TabIndex = 40;
            this.checkBox10.Text = "Hide Window border";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = global::DegreeClock.Properties.Settings.Default.ShowDegreeLines;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowDegreeLines", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox9.Location = new System.Drawing.Point(469, 440);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(279, 21);
            this.checkBox9.TabIndex = 39;
            this.checkBox9.Text = "Show the degree lines around the clock";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = global::DegreeClock.Properties.Settings.Default.ShowWordsRegTime;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowWordsRegTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox11.Location = new System.Drawing.Point(498, 534);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(291, 21);
            this.checkBox11.TabIndex = 32;
            this.checkBox11.Text = "Show words \"RegTime\" on RegTime label";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = global::DegreeClock.Properties.Settings.Default.ShowWordsDegTime;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowWordsDegTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox12.Location = new System.Drawing.Point(96, 534);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(295, 21);
            this.checkBox12.TabIndex = 31;
            this.checkBox12.Text = "Show  words \"DegTime\" on DegTime label";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = global::DegreeClock.Properties.Settings.Default.ShowDegreeNumbers;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowDegreeNumbers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox8.Location = new System.Drawing.Point(160, 440);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(305, 21);
            this.checkBox8.TabIndex = 28;
            this.checkBox8.Text = "Show the degree numbers around the clock";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = global::DegreeClock.Properties.Settings.Default.ShowCurrentTimeMinutes;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowCurrentTimeMinutes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox7.Location = new System.Drawing.Point(239, 413);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(305, 21);
            this.checkBox7.TabIndex = 27;
            this.checkBox7.Text = "Show regular time minutes around the clock";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = global::DegreeClock.Properties.Settings.Default.ShowCurrentTimeLine;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowCurrentTimeLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.Location = new System.Drawing.Point(558, 386);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(246, 21);
            this.checkBox6.TabIndex = 26;
            this.checkBox6.Text = "Show line on clock for current time";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = global::DegreeClock.Properties.Settings.Default.ShowCurrentTimeFill;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowCurrentTimeFill", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.Location = new System.Drawing.Point(558, 413);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(323, 21);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.Text = "Lightly shade the area on clock of time passed";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::DegreeClock.Properties.Settings.Default.ShowNight;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowNight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(59, 413);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(175, 21);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Show nightime shading";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::DegreeClock.Properties.Settings.Default.ShowCurrentTime;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowCurrentTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(239, 386);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(311, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Show regular time numbers around the clock";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::DegreeClock.Properties.Settings.Default.ShowDay;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DegreeClock.Properties.Settings.Default, "ShowDay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(59, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show daytime shading";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.SettingChanged);
            // 
            // button16
            // 
            this.button16.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button16.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button16.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "ClockHoursFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button16.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "ClockHoursColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = global::DegreeClock.Properties.Settings.Default.ClockHoursFont;
            this.button16.ForeColor = global::DegreeClock.Properties.Settings.Default.ClockHoursColor;
            this.button16.Location = new System.Drawing.Point(59, 280);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(264, 39);
            this.button16.TabIndex = 20;
            this.button16.Text = "Clock Hours Font";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.FontChanged += new System.EventHandler(this.SettingChanged);
            this.button16.Click += new System.EventHandler(this.ChooseFont);
            // 
            // button15
            // 
            this.button15.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button15.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button15.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "ClockNumbersFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button15.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "ClockNumbersColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = global::DegreeClock.Properties.Settings.Default.ClockNumbersFont;
            this.button15.ForeColor = global::DegreeClock.Properties.Settings.Default.ClockNumbersColor;
            this.button15.Location = new System.Drawing.Point(589, 280);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(264, 39);
            this.button15.TabIndex = 19;
            this.button15.Text = "Clock Numbers Font";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.FontChanged += new System.EventHandler(this.SettingChanged);
            this.button15.Click += new System.EventHandler(this.ChooseFont);
            // 
            // button14
            // 
            this.button14.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button14.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button14.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "ClockHoursColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button14.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "ClockHoursFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = global::DegreeClock.Properties.Settings.Default.ClockHoursFont;
            this.button14.ForeColor = global::DegreeClock.Properties.Settings.Default.ClockHoursColor;
            this.button14.Location = new System.Drawing.Point(440, 223);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(264, 39);
            this.button14.TabIndex = 18;
            this.button14.Text = "Clock Hours  Color";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button13
            // 
            this.button13.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button13.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button13.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "ClockNumbersFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button13.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "ClockNumbersColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = global::DegreeClock.Properties.Settings.Default.ClockNumbersFont;
            this.button13.ForeColor = global::DegreeClock.Properties.Settings.Default.ClockNumbersColor;
            this.button13.Location = new System.Drawing.Point(174, 223);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(264, 39);
            this.button13.TabIndex = 17;
            this.button13.Text = "Clock Numbers  Color";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button11
            // 
            this.button11.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button11.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button11.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "DegreeNumbersFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button11.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "DegreeNumbersColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = global::DegreeClock.Properties.Settings.Default.DegreeNumbersFont;
            this.button11.ForeColor = global::DegreeClock.Properties.Settings.Default.DegreeNumbersColor;
            this.button11.Location = new System.Drawing.Point(324, 280);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(264, 39);
            this.button11.TabIndex = 14;
            this.button11.Text = "Degree Numbers Font";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.FontChanged += new System.EventHandler(this.SettingChanged);
            this.button11.Click += new System.EventHandler(this.ChooseFont);
            // 
            // button10
            // 
            this.button10.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button10.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "TimeTextFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button10.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "TimeTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button10.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = global::DegreeClock.Properties.Settings.Default.TimeTextFont;
            this.button10.ForeColor = global::DegreeClock.Properties.Settings.Default.TimeTextColor;
            this.button10.Location = new System.Drawing.Point(324, 321);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(264, 39);
            this.button10.TabIndex = 13;
            this.button10.Text = "Current Time Font";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.FontChanged += new System.EventHandler(this.SettingChanged);
            this.button10.Click += new System.EventHandler(this.ChooseFont);
            // 
            // button9
            // 
            this.button9.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button9.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button9.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "CurrentDegreeNumberColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button9.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "DegreeNumbersFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = global::DegreeClock.Properties.Settings.Default.DegreeNumbersFont;
            this.button9.ForeColor = global::DegreeClock.Properties.Settings.Default.CurrentDegreeNumberColor;
            this.button9.Location = new System.Drawing.Point(324, 139);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(264, 39);
            this.button9.TabIndex = 12;
            this.button9.Text = "Current Degree Color";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button8
            // 
            this.button8.BackColor = global::DegreeClock.Properties.Settings.Default.NightColor;
            this.button8.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "NightColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "DegreeLinesColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = global::DegreeClock.Properties.Settings.Default.DegreeLinesColor;
            this.button8.Location = new System.Drawing.Point(324, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(264, 39);
            this.button8.TabIndex = 11;
            this.button8.Text = "Degree Lines Color";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button7
            // 
            this.button7.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button7.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "DegreeNumbersFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "DegreeNumbersColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = global::DegreeClock.Properties.Settings.Default.DegreeNumbersFont;
            this.button7.ForeColor = global::DegreeClock.Properties.Settings.Default.DegreeNumbersColor;
            this.button7.Location = new System.Drawing.Point(57, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(264, 39);
            this.button7.TabIndex = 10;
            this.button7.Text = "Degree Numbers  Color";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button6
            // 
            this.button6.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "TimeTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button6.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DegreeClock.Properties.Settings.Default, "TimeTextFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = global::DegreeClock.Properties.Settings.Default.TimeTextFont;
            this.button6.ForeColor = global::DegreeClock.Properties.Settings.Default.TimeTextColor;
            this.button6.Location = new System.Drawing.Point(591, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(264, 39);
            this.button6.TabIndex = 9;
            this.button6.Text = "Current Time Color";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button5
            // 
            this.button5.BackColor = global::DegreeClock.Properties.Settings.Default.FormBackgroundColor;
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "FormBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(57, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(264, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "Background Color";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ChangeBackColor);
            // 
            // button4
            // 
            this.button4.BackColor = global::DegreeClock.Properties.Settings.Default.DayColor;
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "CurrentTimeLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "DayColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = global::DegreeClock.Properties.Settings.Default.CurrentTimeLine;
            this.button4.Location = new System.Drawing.Point(57, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Current Time Line";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ChangeForeColor);
            // 
            // button3
            // 
            this.button3.BackColor = global::DegreeClock.Properties.Settings.Default.TimePassedColor;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "TimePassedColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "DegreeLinesColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = global::DegreeClock.Properties.Settings.Default.DegreeLinesColor;
            this.button3.Location = new System.Drawing.Point(591, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Time Passed  Color";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ChangeBackColor);
            // 
            // button2
            // 
            this.button2.BackColor = global::DegreeClock.Properties.Settings.Default.NightColor;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "NightColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DegreeClock.Properties.Settings.Default, "DegreeLinesColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = global::DegreeClock.Properties.Settings.Default.DegreeLinesColor;
            this.button2.Location = new System.Drawing.Point(591, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Night Color";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangeBackColor);
            // 
            // button1
            // 
            this.button1.BackColor = global::DegreeClock.Properties.Settings.Default.DayColor;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DegreeClock.Properties.Settings.Default, "DayColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(324, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Day Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ChangeBackColor);
            // 
            // cmbLocations
            // 
            this.cmbLocations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocations.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DegreeClock.Properties.Settings.Default, "LocationName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbLocations.DisplayMember = "Name";
            this.cmbLocations.Location = new System.Drawing.Point(55, 61);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(410, 24);
            this.cmbLocations.TabIndex = 0;
            this.cmbLocations.Text = global::DegreeClock.Properties.Settings.Default.LocationName;
            // 
            // cmbThemes
            // 
            this.cmbThemes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbThemes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThemes.Items.AddRange(new object[] {
            "Choose a theme...",
            "Default - Light Windowed",
            "Dark Windowless",
            "Light Windowless"});
            this.cmbThemes.Location = new System.Drawing.Point(498, 61);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(291, 24);
            this.cmbThemes.TabIndex = 41;
            this.cmbThemes.Tag = "Choose a theme...";
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button17.Location = new System.Drawing.Point(796, 61);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 23);
            this.button17.TabIndex = 42;
            this.button17.Text = "Load";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Load a theme";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(909, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.cmbThemes);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRegTimeLabelFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTitleBarFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDegTimeLabelFormat);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.ComboBox cmbDegTimeLabelFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTitleBarFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRegTimeLabelFormat;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.ComboBox cmbThemes;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label5;
    }
}