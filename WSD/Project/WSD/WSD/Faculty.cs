using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSD
{
    public partial class Faculty : Form
    {
        public string cur_user = "";
        private int class_flag = 0;
        private int date_flag = 0;
        private int extra_lec_flag = 0;
        private int[] slot_flag = new int[6] { 0, 0, 0, 0, 0, 0 };
        private DateTime t = DateTime.Now;
        private TimeSpan ts = new TimeSpan(18, 30, 00);
        private SerialPort serial_data = new SerialPort();

        public Faculty(string cur_name)
        {
            InitializeComponent();
            this.ControlBox = false;

            class_box_init();
            set_datetime();
            restrict_date();
            device_list_init();           
            disable_contents();
            serial_data_init();

            faculty_time.Text = DateTime.Now.ToString("hh:mm tt");
            name.Text = cur_name;

            t = t.Date + ts;
        }

        private void serial_data_init()
        {
            serial_data.PortName = "COM15";
            serial_data.BaudRate = 115200;
            serial_data.Parity = Parity.None;
            serial_data.StopBits = StopBits.One;
            serial_data.Handshake = Handshake.None;

        }

        private void disable_contents()
        {
            topic1.Enabled = false;
            topic2.Enabled = false;
            topic3.Enabled = false;
            topic4.Enabled = false;
            topic5.Enabled = false;
            topic6.Enabled = false;

            device1.Enabled = false;
            device2.Enabled = false;
            device3.Enabled = false;
            device4.Enabled = false;
            device5.Enabled = false;
            device6.Enabled = false;

            save.Enabled = false;
            reset.Enabled = false;            
            suggestion.Enabled = false;
        }

        private void enable_content()
        {
            topic1.Enabled = true;
            topic2.Enabled = true;
            topic3.Enabled = true;
            topic4.Enabled = true;
            topic5.Enabled = true;
            topic6.Enabled = true;

            device1.Enabled = true;
            device2.Enabled = true;
            device3.Enabled = true;
            device4.Enabled = true;
            device5.Enabled = true;
            device6.Enabled = true;

            save.Enabled = true;
            reset.Enabled = true;
            suggestion.Enabled = true;
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login();
        }

        private void login()
        {
            Form1 f1 = new Form1();
            f1.FormClosed += new FormClosedEventHandler(f1_FormClosed);
            f1.Show();

            this.Hide();
        }

        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }     
        
        private void set_datetime()
        {
            DateTime today = DateTime.Today;
            int a = today.Month;
            string month;
            switch (a)
            {
                case 1: month = "January";
                    break;
                case 2: month = "February";
                    break;
                case 3: month = "March";
                    break;
                case 4: month = "April";
                    break;
                case 5: month = "May";
                    break;
                case 6: month = "June";
                    break;
                case 7: month = "July";
                    break;
                case 8: month = "August";
                    break;
                case 9: month = "September";
                    break;
                case 10: month = "October";
                    break;
                case 11: month = "November";
                    break;
                case 12: month = "December";
                    break;
                default: month = " ";
                    break;
            }
            faculty_date.Text = month;
            faculty_date.Text += " " + today.Day.ToString() + ", " + today.Year.ToString();
        }
       
        private void restrict_date()
        {
            dateTimePicker1.MinDate = DateTime.Now;
            switch ((int)DateTime.Now.DayOfWeek)
            {
                case 1: dateTimePicker1.MaxDate = DateTime.Now.AddDays(5);
                    break;
                case 2: dateTimePicker1.MaxDate = DateTime.Now.AddDays(4);
                    break;
                case 3: dateTimePicker1.MaxDate = DateTime.Now.AddDays(3);
                    break;
                case 4: dateTimePicker1.MaxDate = DateTime.Now.AddDays(2);
                    break;
                case 5: dateTimePicker1.MaxDate = DateTime.Now.AddDays(1);
                    break;
                case 6: dateTimePicker1.MaxDate = DateTime.Now.AddDays(2);
                    break;
            }
        }

        private void class_box_init()
        {
            const string query = "select * from WSD_Classrooms";
            string str = "";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            str = (string)rdr["Classroom"];
                            class_box.Items.Add(str);
                        }
                    }
                }
            }
        }

        private void device_list_init()
        {
            const string query = "select * from WSD_Devices";
            string str = "";
            int occ = 0;
            int qty = 0;
            
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            str = (string)rdr["Device"];

                            qty = rdr.GetInt32(1);
                            occ = rdr.GetInt32(2);
                            if (occ < qty)
                            {
                                device1.Items.Add(str);
                            }

                            occ = rdr.GetInt32(3);
                            if (occ < qty)
                            {
                                device2.Items.Add(str);
                            }

                            occ = rdr.GetInt32(4);
                            if (occ < qty)
                            {
                                device3.Items.Add(str);
                            }

                            occ = rdr.GetInt32(5);
                            if (occ < qty)
                            {
                                device4.Items.Add(str);
                            }

                            occ = rdr.GetInt32(6);
                            if (occ < qty)
                            {
                                device5.Items.Add(str);
                            }

                            occ = rdr.GetInt32(7);
                            if (occ < qty)
                            {
                                device6.Items.Add(str);
                                //return;
                            }                     
                        }
                    }
                }
            }
        }

        private void suggestion_save()
        {
            if (!string.IsNullOrWhiteSpace(suggestion.Text))
            {
                string date = "";
                date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    string query = "INSERT into WSD_Suggestions values (@username, @date, @content)";
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@username", cur_user);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@content", suggestion.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void extra_lec_save()
        {
            if (!string.IsNullOrWhiteSpace(extrahh.Text) && !string.IsNullOrWhiteSpace(extramm.Text) && !string.IsNullOrWhiteSpace(extratopic.Text) && extrahh.ReadOnly==false)
            {
                if (extra_lec_flag == 0)
                {
                    using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                    {
                        string query = "INSERT into WSD_Extra_lec(Username, Fullname, Hour, Minute, Topic, Classroom) values (@username, @fullname, @hour, @minute, @topic, @class)";
                        connect.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@username", cur_user);
                            command.Parameters.AddWithValue("@fullname", name.Text);
                            command.Parameters.AddWithValue("@hour", extrahh.Text);
                            command.Parameters.AddWithValue("@minute", extramm.Text);
                            command.Parameters.AddWithValue("@Topic", extratopic.Text);
                            command.Parameters.AddWithValue("@class", class_box.SelectedItem.ToString());
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                    {
                        string query = "UPDATE WSD_Extra_Lec set Hour=@hour, Minute=@minute, Topic=@topic where Username=@uname AND Classroom=@class";
                        connect.Open();

                        using (SQLiteCommand update_cmd = new SQLiteCommand(query, connect))
                        {
                            update_cmd.Parameters.AddWithValue("@hour", extrahh.Text);
                            update_cmd.Parameters.AddWithValue("@minute", extramm.Text);
                            update_cmd.Parameters.AddWithValue("@topic", extratopic.Text);
                            update_cmd.Parameters.AddWithValue("@uname", cur_user);
                            update_cmd.Parameters.AddWithValue("@class", class_box.SelectedItem.ToString());

                            update_cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void regular_class_save()
        {
            string query = "";
            string query2 = "";
            string day = dateTimePicker1.Value.DayOfWeek.ToString();
            switch (day)
            {
                case "Monday":
                    query = "INSERT into WSD_Monday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Monday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;

                case "Tuesday":
                    query = "INSERT into WSD_Tuesday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Tuesday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;

                case "Wednesday":
                    query = "INSERT into WSD_Wednesday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Wednesday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;

                case "Thursday":
                    query = "INSERT into WSD_Thursday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Thursday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;

                case "Friday":
                    query = "INSERT into WSD_Friday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Friday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;

                case "Saturday":
                    query = "INSERT into WSD_Saturday (Classroom, Time_Slot, Topic, Devices, User) values (@Classroom, @Time_Slot, @Topic, @Devices, @User)";
                    query2 = "UPDATE WSD_Saturday set Topic=@topic where Classroom=@Classroom AND Time_Slot=@Time_Slot";
                    break;
            }

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    //Slot1
                    if (!String.IsNullOrWhiteSpace(topic1.Text))
                    {
                        if (slot_flag[0] == 0)
                        {
                            if (device1.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot1");
                                command.Parameters.AddWithValue("@Topic", topic1.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device1.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot1");
                                    command.Parameters.AddWithValue("@Topic", topic1.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[0] == 1)
                        {
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic1.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot1");
                                update_cmd.ExecuteNonQuery();
                            }                            
                        }
                    }

                    //Slot2
                    if (!String.IsNullOrWhiteSpace(topic2.Text))
                    {
                        if (slot_flag[1] == 0)
                        {
                            if (device2.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot2");
                                command.Parameters.AddWithValue("@Topic", topic2.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device2.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot2");
                                    command.Parameters.AddWithValue("@Topic", topic2.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[1] == 1)
                        { 
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic2.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot2");
                                update_cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    //Slot3
                    if (!String.IsNullOrWhiteSpace(topic3.Text))
                    {
                        if (slot_flag[2] == 0)
                        {
                            if (device3.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot3");
                                command.Parameters.AddWithValue("@Topic", topic3.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device1.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot3");
                                    command.Parameters.AddWithValue("@Topic", topic3.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[2] == 1)
                        {
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic3.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot3");
                                update_cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    //Slot4
                    if (!String.IsNullOrWhiteSpace(topic4.Text))
                    {
                        if (slot_flag[3] == 0)
                        {
                            if (device4.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot4");
                                command.Parameters.AddWithValue("@Topic", topic4.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device4.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot4");
                                    command.Parameters.AddWithValue("@Topic", topic4.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[3] == 1)
                        {
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic4.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot4");
                                update_cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    //Slot5
                    if (!String.IsNullOrWhiteSpace(topic5.Text))
                    {
                        if (slot_flag[4] == 0)
                        {
                            if (device5.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot5");
                                command.Parameters.AddWithValue("@Topic", topic5.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device5.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot5");
                                    command.Parameters.AddWithValue("@Topic", topic5.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[4] == 1)
                        {
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic5.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot5");
                                update_cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    //Slot6
                    if (!String.IsNullOrWhiteSpace(topic6.Text))
                    {
                        if (slot_flag[5] == 0)
                        {
                            if (device6.CheckedItems.Count == 0)
                            {
                                command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@Time_Slot", "Slot6");
                                command.Parameters.AddWithValue("@Topic", topic6.Text);
                                command.Parameters.AddWithValue("@Devices", "None");
                                command.Parameters.AddWithValue("@User", cur_user);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                foreach (object checkeddevice in device6.CheckedItems)
                                {
                                    command.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@Time_Slot", "Slot6");
                                    command.Parameters.AddWithValue("@Topic", topic6.Text);
                                    command.Parameters.AddWithValue("@Devices", checkeddevice.ToString());
                                    command.Parameters.AddWithValue("@User", cur_user);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (slot_flag[5] == 1)
                        {
                            //connect.Open();
                            using (SQLiteCommand update_cmd = new SQLiteCommand(query2, connect))
                            {
                                update_cmd.Parameters.AddWithValue("@topic", topic6.Text);
                                update_cmd.Parameters.AddWithValue("@Classroom", class_box.SelectedItem.ToString());
                                update_cmd.Parameters.AddWithValue("@Time_Slot", "Slot6");
                                update_cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            suggestion_save();
            regular_class_save();
            extra_lec_save();
            update_device_occupancy();
            reset_data();
        }

        private void class_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_flag = 1;
            extra_lec_flag = 0;
            reset_data();
            if (class_flag == 1 && date_flag == 1)
            {
                enable_content();
                load_content();
                extra_lec_status();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_flag = 1;
            extra_lec_flag = 0;
            reset_data();
            if (class_flag == 1 && date_flag == 1)
            {
                enable_content();
                load_content();
                extra_lec_status();
            }
        }

        private void load_content()
        {
            string query = "";
            string dow = dateTimePicker1.Value.DayOfWeek.ToString();
            switch (dow)
            {
                case "Monday": query = "select * from WSD_Monday";
                    break;

                case "Tuesday": query = "select * from WSD_Tuesday";
                    break;

                case "Wednesday": query = "select * from WSD_Wednesday";
                    break;

                case "Thursday": query = "select * from WSD_Thursday";
                    break;

                case "Friday": query = "select * from WSD_Friday";
                    break;

                case "Saturday": query = "select * from WSD_Saturday";
                    break;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot1")
                            {
                                topic1.Text = (string)rdr["Topic"];
                                slot_flag[0] = 1;
                                device1.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic1.Enabled = false;
                                    slot_flag[0] = 2;
                                }
                            }

                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot2")
                            {
                                topic2.Text = (string)rdr["Topic"];
                                slot_flag[1] = 1;
                                device2.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic2.Enabled = false;
                                    slot_flag[1] = 2;
                                }
                            }

                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot3")
                            {
                                topic3.Text = (string)rdr["Topic"];
                                slot_flag[2] = 1;
                                device3.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic3.Enabled = false;
                                    slot_flag[2] = 2;
                                }
                            }

                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot4")
                            {
                                topic4.Text = (string)rdr["Topic"];
                                slot_flag[3] = 1;
                                device4.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic4.Enabled = false;
                                    slot_flag[3] = 2;
                                }
                            }

                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot5")
                            {
                                topic5.Text = (string)rdr["Topic"];
                                slot_flag[4] = 1;
                                device5.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic5.Enabled = false;
                                    slot_flag[4] = 2;
                                }
                            }

                            if ((string)rdr["Classroom"] == class_box.SelectedItem.ToString() && (string)rdr["Time_Slot"] == "Slot6")
                            {
                                topic6.Text = (string)rdr["Topic"];
                                slot_flag[5] = 1;
                                device6.Enabled = false;
                                if ((string)rdr["User"] != cur_user)
                                {
                                    topic6.Enabled = false;                                    
                                    slot_flag[5] = 2;
                                }
                            }

                        }
                    }
                }
            }
        }

        private void update_device_occupancy()
        {
            string query = "select * from WSD_Devices";
            string device_sel = "";
            string query2 = "UPDATE WSD_Devices set Slot1_Occupancy=@Slot1, Slot2_Occupancy=@Slot2, Slot3_Occupancy=@Slot3, Slot4_Occupancy=@Slot4, Slot5_Occupancy=@Slot5, Slot6_Occupancy=@Slot6 where Device=@device";
            int[] occ = new int[6] { 0, 0, 0, 0, 0, 0 };
            int qty = 0;

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            device_sel = (string)rdr["Device"];
                            qty = rdr.GetInt32(1);
                            occ[0] = rdr.GetInt32(2);
                            occ[1] = rdr.GetInt32(3);
                            occ[2] = rdr.GetInt32(4);
                            occ[3] = rdr.GetInt32(5);
                            occ[4] = rdr.GetInt32(6);
                            occ[5] = rdr.GetInt32(7);

                            foreach (object checkeddevice in device1.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)                            
                                    occ[0]++;
                            
                            foreach (object checkeddevice in device2.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)
                                    occ[1]++;

                            foreach (object checkeddevice in device3.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)
                                    occ[2]++;

                            foreach (object checkeddevice in device4.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)
                                    occ[3]++;

                            foreach (object checkeddevice in device5.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)
                                    occ[4]++;

                            foreach (object checkeddevice in device6.CheckedItems)
                                if (checkeddevice.ToString() == device_sel)
                                    occ[5]++;

                            using (SQLiteCommand command = new SQLiteCommand(query2, connect))
                            {
                                command.Parameters.AddWithValue("@Slot1", occ[0].ToString());
                                command.Parameters.AddWithValue("@Slot2", occ[1].ToString());
                                command.Parameters.AddWithValue("@Slot3", occ[2].ToString());
                                command.Parameters.AddWithValue("@Slot4", occ[3].ToString());
                                command.Parameters.AddWithValue("@Slot5", occ[4].ToString());
                                command.Parameters.AddWithValue("@Slot6", occ[5].ToString());
                                command.Parameters.AddWithValue("@device", device_sel);
                                command.ExecuteNonQuery();
                            }                     
                        }
                    }
                }                       
            }
        }

        private void reset_data()
        {
            topic1.Text = "";
            topic2.Text = "";
            topic3.Text = "";
            topic4.Text = "";
            topic5.Text = "";
            topic6.Text = "";

            device1.Items.Clear();
            device2.Items.Clear();
            device3.Items.Clear();
            device3.Items.Clear();
            device4.Items.Clear();
            device5.Items.Clear();
            device6.Items.Clear();

            extrahh.Text = "";
            extramm.Text = "";
            extratopic.Text = "";
            request.Text = "Not Updated";

            extrahh.ReadOnly = false;
            extramm.ReadOnly = false;
            extratopic.ReadOnly = false;
            device_list_init();
            disable_contents();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_data();
        }

        private void extra_lec_status()
        {
            const string query = "select * from WSD_Extra_Lec";
            string uname = "";
            string cls = "";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            uname = (string)rdr["Username"];
                            cls = (string)rdr["Classroom"];
                            if (uname == cur_user && cls == class_box.SelectedItem.ToString())
                            {
                                extrahh.Text = (string)rdr["Hour"];
                                extramm.Text = (string)rdr["Minute"];
                                extratopic.Text = (string)rdr["Topic"];
                                extra_lec_flag = 1;

                                if ((string)rdr["Status"] == "Request Granted")
                                {                                    
                                    request.Text = "Request Granted";
                                    extrahh.ReadOnly = true;
                                    extramm.ReadOnly = true;
                                    extratopic.ReadOnly = true;

                                    request.ForeColor = System.Drawing.Color.Green;
                                    extrahh.BackColor = System.Drawing.Color.White;                                    
                                    extramm.BackColor = System.Drawing.Color.White;
                                    extratopic.BackColor = System.Drawing.Color.White;
                                }
                                else if ((string)rdr["Status"] == "Request Denied")
                                {                                    
                                    request.Text = "Request Denied";
                                    extrahh.ReadOnly = true;
                                    extramm.ReadOnly = true;
                                    extratopic.ReadOnly = true;

                                    request.ForeColor = System.Drawing.Color.Red;
                                    extrahh.BackColor = System.Drawing.Color.White;
                                    extramm.BackColor = System.Drawing.Color.White;
                                    extratopic.BackColor = System.Drawing.Color.White;
                                }
                                else if ((string)rdr["Status"] == "Not Updated")
                                {
                                    request.Text = "Not Updated";
                                    extrahh.ReadOnly = false;
                                    extramm.ReadOnly = false;
                                    extratopic.ReadOnly = false;

                                    request.ForeColor = System.Drawing.Color.Black;
                                    extrahh.BackColor = System.Drawing.Color.White;
                                    extramm.BackColor = System.Drawing.Color.White;
                                    extratopic.BackColor = System.Drawing.Color.White;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void extrahh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void extramm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password pass = new Password(cur_user);
            pass.ShowDialog();
        }
      
        private void refresh_database()
        {
            string query = "";
            string day = DateTime.Now.DayOfWeek.ToString();
            switch (day)
            {
                case "Monday": query = "delete from WSD_Monday";
                    break;

                case "Tuesday": query = "delete from WSD_Tuesday";
                    break;

                case "Wednesday": query = "delete from WSD_Wednesday";
                    break;

                case "Thursday": query = "delete from WSD_Thursday";
                    break;

                case "Friday": query = "delete from WSD_Friday";
                    break;

                case "Saturday": query = "delete from WSD_Saturday";
                    break;
            }

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.ExecuteNonQuery();
                }
            }

            query = "delete from WSD_Extra_Lec";
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.ExecuteNonQuery();
                }
            }

            query = "delete from WSD_Announcement";
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cur_t = DateTime.Now;
            faculty_time.Text = cur_t.ToString("hh:mm tt");

            if (t.TimeOfDay < cur_t.TimeOfDay)
            {
                refresh_database();
            }
            
        }


    }
}
