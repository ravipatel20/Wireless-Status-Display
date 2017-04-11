namespace WSD
{
    partial class Devices
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
            this.Add_Device = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.device_list = new System.Windows.Forms.DataGridView();
            this.tick = new System.Windows.Forms.Button();
            this.qty_counter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.new_device = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.device_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_counter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_Device);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.device_list);
            this.groupBox1.Controls.Add(this.tick);
            this.groupBox1.Controls.Add(this.qty_counter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.new_device);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Devices";
            // 
            // Add_Device
            // 
            this.Add_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Device.Location = new System.Drawing.Point(409, 265);
            this.Add_Device.Name = "Add_Device";
            this.Add_Device.Size = new System.Drawing.Size(132, 23);
            this.Add_Device.TabIndex = 13;
            this.Add_Device.Text = "Add  Device";
            this.Add_Device.UseVisualStyleBackColor = true;
            this.Add_Device.Click += new System.EventHandler(this.Add_Device_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(637, 228);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(35, 33);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "X";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // device_list
            // 
            this.device_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.device_list.Location = new System.Drawing.Point(9, 19);
            this.device_list.Name = "device_list";
            this.device_list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.device_list.Size = new System.Drawing.Size(898, 201);
            this.device_list.TabIndex = 11;
            this.device_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.device_list_CellDoubleClick);
            // 
            // tick
            // 
            this.tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tick.ForeColor = System.Drawing.Color.Green;
            this.tick.Location = new System.Drawing.Point(596, 228);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(35, 33);
            this.tick.TabIndex = 10;
            this.tick.Text = "✓ ";
            this.tick.UseVisualStyleBackColor = true;
            this.tick.Click += new System.EventHandler(this.tick_Click);
            // 
            // qty_counter
            // 
            this.qty_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_counter.Location = new System.Drawing.Point(549, 237);
            this.qty_counter.Name = "qty_counter";
            this.qty_counter.Size = new System.Drawing.Size(41, 23);
            this.qty_counter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qty :";
            // 
            // new_device
            // 
            this.new_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_device.Location = new System.Drawing.Point(375, 236);
            this.new_device.Name = "new_device";
            this.new_device.Size = new System.Drawing.Size(124, 23);
            this.new_device.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device Name :";
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(929, 309);
            this.Controls.Add(this.groupBox1);
            this.Name = "Devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.Devices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.device_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_counter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox new_device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qty_counter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tick;
        private System.Windows.Forms.DataGridView device_list;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add_Device;
    }
}