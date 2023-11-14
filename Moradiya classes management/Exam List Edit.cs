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
    public partial class Exam_List_Edit : Form
    {
        database d = new database();
        public Exam_List_Edit()
        {
            InitializeComponent();
        }

        private void Exam_List_Edit_Load(object sender, EventArgs e)
        {
            Class.Text = Exam_List.Class;
            ExamDate.Text = Exam_List.date;
            Subject.Text = Exam_List.subject;
            Total_Marks.Text = Exam_List.marks;

            string[] subjects = d.get_subject_by_class(Class.Text);
            Subject.Items.Clear();
            foreach (string sub in subjects)
            {
                if(sub==""||sub==null)
                {
                    break;
                }
                //MessageBox.Show(sub);
                Subject.Items.Add(sub);
            }

        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Class_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] subjects = d.get_subject_by_class(Class.Text);
            Subject.Items.Clear();
            foreach (string sub in subjects)
            {
                if (sub == "" || sub == null)
                {
                    break;
                }
                //MessageBox.Show(sub);
                Subject.Items.Add(sub);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Class.Text == "1" || Class.Text == "2" || Class.Text == "3" || Class.Text == "4" || Class.Text == "5" || Class.Text == "6" || Class.Text == "7" || Class.Text == "8" || Class.Text == "9" || Class.Text == "10" || Class.Text == "11-com" || Class.Text == "12-com" || Class.Text == "11-sci" || Class.Text == "12-sci")
            {
                if (Total_Marks.Text == "Total Marks" || Total_Marks.Text == "" || Total_Marks.Text == " ")
                {
                    MessageBox.Show ("Enter Total Marks");
                }
                else
                {
                    d.update_exam(Class.Text, Subject.Text, ExamDate.Text, Total_Marks.Text, Exam_List.Class, Exam_List.date);
                    MessageBox.Show("Update Successfully");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Class");
            }

        }

        private void Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
