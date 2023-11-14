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
    public partial class All_Course : Form
    {
        database d = new database();
        public All_Course()
        {
            InitializeComponent();
        }

        private void All_Course_Load(object sender, EventArgs e)
        {
            //code for display data on datagridview
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from class_subject where class='" + comboBox1.Text + "'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview
                DataGridViewButtonColumn Delete_column = new DataGridViewButtonColumn();
                Delete_column.Name = "Delete_column";
                Delete_column.HeaderText = "Delete";
                Delete_column.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Delete_column.UseColumnTextForButtonValue = true;
                Delete_column.Text = "Delete";
                Delete_column.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Delete_column);
            }
            d.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from class_subject where class='" + comboBox1.Text + "'";
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
            if (e.ColumnIndex == senderGrid.Columns["Delete_column"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete this student", "Sure", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //this code is for delete image also from document folder

                    d.delete_subject(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                    MessageBox.Show("Student Delete Successfully");

                    //elow is for refresh datagridview
                    d.con.Open();
                    d.cmd = d.con.CreateCommand();
                    string CommandText = "select * from class_subject where class='" + comboBox1.Text + "'";
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
