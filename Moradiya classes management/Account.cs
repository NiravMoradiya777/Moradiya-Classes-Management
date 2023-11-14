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
    public partial class Account : Form
    {
        database d = new database();
        public Account()
        {
            InitializeComponent();
        }

        private void Old_Password_Click(object sender, EventArgs e)
        {
            Old_Password.Text = "";
            label11.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label8.BackColor = Color.Black;
            label4.BackColor = Color.Black;
            label2.BackColor = Color.Black;
        }

        private void New_Password_Click(object sender, EventArgs e)
        {
            New_Password.Text = "";
            label8.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label4.BackColor = Color.Black;
            label2.BackColor = Color.Black;
        }

        private void Teacker_Old_Password_Click(object sender, EventArgs e)
        {
            Teacher_Old_Password.Text = "";
            label4.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label8.BackColor = Color.Black;
            label2.BackColor = Color.Black;
        }

        private void Teacker_New_Password_Click(object sender, EventArgs e)
        {
            Teacher_New_Password.Text = "";
            label2.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label8.BackColor = Color.Black;
            label4.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string old_password = d.get_password("Admin");
            if(Old_Password.Text == old_password)
            {
                if(New_Password.Text == "" || New_Password.Text == " " || New_Password.Text == null || New_Password.Text == "New_Password")
                {
                    MessageBox.Show("Enter Valid New Password");
                }
                else
                {
                    d.change_password("Admin", New_Password.Text);
                    MessageBox.Show("Update Password Successfully");
                    Old_Password.Text = "";
                    New_Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Old Password is Wrong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string old_password = d.get_password("Teacher");
            if (Teacher_Old_Password.Text == old_password)
            {
                if (Teacher_New_Password.Text == "" || Teacher_New_Password.Text == " " || Teacher_New_Password.Text == null || Teacher_New_Password.Text == "New_Password")
                {
                    MessageBox.Show("Enter Valid New Password");
                }
                else
                {
                    d.change_password("Teacher", New_Password.Text);
                    MessageBox.Show("Update Password Successfully");
                    Teacher_Old_Password.Text = "";
                    Teacher_New_Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Old Password is Wrong");
            }
        }
    }
}
