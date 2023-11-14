using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradiya_classes_management
{
    public partial class Exam_List : Form
    {
        database d = new database();
        string sMonth;
        public static string Class,date,subject,marks;
        public Exam_List()
        {
            InitializeComponent();
        }

        private void Exam_List_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0:MMMM}", DateTime.Now);
            sMonth = DateTime.Now.ToString("MM");

            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;              

                DataGridViewButtonColumn Edit_column = new DataGridViewButtonColumn();
                Edit_column.Name = "Edit_column";
                Edit_column.HeaderText = "Edit";
                Edit_column.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Edit_column.UseColumnTextForButtonValue = true;
                Edit_column.Text = "Edit";
                Edit_column.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Edit_column);

                DataGridViewButtonColumn Delete_column = new DataGridViewButtonColumn();
                Delete_column.Name = "Delete_column";
                Delete_column.HeaderText = "Delete";
                Delete_column.CellTemplate.Style.BackColor = Color.FromArgb(245, 105, 84);
                Delete_column.UseColumnTextForButtonValue = true;
                Delete_column.Text = "Delete";
                Delete_column.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Delete_column);

            }
            d.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "January")
            {
                label2.Text = "December";
                sMonth = "12";
            }
            else if (label2.Text == "December")
            {
                label2.Text = "November";
                sMonth = "11";
            }
            else if (label2.Text == "November")
            {
                label2.Text = "October";
                sMonth = "10";
            }
            else if (label2.Text == "October")
            {
                label2.Text = "September";
                sMonth = "09";
            }
            else if (label2.Text == "September")
            {
                label2.Text = "August";
                sMonth = "08";
            }
            else if (label2.Text == "August")
            {
                label2.Text = "July";
                sMonth = "07";
            }
            else if (label2.Text == "July")
            {
                label2.Text = "June";
                sMonth = "06";
            }
            else if (label2.Text == "June")
            {
                label2.Text = "May";
                sMonth = "05";
            }
            else if (label2.Text == "May")
            {
                label2.Text = "April";
                sMonth = "04";
            }
            else if (label2.Text == "April")
            {
                label2.Text = "March";
                sMonth = "03";
            }
            else if (label2.Text == "March")
            {
                label2.Text = "February";
                sMonth = "02";
            }
            else if (label2.Text == "February")
            {
                label2.Text = "January";
                sMonth = "01";
            }

            //below code is for refreshing datagridview when click on moth buttons
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();

        }

        private void Add_New_Exam_Click(object sender, EventArgs e)
        {
            Add_New_Exam ane = new Add_New_Exam();
            ane.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "January")
            {
                label2.Text = "February";
                sMonth = "02";
            }
            else if (label2.Text == "February")
            {
                label2.Text = "March";
                sMonth = "03";
            }
            else if (label2.Text == "March")
            {
                label2.Text = "April";
                sMonth = "04";
            }
            else if (label2.Text == "April")
            {
                label2.Text = "May";
                sMonth = "05";
            }
            else if (label2.Text == "May")
            {
                label2.Text = "June";
                sMonth = "6";
            }
            else if (label2.Text == "June")
            {
                label2.Text = "July";
                sMonth = "07";
            }
            else if (label2.Text == "July")
            {
                label2.Text = "August";
                sMonth = "08";
            }
            else if (label2.Text == "August")
            {
                label2.Text = "September";
                sMonth = "09";
            }
            else if (label2.Text == "September")
            {
                label2.Text = "October";
                sMonth = "10";
            }
            else if (label2.Text == "October")
            {
                label2.Text = "November";
                sMonth = "11";
            }
            else if (label2.Text == "November")
            {
                label2.Text = "December";
                sMonth = "12";
            }
            else if (label2.Text == "December")
            {
                label2.Text = "January";
                sMonth = "01";
            }

            //below code is for refreshing datagridview when click on moth buttons
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //below code is for refreshing datagridview when click on moth buttons
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == senderGrid.Columns["Edit_column"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Class = row.Cells[2].Value.ToString();
                DateTime date1 = Convert.ToDateTime(row.Cells[4].Value.ToString());
                date = date1.ToString("yyyy-MM-dd");
                subject = row.Cells[3].Value.ToString();
                marks = row.Cells[5].Value.ToString();
                //MessageBox.Show(row.Cells[2].Value.ToString());
                Exam_List_Edit ele = new Exam_List_Edit();
                ele.ShowDialog();

                //refresh datagridview
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                d.con.Close();
            }


            if (e.ColumnIndex == senderGrid.Columns["Delete_column"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete this exam", "Sure", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DateTime date1 = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    string date_for_delete = date1.ToString("yyyy-MM-dd");
                    d.delete_exam(row.Cells[2].Value.ToString(), date_for_delete);
                    MessageBox.Show("Exam Delete Successfully");

                    //refresh datagridview
                    d.con.Open();
                    d.cmd = d.con.CreateCommand();
                    string CommandText = "select * from exam where class='" + comboBox1.Text + "' and e_date like'_____" + sMonth + "%'";
                    d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                    DataTable dt;
                    using (dt = new DataTable())
                    {
                        d.adepter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    d.con.Close();

                }
                else if (dr == DialogResult.No)
                {

                }
            }
        }
    }
}
