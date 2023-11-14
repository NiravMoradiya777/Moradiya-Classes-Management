using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Moradiya_classes_management
{
    public partial class Salary_Update_Change : Form
    {
        database d = new database();
        public Salary_Update_Change()
        {
            InitializeComponent();
        }

        private void Salary_Update_Change_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //Student_Information.id.ToString()

            string[] information = d.get_employe_information_by_id(Salary_Update.id.ToString());

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
            Employe_ID.Text = information[0];
            Full_Name.Text = information[2] + " " + information[3];
            First_Name.Text = information[2];
            Last_Name.Text = information[3];
            Middle_Name.Text = information[4];
            if (information[5] != "")
            {
                BirthDate.Value = DateTime.Parse(information[5]);
            }
            Gender.Text = information[6];
            Address.Text = information[7];
            Mobile_No.Text = information[8];
            Phone_No.Text = information[9];
            Employe_Salary.Text = information[10];
            Employe_Type.Text = information[11];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Employe_Salary.Text=="" || Employe_Salary.Text== " " || Employe_Salary.Text == null)
            {
                MessageBox.Show("Enter valid amount");
            }
            else
            {
                d.update_salary(Employe_ID.Text,Employe_Salary.Text);
                MessageBox.Show("Salary Update Successfully");
            }
        }
    }
}
