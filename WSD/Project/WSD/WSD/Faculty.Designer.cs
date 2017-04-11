namespace WSD
{
    partial class Faculty
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.class_box = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.request = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.extratopic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.extramm = new System.Windows.Forms.TextBox();
            this.extrahh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.device6 = new System.Windows.Forms.CheckedListBox();
            this.device5 = new System.Windows.Forms.CheckedListBox();
            this.device4 = new System.Windows.Forms.CheckedListBox();
            this.device3 = new System.Windows.Forms.CheckedListBox();
            this.device2 = new System.Windows.Forms.CheckedListBox();
            this.device1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.topic6 = new System.Windows.Forms.TextBox();
            this.topic5 = new System.Windows.Forms.TextBox();
            this.topic4 = new System.Windows.Forms.TextBox();
            this.topic3 = new System.Windows.Forms.TextBox();
            this.topic2 = new System.Windows.Forms.TextBox();
            this.topic1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suggestion = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.LinkLabel();
            this.faculty_time = new System.Windows.Forms.Label();
            this.faculty_date = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label33 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 542);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.logout);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.reset);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.faculty_time);
            this.tabPage1.Controls.Add(this.faculty_date);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Faculty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.class_box);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(693, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 128);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // class_box
            // 
            this.class_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.class_box.FormattingEnabled = true;
            this.class_box.ItemHeight = 16;
            this.class_box.Location = new System.Drawing.Point(60, 43);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(120, 20);
            this.class_box.TabIndex = 5;
            this.class_box.SelectedIndexChanged += new System.EventHandler(this.class_box_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 84);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 3, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.logout.Location = new System.Drawing.Point(809, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 13);
            this.logout.TabIndex = 57;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.request);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.extratopic);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.extramm);
            this.groupBox4.Controls.Add(this.extrahh);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox4.Location = new System.Drawing.Point(49, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 114);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extra Lecture";
            // 
            // request
            // 
            this.request.AutoSize = true;
            this.request.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.request.Location = new System.Drawing.Point(214, 85);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(88, 17);
            this.request.TabIndex = 50;
            this.request.Text = "Not Updated";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.Location = new System.Drawing.Point(67, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 17);
            this.label23.TabIndex = 49;
            this.label23.Text = "Request Status   :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(67, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Time";
            // 
            // extratopic
            // 
            this.extratopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extratopic.Location = new System.Drawing.Point(150, 49);
            this.extratopic.Name = "extratopic";
            this.extratopic.Size = new System.Drawing.Size(236, 23);
            this.extratopic.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(83, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = ":";
            // 
            // extramm
            // 
            this.extramm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extramm.Location = new System.Drawing.Point(94, 49);
            this.extramm.MaxLength = 2;
            this.extramm.Name = "extramm";
            this.extramm.Size = new System.Drawing.Size(37, 23);
            this.extramm.TabIndex = 45;
            this.extramm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extramm_KeyPress);
            // 
            // extrahh
            // 
            this.extrahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extrahh.Location = new System.Drawing.Point(44, 49);
            this.extrahh.MaxLength = 2;
            this.extrahh.Name = "extrahh";
            this.extrahh.Size = new System.Drawing.Size(37, 23);
            this.extrahh.TabIndex = 44;
            this.extrahh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extrahh_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(240, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Topic";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.device6);
            this.groupBox3.Controls.Add(this.device5);
            this.groupBox3.Controls.Add(this.device4);
            this.groupBox3.Controls.Add(this.device3);
            this.groupBox3.Controls.Add(this.device2);
            this.groupBox3.Controls.Add(this.device1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.topic6);
            this.groupBox3.Controls.Add(this.topic5);
            this.groupBox3.Controls.Add(this.topic4);
            this.groupBox3.Controls.Add(this.topic3);
            this.groupBox3.Controls.Add(this.topic2);
            this.groupBox3.Controls.Add(this.topic1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox3.Location = new System.Drawing.Point(9, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 222);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regular Class";
            // 
            // device6
            // 
            this.device6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device6.FormattingEnabled = true;
            this.device6.Location = new System.Drawing.Point(516, 175);
            this.device6.Name = "device6";
            this.device6.Size = new System.Drawing.Size(120, 22);
            this.device6.TabIndex = 87;
            // 
            // device5
            // 
            this.device5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device5.FormattingEnabled = true;
            this.device5.Location = new System.Drawing.Point(516, 148);
            this.device5.Name = "device5";
            this.device5.Size = new System.Drawing.Size(120, 22);
            this.device5.TabIndex = 86;
            // 
            // device4
            // 
            this.device4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device4.FormattingEnabled = true;
            this.device4.Location = new System.Drawing.Point(516, 121);
            this.device4.Name = "device4";
            this.device4.Size = new System.Drawing.Size(120, 22);
            this.device4.TabIndex = 85;
            // 
            // device3
            // 
            this.device3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device3.FormattingEnabled = true;
            this.device3.Location = new System.Drawing.Point(516, 94);
            this.device3.Name = "device3";
            this.device3.Size = new System.Drawing.Size(120, 22);
            this.device3.TabIndex = 84;
            // 
            // device2
            // 
            this.device2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device2.FormattingEnabled = true;
            this.device2.Location = new System.Drawing.Point(516, 67);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(120, 22);
            this.device2.TabIndex = 83;
            // 
            // device1
            // 
            this.device1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.device1.FormattingEnabled = true;
            this.device1.Location = new System.Drawing.Point(516, 40);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(120, 22);
            this.device1.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(547, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Devices";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(308, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 68;
            this.label13.Text = "Topic";
            // 
            // topic6
            // 
            this.topic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic6.Location = new System.Drawing.Point(213, 177);
            this.topic6.MaxLength = 20;
            this.topic6.Name = "topic6";
            this.topic6.Size = new System.Drawing.Size(236, 23);
            this.topic6.TabIndex = 67;
            // 
            // topic5
            // 
            this.topic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic5.Location = new System.Drawing.Point(213, 150);
            this.topic5.MaxLength = 20;
            this.topic5.Name = "topic5";
            this.topic5.Size = new System.Drawing.Size(236, 23);
            this.topic5.TabIndex = 66;
            // 
            // topic4
            // 
            this.topic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic4.Location = new System.Drawing.Point(213, 123);
            this.topic4.MaxLength = 20;
            this.topic4.Name = "topic4";
            this.topic4.Size = new System.Drawing.Size(236, 23);
            this.topic4.TabIndex = 65;
            // 
            // topic3
            // 
            this.topic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic3.Location = new System.Drawing.Point(213, 96);
            this.topic3.MaxLength = 20;
            this.topic3.Name = "topic3";
            this.topic3.Size = new System.Drawing.Size(236, 23);
            this.topic3.TabIndex = 64;
            // 
            // topic2
            // 
            this.topic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic2.Location = new System.Drawing.Point(213, 69);
            this.topic2.MaxLength = 20;
            this.topic2.Name = "topic2";
            this.topic2.Size = new System.Drawing.Size(236, 23);
            this.topic2.TabIndex = 63;
            // 
            // topic1
            // 
            this.topic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.topic1.Location = new System.Drawing.Point(213, 42);
            this.topic1.MaxLength = 20;
            this.topic1.Name = "topic1";
            this.topic1.Size = new System.Drawing.Size(236, 23);
            this.topic1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(37, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "18:00 - 19:00 hrs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "17:00 - 18:00 hrs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "15:00 - 16:30 hrs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "13:30 - 15:00 hrs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "11:00 - 12:30 hrs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "09:30 - 11:00 hrs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suggestion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox2.Location = new System.Drawing.Point(602, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 191);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suggestions / Complaints";
            // 
            // suggestion
            // 
            this.suggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.suggestion.Location = new System.Drawing.Point(11, 26);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(299, 154);
            this.suggestion.TabIndex = 55;
            this.suggestion.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(312, 466);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 23);
            this.save.TabIndex = 41;
            this.save.Text = "Save Changes";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(97, 466);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 23);
            this.reset.TabIndex = 40;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.password.Location = new System.Drawing.Point(863, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(93, 13);
            this.password.TabIndex = 4;
            this.password.TabStop = true;
            this.password.Text = "Change Password";
            this.password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.password_LinkClicked);
            // 
            // faculty_time
            // 
            this.faculty_time.AutoSize = true;
            this.faculty_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.faculty_time.Location = new System.Drawing.Point(874, 23);
            this.faculty_time.Name = "faculty_time";
            this.faculty_time.Size = new System.Drawing.Size(76, 17);
            this.faculty_time.TabIndex = 3;
            this.faculty_time.Text = "14 : 20 hrs";
            // 
            // faculty_date
            // 
            this.faculty_date.AutoSize = true;
            this.faculty_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.faculty_date.Location = new System.Drawing.Point(701, 23);
            this.faculty_date.Name = "faculty_date";
            this.faculty_date.Size = new System.Drawing.Size(130, 17);
            this.faculty_date.TabIndex = 1;
            this.faculty_date.Text = "3rd February, 2015";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name.Location = new System.Drawing.Point(6, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(262, 17);
            this.name.TabIndex = 0;
            this.name.Text = "FIRSTNAME MIDDLENAME LASTNAME ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(320, 554);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(371, 14);
            this.label33.TabIndex = 116;
            this.label33.Text = "© einfochips Training and Research Academy ( eiTRA )";
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 569);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wireless Status Display";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label request;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox extratopic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox extramm;
        private System.Windows.Forms.TextBox extrahh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox topic6;
        private System.Windows.Forms.TextBox topic5;
        private System.Windows.Forms.TextBox topic4;
        private System.Windows.Forms.TextBox topic3;
        private System.Windows.Forms.TextBox topic2;
        private System.Windows.Forms.TextBox topic1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox suggestion;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ListBox class_box;
        private System.Windows.Forms.LinkLabel password;
        private System.Windows.Forms.Label faculty_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label faculty_date;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox device6;
        private System.Windows.Forms.CheckedListBox device5;
        private System.Windows.Forms.CheckedListBox device4;
        private System.Windows.Forms.CheckedListBox device3;
        private System.Windows.Forms.CheckedListBox device2;
        private System.Windows.Forms.CheckedListBox device1;
        private System.Windows.Forms.Label label33;



    }
}