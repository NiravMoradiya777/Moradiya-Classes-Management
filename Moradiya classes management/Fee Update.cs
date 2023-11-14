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
    public partial class Fee_Update : Form
    {
        database d = new database();
        public static string amount, Class;
        DataGridViewButtonColumn Change = new DataGridViewButtonColumn();
        public Fee_Update()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Class = row.Cells[1].Value.ToString();
            amount = row.Cells[2].Value.ToString();
            //MessageBox.Show(row.Cells[0].Value.ToString());
            Fee_Update_Change fuc = new Fee_Update_Change();
            fuc.ShowDialog();
        }

        private void Fee_Update_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from total_fees";
            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;

                //code for display buttons in data gridview

                Change.Name = "Change";
                Change.DisplayIndex = 6;
                Change.HeaderText = "Change";
                Change.CellTemplate.Style.BackColor = Color.FromArgb(0, 166, 90);
                Change.UseColumnTextForButtonValue = true;
                Change.Text = "Change";
                Change.FlatStyle = FlatStyle.Flat;
                dataGridView1.Columns.Add(Change);
            }
            d.con.Close();
        }
    }
}
