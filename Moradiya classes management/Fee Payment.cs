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
    public partial class Fee_Payment : Form
    {
        public static string id,Class;
        database d = new database();
        public Fee_Payment()
        {
            InitializeComponent();
        }

        private void Fee_Payment_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select s_id,f_name,l_name,m_name,mobile_no_1 from student where class='" + comboBox1.Text + "'";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataGridViewButtonColumn Pay_Fees = new DataGridViewButtonColumn();
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview

                Pay_Fees.Name = "Pay_Fees";
                Pay_Fees.DisplayIndex = 6;
                Pay_Fees.HeaderText = "Pay_Fees";
                Pay_Fees.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Pay_Fees.UseColumnTextForButtonValue = true;
                Pay_Fees.Text = "Pay_Fees";
                Pay_Fees.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Pay_Fees);

            }
            d.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["Pay_Fees"].Index && e.RowIndex >= 0)
            {
                //code for retrive id from selected row on clicking of view button
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[1].Value.ToString();
                Class = comboBox1.Text;
                //MessageBox.Show(row.Cells[4].Value.ToString());

                Fee_Payment_Pay_Fee fppf = new Fee_Payment_Pay_Fee();
                fppf.ShowDialog();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            d.con.Close();
        }
    }
}
