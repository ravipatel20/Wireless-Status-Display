namespace WSD
{
    partial class Administrator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.announce_time = new System.Windows.Forms.ListBox();
            this.Admin_time = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.suggestion_date = new System.Windows.Forms.DateTimePicker();
            this.suggestion_list = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.req_time = new System.Windows.Forms.Label();
            this.req_topic = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.request_list = new System.Windows.Forms.DataGridView();
            this.request_deny = new System.Windows.Forms.Button();
            this.request_grant = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.employee_remove = new System.Windows.Forms.Button();
            this.employee_new = new System.Windows.Forms.Button();
            this.announce_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manage_device = new System.Windows.Forms.Button();
            this.manage_class = new System.Windows.Forms.Button();
            this.announce_save = new System.Windows.Forms.Button();
            this.announce_class = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.announce_message = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.admin_logout = new System.Windows.Forms.LinkLabel();
            this.admin_ch_pass = new System.Windows.Forms.LinkLabel();
            this.Admin_date = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label33 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.announce_time);
            this.tabPage1.Controls.Add(this.Admin_time);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.announce_reset);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.announce_save);
            this.tabPage1.Controls.Add(this.announce_class);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.announce_message);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.admin_logout);
            this.tabPage1.Controls.Add(this.admin_ch_pass);
            this.tabPage1.Controls.Add(this.Admin_date);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 507);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Aministrator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Class";
            // 
            // announce_time
            // 
            this.announce_time.FormattingEnabled = true;
            this.announce_time.ItemHeight = 16;
            this.announce_time.Items.AddRange(new object[] {
            "Now",
            "After 5 min",
            "After 10 min",
            "After 20 min",
            "After 30 min",
            "After 40 min",
            "After 50 min",
            "After 1 hr",
            "After 2 hrs",
            "After 3 hrs"});
            this.announce_time.Location = new System.Drawing.Point(352, 73);
            this.announce_time.Name = "announce_time";
            this.announce_time.Size = new System.Drawing.Size(120, 20);
            this.announce_time.TabIndex = 61;
            this.announce_time.SelectedIndexChanged += new System.EventHandler(this.announce_time_SelectedIndexChanged);
            // 
            // Admin_time
            // 
            this.Admin_time.AutoSize = true;
            this.Admin_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Admin_time.Location = new System.Drawing.Point(870, 23);
            this.Admin_time.Name = "Admin_time";
            this.Admin_time.Size = new System.Drawing.Size(76, 17);
            this.Admin_time.TabIndex = 60;
            this.Admin_time.Text = "14 : 20 hrs";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.suggestion_date);
            this.groupBox7.Controls.Add(this.suggestion_list);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox7.Location = new System.Drawing.Point(679, 156);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 345);
            this.groupBox7.TabIndex = 59;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Suggestion List";
            // 
            // suggestion_date
            // 
            this.suggestion_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.suggestion_date.Location = new System.Drawing.Point(25, 30);
            this.suggestion_date.Name = "suggestion_date";
            this.suggestion_date.Size = new System.Drawing.Size(200, 23);
            this.suggestion_date.TabIndex = 3;
            this.suggestion_date.ValueChanged += new System.EventHandler(this.suggestion_date_ValueChanged);
            // 
            // suggestion_list
            // 
            this.suggestion_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.suggestion_list.Location = new System.Drawing.Point(6, 59);
            this.suggestion_list.Name = "suggestion_list";
            this.suggestion_list.Size = new System.Drawing.Size(238, 280);
            this.suggestion_list.TabIndex = 1;
            this.suggestion_list.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.req_time);
            this.groupBox6.Controls.Add(this.req_topic);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.request_list);
            this.groupBox6.Controls.Add(this.request_deny);
            this.groupBox6.Controls.Add(this.request_grant);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox6.Location = new System.Drawing.Point(305, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 345);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Requests";
            // 
            // req_time
            // 
            this.req_time.AutoSize = true;
            this.req_time.BackColor = System.Drawing.Color.White;
            this.req_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.req_time.Location = new System.Drawing.Point(69, 281);
            this.req_time.Name = "req_time";
            this.req_time.Size = new System.Drawing.Size(0, 17);
            this.req_time.TabIndex = 65;
            // 
            // req_topic
            // 
            this.req_topic.AutoSize = true;
            this.req_topic.BackColor = System.Drawing.Color.White;
            this.req_topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.req_topic.Location = new System.Drawing.Point(219, 281);
            this.req_topic.Name = "req_topic";
            this.req_topic.Size = new System.Drawing.Size(0, 17);
            this.req_topic.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(16, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(162, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Topic :";
            // 
            // request_list
            // 
            this.request_list.AllowUserToAddRows = false;
            this.request_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.request_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_list.Location = new System.Drawing.Point(7, 23);
            this.request_list.Name = "request_list";
            this.request_list.ReadOnly = true;
            this.request_list.Size = new System.Drawing.Size(340, 238);
            this.request_list.TabIndex = 56;
            this.request_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.request_list_CellContentClick);
            // 
            // request_deny
            // 
            this.request_deny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.request_deny.Location = new System.Drawing.Point(195, 310);
            this.request_deny.Name = "request_deny";
            this.request_deny.Size = new System.Drawing.Size(97, 23);
            this.request_deny.TabIndex = 55;
            this.request_deny.Text = "Deny";
            this.request_deny.UseVisualStyleBackColor = true;
            this.request_deny.Click += new System.EventHandler(this.request_deny_Click);
            // 
            // request_grant
            // 
            this.request_grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.request_grant.Location = new System.Drawing.Point(55, 310);
            this.request_grant.Name = "request_grant";
            this.request_grant.Size = new System.Drawing.Size(97, 23);
            this.request_grant.TabIndex = 54;
            this.request_grant.Text = "Grant";
            this.request_grant.UseVisualStyleBackColor = true;
            this.request_grant.Click += new System.EventHandler(this.request_grant_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.employee_remove);
            this.groupBox5.Controls.Add(this.employee_new);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox5.Location = new System.Drawing.Point(39, 354);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 147);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manage Employee";
            // 
            // employee_remove
            // 
            this.employee_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.employee_remove.Location = new System.Drawing.Point(33, 95);
            this.employee_remove.Name = "employee_remove";
            this.employee_remove.Size = new System.Drawing.Size(156, 23);
            this.employee_remove.TabIndex = 53;
            this.employee_remove.Text = "Remove Employee";
            this.employee_remove.UseVisualStyleBackColor = true;
            this.employee_remove.Click += new System.EventHandler(this.employee_remove_Click);
            // 
            // employee_new
            // 
            this.employee_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.employee_new.Location = new System.Drawing.Point(33, 42);
            this.employee_new.Name = "employee_new";
            this.employee_new.Size = new System.Drawing.Size(156, 23);
            this.employee_new.TabIndex = 52;
            this.employee_new.Text = "New Employee";
            this.employee_new.UseVisualStyleBackColor = true;
            this.employee_new.Click += new System.EventHandler(this.employee_new_Click);
            // 
            // announce_reset
            // 
            this.announce_reset.Location = new System.Drawing.Point(295, 109);
            this.announce_reset.Name = "announce_reset";
            this.announce_reset.Size = new System.Drawing.Size(109, 23);
            this.announce_reset.TabIndex = 50;
            this.announce_reset.Text = "Reset";
            this.announce_reset.UseVisualStyleBackColor = true;
            this.announce_reset.Click += new System.EventHandler(this.announce_reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manage_device);
            this.groupBox1.Controls.Add(this.manage_class);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(39, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 168);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // manage_device
            // 
            this.manage_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manage_device.Location = new System.Drawing.Point(33, 98);
            this.manage_device.Name = "manage_device";
            this.manage_device.Size = new System.Drawing.Size(156, 23);
            this.manage_device.TabIndex = 54;
            this.manage_device.Text = "Manage Devices";
            this.manage_device.UseVisualStyleBackColor = true;
            this.manage_device.Click += new System.EventHandler(this.manage_device_Click);
            // 
            // manage_class
            // 
            this.manage_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manage_class.Location = new System.Drawing.Point(33, 41);
            this.manage_class.Name = "manage_class";
            this.manage_class.Size = new System.Drawing.Size(156, 23);
            this.manage_class.TabIndex = 53;
            this.manage_class.Text = "Manage Classrooms";
            this.manage_class.UseVisualStyleBackColor = true;
            this.manage_class.Click += new System.EventHandler(this.manage_class_Click);
            // 
            // announce_save
            // 
            this.announce_save.Location = new System.Drawing.Point(536, 109);
            this.announce_save.Name = "announce_save";
            this.announce_save.Size = new System.Drawing.Size(140, 23);
            this.announce_save.TabIndex = 51;
            this.announce_save.Text = "Save Changes";
            this.announce_save.UseVisualStyleBackColor = true;
            this.announce_save.Click += new System.EventHandler(this.announce_save_Click);
            // 
            // announce_class
            // 
            this.announce_class.FormattingEnabled = true;
            this.announce_class.ItemHeight = 16;
            this.announce_class.Location = new System.Drawing.Point(226, 73);
            this.announce_class.Name = "announce_class";
            this.announce_class.Size = new System.Drawing.Size(120, 20);
            this.announce_class.TabIndex = 49;
            this.announce_class.SelectedIndexChanged += new System.EventHandler(this.announce_class_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(391, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = "Time";
            // 
            // announce_message
            // 
            this.announce_message.Location = new System.Drawing.Point(494, 73);
            this.announce_message.Name = "announce_message";
            this.announce_message.Size = new System.Drawing.Size(277, 23);
            this.announce_message.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Announcement        : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(604, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Message";
            // 
            // admin_logout
            // 
            this.admin_logout.AutoSize = true;
            this.admin_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.admin_logout.Location = new System.Drawing.Point(809, 3);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(40, 13);
            this.admin_logout.TabIndex = 42;
            this.admin_logout.TabStop = true;
            this.admin_logout.Text = "Logout";
            this.admin_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_logout_LinkClicked);
            // 
            // admin_ch_pass
            // 
            this.admin_ch_pass.AutoSize = true;
            this.admin_ch_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.admin_ch_pass.Location = new System.Drawing.Point(860, 3);
            this.admin_ch_pass.Name = "admin_ch_pass";
            this.admin_ch_pass.Size = new System.Drawing.Size(93, 13);
            this.admin_ch_pass.TabIndex = 41;
            this.admin_ch_pass.TabStop = true;
            this.admin_ch_pass.Text = "Change Password";
            this.admin_ch_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_ch_pass_LinkClicked);
            // 
            // Admin_date
            // 
            this.Admin_date.AutoSize = true;
            this.Admin_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Admin_date.Location = new System.Drawing.Point(701, 23);
            this.Admin_date.Name = "Admin_date";
            this.Admin_date.Size = new System.Drawing.Size(130, 17);
            this.Admin_date.TabIndex = 39;
            this.Admin_date.Text = "3rd February, 2015";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(953, 501);
            this.shapeContainer1.TabIndex = 54;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Silver;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 16;
            this.lineShape2.X2 = 942;
            this.lineShape2.Y1 = 141;
            this.lineShape2.Y2 = 141;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 284;
            this.lineShape1.Y1 = 339;
            this.lineShape1.Y2 = 339;
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
            this.label33.TabIndex = 117;
            this.label33.Text = "© einfochips Training and Research Academy ( eiTRA )";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 569);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wireless Status Display";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker suggestion_date;
        private System.Windows.Forms.RichTextBox suggestion_list;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button request_deny;
        private System.Windows.Forms.Button request_grant;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button employee_remove;
        private System.Windows.Forms.Button employee_new;
        private System.Windows.Forms.Button announce_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button announce_save;
        private System.Windows.Forms.ListBox announce_class;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox announce_message;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel admin_logout;
        private System.Windows.Forms.LinkLabel admin_ch_pass;
        private System.Windows.Forms.Label Admin_date;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button manage_device;
        private System.Windows.Forms.Button manage_class;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label Admin_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView request_list;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label req_time;
        private System.Windows.Forms.Label req_topic;
        private System.Windows.Forms.ListBox announce_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
    }
}