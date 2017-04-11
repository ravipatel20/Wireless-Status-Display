using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSD
{
    public partial class Administrator : Form
    {

        private string fname = "";
        private string cls = "";
        private DateTime t = DateTime.Now;
        private TimeSpan ts = new TimeSpan(18, 30, 00);
        private SerialPort serial_data = new SerialPort();

        public Administrator()
        {
            InitializeComponent();

            Admin_time.Text = DateTime.Now.ToString("hh:mm tt");
            request_grant.Enabled = false;
            request_deny.Enabled = false;

            announce_time.Enabled = false;
            announce_message.Enabled = false;
            announce_reset.Enabled = false;
            announce_save.Enabled = false;
            
            announce_class_init();
            set_datetime();
            request_list_display();
            serial_data_init();
            this.ControlBox = false;

            t = t.Date + ts;

        }

        private void serial_data_init()
        {
            serial_data.PortName = "COM14";
            serial_data.BaudRate = 115200;
            serial_data.Parity = Parity.None;
            serial_data.StopBits = StopBits.One;
            serial_data.Handshake = Handshake.None;

        }

        private void admin_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void manage_class_Click(object sender, EventArgs e)
        {
            Classroom cls = new Classroom();
            cls.ShowDialog();
        }

        private void manage_device_Click(object sender, EventArgs e)
        {
            Devices dvs = new Devices();
            dvs.ShowDialog();
            dvs.FormClosing += new System.Windows.Forms.FormClosingEventHandler(refresh_devices);
            announce_class_init();
        }

        private void refresh_devices(object sender, EventArgs e)
        {
            announce_class_init();
        }

        private void employee_new_Click(object sender, EventArgs e)
        {
            newEmp emp = new newEmp();
            emp.ShowDialog();
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
            Admin_date.Text = month;
            Admin_date.Text += " " + today.Day.ToString() + ", " + today.Year.ToString();
        }      

        private void suggestion_date_ValueChanged(object sender, EventArgs e)
        {
            string sel_date = suggestion_date.Value.ToString("dd-MM-yyyy");
            const string query = "select * from WSD_Suggestions";
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
                            if (sel_date == (string)rdr["Date"])
                            {
                                str = (string)rdr["Content"];
                                suggestion_list.Text += Environment.NewLine + str + Environment.NewLine;
                            }
                        }
                    }
                }
            }
        }

        private void request_list_display()
        {
            const string query = "select Fullname, Classroom from WSD_Extra_Lec where Status='Not Updated'";
            
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                DataSet ds = new DataSet();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.Fill(ds);
                    request_list.DataSource=ds.Tables[0].DefaultView;
                    request_list.ReadOnly = true;
                    request_list.Columns[0].Width = 200;
                    request_list.Columns[1].Width = 120;
                }
            }

        }

        private void request_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string query = "Select * from WSD_Extra_Lec";

            int rowInd = e.RowIndex;
            DataGridViewRow row = request_list.Rows[rowInd];

            fname = row.Cells[0].Value.ToString();
            cls = row.Cells[1].Value.ToString();
            
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (fname == (string)rdr["Fullname"] && cls == (string)rdr["Classroom"] && (string)rdr["Status"] == "Not Updated")
                            {
                                req_time.Text = (string)rdr["Hour"] + ":" + (string)rdr["Minute"];
                                req_topic.Text = (string)rdr["Topic"];
                            }
                        }
                    }
                }
            }

            request_grant.Enabled = true;
            request_deny.Enabled = true;
        }

        private void announce_class_init()
        {
            announce_class.Items.Clear();
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
                            announce_class.Items.Add(str);
                        }
                    }
                }
            }
        }

        private void announce_hh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void announce_mm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void request_grant_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                string query = "UPDATE WSD_Extra_Lec set Status=@status where Fullname=@fullname AND Classroom=@classroom";
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@status", "Request Granted");
                    command.Parameters.AddWithValue("@fullname", fname);
                    command.Parameters.AddWithValue("@classroom", cls);
                    command.ExecuteNonQuery();
                }
            }
            request_grant.Enabled = false;
            request_deny.Enabled = false;
            req_time.Text = "";
            req_topic.Text = "";
            request_list_display();
        }

        private void request_deny_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                string query = "UPDATE WSD_Extra_Lec set Status=@status where Fullname=@fullname AND Classroom=@classroom";
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@status", "Request Denied");
                    command.Parameters.AddWithValue("@fullname", fname);
                    command.Parameters.AddWithValue("@classroom", cls);
                    command.ExecuteNonQuery();
                }
            }
            request_grant.Enabled = false;
            request_deny.Enabled = false;
            request_list_display();
        }

        private void announce_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            announce_time.Enabled = true;                     
        }

        private void announce_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            announce_message.Enabled = true;
            announce_reset.Enabled = true;
            announce_save.Enabled = true;  
        }

        private void announce_save_Click(object sender, EventArgs e)
        {
            int index = announce_time.SelectedIndex;

            if (index < 2)
            {
                if (index == 0)
                {
                    string data = "";
                    serial_data.Open();
                    data = "-----Attention!-----$" + announce_message.Text + "#";
                    serial_data.Write(data);
                    serial_data.Close();
                }
                else
                {
                    int mm = DateTime.Now.Minute + 5;
                    save_announcement(DateTime.Now.Hour.ToString(), mm.ToString());
                }
            }
            else if (index >= 2 && index < 7)
            {
                int mm = DateTime.Now.Minute + ((index - 1) * 10);
                int hh = DateTime.Now.Hour;
                if (mm > 59)
                {
                    hh += 1;
                    mm -= 60;
                }
                save_announcement(hh.ToString(), mm.ToString());
            }
            else
            {
                int hh = DateTime.Now.Hour + (index - 6);
                save_announcement(hh.ToString(), DateTime.Now.Minute.ToString());
            }


            announce_time.SelectedIndex = -1;
            announce_class.SelectedIndex = -1;
            announce_time.Enabled = false;
            announce_message.Enabled = false;
            announce_reset.Enabled = false;
            announce_save.Enabled = false; 
        }

        private void save_announcement(string hh, string mm)
        {

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                string query = "Insert into WSD_Announcement (Classroom, Hour, Minute, Message) values (@Classroom, @Hour, @Minutes, @Message)";
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Classroom", announce_class.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Hour", hh);
                    command.Parameters.AddWithValue("@Minutes", mm);
                    command.Parameters.AddWithValue("@Message", announce_message.Text);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void announce_reset_Click(object sender, EventArgs e)
        {
            announce_time.SelectedIndex = -1;
            announce_class.SelectedIndex = -1;
            announce_time.Enabled = false;
            announce_message.Enabled = false;
            announce_reset.Enabled = false;
            announce_save.Enabled = false; 
        }

        private void admin_ch_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password pass = new Password("Administrator");
            pass.ShowDialog();
        }

        private void employee_remove_Click(object sender, EventArgs e)
        {
            remEmp x = new remEmp();
            x.ShowDialog();
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

        //private void send_message()
        //{
        //    string query = "";
        //    string query2 = "";
        //    string dow = DateTime.Now.DayOfWeek.ToString();
        //    string[] user = new string[100];
        //    string[] cls = new string[100];
        //    string[] slot = new string[100];
        //    string[] ann_hr = new string[100];
        //    string[] ann_min = new string[100];
        //    string data = "";
        //    int ctr = 0;

        //    DateTime disp_t = DateTime.Now;
        //    int hours = 0;
        //    int min = 0;


        //    DateTime start_t = DateTime.Now;
        //    int start_hours = 0;
        //    int start_min = 0;
        //    DateTime end_t = DateTime.Now;
        //    int end_hours = 0;
        //    int end_min = 0;


        //    switch (dow)
        //    {
        //        case "Monday": query = "select * from WSD_Monday";
        //            query2 = "update WSD_Monday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;

        //        case "Tuesday": query = "select * from WSD_Tuesday";
        //            query2 = "update WSD_Tuesday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;

        //        case "Wednesday": query = "select * from WSD_Wednesday";
        //            query2 = "update WSD_Wednesday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;

        //        case "Thursday": query = "select * from WSD_Thursday";
        //            query2 = "update WSD_Thursday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;

        //        case "Friday": query = "select * from WSD_Friday";
        //            query2 = "update WSD_Friday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;

        //        case "Saturday": query = "select * from WSD_Saturday";
        //            query2 = "update WSD_Saturday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
        //            break;
        //    }

        //    //////////Ongoing Lecture//////////

        //    using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //        {
        //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    switch ((string)rdr["Time_Slot"])
        //                    {
        //                        case "Slot1": start_hours = 9; start_min = 30;
        //                            end_hours = 10; end_min = 55;
        //                            break;
        //                        case "Slot2": start_hours = 11; start_min = 0;
        //                            end_hours = 12; end_min = 25;
        //                            break;
        //                        case "Slot3": start_hours = 13; start_min = 30;
        //                            end_hours = 14; end_min = 55;
        //                            break;
        //                        case "Slot4": start_hours = 15; start_min = 0;
        //                            end_hours = 16; end_min = 25;
        //                            break;
        //                        case "Slot5": start_hours = 17; start_min = 00;
        //                            end_hours = 17; end_min = 55;
        //                            break;
        //                        case "Slot6": start_hours = 18; start_min = 00;
        //                            end_hours = 18; end_min = 55;
        //                            break;

        //                    }

        //                    TimeSpan disp_ts = new TimeSpan(start_hours, start_min, 0);
        //                    start_t = start_t.Date + disp_ts;

        //                    disp_ts = new TimeSpan(end_hours, end_min, 0);
        //                    end_t = end_t.Date + disp_ts;

        //                    if (start_t.TimeOfDay <= DateTime.Now.TimeOfDay && end_t.TimeOfDay >= DateTime.Now.TimeOfDay)
        //                    {
        //                        //MessageBox.Show((string)rdr["Topic"]);
        //                        data = "Ongoing Lec : " + (string)rdr["Topic"] + "$";
        //                        serial_print(data, (string)rdr["User"], 0);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    ////////////Next Lecture Region//////////
        //    ctr = 0;
        //    using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //        {
        //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    switch ((string)rdr["Time_Slot"])
        //                    {
        //                        case "Slot2": hours = 10; min = 55;
        //                            break;
        //                        case "Slot3": hours = 12; min = 25;
        //                            break;
        //                        case "Slot4": hours = 14; min = 55;
        //                            break;
        //                        case "Slot5": hours = 16; min = 25;
        //                            break;
        //                        case "Slot6": hours = 17; min = 55;
        //                            break;
        //                        //case "Slot6": start_hours = 18; start_min = 00;
        //                        //    end_hours = 18; end_min = 55;
        //                        //    break;

        //                    }

        //                    TimeSpan disp_ts = new TimeSpan(hours, min, 0);
        //                    disp_t = disp_t.Date + disp_ts;

        //                    if (disp_t.TimeOfDay <= DateTime.Now.TimeOfDay && (string)rdr["Display_Status"] == "0")
        //                    {
        //                        //MessageBox.Show((string)rdr["Topic"]);
        //                        data = "Next Lec : " + (string)rdr["Topic"] + "$";
        //                        serial_print(data, (string)rdr["User"], 1);

        //                        cls[ctr] = (string)rdr["Classroom"];
        //                        user[ctr] = (string)rdr["User"];
        //                        slot[ctr] = (string)rdr["Time_Slot"];
        //                        ctr++;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    while (ctr != 0)
        //    {
        //        ctr--;
        //        using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //        {
        //            connect.Open();
        //            using (SQLiteCommand command = new SQLiteCommand(query2, connect))
        //            {
        //                command.Parameters.AddWithValue("@user", user[ctr]);
        //                command.Parameters.AddWithValue("@class", cls[ctr]);
        //                command.Parameters.AddWithValue("@slot", slot[ctr]);
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //    /////////////*Announcement Region*///////////////

        //    ctr = 0;
        //    query = "select * from WSD_Announcement";
        //    query2 = "update WSD_Announcement set Display_Status='1' where Classroom=@class AND Hour=@hour AND Minute=@minute";

        //    using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //        {
        //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    hours = int.Parse((string)rdr["Hour"]);
        //                    min = int.Parse((string)rdr["Minute"]);

        //                    TimeSpan disp_ts = new TimeSpan(hours, min, 0);
        //                    disp_t = disp_t.Date + disp_ts;

        //                    if (disp_t.Hour == DateTime.Now.Hour && disp_t.Minute == DateTime.Now.Minute && (string)rdr["Display_Status"] == "0")
        //                    {
        //                        //MessageBox.Show((string)rdr["Message"]);
        //                        serial_data.Open();
        //                        data = "-----Attention!-----$" + (string)rdr["Message"] + "#";
        //                        serial_data.Write(data);
        //                        serial_data.Close();

        //                        cls[ctr] = (string)rdr["Classroom"];
        //                        ann_hr[ctr] = (string)rdr["Hour"];
        //                        ann_min[ctr] = (string)rdr["Minute"];
        //                        ctr++;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    while (ctr != 0)
        //    {
        //        ctr--;
        //        using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //        {
        //            connect.Open();
        //            using (SQLiteCommand command = new SQLiteCommand(query2, connect))
        //            {
        //                command.Parameters.AddWithValue("@class", cls[ctr]);
        //                command.Parameters.AddWithValue("@hour", ann_hr[ctr]);
        //                command.Parameters.AddWithValue("@minute", ann_min[ctr]);
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //}

        //private void serial_print(string topic, string user, int flag)
        //{
        //    string query = "select * from WSD_Employee where Username=@user";
        //    string name = "";
        //    string data = "";

        //    using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
        //    {
        //        conn.Open();
        //        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@user", user);
        //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    name = "By : " + (string)rdr["Fname"] + " ";
        //                    name += (string)rdr["Lname"];
        //                    name += "#";
        //                    data = topic + name;
        //                }
        //            }
        //        }
        //    }

        //    serial_data.Open();
        //    serial_data.Write(data);
        //    serial_data.Close();
        //}
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cur_t = DateTime.Now;
            Admin_time.Text = cur_t.ToString("hh:mm tt");

            if (t.TimeOfDay < cur_t.TimeOfDay)
            {
                refresh_database();
            }

            //Form1.send_message();
        }
    
    }
}
