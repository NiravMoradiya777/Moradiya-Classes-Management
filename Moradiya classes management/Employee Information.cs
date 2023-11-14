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
    public partial class Employee_Information : Form
    {
        database d = new database();
        public static string id;
        public Employee_Information()
        {
            InitializeComponent();
        }

        private void Employee_Information_Load(object sender, EventArgs e)
        {
            //code for view data in data gridview
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select e_id,f_name,l_name,m_name,dob,mobile_no_1 from employee";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview
                DataGridViewButtonColumn View_column = new DataGridViewButtonColumn();
                View_column.Name = "View_column";
                View_column.HeaderText = "View";
                View_column.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                View_column.UseColumnTextForButtonValue = true;
                View_column.Text = "View";
                View_column.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(View_column);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["View_column"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[3].Value.ToString();
                //MessageBox.Show(row.Cells[3].Value.ToString());

                Employee_information_view eiv = new Employee_information_view();
                eiv.ShowDialog();

            }

            if (e.ColumnIndex == senderGrid.Columns["Edit_column"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[3].Value.ToString();
                //MessageBox.Show(row.Cells[3].Value.ToString());

                Employe_Information_Edit eie = new Employe_Information_Edit();
                eie.ShowDialog();
            }
            if (e.ColumnIndex == senderGrid.Columns["Delete_column"].Index && e.RowIndex >= 0)
            {
                
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Teacher
            //Assistant Teacher
            //All

            if (comboBox1.Text=="Teacher" || comboBox1.Text == "Assistant_Teacher")
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "select e_id,f_name,l_name,m_name,dob,mobile_no_1 from employee where employe_type = '"+ comboBox1.Text + "'";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                d.con.Close();
            }
            else
            {
                d.con.Open();
                d.cmd = d.con.CreateCommand();
                string CommandText = "select e_id,f_name,l_name,m_name,dob,mobile_no_1 from employee";
                d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
                DataTable dt;
                using (dt = new DataTable())
                {
                    d.adepter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                d.con.Close();
            }
            
        }
    }
}
