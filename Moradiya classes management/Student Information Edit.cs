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
using System.Security.Permissions;

namespace Moradiya_classes_management
{
    public partial class Student_Information_Edit : Form
    {
        database d = new database();
        
        public Student_Information_Edit()
        {
            InitializeComponent();
        }

        private void Student_Information_Edit_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //Student_Information.id.ToString()

            string[] information=d.get_student_information_by_id(Student_Information.id.ToString());

            if (information[1] == "")
            {

            }
            else
            {
                using (FileStream fs = new FileStream(information[1], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, (int)fs.Length);
                    using (MemoryStream ms = new MemoryStream(buffer))
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
            }

            Student_ID.Text = information[0];
            image_path.Text = information[1];
            First_Name.Text = information[2];
            Last_Name.Text = information[3];
            Middle_Name.Text = information[4];
            if(information[5]!="")
            {
                BirthDate.Value = DateTime.Parse(information[5]);
            }
            Gender.Text = information[6];
            Address.Text = information[7];
            Class.Text = information[8];
            Mobile_No.Text = information[9];
            Phone_No.Text = information[10];

        }

        private void Chose_Image_Click(object sender, EventArgs e)
        {
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
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string[] information = d.get_student_information_by_id(Student_Information.id.ToString());

            string imgpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Classes Management\\student\\" + information[2] + " " + information[3] + ".jpg";
            string imagepath_new = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Classes Management\\student\\" + First_Name.Text + " " + Last_Name.Text + ".jpg";
            int mobilenodefault = 0;
            if ((Class.Text == "1" || Class.Text == "2" || Class.Text == "3" || Class.Text == "4" || Class.Text == "5" || Class.Text == "6" || Class.Text == "7" || Class.Text == "8" || Class.Text == "9" || Class.Text == "10" || Class.Text == "11-com" || Class.Text == "12-com" || Class.Text == "11-sci" || Class.Text == "12-sci") && (Gender.Text == "Male" || Gender.Text == "Female") && (Mobile_No.Text.Length == 10 || Phone_No.Text.Length == 10))
            {

                //this try and catch block is for image settle
                //here what happend when the image is not changed than it's not work properly
                //so what we have to do just put it in try and catch block if image will be change
                //than it will change image other vise image will be as it is
                
                if(image_path.Text != imgpath)
                {
                    //below line is for give permission to image to delete the image
                    File.SetAttributes(imgpath, FileAttributes.Normal);
                    //below line is for delete image
                    System.IO.File.Delete(imgpath);
                    System.IO.File.Copy(image_path.Text, imagepath_new);
                }
                else if(information[2] != First_Name.Text || information[3] != Last_Name.Text)
                {
                    //below line is for give permission to image to delete the image
                    File.SetAttributes(imgpath, FileAttributes.Normal);
                    System.IO.File.Copy(imgpath, imagepath_new);
                    //below line is for delete image
                    System.IO.File.Delete(imgpath);
                }

                if (Mobile_No.Text.Length == 10 && Phone_No.Text.Length == 10)
                    {
                        d.update_student(Student_Information.id, imagepath_new, First_Name.Text, Last_Name.Text, Middle_Name.Text, BirthDate.Text, Gender.Text, Address.Text, Class.Text, Convert.ToInt64(Mobile_No.Text), Convert.ToInt64(Phone_No.Text));
                        MessageBox.Show("Update Student Successfull");
                    }
                    else if (Mobile_No.Text.Length == 10 && (Phone_No.Text == null || Phone_No.Text == "" || Phone_No.Text == " " || Phone_No.Text == "0"))
                    {
                        d.update_student(Student_Information.id, imagepath_new, First_Name.Text, Last_Name.Text, Middle_Name.Text, BirthDate.Text, Gender.Text, Address.Text, Class.Text, Convert.ToInt64(Mobile_No.Text), mobilenodefault);
                        MessageBox.Show("Update Student Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Enter valid mobile No");
                    }

               
            }
            else
            {
                MessageBox.Show("Enter Valid details");
            }
        }
    }
}
