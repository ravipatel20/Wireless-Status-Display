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
    public partial class Classroom : Form
    {
        public Classroom()
        {
            InitializeComponent();
        }

        public int flag = 0;
        public string temp = "";

        private void Classroom_Load(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Subtract.Enabled = true;
            tick.Enabled = false;
            Class_name.Enabled = false;
            Class_list.AllowUserToResizeColumns = false;
            Class_list.MultiSelect = false;
            update_list();
        }

        private void update_list()
        {
            const string query = "select * from WSD_Classrooms";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
            {
                conn.Open();
                DataSet ds = new DataSet();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.Fill(ds);
                    Class_list.DataSource = ds.Tables[0].DefaultView;
                    Class_list.ReadOnly = true;
                    Class_list.Columns[0].Width = 171;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            flag = 1;
            Add.Enabled = false;
            Subtract.Enabled = false;
            Class_name.Enabled = true;
            tick.Enabled = true;
            Class_list.Enabled = false;
        }

        private void tick_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Class_name.Text))
            {
                if (flag == 0)
                {
                    using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                    {
                        string query = "UPDATE WSD_Classrooms set Classroom=@newname where Classroom=@oldname";
                        connect.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@newname", Class_name.Text);
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
                            string query = "INSERT into WSD_Classrooms values (@newname)";
                            connect.Open();
                            using (SQLiteCommand command = new SQLiteCommand(query, connect))
                            {
                                command.Parameters.AddWithValue("@newname", Class_name.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Duplicate Entries not allowed");
                    }
                }

                Class_name.Text = null;
                Class_name.Enabled = false;
                tick.Enabled = false;
                Subtract.Enabled = true;
                Add.Enabled = true;
                Class_list.Enabled = true;

                update_list();
            }
        }

        private void Class_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 0;

            int rowInd = e.RowIndex;
            DataGridViewRow row = Class_list.Rows[rowInd];
            
            Class_name.Enabled = true;  
            tick.Enabled = true;
            Add.Enabled = false;
            Subtract.Enabled = false;
            Class_list.Enabled = false;

            temp = row.Cells[0].Value.ToString();
            Class_name.Text = temp;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (Class_list.SelectedCells.Count == 1)
            {
                int rowind = Class_list.SelectedCells[0].RowIndex;
                DataGridViewRow row = Class_list.Rows[rowind];
                string temp2 = "";
                temp2 = row.Cells[0].Value.ToString();

                using (SQLiteConnection connect = new SQLiteConnection("Data Source=C://WSD.mdf;Version=3"))
                {
                    string query = "delete from WSD_Classrooms where Classroom='" + temp2 + "'";
                    connect.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connect))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                update_list();
            }
        }

    }
}
