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
    public partial class Fee_Detail_Of_Student_View : Form
    {
        database d = new database();
        public Fee_Detail_Of_Student_View()
        {
            InitializeComponent();
        }

        private void Fee_Detail_Of_Student_View_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //Student_Information.id.ToString()

            string[] information = d.get_student_information_by_id(Fee_Detail_Of_Student.id.ToString());
            int paid_fee = d.get_paid_fees(Fee_Detail_Of_Student.id.ToString());
            int total_fee = d.get_total_fees(Fee_Detail_Of_Student.Class.ToString());
            if (information[1] == "")
            {

            }
            else
            {
                //MessageBox.Show(information[1]);
                pictureBox1.Image = Image.FromFile(information[1]);
            }

            Student_ID.Text = information[0];
            Full_Name.Text = information[2] + " " + information[3];
            First_Name.Text = information[2];
            Last_Name.Text = information[3];
            Middle_Name.Text = information[4];
            Class.Text = information[8];
            Total_Fees.Text = total_fee.ToString();
            Paid_Fees.Text = paid_fee.ToString();
            Remaining.Text = (total_fee - paid_fee).ToString();
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
