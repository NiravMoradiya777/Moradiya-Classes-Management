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
    public partial class Employee_Salary_Detail : Form
    {
        database d = new database();
        public static string id;
        DataGridViewButtonColumn View_Salary = new DataGridViewButtonColumn();
        public Employee_Salary_Detail()
        {
            InitializeComponent();
        }

        private void Employee_Salary_Detail_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from salary_paid";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview

                View_Salary.Name = "View_Salary";
                View_Salary.DisplayIndex = 6;
                View_Salary.HeaderText = "View_Salary";
                View_Salary.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                View_Salary.UseColumnTextForButtonValue = true;
                View_Salary.Text = "View_Salary";
                View_Salary.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(View_Salary);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["View_Salary"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[1].Value.ToString();
                //MessageBox.Show(row.Cells[1].Value.ToString());

                Employee_Salary_Detail_View esdv = new Employee_Salary_Detail_View();
                esdv.ShowDialog();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
