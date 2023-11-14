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
    public partial class Student_Information : Form
    {
        database d = new database();
        public static string id;
        public Student_Information()
        {
            InitializeComponent();
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            //code for display data on datagridview
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,dob,mobile_no_1 from student where class='"+comboBox1.Text+"'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
                //DataGridViewComboBoxColumn combobox_column = new DataGridViewComboBoxColumn();
                //combobox_column.HeaderText = "Edit";
                ////combobox_column.UseColumnTextForComboBox = true;
                //combobox_column.Items.Add("Update");
                //combobox_column.Items.Add("Delete");
                ////combobox_column.FlatStyle = FlatStyle.Flat;
                //dataGridView1.Columns.Add(combobox_column);
                //combobox_column.Name = "combobox_column";
                ////dataGridView1.Rows[0].Cells["Edit"].ReadOnly = false;

                //code for display buttons in data gridview
                DataGridViewButtonColumn View_column = new DataGridViewButtonColumn();
                View_column.Name = "View_column";
                View_column.HeaderText = "View";
                View_column.CellTemplate.Style.BackColor = Color.FromArgb(0,166,90);
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

                Student_Information_View siv = new Student_Information_View();
                siv.ShowDialog();

            }

            if (e.ColumnIndex == senderGrid.Columns["Edit_column"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[3].Value.ToString();
                //MessageBox.Show(row.Cells[3].Value.ToString());

                Student_Information_Edit sie = new Student_Information_Edit();
                sie.ShowDialog();
            }
            if (e.ColumnIndex == senderGrid.Columns["Delete_column"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete this student", "Sure",MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //this code is for delete image also from document folder

                    string[] information = d.get_student_information_by_id(row.Cells[3].Value.ToString());
                    //string imgpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Classes Management\\student\\" + information[2] + " " + information[3] + ".jpg";
                    //System.IO.File.Delete(imgpath);

                    DateTime oDate = Convert.ToDateTime(information[5]);
                    //this code is for enter student in delete student table
                    d.student_in_delete_table(information[0], information[1], information[2], information[3], information[4], oDate.ToString("yyyy-MM-dd"), information[6], information[7],  Convert.ToInt64(information[9]), Convert.ToInt64(information[10]), information[8]);

                    d.delete_student(row.Cells[3].Value.ToString());
                    MessageBox.Show("Student Delete Successfully");

                }
                else if(dr==DialogResult.No)
                {
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,dob,mobile_no_1 from student where class='" + comboBox1.Text + "'";
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
