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
    public partial class Student_Marksheet : Form
    {
        database d = new database();
        public static string id;
        public Student_Marksheet()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["View_Result"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[1].Value.ToString();

                Student_Marksheet_View_Result smvr = new Student_Marksheet_View_Result();
                smvr.ShowDialog();

            }
        }

        private void Student_Marksheet_Load(object sender, EventArgs e)
        {
            //code for display data on datagridview
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,class from student where class = '"+ Class.Text +"'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview
                DataGridViewButtonColumn View_column = new DataGridViewButtonColumn();
                View_column.Name = "View_Result";
                View_column.HeaderText = "View_Result";
                View_column.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                View_column.UseColumnTextForButtonValue = true;
                View_column.Text = "View_Result";
                View_column.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(View_column);
            }
            d.con.Close();
        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,class from student where class = '" + Class.Text + "'";
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
