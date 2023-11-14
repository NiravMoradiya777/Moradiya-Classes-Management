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
    public partial class Deleted_Student : Form
    {
        database d = new database();
        public Deleted_Student()
        {
            InitializeComponent();
        }

        private void Deleted_Student_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from deleted_student";
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
