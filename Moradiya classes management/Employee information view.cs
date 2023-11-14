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
    public partial class Employee_information_view : Form
    {
        database d = new database();
        public Employee_information_view()
        {
            InitializeComponent();
        }

        private void Employee_information_view_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //Student_Information.id.ToString()
            string[] information = d.get_employe_information_by_id(Employee_Information.id.ToString());

            if (information[1] == "")
            {

            }
            else
            {
                pictureBox1.Image = Image.FromFile(information[1]);
            }

            Employe_ID.Text = information[0];
            Full_Name.Text = information[2] + " " + information[3];
            BirthDate.Text = information[5];
            Gender.Text = information[6];
            Address.Text = information[7];
            Employe_Type.Text = information[11];
            Mobile_No.Text = information[8];
            Phone_No.Text = information[9];
            Employe_Salary.Text = information[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
