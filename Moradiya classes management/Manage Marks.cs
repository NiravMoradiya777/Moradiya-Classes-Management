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
    public partial class Manage_Marks : Form
    {
        database d = new database();
        public Manage_Marks()
        {
            InitializeComponent();
        }

        private void Manage_Marks_Load(object sender, EventArgs e)
        {
            //ExamDate.Text = "2017-10-19";
            //code for display data on datagridview

            string[] subjects = d.get_subject_by_class(Class.Text);
            Subject.Items.Clear();
            foreach (string sub in subjects)
            {
                if (sub == "" || sub == null)
                {
                    break;
                }
                //MessageBox.Show(sub);
                Subject.Items.Add(sub);
            }

            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,subject_name,total_marks from student,(select subject_name,total_marks from exam where class ='" + Class.Text+"' and e_date = '"+ExamDate.Text+"') where class='" + Class.Text + "' order by s_id;";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                DataGridViewTextBoxColumn Obtain_Marks = new DataGridViewTextBoxColumn();
                Obtain_Marks.Name = "Obtain_Marks";
                Obtain_Marks.HeaderText = "Obtain_Marks";
                dataGridView1.Columns.Add(Obtain_Marks);

                //code for display buttons in data gridview
                DataGridViewButtonColumn Add_Marks = new DataGridViewButtonColumn();
                Add_Marks.Name = "Add_Marks";
                Add_Marks.HeaderText = "Add_Marks";
                Add_Marks.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Add_Marks.UseColumnTextForButtonValue = true;
                Add_Marks.Text = "Add_Marks";
                Add_Marks.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Add_Marks);

            }
            d.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //below code is for change color when we enter marks

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Red;


            if (e.ColumnIndex == senderGrid.Columns["Add_Marks"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //MessageBox.Show(row.Cells[0].Value.GetType().ToString());
                try
                {
                    if (Convert.ToInt32(row.Cells[0].Value.ToString()) > Convert.ToInt32(row.Cells[6].Value.ToString()))
                    {
                        MessageBox.Show("Obtain Marks must be lessthan total marks");
                    }
                    else
                    {
                        d.add_marks(row.Cells[2].Value.ToString(), Class.Text, Subject.Text, ExamDate.Text, row.Cells[6].Value.ToString(), row.Cells[0].Value.ToString());
                        row.DefaultCellStyle = style;
                    }
                    //MessageBox.Show(row.Cells[6].Value.ToString());
                    //MessageBox.Show(row.Cells[0].Value.ToString());
                }
                catch(Exception)
                {
                    MessageBox.Show("Enter Marks");
                }
                

            }
        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] subjects = d.get_subject_by_class(Class.Text);
            Subject.Items.Clear();
            foreach (string sub in subjects)
            {
                if (sub == "" || sub == null)
                {
                    break;
                }
                //MessageBox.Show(sub);
                Subject.Items.Add(sub);
            }

            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,subject_name,total_marks from student,(select subject_name,total_marks from exam where class ='" + Class.Text + "' and e_date = '" + ExamDate.Text + "') where class='" + Class.Text + "' order by s_id;";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        private void ExamDate_ValueChanged(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,subject_name,total_marks from student,(select subject_name,total_marks from exam where class ='" + Class.Text + "' and e_date = '" + ExamDate.Text + "') where class='" + Class.Text + "' order by s_id;";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        private void Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,subject_name,total_marks from student,(select subject_name,total_marks from exam where class ='" + Class.Text + "' and e_date = '" + ExamDate.Text + "') where class='" + Class.Text + "' order by s_id;";
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
