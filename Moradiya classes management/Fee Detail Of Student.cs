using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradiya_classes_management
{
    public partial class Fee_Detail_Of_Student : Form
    {
        database d = new database();
        public static string id,Class;
        DataGridViewButtonColumn View_Fees = new DataGridViewButtonColumn();
        public Fee_Detail_Of_Student()
        {
            InitializeComponent();
        }

        private void Fee_Detail_Of_Student_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,mobile_no_1 from student where class='" + comboBox1.Text + "'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
                
                //code for display buttons in data gridview
                
                View_Fees.Name = "View_Fees";
                View_Fees.DisplayIndex = 6;
                View_Fees.HeaderText = "View_Fees";
                View_Fees.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                View_Fees.UseColumnTextForButtonValue = true;
                View_Fees.Text = "View";
                View_Fees.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(View_Fees);

            }
            d.con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Student")
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "select s_id,f_name,l_name,m_name,mobile_no_1 from student where class='" + comboBox1.Text + "'";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    View_Fees.DisplayIndex = 5;
                }
                d.con.Close();
            }
            else
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "SELECT * FROM fee_paid, (select total_fees from total_fees where class='" + comboBox1.Text + "') where class='" + comboBox1.Text + "'  order by f_date";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    View_Fees.DisplayIndex = 5;
                }
                d.con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Student")
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "select s_id,f_name,l_name,m_name,mobile_no_1 from student where class='" + comboBox1.Text + "'";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    View_Fees.DisplayIndex = 5;
                }
                d.con.Close();
            }
            else
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "SELECT * FROM fee_paid, (select total_fees from total_fees where class='" + comboBox1.Text + "') where class='" + comboBox1.Text + "'  order by f_date";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    View_Fees.DisplayIndex = 5;
                }
                d.con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["View_Fees"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[1].Value.ToString();
                Class = comboBox1.Text;
                //MessageBox.Show(row.Cells[1].Value.ToString());

                Fee_Detail_Of_Student_View fdosv = new Fee_Detail_Of_Student_View();
                fdosv.ShowDialog();

            }
        }
    }
}
