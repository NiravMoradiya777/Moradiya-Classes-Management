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
    public partial class Student_Marksheet_View_Result : Form
    {
        database d = new database();
        string sMonth;
        public static string Class, date, subject, marks;

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "January")
            {
                label2.Text = "February";
                sMonth = "02";
            }
            else if (label2.Text == "February")
            {
                label2.Text = "March";
                sMonth = "03";
            }
            else if (label2.Text == "March")
            {
                label2.Text = "April";
                sMonth = "04";
            }
            else if (label2.Text == "April")
            {
                label2.Text = "May";
                sMonth = "05";
            }
            else if (label2.Text == "May")
            {
                label2.Text = "June";
                sMonth = "6";
            }
            else if (label2.Text == "June")
            {
                label2.Text = "July";
                sMonth = "07";
            }
            else if (label2.Text == "July")
            {
                label2.Text = "August";
                sMonth = "08";
            }
            else if (label2.Text == "August")
            {
                label2.Text = "September";
                sMonth = "09";
            }
            else if (label2.Text == "September")
            {
                label2.Text = "October";
                sMonth = "10";
            }
            else if (label2.Text == "October")
            {
                label2.Text = "November";
                sMonth = "11";
            }
            else if (label2.Text == "November")
            {
                label2.Text = "December";
                sMonth = "12";
            }
            else if (label2.Text == "December")
            {
                label2.Text = "January";
                sMonth = "01";
            }

            //below code is for refreshing datagridview when click on moth buttons
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from marks where s_id='" + Student_ID.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employe_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "January")
            {
                label2.Text = "December";
                sMonth = "12";
            }
            else if (label2.Text == "December")
            {
                label2.Text = "November";
                sMonth = "11";
            }
            else if (label2.Text == "November")
            {
                label2.Text = "October";
                sMonth = "10";
            }
            else if (label2.Text == "October")
            {
                label2.Text = "September";
                sMonth = "09";
            }
            else if (label2.Text == "September")
            {
                label2.Text = "August";
                sMonth = "08";
            }
            else if (label2.Text == "August")
            {
                label2.Text = "July";
                sMonth = "07";
            }
            else if (label2.Text == "July")
            {
                label2.Text = "June";
                sMonth = "06";
            }
            else if (label2.Text == "June")
            {
                label2.Text = "May";
                sMonth = "05";
            }
            else if (label2.Text == "May")
            {
                label2.Text = "April";
                sMonth = "04";
            }
            else if (label2.Text == "April")
            {
                label2.Text = "March";
                sMonth = "03";
            }
            else if (label2.Text == "March")
            {
                label2.Text = "February";
                sMonth = "02";
            }
            else if (label2.Text == "February")
            {
                label2.Text = "January";
                sMonth = "01";
            }

            //below code is for refreshing datagridview when click on moth buttons
            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from marks where s_id='" + Student_ID.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();
        }

        public Student_Marksheet_View_Result()
        {
            InitializeComponent();
        }

        private void Student_Marksheet_View_Result_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);
            //Student_Information.id.ToString()
            string[] information = d.get_student_information_by_id(Student_Marksheet.id.ToString());

            if (information[1] == "")
            {

            }
            else
            {
                pictureBox1.Image = Image.FromFile(information[1]);
            }

            Student_ID.Text = information[0];
            Full_Name.Text = information[2] + " " + information[3];

            label2.Text = String.Format("{0:MMMM}", DateTime.Now);
            sMonth = DateTime.Now.ToString("MM");

            d.con.Open();
            d.cmd = d.con.CreateCommand();
            string CommandText = "select * from marks where s_id='" + Student_ID.Text + "' and e_date like'_____" + sMonth + "%'";

            d.adepter = new Finisar.SQLite.SQLiteDataAdapter(CommandText, d.con);
            DataTable dt;
            using (dt = new DataTable())
            {
                d.adepter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            d.con.Close();

            int[] marks = d.get_total_marks_and_obtain_marks_by_id_and_month(Student_ID.Text,sMonth);
            Total_Marks.Text = marks[0].ToString();
            Obtain_Marks.Text = marks[1].ToString();
            try
            {
                double percentage = 100 * marks[1] / marks[0];
                Percentage.Text = percentage.ToString() + " % ";
            }
            catch
            { }
            
        }
    }
}
