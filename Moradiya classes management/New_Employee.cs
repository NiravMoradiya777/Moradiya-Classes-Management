using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moradiya_classes_management
{
    public partial class New_Employee : Form
    {
        public New_Employee()
        {
            InitializeComponent();
        }

        private void New_Employee_Load(object sender, EventArgs e)
        {
            database d = new database();
            int a = d.give_new_id("e_id", "employee");
            Employee_ID.Text = a.ToString();

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mobile_No_2.Text = "";
            First_Name.Text = "";
            Last_Name.Text = "";
            Middle_Name.Text = "";
            Birth_Date.Text = "";
            Address.Text = "";
            Mobile_No_1.Text = "";
            Gender.Text = "";
            Employee_Type.Text = "";
            pictureBox1.Image = null;
            Employee_Salary.Text = "";

            //withour selecting any text box if user select reset than what??
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
            label22.Visible = true;
        }

        private void First_Name_Click(object sender, EventArgs e)
        {
            //for first name
            //this code is for change color of underline and display big lable
            if (First_Name.Text == "First Name")
            {
                First_Name.Text = "";
            }
            label3.Visible = true;
            label9.BackColor = Color.FromArgb(33, 169, 225);
            First_Name.ForeColor = Color.FromArgb(48, 54, 65);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            //label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Last_Name_Click(object sender, EventArgs e)
        {
            // for last name
            //this code is for change color of underline and display big lable
            if (Last_Name.Text == "Last Name")
            {
                Last_Name.Text = "";
            }
            label4.Visible = true;
            label10.BackColor = Color.FromArgb(33, 169, 225);
            Last_Name.ForeColor = Color.FromArgb(48, 54, 65);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            //label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Middle_Name_Click(object sender, EventArgs e)
        {
            //for middlw name
            //this code is for change color of underline and display big lable
            if (Middle_Name.Text == "Middle Name")
            {
                Middle_Name.Text = "";
            }
            label5.Visible = true;
            label11.BackColor = Color.FromArgb(33, 169, 225);
            Middle_Name.ForeColor = Color.FromArgb(48, 54, 65);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            //label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Address_Click(object sender, EventArgs e)
        {
            //for address
            //this code is for change color of underline and display big lable
            if (Address.Text == "Address")
            {
                Address.Text = "";
            }
            label13.Visible = true;
            Address.ForeColor = Color.FromArgb(48, 54, 65);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Gender_Click(object sender, EventArgs e)
        {
            //for gender
            //this code is for change color of underline and display big lable
            if (Gender.Text == "Gender")
            {
                Gender.Text = "";
            }
            label14.Visible = true;
            Gender.ForeColor = Color.FromArgb(48, 54, 65);
            label20.BackColor = Color.FromArgb(33, 169, 225);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            //label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Employee_Type_Click(object sender, EventArgs e)
        {
            //for Employee_Type
            //this code is for change color of underline and display big lable
            if (Employee_Type.Text == "Class")
            {
                Employee_Type.Text = "";
            }
            label15.Visible = true;
            Employee_Type.ForeColor = Color.FromArgb(48, 54, 65);
            label21.BackColor = Color.FromArgb(33, 169, 225);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            //label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Mobile_No_1_Click(object sender, EventArgs e)
        {
            // for mobile no 1
            //this code is for change color of underline and display big lable
            if (Mobile_No_1.Text == "Mobile No 1")
            {
                Mobile_No_1.Text = "";
            }
            label16.Visible = true;
            Mobile_No_1.ForeColor = Color.FromArgb(48, 54, 65);
            label17.BackColor = Color.FromArgb(33, 169, 225);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            //label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Mobile_No_2_Click(object sender, EventArgs e)
        {
            // for mobile no 2
            //this code is for change color of underline and display big lable
            if (Mobile_No_2.Text == "Mobile No 2")
            {
                Mobile_No_2.Text = "";
            }
            label18.Visible = true;
            Mobile_No_2.ForeColor = Color.FromArgb(48, 54, 65);
            label19.BackColor = Color.FromArgb(33, 169, 225);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            //label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            //for date of birth
            //this code is for change color of underline and display big lable
            if (Birth_Date.Text == "Birth Date")
            {
                Birth_Date.Text = "";
            }
            label6.Visible = true;
            label12.BackColor = Color.FromArgb(33, 169, 225);
            Birth_Date.ForeColor = Color.FromArgb(48, 54, 65);
            Birth_Date.Text = dateTimePicker1.Text;

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void Employee_Salary_Click(object sender, EventArgs e)
        {
            // for Employee_Salary
            //this code is for change color of underline and display big lable
            if (Employee_Salary.Text == "Employee Salary")
            {
                Employee_Salary.Text = "";
            }
            label22.Visible = true;
            Employee_Salary.ForeColor = Color.FromArgb(48, 54, 65);
            label23.BackColor = Color.FromArgb(33, 169, 225);

            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            //label23.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for chose photo
            //this code is for chose a image of student from computer
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                //img = Image.FromFile(f.FileName);
                //pictureBox1.Image = img;
                //image_path.Text = pictureBox1.ImageLocation;
                //enter picture in picturebox and enter a location in text box
                string path = f.FileName.ToString();
                image_path.Text = path;
                pictureBox1.ImageLocation = path;
            }
            //this code is for change color of other underline when select this one
            label8.BackColor = Color.Black;
            label9.BackColor = Color.Black;
            label10.BackColor = Color.Black;
            label11.BackColor = Color.Black;
            label12.BackColor = Color.Black;
            label17.BackColor = Color.Black;
            label19.BackColor = Color.Black;
            label20.BackColor = Color.Black;
            label21.BackColor = Color.Black;
            label23.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mobilenodefault = 0;
            string imgpath = null;
            if (First_Name.Text == null || Middle_Name.Text == null || Last_Name.Text == null || Birth_Date.Text == null || Address.Text == null || Gender.Text == null || Employee_Type.Text == null || Mobile_No_1.Text == null || First_Name.Text == "First Name" || Middle_Name.Text == "Middle Name" || Last_Name.Text == "Last Name" || Birth_Date.Text == "Birth Date" || Address.Text == "Address" || Gender.Text == "Gender" || Employee_Type.Text == "Employee Type" || Mobile_No_1.Text == "Mobile No 1" || Employee_Salary.Text== "Employee Salary" || Employee_Salary.Text == "")
            {
                if (First_Name.Text != null && Middle_Name.Text != null && Last_Name.Text != null && Birth_Date.Text != null && Address.Text != null && Gender.Text != null && Employee_Type.Text != null && Mobile_No_1.Text == null && Mobile_No_2.Text != null)
                {
                    if (Mobile_No_2.Text != "Mobile No 2")
                    {
                        MessageBox.Show("Please Enter mobile no 2 in mobile no 1");
                    }
                    else
                    {
                        MessageBox.Show("Mobile No 1 is mendetory");
                    }
                }
                else if (First_Name.Text != "First Name" && Middle_Name.Text != "Middle Name" && Last_Name.Text != "Last Name" && Birth_Date.Text != "Birth Date" && Address.Text != "Address" && Gender.Text != "Gender" && Employee_Type.Text != "Employee Type" && Mobile_No_1.Text == "Mobile No 1" && Mobile_No_2.Text == "Mobile No 2")
                {
                    MessageBox.Show("Mobile No 1 is mendetory");
                }
                else if (First_Name.Text != "First Name" && Middle_Name.Text != "Middle Name" && Last_Name.Text != "Last Name" && Birth_Date.Text != "Birth Date" && Address.Text != "Address" && Gender.Text != "Gender" && Employee_Type.Text != "Employee Type" && Mobile_No_1.Text == "Mobile No 1" && Mobile_No_2.Text != "Mobile No 2")
                {
                    if (Mobile_No_2.Text != "Mobile No 2")
                    {
                        MessageBox.Show("Please Enter mobile no 2 in mobile no 1");
                    }
                }
                MessageBox.Show("Enter every detail");
            }
            else if ((Employee_Type.Text == "Teacher" || Employee_Type.Text == "Assistant_Teacher") && (Gender.Text == "Male" || Gender.Text == "Female") && (Mobile_No_1.Text.Length == 10 || Mobile_No_2.Text.Length == 10))
            {
                //hear comment for if we gave a null path for store it's gave exception but but it's also store in database by null because we are using function
                if (image_path.Text == "Image path")
                {
                    image_path.Text = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Resources\\Employe2.png";

                }
                imgpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Classes Management\\Employee\\" + First_Name.Text + " " + Last_Name.Text + ".jpg";

                try
                {
                    database d = new database();
                    if (Mobile_No_2.Text == null || Mobile_No_2.Text == "Mobile No 2" || Mobile_No_2.Text == "")
                    {

                        d.add_new_employee(Employee_ID.Text, imgpath, First_Name.Text, Last_Name.Text, Middle_Name.Text, Birth_Date.Text, Gender.Text, Address.Text, Convert.ToInt64(Mobile_No_1.Text), mobilenodefault, Convert.ToInt64(Employee_Salary.Text),Employee_Type.Text);
                        File.Copy(image_path.Text, imgpath); //hear name of image.jpg);
                        MessageBox.Show("Insert Employee success full");
                        foreach (Form frm in this.MdiChildren)
                        {
                            if (!frm.Focused)
                            {
                                frm.Visible = false;
                                frm.Dispose();
                            }
                        }
                        New_Employee n = new New_Employee();
                        n.MdiParent = this.ParentForm;
                        n.Dock = DockStyle.Fill;
                        n.Show();
                    }
                    else
                    {
                        if (Mobile_No_2.Text.Length != 10)
                        {
                            MessageBox.Show("Enter valid number");
                        }
                        else
                        {
                            d.add_new_employee(Employee_ID.Text, imgpath, First_Name.Text, Last_Name.Text, Middle_Name.Text, Birth_Date.Text, Gender.Text, Address.Text, Convert.ToInt64(Mobile_No_1.Text), Convert.ToInt64(Mobile_No_2.Text), Convert.ToInt64(Employee_Salary.Text), Employee_Type.Text);
                            File.Copy(image_path.Text, imgpath); //hear name of image.jpg);
                            MessageBox.Show("Insert Employee success full");
                            foreach (Form frm in this.MdiChildren)
                            {
                                if (!frm.Focused)
                                {
                                    frm.Visible = false;
                                    frm.Dispose();
                                }
                            }
                            New_Employee n = new New_Employee();
                            n.MdiParent = this.ParentForm;
                            n.Dock = DockStyle.Fill;
                            n.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Check every detail and enter valid details");
            }
        }
    }
}
