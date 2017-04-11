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
    public partial class newEmp : Form
    {
        public newEmp()
        {
            InitializeComponent();
            tick.Hide();
            emailtick.Hide();
            disable_content();
        }

        private void disable_content()
        {
            Division.Enabled = false;
            Subject1.Enabled = false;
            Subject2.Enabled = false;
            Subject3.Enabled = false;
            Subject4.Enabled = false;
            Subject5.Enabled = false;
        }

        private void enable_content()
        {

            Division.Enabled = true;
            Subject1.Enabled = true;
            Subject2.Enabled = true;
            Subject3.Enabled = true;
            Subject4.Enabled = true;
            Subject5.Enabled = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            firstname.Text = middlename.Text = lastname.Text = username.Text = password.Text = repassword.Text = email.Text = address.Text = "";
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstname.Text) || string.IsNullOrWhiteSpace(middlename.Text) || string.IsNullOrWhiteSpace(lastname.Text) || string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(repassword.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrEmpty(Designation.Text))
            {
                MessageBox.Show("Fill up the mandatory fields");
            }
            else if (validate_uname()==0 && validate_pass()==0)
            {
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    connect.Open();
                    string query = "insert into WSD_Employee values (@Fname, @Mname, @Lname, @Username, @Pass, @Email, @Phone, @Address, @Designation, @Division, @Subject1, @Subject2, @Subject3, @Subject4, @Subject5)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Fname", firstname.Text);
                        cmd.Parameters.AddWithValue("@Mname", middlename.Text);
                        cmd.Parameters.AddWithValue("@Lname", lastname.Text);
                        cmd.Parameters.AddWithValue("@Username", username.Text);
                        cmd.Parameters.AddWithValue("@Pass", password.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@Phone", phone.Text);
                        cmd.Parameters.AddWithValue("@Address", address.Text);
                        cmd.Parameters.AddWithValue("@Designation", Designation.Text);
                        cmd.Parameters.AddWithValue("@Division", Division.Text);
                        cmd.Parameters.AddWithValue("@Subject1", Subject1.Text);
                        cmd.Parameters.AddWithValue("@Subject2", Subject2.Text);
                        cmd.Parameters.AddWithValue("@Subject3", Subject3.Text);
                        cmd.Parameters.AddWithValue("@Subject4", Subject4.Text);
                        cmd.Parameters.AddWithValue("@Subject5", Subject5.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Details Saved");
                this.Close();
               
            }
                
            
        }

        private int validate_uname()
        {
            string user;
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                connect.Open();
                string query = "select Username from WSD_Employee";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader()) 
                    {
                        while (rdr.Read())
                        {
                            user = (string)rdr["Username"];
                            if (username.Text == user)
                            {
                                MessageBox.Show("Username already exists");
                                connect.Close();
                                return 1;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        private int validate_pass()
        {
            if (password.Text == repassword.Text)
            {
                return 0;
            }
            else 
            {
                MessageBox.Show("Password feilds do not match");
                return 1;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void repassword_KeyUp(object sender, KeyEventArgs e)
        {
            tick.Show();

            if (password.Text == repassword.Text)
            {
                tick.Text = "✓";
                tick.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                tick.Text = "X";
                tick.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void email_KeyUp(object sender, KeyEventArgs e)
        {
            emailtick.Show();
            if (email.Text.Contains("@") && (email.Text.Contains(".com") || email.Text.Contains(".co.uk") || email.Text.Contains(".co.in") || email.Text.Contains(".co.us")))
            {
                emailtick.Text = "✓";
                emailtick.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                emailtick.Text = "X";
                emailtick.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void middlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Designation.SelectedItem.ToString() == "Technical Associate")
            {
                enable_content();
            }
            else
            {
                disable_content();
            }
        }
                
    }
}
