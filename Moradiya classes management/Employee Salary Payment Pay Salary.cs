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
    public partial class Employee_Salary_Payment_Pay_Salary : Form
    {
        database d = new database();
        public Employee_Salary_Payment_Pay_Salary()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Salary_Payment_Pay_Salary_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);
            string[] information;
            int paid_salary, total_salary;

            //Student_Information.id.ToString()
            information = d.get_employe_information_by_id(Employee_Salary_Payment.id.ToString());
            paid_salary = d.get_paid_salary(Employee_Salary_Payment.id.ToString());
            total_salary = d.get_total_salary(Employee_Salary_Payment.id.ToString());

            if (information[1] == "")
            {

            }
            else
            {
                //MessageBox.Show(information[1]);
                pictureBox1.Image = Image.FromFile(information[1]);
            }

            Employee_ID.Text = information[0];
            Full_Name.Text = information[2] + " " + information[3];
            First_Name.Text = information[2];
            Last_Name.Text = information[3];
            Middle_Name.Text = information[4];
            Employee_Type.Text = information[11];
            Total_Salary.Text = total_salary.ToString();
            Paid_Salary.Text = paid_salary.ToString();
            Remaining.Text = (total_salary - paid_salary).ToString();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (Amount.Text == "Enter Amount Here")
            {
                MessageBox.Show("Enter Valid Amount");
            }
            try
            {
                int amount = Convert.ToInt32(Amount.Text);
                if (amount > Convert.ToInt32(Remaining.Text))
                {
                    MessageBox.Show("Remaining Fees Is Less");
                }
                else
                {
                    d.salary_paid(Employee_ID.Text, First_Name.Text, Last_Name.Text, Middle_Name.Text, DateTime.Now.ToString("yyyy-MM-dd"), amount.ToString());
                    MessageBox.Show("Payment Successfull");
                }
            }
            catch
            {
                MessageBox.Show("Amount Must Be In Numerical");
            }
        }
    }
}
