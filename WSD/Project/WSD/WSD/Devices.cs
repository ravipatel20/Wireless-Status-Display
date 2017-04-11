using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSD
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
         
        }

        public string temp = "";
        public int flag = 0;

        private void Devices_Load(object sender, EventArgs e)
        {
            new_device.Enabled = false;
            qty_counter.Enabled = false;
            tick.Enabled = false;
            Cancel.Enabled = false;

            update_list();
        }

        private void update_list()
        {
            const string query = "select Device, Quantity, Slot1_Occupancy AS 'Time Slot 1', Slot2_Occupancy AS 'Time Slot 2', Slot3_Occupancy AS 'Time Slot 3', Slot4_Occupancy AS 'Time Slot 4', Slot5_Occupancy AS 'Time Slot 5', Slot6_Occupancy AS 'Time Slot 6' from WSD_Devices";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                DataSet ds = new DataSet();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.Fill(ds);
                    device_list.DataSource = ds.Tables[0].DefaultView;
                    device_list.ReadOnly = true;
                    device_list.Columns[0].Width = 155;
                }
            }
        }
        
        private void device_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 0;

            int rowInd = e.RowIndex;
            DataGridViewRow row = device_list.Rows[rowInd];
            
            new_device.Enabled = true;
            qty_counter.Enabled = true;
            tick.Enabled = true;
            Cancel.Enabled = true;
            Add_Device.Enabled = false;
            device_list.Enabled = false;

            temp = row.Cells[0].Value.ToString();
            new_device.Text = temp;
            qty_counter.Value = int.Parse(row.Cells[1].Value.ToString());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    string query = "delete from WSD_Devices where Device='" + temp + "'";
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            new_device.Text = null;
            new_device.Enabled = false;
            qty_counter.Enabled = false;
            tick.Enabled = false;
            Cancel.Enabled = false;
            Add_Device.Enabled = true;
            device_list.Enabled = true;

            update_list();                     
        }

        private void tick_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(new_device.Text))
            {
                if (flag == 0)
                {
                    using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                    {
                        string query = "UPDATE WSD_Devices set Device=@newname, Quantity=@qty where Device=@oldname";
                        connect.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@newname", new_device.Text);
                            command.Parameters.AddWithValue("@qty", int.Parse(qty_counter.Value.ToString()));
                            command.Parameters.AddWithValue("@oldname", temp);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    try
                    {
                        using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                        {
                            string query = "INSERT into WSD_Devices (Device, Quantity) values (@newname, @qty)";
                            connect.Open();
                            using (SQLiteCommand command = new SQLiteCommand(query, connect))
                            {
                                command.Parameters.AddWithValue("@newname", new_device.Text);
                                command.Parameters.AddWithValue("@qty", int.Parse(qty_counter.Value.ToString()));
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Duplicate Entries not allowed");
                    }
                }
                new_device.Text = null;
                new_device.Enabled = false;
                qty_counter.Enabled = false;
                tick.Enabled = false;
                Cancel.Enabled = false;
                Add_Device.Enabled = true;
                device_list.Enabled = true;

                update_list();
            }
        }

        private void Add_Device_Click(object sender, EventArgs e)
        {
            flag = 1;

            device_list.Enabled = false;
            new_device.Text = null;
            new_device.Enabled = true;
            qty_counter.Enabled = true;
            tick.Enabled = true;
            Cancel.Enabled = true;
            Add_Device.Enabled = false;
        }

       
    }
}
