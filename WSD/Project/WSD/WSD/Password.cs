using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSD
{
    public partial class Password : Form
    {
        private string cur_user = "";

        public Password(string caller)
        {
            InitializeComponent();
            new_pass.Enabled = false;
            renew_pas.Enabled = false;
            save_newpass.Enabled = false;
            cur_user = caller;
            tick.Hide();
        }

        private void old_pass_KeyUp(object sender, KeyEventArgs e)
        {
            string query = "Select * from WSD_Employee";
            string pass = "";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (cur_user == (string)rdr["Username"])
                            {
                                pass = (string)rdr["Pass"];
                            }
                        }
                    }
                }
            }

            if (old_pass.Text == pass)
            {
                old_pass.Enabled = false;
                new_pass.Enabled = true;
                renew_pas.Enabled = true;
            }

        }

        private void renew_pas_KeyUp(object sender, KeyEventArgs e)
        {
            tick.Show();

            if (new_pass.Text == renew_pas.Text)
            {
                tick.Text = "✓";
                tick.ForeColor = System.Drawing.Color.Green;
                save_newpass.Enabled = true;
            }
            else
            {
                tick.Text = "X";
                tick.ForeColor = System.Drawing.Color.Red;
                save_newpass.Enabled = false;
            }
        }

        private void save_newpass_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                string query = "UPDATE WSD_Employee set Pass=@password where Username=@user";
                connect.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@password", new_pass.Text);
                    command.Parameters.AddWithValue("@user", cur_user.ToString());
                    command.ExecuteNonQuery();
                }
            }
            this.Close();
        }
              
    }
}
