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
    public partial class Salary_Update : Form
    {
        database d = new database();
        public static string id;
        DataGridViewButtonColumn Change_salary = new DataGridViewButtonColumn();
        public Salary_Update()
        {
            InitializeComponent();
        }

        private void Salary_Update_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select e_id,f_name,m_name,l_name,salary,employe_type from employee";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview

                Change_salary.Name = "Change_salary";
                Change_salary.DisplayIndex = 6;
                Change_salary.HeaderText = "Change_salary";
                Change_salary.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Change_salary.UseColumnTextForButtonValue = true;
                Change_salary.Text = "Change_salary";
                Change_salary.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Change_salary);
            }
            d.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = row.Cells[1].Value.ToString();
            //MessageBox.Show(row.Cells[1].Value.ToString());
            Salary_Update_Change suc = new Salary_Update_Change();
            suc.ShowDialog();
        }
    }
}
