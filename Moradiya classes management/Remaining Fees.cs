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
    public partial class Remaining_Fees : Form
    {
        public static string id, Class;
        database d = new database();
        public Remaining_Fees()
        {
            InitializeComponent();
        }

        private void Remaining_Fees_Load(object sender, EventArgs e)
        {
            //code for display data on datagridview
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "SELECT DISTINCT s_id, f_name,l_name,m_name FROM student WHERE (s_id NOT IN (SELECT s_id  FROM final_fee_paid))";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
                
                //code for display buttons in data gridview
                DataGridViewButtonColumn Pay_fees = new DataGridViewButtonColumn();
                Pay_fees.Name = "Pay_fees";
                Pay_fees.HeaderText = "Pay_fees";
                Pay_fees.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Pay_fees.UseColumnTextForButtonValue = true;
                Pay_fees.Text = "Pay_fees";
                Pay_fees.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Pay_fees);

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
                //MessageBox.Show(row.Cells[4].Value.ToString());

                Remaining_fees_pay_fees rfpf = new Remaining_fees_pay_fees();
                rfpf.ShowDialog();

            }
        }
    }
}
