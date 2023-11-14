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
    public partial class Fee_Update_Change : Form
    {
        database d = new database();
        public Fee_Update_Change()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fee_Update_Change_Load(object sender, EventArgs e)
        {
            Class.Text = Fee_Update.Class;
            New_Fees.Text = Fee_Update.amount;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(New_Fees.Text == "" || New_Fees.Text == " " || New_Fees.Text == null)
            {
                MessageBox.Show("Enter Valid Amount");
            }
            else
            {
                d.update_fees(Class.Text, New_Fees.Text);
                MessageBox.Show("Update Successfully");
            }
        }
    }
}
