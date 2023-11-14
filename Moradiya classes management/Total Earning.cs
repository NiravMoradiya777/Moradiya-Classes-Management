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
    public partial class Total_Earning : Form
    {
        database d = new database();
        public Total_Earning()
        {
            InitializeComponent();
        }

        private void Total_Earning_Load(object sender, EventArgs e)
        {
            int[] Class = new int[14];
            int[] Fees = new int[14];
            int total_fees=0, arrived_fees=0, total_salary=0, given_salary=0;
            Class[0]= d.total_number_of_student_by_class("1");
            Class[1] = d.total_number_of_student_by_class("2");
            Class[2] = d.total_number_of_student_by_class("3");
            Class[3] = d.total_number_of_student_by_class("4");
            Class[4] = d.total_number_of_student_by_class("5");
            Class[5] = d.total_number_of_student_by_class("6");
            Class[6] = d.total_number_of_student_by_class("7");
            Class[7] = d.total_number_of_student_by_class("8");
            Class[8] = d.total_number_of_student_by_class("9");
            Class[9] = d.total_number_of_student_by_class("10");
            Class[10] = d.total_number_of_student_by_class("11-com");
            Class[11] = d.total_number_of_student_by_class("12-com");
            Class[12] = d.total_number_of_student_by_class("11-sci");
            Class[13] = d.total_number_of_student_by_class("12-sci");

            Fees[0] = d.get_total_fees("1");
            Fees[1] = d.get_total_fees("2");
            Fees[2] = d.get_total_fees("3");
            Fees[3] = d.get_total_fees("4");
            Fees[4] = d.get_total_fees("5");
            Fees[5] = d.get_total_fees("6");
            Fees[6] = d.get_total_fees("7");
            Fees[7] = d.get_total_fees("8");
            Fees[8] = d.get_total_fees("9");
            Fees[9] = d.get_total_fees("10");
            Fees[10] = d.get_total_fees("11-com");
            Fees[11] = d.get_total_fees("12-com");
            Fees[12] = d.get_total_fees("11-sci");
            Fees[13] = d.get_total_fees("12-sci");
            
            for(int i=0;i<14;i++)
            {
                if(Class[i]==0 || Fees[i]==0)
                {

                }
                else
                {
                    total_fees = Class[i] * Fees[i];
                }
            }
            Total_Student_Fees.Text = total_fees.ToString();
            Arrived_Student_Fees.Text = d.get_paid_total_fees().ToString();
            Total_Employee_Salary.Text = d.get_total_salary_of_all_employee().ToString();
            Gave_Employee_Salary.Text = d.get_paid_total_salary().ToString();

            label12.Text = (total_fees - d.get_total_salary_of_all_employee()).ToString();
        }
    }
}
