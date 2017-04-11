using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSD
{
    public partial class Form1 : Form
    {
        private DateTime t = DateTime.Now;
        private TimeSpan ts = new TimeSpan(18, 30, 00);
        public static SerialPort serial_data = new SerialPort();
        public static int status_lcd = 0;

        public Form1()
        {
            InitializeComponent();
            t = t.Date + ts;
            main_time.Text = DateTime.Now.ToString("hh:mm tt");
            set_datetime();
            database_init();
            serial_data_init();
        }

        private void serial_data_init()
        {
            serial_data.PortName = "COM14";
            serial_data.BaudRate = 115200;
            serial_data.Parity = Parity.None;
            serial_data.StopBits = StopBits.One;
            serial_data.Handshake = Handshake.None;
            
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
            main_date.Text = month;
            main_date.Text += " " + today.Day.ToString() + ", " + today.Year.ToString();
        }

        private void database_init()
        {

            if (!File.Exists("C://WSD.mdf"))
            {
                SQLiteConnection.CreateFile("C://WSD.mdf");
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    string query = "create table WSD_Employee (Fname varchar2(20), Mname varchar2(20), Lname varchar2(20), Username varchar2(20) PRIMARY KEY, Pass varchar2(20), Email varchar2(20),Phone varchar2(20), Address varchar2(100), Designation varchar2(20), Division varchar2(20), Subject1 varchar2(20), Subject2 varchar2(20), Subject3 varchar2(20), Subject4 varchar2(20), Subject5 varchar2(20) )";
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "insert into WSD_Employee (Username, Pass) values('Administrator', 'helloworld')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Devices (Device varchar2(20) PRIMARY KEY, Quantity integer DEFAULT 0, Slot1_Occupancy integer DEFAULT 0, Slot2_Occupancy integer DEFAULT 0, Slot3_Occupancy integer DEFAULT 0, Slot4_Occupancy integer DEFAULT 0, Slot5_Occupancy integer DEFAULT 0, Slot6_Occupancy integer DEFAULT 0)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "insert into WSD_Devices (Device, Quantity) values('Projector', 6)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Classrooms (Classroom varchar2(20) PRIMARY KEY)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Suggestions (Username varchar2(20) , Date varchar2(10), Content varchar2(250))";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Extra_Lec (Username varchar2(20), Fullname varchar2(50), Hour varchar2(5), Minute varchar2(5), Topic varchar2(100), Classroom varchar2(20), Status varchar2(20) DEFAULT 'Not Updated')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Announcement (Classroom varchar2(20), Hour varchar2(5), Minute varchar2(5), Message varchar2(50), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Monday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Tuesday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Wednesday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Thursday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Friday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }

                    query = "create table WSD_Saturday (Classroom varchar2(20), Time_Slot varchar2(10), Topic varchar2(50), Devices varchar2(20), User varchar2(20), Display_Status varchar2(5) DEFAULT '0')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }

            }

        }

        private void login_main_Click(object sender, EventArgs e)
        {
            string query = "select Pass, Username, Fname, Mname, Lname from WSD_Employee";
            string pass = "";
            string user = "";
            string name = "";
            int flag = 0;

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            pass = (string)rdr["Pass"];
                            user = (string)rdr["Username"];
                            if (password.Text == pass && uname.Text == "Administrator" && uname.Text == user)
                            {
                                admin_login();
                                flag = 1;
                                break;
                            }
                            else if (uname.Text == user && password.Text == pass)
                            {
                                name = (string)rdr["Fname"] + " " + (string)rdr["Mname"] + " " + (string)rdr["Lname"];
                                faculty_login(name);
                                flag = 1;
                                break;
                            }

                        }
                    }
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Invalid Username or Password");
            }
        
        }
        
        private void faculty_login(string name)
        {
            Faculty f = new Faculty(name);
            f.cur_user = uname.Text;
            f.FormClosed += new FormClosedEventHandler(menu_FormClosed);
            f.Show();
            this.Hide();

        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        
        private void admin_login()
        {
            Administrator a = new Administrator();
            a.FormClosed += new FormClosedEventHandler(menu_FormClosed);
            a.Show();
            this.Hide();
        }

        private void reset_main_Click(object sender, EventArgs e)
        {
            uname.Text = "";
            password.Text = "";
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

        public static void send_message()
        {
            string query = "";
            string query2 = "";
            string dow = DateTime.Now.DayOfWeek.ToString();
            string[] user = new string[100];
            string[] cls = new string[100];
            string[] slot = new string[100];
            string[] ann_hr = new string[100];
            string[] ann_min = new string[100];
            string data = "";
            int ctr = 0;

            DateTime disp_t = DateTime.Now;
            int hours = 0;
            int min = 0;


            DateTime start_t = DateTime.Now;
            int start_hours = 0;
            int start_min = 0;
            DateTime end_t = DateTime.Now;
            int end_hours = 0;
            int end_min = 0;


            switch (dow)
            {
                case "Monday": query = "select * from WSD_Monday";
                    query2 = "update WSD_Monday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;

                case "Tuesday": query = "select * from WSD_Tuesday";
                    query2 = "update WSD_Tuesday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;

                case "Wednesday": query = "select * from WSD_Wednesday";
                    query2 = "update WSD_Wednesday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;

                case "Thursday": query = "select * from WSD_Thursday";
                    query2 = "update WSD_Thursday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;

                case "Friday": query = "select * from WSD_Friday";
                    query2 = "update WSD_Friday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;

                case "Saturday": query = "select * from WSD_Saturday";
                    query2 = "update WSD_Saturday set Display_Status='1' where User=@user AND Classroom=@class AND Time_Slot=@slot";
                    break;
            }

            //////////Ongoing Lecture//////////

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            switch ((string)rdr["Time_Slot"])
                            {
                                case "Slot1": start_hours = 9; start_min = 30;
                                    end_hours = 10; end_min=55;  
                                    break;
                                case "Slot2": start_hours = 11; start_min = 0;
                                    end_hours = 12; end_min=25;
                                    break;
                                case "Slot3": start_hours = 13; start_min = 30;
                                    end_hours = 14; end_min=55;
                                    break;
                                case "Slot4": start_hours = 15; start_min = 0;
                                    end_hours = 16; end_min=25;
                                    break;
                                case "Slot5": start_hours = 17; start_min = 00;
                                    end_hours = 17; end_min=55;
                                    break;
                                case "Slot6": start_hours = 18; start_min = 00;
                                    end_hours = 18; end_min=55;
                                    break;

                            }
                            
                            TimeSpan disp_ts = new TimeSpan(start_hours, start_min, 0);
                            start_t = start_t.Date + disp_ts;

                            disp_ts = new TimeSpan(end_hours, end_min, 0);
                            end_t = end_t.Date + disp_ts;

                            if (start_t.TimeOfDay <= DateTime.Now.TimeOfDay && end_t.TimeOfDay >= DateTime.Now.TimeOfDay)
                            {
                                //MessageBox.Show((string)rdr["Topic"]);
                                data = "Ongoing Lec : " + (string)rdr["Topic"] + "$";
                                serial_print(data, (string)rdr["User"], 0);
                            }
                        }
                    }
                }
            }

            ////////////Next Lecture Region//////////
            ctr = 0;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            switch ((string)rdr["Time_Slot"])
                            {
                                case "Slot2": hours = 10; min = 55;
                                    break;
                                case "Slot3": hours = 12; min = 25;
                                    break;
                                case "Slot4": hours = 14; min = 55;
                                    break;
                                case "Slot5": hours = 16; min = 25;
                                    break;
                                case "Slot6": hours = 17; min = 55;
                                    break;
                                //case "Slot6": start_hours = 18; start_min = 00;
                                //    end_hours = 18; end_min = 55;
                                //    break;

                            }

                            TimeSpan disp_ts = new TimeSpan(hours, min, 0);
                            disp_t = disp_t.Date + disp_ts;

                            if (disp_t.TimeOfDay <= DateTime.Now.TimeOfDay && (string)rdr["Display_Status"]=="0")
                            {
                                //MessageBox.Show((string)rdr["Topic"]);
                                data = "Next Lec : " + (string)rdr["Topic"] + "$";
                                serial_print(data, (string)rdr["User"], 1);

                                cls[ctr] = (string)rdr["Classroom"];
                                user[ctr] = (string)rdr["User"];
                                slot[ctr] = (string)rdr["Time_Slot"];
                                ctr++;
                            }
                        }
                    }
                }
            }
            
            while (ctr != 0)
            {
                ctr--;
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query2, connect))
                    {
                        command.Parameters.AddWithValue("@user", user[ctr]);
                        command.Parameters.AddWithValue("@class", cls[ctr]);
                        command.Parameters.AddWithValue("@slot", slot[ctr]);
                        command.ExecuteNonQuery();
                    }
                }
            }

            /////////////*Announcement Region*///////////////

            ctr = 0;
            query = "select * from WSD_Announcement";
            query2 = "update WSD_Announcement set Display_Status='1' where Classroom=@class AND Hour=@hour AND Minute=@minute";
                    
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            hours = int.Parse((string)rdr["Hour"]);
                            min = int.Parse((string)rdr["Minute"]);

                            TimeSpan disp_ts = new TimeSpan(hours, min, 0);
                            disp_t = disp_t.Date + disp_ts;

                            if (disp_t.Hour == DateTime.Now.Hour && disp_t.Minute==DateTime.Now.Minute && (string)rdr["Display_Status"] == "0")
                            {
                                //MessageBox.Show((string)rdr["Message"]);
                                serial_data.Open();
                                data = "-----Attention!-----$" + (string)rdr["Message"] + "#";
                                serial_data.Write(data);
                                serial_data.Close();

                                cls[ctr] = (string)rdr["Classroom"];
                                ann_hr[ctr] = (string)rdr["Hour"];
                                ann_min[ctr] = (string)rdr["Minute"];
                                ctr++;
                            }
                        }
                    }
                }
            }

            while (ctr != 0)
            {
                ctr--;
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query2, connect))
                    {
                        command.Parameters.AddWithValue("@class", cls[ctr]);
                        command.Parameters.AddWithValue("@hour", ann_hr[ctr]);
                        command.Parameters.AddWithValue("@minute", ann_min[ctr]);
                        command.ExecuteNonQuery();
                    }
                }
            }

        }

        public static void serial_print(string topic, string user, int flag)
        {
            string query = "select * from WSD_Employee where Username=@user";
            string name = "";
            string data = "";
            
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user",user);
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            name = "By : " + (string)rdr["Fname"] + " ";
                            name += (string)rdr["Lname"];
                            name += "#";
                            data = topic + name;
                            
                        }
                    }
                }
            }

            serial_data.Open();
            serial_data.Write(data);
            serial_data.Close();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cur_t = DateTime.Now;
            main_time.Text = cur_t.ToString("hh:mm tt");

            if (t.TimeOfDay < cur_t.TimeOfDay)
            {
                refresh_database();
            }

            send_message();
        }
        

    }
}
