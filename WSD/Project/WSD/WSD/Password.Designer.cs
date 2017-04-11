namespace WSD
{
    partial class Password
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
            this.save_newpass = new System.Windows.Forms.Button();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.renew_pas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_newpass
            // 
            this.save_newpass.Location = new System.Drawing.Point(158, 102);
            this.save_newpass.Name = "save_newpass";
            this.save_newpass.Size = new System.Drawing.Size(118, 23);
            this.save_newpass.TabIndex = 15;
            this.save_newpass.Text = "Reset Password";
            this.save_newpass.UseVisualStyleBackColor = true;
            this.save_newpass.Click += new System.EventHandler(this.save_newpass_Click);
            // 
            // old_pass
            // 
            this.old_pass.Location = new System.Drawing.Point(182, 24);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(191, 20);
            this.old_pass.TabIndex = 13;
            this.old_pass.UseSystemPasswordChar = true;
            this.old_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.old_pass_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Old Password";
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(182, 50);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(191, 20);
            this.new_pass.TabIndex = 17;
            this.new_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Password";
            // 
            // renew_pas
            // 
            this.renew_pas.Location = new System.Drawing.Point(182, 76);
            this.renew_pas.Name = "renew_pas";
            this.renew_pas.Size = new System.Drawing.Size(191, 20);
            this.renew_pas.TabIndex = 19;
            this.renew_pas.UseSystemPasswordChar = true;
            this.renew_pas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.renew_pas_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Re-Enter Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(164, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 93;
            this.label10.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(164, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(164, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 95;
            this.label5.Text = ":";
            // 
            // tick
            // 
            this.tick.AutoSize = true;
            this.tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tick.ForeColor = System.Drawing.Color.Green;
            this.tick.Location = new System.Drawing.Point(379, 77);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(28, 17);
            this.tick.TabIndex = 96;
            this.tick.Text = "✓ ";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(419, 130);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.renew_pas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_newpass);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.label2);
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_newpass;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox renew_pas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tick;
    }
}