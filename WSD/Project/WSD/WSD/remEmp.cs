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
    public partial class remEmp : Form
    {
        public remEmp()
        {
            InitializeComponent();
            emp_data_init();
            groupBox1.Hide();
        }

        private void emp_data_init()
        {
            const string query = "select (Fname||' '||Lname) as Name from WSD_Employee where Username!='Administrator'";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                DataSet ds = new DataSet();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.Fill(ds);
                    emp_data.DataSource = ds.Tables[0].DefaultView;
                    emp_data.ReadOnly = true;
                    emp_data.Columns[0].Width = 173;
                }
            }
            emp_data.Rows[0].Cells[0].Selected = false;            
        }

        private void groupbox1_init(string fullname, int index)
        {
            groupBox1.Show();

            int ctr = 0;
            string query = "Select Username, Email, Designation from WSD_Employee where Username!='Administrator'";
            groupBox1.Text = fullname;
            
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (ctr == index)
                            {
                                uname.Text = (string)rdr["Username"];
                                email.Text = (string)rdr["Email"];
                                designation.Text = (string)rdr["Designation"];
                            }
                            ctr++;                            
                        }
                    }
                }
            }

        }

        private void emp_data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            DataGridViewRow row = emp_data.Rows[rowInd];
            //MessageBox.Show("Double Click " + row.Cells[0].Value.ToString());
            groupbox1_init(row.Cells[0].Value.ToString(),rowInd);

        }

        private void delete_emp_Click(object sender, EventArgs e)
        {
            string[] query = new string[9];
            query[0] = "delete from WSD_Employee where Username='" + uname.Text + "'";
            query[1] = "delete from WSD_Extra_Lec where Username='" + uname.Text + "'";
            query[2] = "delete from WSD_Monday where User='" + uname.Text + "'";
            query[3] = "delete from WSD_Tuesday where User='" + uname.Text + "'";
            query[4] = "delete from WSD_Wednesday where User='" + uname.Text + "'";
            query[5] = "delete from WSD_Thursday where User='" + uname.Text + "'";
            query[6] = "delete from WSD_Friday where User='" + uname.Text + "'";
            query[7] = "delete from WSD_Saturday where User='" + uname.Text + "'";
            query[8] = "delete from WSD_Suggestions where Username='" + uname.Text + "'";

            for (int i = 0; i < 9; i++)
            {
                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query[i], connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
         
            emp_data_init();
            groupBox1.Hide();
        }
    }
}
