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
    public partial class Enter_Course : Form
    {
        database d = new database();
        public Enter_Course()
        {
            InitializeComponent();
        }

        private void Subject_Name_Click(object sender, EventArgs e)
        {
            Subject_Name.Text = "";
            label3.Visible = true;
            label9.BackColor= Color.FromArgb(33, 169, 225);
            label21.BackColor = Color.Black;
        }

        private void Class_Click(object sender, EventArgs e)
        {
            Class.Text = "";
            label15.Visible = true;
            label21.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subject_Name.Text = "";
            label3.Visible = true;
            Class.Text = "";
            label15.Visible = true;
            label21.BackColor = Color.Black;
            label9.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Class.Text == "1" || Class.Text == "2" || Class.Text == "3" || Class.Text == "4" || Class.Text == "5" || Class.Text == "6" || Class.Text == "7" || Class.Text == "8" || Class.Text == "9" || Class.Text == "10" || Class.Text == "11-com" || Class.Text == "12-com" || Class.Text == "11-sci" || Class.Text == "12-sci")
            {
                if(Subject_Name.Text==""  || Subject_Name.Text== "Subject Name" || Subject_Name.Text == null)
                {
                    MessageBox.Show("Enter Valid Subject Name");
                }
                else
                {
                    d.add_subject(Class.Text, Subject_Name.Text);
                    MessageBox.Show("Subject Added Succesfully");
                    Subject_Name.Text = "";
                    label3.Visible = true;
                    Class.Text = "";
                    label15.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Class Name");
            }
                
        }
    }
}
