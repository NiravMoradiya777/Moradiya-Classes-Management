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
    public partial class Form1 : Form
    {
        public Form1()
        {
            new connect();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
            Password.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            //this code is for developer when customer forget password
            if (Username.Text == "Master")
            {
                if (Password.Text == "i am nirav moradiya" || Password.Text == "I Am Nirav Moradiya" || Password.Text == "I am Nirav Moradiya")
                {
                    string admin_password = d.get_password("Admin");
                    string teacher_password = d.get_password("Teacher");
                    MessageBox.Show(admin_password);
                    MessageBox.Show(teacher_password);
                }
            }

            if (Username.Text=="Admin"||Username.Text=="admin")
            {
                string password=d.get_password("Admin");
                if(Password.Text==password)
                {
                    this.Hide();
                    MDIParent1 mdi = new MDIParent1();
                    mdi.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    Password.Text="";
                    MessageBox.Show("Enter valid password");
                }
            }
            else if(Username.Text == "Teacher" || Username.Text == "teacher")
            {
                string password = d.get_password("Teacher");
                if (Password.Text == password)
                {
                    this.Hide();
                    MDIParent2 mdi = new MDIParent2();
                    mdi.ShowDialog();
                    this.Close();

                }
                else
                {
                    Password.Text = "";
                    MessageBox.Show("Enter valid password");
                }
            }
            else
            {
                MessageBox.Show("Enter valid username");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contect your service provider");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
