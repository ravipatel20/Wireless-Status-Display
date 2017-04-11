namespace WSD
{
    partial class Classroom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tick = new System.Windows.Forms.Button();
            this.Class_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subtract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Class_list = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Class_list);
            this.groupBox1.Controls.Add(this.tick);
            this.groupBox1.Controls.Add(this.Class_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Subtract);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Classrooms";
            // 
            // tick
            // 
            this.tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tick.ForeColor = System.Drawing.Color.Green;
            this.tick.Location = new System.Drawing.Point(227, 173);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(35, 33);
            this.tick.TabIndex = 11;
            this.tick.Text = "✓ ";
            this.tick.UseVisualStyleBackColor = true;
            this.tick.Click += new System.EventHandler(this.tick_Click);
            // 
            // Class_name
            // 
            this.Class_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_name.Location = new System.Drawing.Point(105, 179);
            this.Class_name.Name = "Class_name";
            this.Class_name.Size = new System.Drawing.Size(118, 23);
            this.Class_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Name  : ";
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(227, 61);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(35, 33);
            this.Subtract.TabIndex = 4;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(227, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(35, 33);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Class_list
            // 
            this.Class_list.AllowUserToAddRows = false;
            this.Class_list.AllowUserToDeleteRows = false;
            this.Class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Class_list.Location = new System.Drawing.Point(9, 19);
            this.Class_list.Name = "Class_list";
            this.Class_list.ReadOnly = true;
            this.Class_list.Size = new System.Drawing.Size(214, 150);
            this.Class_list.TabIndex = 12;
            this.Class_list.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Class_list_CellContentDoubleClick);
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(293, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "Classroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classrooms";
            this.Load += new System.EventHandler(this.Classroom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Class_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button tick;
        private System.Windows.Forms.DataGridView Class_list;
    }
}