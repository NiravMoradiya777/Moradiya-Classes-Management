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
    public partial class New_Acedemic_Year : Form
    {
        database d = new database();
        public New_Acedemic_Year()
        {
            InitializeComponent();
        }

        private void User_ID_Click(object sender, EventArgs e)
        {
            User_ID.Text = "";

        }

        private void User_ID_TextChanged(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(33, 169, 225);
            label8.BackColor = Color.Black;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            label8.BackColor = Color.FromArgb(33, 169, 225);
            label9.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (User_ID.Text == "Master")
            {
                if (Password.Text == "i am nirav moradiya" || Password.Text == "I Am Nirav Moradiya" || Password.Text == "I am Nirav Moradiya")
                {
                    DialogResult dr = MessageBox.Show("Do you want to go for next year", "Sure", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        d.con.Open();
                        d.cmd = d.con.CreateCommand();
                        //cmd.CommandText = "update student (s_photo,f_name,l_name,m_name,dob,gender,address,class,mobile_no_1,mobile_no_2) set ('" + img + "', '" + f_name + "', '" + l_name + "', '" + m_name + "', '" + date + "', '" + address + "', '" + gender + "', '" + std + "', '" + no_1 + "', '" + no_2 + "');";

                        //d.cmd.CommandText = "select count(s_id) from student where class = '12-com' or class = '12-sci'";
                        //int size = Convert.ToInt32(d.cmd.ExecuteScalar());
                        //d.con.Close();
                        //string[,] arr = d.get_all_data_of_all_student_fot_new_academic_year(size);

                        //d.con.Open();
                        //for (int x = 0; x < arr.GetLength(0); x++)
                        //{

                        //    d.cmd.CommandText = "insert into deleted_student values('" + arr[x, 0] + "', '" + arr[x, 1] + "', '" + arr[x, 2] + "', '" + arr[x, 3] + "', '" + arr[x, 4] + "', '" + arr[x, 5] + "', '" + arr[x, 6] + "', '" + arr[x, 7] + "',  '" + Convert.ToInt64(arr[x, 9]) + "', '" + Convert.ToInt64(arr[x, 10]) + "','Empty')";
                        //    d.cmd.ExecuteNonQuery();
                        //}


                        d.cmd.CommandText = "DELETE FROM exam";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM fee_paid";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM final_fee_paid";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM marks";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM salary_paid";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM student where class = '12-com'";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "DELETE FROM student where class = '12-sci'";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='12-com' where class ='11-com';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='11-com' where class ='10';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='12-sci' where class ='11-sci';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='10' where class ='9';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='9' where class ='8';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='8' where class ='7';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='7' where class ='6';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='6' where class ='5';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='5' where class ='4';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='4' where class ='3';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='3' where class ='2';";
                        d.cmd.ExecuteNonQuery();

                        d.cmd.CommandText = "update student set class='2' where class ='1';";
                        d.cmd.ExecuteNonQuery();

                        d.con.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("Your Data Is Safe");
                    }
                }
            }
        }
    }
}
