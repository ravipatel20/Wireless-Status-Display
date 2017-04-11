namespace WSD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.reset_main = new System.Windows.Forms.Button();
            this.login_main = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.main_time = new System.Windows.Forms.Label();
            this.main_date = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(991, 569);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.Location = new System.Drawing.Point(298, 162);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(416, 194);
            // 
            // reset_main
            // 
            this.reset_main.Location = new System.Drawing.Point(557, 288);
            this.reset_main.Name = "reset_main";
            this.reset_main.Size = new System.Drawing.Size(75, 23);
            this.reset_main.TabIndex = 11;
            this.reset_main.Text = "Reset";
            this.reset_main.UseVisualStyleBackColor = true;
            this.reset_main.Click += new System.EventHandler(this.reset_main_Click);
            // 
            // login_main
            // 
            this.login_main.Location = new System.Drawing.Point(413, 288);
            this.login_main.Name = "login_main";
            this.login_main.Size = new System.Drawing.Size(75, 23);
            this.login_main.TabIndex = 10;
            this.login_main.Text = "Login";
            this.login_main.UseVisualStyleBackColor = true;
            this.login_main.Click += new System.EventHandler(this.login_main_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(469, 246);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(191, 20);
            this.password.TabIndex = 9;
            this.password.UseSystemPasswordChar = true;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(467, 210);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(191, 20);
            this.uname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login Form";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main_time
            // 
            this.main_time.AutoSize = true;
            this.main_time.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.main_time.Location = new System.Drawing.Point(625, 172);
            this.main_time.Name = "main_time";
            this.main_time.Size = new System.Drawing.Size(76, 17);
            this.main_time.TabIndex = 13;
            this.main_time.Text = "14 : 20 hrs";
            // 
            // main_date
            // 
            this.main_date.AutoSize = true;
            this.main_date.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.main_date.Location = new System.Drawing.Point(320, 172);
            this.main_date.Name = "main_date";
            this.main_date.Size = new System.Drawing.Size(130, 17);
            this.main_date.TabIndex = 14;
            this.main_date.Text = "3rd February, 2015";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 100);
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(234, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(572, 27);
            this.label4.TabIndex = 119;
            this.label4.Text = "eInfochips Training and Research Academy";
            // 
            // Form1
            // 
            this.AcceptButton = this.login_main;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.main_date);
            this.Controls.Add(this.main_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset_main);
            this.Controls.Add(this.login_main);
            this.Controls.Add(this.password);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wireless Status Display";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button reset_main;
        private System.Windows.Forms.Button login_main;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label main_time;
        private System.Windows.Forms.Label main_date;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;

    }
}

