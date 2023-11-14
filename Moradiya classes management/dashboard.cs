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
    public partial class dashboard : Form
    {
        database d = new database();
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            d.cmd.CommandText = "select count(*) from student";
            int student = Convert.ToInt32(d.cmd.ExecuteScalar());
            d.cmd.CommandText = "select count(*) from employee";
            int employe = Convert.ToInt32(d.cmd.ExecuteScalar());
            label3.Text = student.ToString();
            label6.Text = employe.ToString();
            d.con.Close();
        }
    }
}
