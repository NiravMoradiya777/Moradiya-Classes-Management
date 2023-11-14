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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Moradiya_classes_management
{
    public partial class Fee_Payment_Pay_Fee : Form
    {
        database d = new database();
        
        public Fee_Payment_Pay_Fee()
        {
            InitializeComponent();
        }

        private void Pay_Amount_Click(object sender, EventArgs e)
        {
            Pay_Amount.Text = "";
        }

        private void Fee_Payment_Pay_Fee_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //Student_Information.id.ToString()

            string[] information = d.get_student_information_by_id(Fee_Payment.id.ToString());
            int paid_fee = d.get_paid_fees(Fee_Payment.id.ToString());
            int total_fee = d.get_total_fees(Fee_Payment.Class.ToString());
            if (information[1] == "")
            {

            }
            else
            {
                //MessageBox.Show(information[1]);
                pictureBox1.Image = System.Drawing.Image.FromFile(information[1]);
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

        private void Pay_Click(object sender, EventArgs e)
        {
            string pdf_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Classes Management\\recipt\\" + First_Name.Text + " " + Last_Name.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            if (Pay_Amount.Text== "Enter Amount Here" || Pay_Amount.Text == "0" || Pay_Amount.Text=="" || Pay_Amount.Text == " ")
            {
                MessageBox.Show("Enter Valid Amount");
            }
            else
            {
                try
                {
                    int amount = Convert.ToInt32(Pay_Amount.Text);
                    if (amount > Convert.ToInt32(Remaining.Text))
                    {
                        MessageBox.Show("Remaining Fees Is Less");
                    }
                    else
                    {
                        d.pay_fee(Student_ID.Text, Class.Text, DateTime.Now.ToString("yyyy-MM-dd"), amount);
                        MessageBox.Show("Payment Successfull");

                        if (Remaining.Text == Pay_Amount.Text)
                        {
                            d.insert_into_final_fee_paid(Student_ID.Text);
                        }

                        ////Here Recipt Will be generate
                        //Here Recipt Will be generate
                        Document doc = new Document(PageSize.LETTER, 50, 50, 50, 50);
                        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdf_path, FileMode.Create));
                        doc.Open();

                        Paragraph pr = new Paragraph("--------------------------------------------------------------------------------------------------------------------------------");
                        Paragraph pr2 = new Paragraph("                                                                     Fee Recipt");
                        Paragraph pr3 = new Paragraph(" ");
                        Paragraph pr4 = new Paragraph("               Student ID  :-     " + Student_ID.Text + "                                            Date :- " + DateTime.Now.ToString("dd-MM-yyyy"));
                        Paragraph pr5 = new Paragraph("               Name          :-     " + First_Name.Text + " " + Middle_Name.Text + " " + Last_Name.Text);
                        Paragraph pr6 = new Paragraph("               Class          :-     " + Class.Text);
                        Paragraph pr7 = new Paragraph("               Amount       :-     " + Pay_Amount.Text);
                        Paragraph pr8 = new Paragraph("               Total Fees  :-     " + Total_Fees.Text);
                        Paragraph pr9 = new Paragraph(" ");
                        Paragraph pr10 = new Paragraph(" ");
                        Paragraph pr11 = new Paragraph("-Fees will noy be given back in any case.");
                        Paragraph pr12 = new Paragraph("-Fees are not transferable.");
                        Paragraph pr13 = new Paragraph("                                                                                                         ___________________");
                        Paragraph pr14 = new Paragraph("                                                                                                                  Received By");
                        Paragraph pr15 = new Paragraph("--------------------------------------------------------------------------------------------------------------------------------");

                        doc.Add(pr);
                        doc.Add(pr2);
                        doc.Add(pr3);
                        doc.Add(pr4);
                        doc.Add(pr5);
                        doc.Add(pr6);
                        doc.Add(pr7);
                        doc.Add(pr8);
                        doc.Add(pr9);
                        doc.Add(pr10);
                        doc.Add(pr11);
                        doc.Add(pr12);
                        doc.Add(pr13);
                        doc.Add(pr14);
                        doc.Add(pr15);
                        doc.Close();

                        //this code is for open pdf file in internet explorer
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        process.StartInfo = startInfo;

                        startInfo.FileName = pdf_path;
                        process.Start();
                    }
                }
                catch
                {
                    MessageBox.Show("Amount Must Be In Numerical");
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
