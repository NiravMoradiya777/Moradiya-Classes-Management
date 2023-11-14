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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            dashboard d = new dashboard();
            d.MdiParent = this;
            //d.ClientSize = new System.Drawing.Size(2000, 800);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.Fill;
            d.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            dashboard d = new dashboard();
            d.MdiParent = this;
            //d.ClientSize = new System.Drawing.Size(2000, 800);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.Fill;
            d.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_down;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image= Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel6.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);


            //give effect when click on button show sub buttons
            if (Convert.ToInt32(flowLayoutPanel6.Size.Height)==140)
            {
                button1.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 140);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
                
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //change button images
            button6.Image = Properties.Resources.if_arrow_down;
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel7.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            if (Convert.ToInt32(flowLayoutPanel7.Size.Height) == 140)
            {
                button6.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 140);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //change button images
            button10.Image = Properties.Resources.if_arrow_down;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel8.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            if (Convert.ToInt32(flowLayoutPanel8.Size.Height) == 140)
            {
                button10.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 140);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //change button images
            button14.Image = Properties.Resources.if_arrow_down;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel9.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            if (Convert.ToInt32(flowLayoutPanel9.Size.Height) == 105)
            {
                button14.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 105);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //change button images
            button17.Image = Properties.Resources.if_arrow_down;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel10.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            if (Convert.ToInt32(flowLayoutPanel10.Size.Height) == 105)
            {
                button17.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 105);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //change button images
            button20.Image = Properties.Resources.if_arrow_down;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button1.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel11.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            if (Convert.ToInt32(flowLayoutPanel11.Size.Height) == 105)
            {
                button20.Image = Properties.Resources.if_arrow_right_01_186409;
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);
            }
            else
            {
                flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
                flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
                flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
                flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
                flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
                flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 105);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            new_student d = new new_student();
            d.MdiParent = this;
            //d.ClientSize = new System.Drawing.Size(2000, 800);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.Fill;
            d.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel4.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Fee_Update fu = new Fee_Update();
            fu.MdiParent = this;
            fu.Dock = DockStyle.Fill;
            fu.Show();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel12.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Salary_Update su = new Salary_Update();
            su.MdiParent = this;
            su.Dock = DockStyle.Fill;
            su.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel13.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Account a = new Account();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel14.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Total_Earning te = new Total_Earning();
            te.MdiParent = this;
            te.Dock = DockStyle.Fill;
            te.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel15.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel16.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Deleted_Student ds = new Deleted_Student();
            ds.MdiParent = this;
            ds.Dock = DockStyle.Fill;
            ds.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //change image
            button1.Image = Properties.Resources.if_arrow_right_01_186409;
            button6.Image = Properties.Resources.if_arrow_right_01_186409;
            button10.Image = Properties.Resources.if_arrow_right_01_186409;
            button14.Image = Properties.Resources.if_arrow_right_01_186409;
            button17.Image = Properties.Resources.if_arrow_right_01_186409;
            button20.Image = Properties.Resources.if_arrow_right_01_186409;

            //change color when click on button
            flowLayoutPanel16.BackColor = Color.FromArgb(55, 62, 74);
            flowLayoutPanel4.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel7.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel8.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel9.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel10.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel11.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel12.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel13.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel14.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel15.BackColor = Color.FromArgb(48, 54, 65);
            flowLayoutPanel6.BackColor = Color.FromArgb(48, 54, 65);

            //restore all penel to it's original position when click on button
            flowLayoutPanel6.Size = new Size(flowLayoutPanel6.Size.Width, 35);
            flowLayoutPanel7.Size = new Size(flowLayoutPanel7.Size.Width, 35);
            flowLayoutPanel8.Size = new Size(flowLayoutPanel8.Size.Width, 35);
            flowLayoutPanel9.Size = new Size(flowLayoutPanel9.Size.Width, 35);
            flowLayoutPanel10.Size = new Size(flowLayoutPanel10.Size.Width, 35);
            flowLayoutPanel11.Size = new Size(flowLayoutPanel11.Size.Width, 35);

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            New_Acedemic_Year acy = new New_Acedemic_Year();
            acy.MdiParent = this;
            acy.Dock = DockStyle.Fill;
            acy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Student_Information d = new Student_Information();
            d.MdiParent = this;
            //d.ClientSize = new System.Drawing.Size(2000, 800);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            d.Dock = DockStyle.Fill;
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Student_Marksheet sm = new Student_Marksheet();
            sm.MdiParent = this;
            sm.Dock = DockStyle.Fill;
            sm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            New_Employee ne = new New_Employee();
            ne.MdiParent = this;
            ne.Dock = DockStyle.Fill;
            ne.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Employee_Information ei = new Employee_Information();
            ei.MdiParent = this;
            ei.Dock = DockStyle.Fill;
            ei.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Fee_Detail_Of_Student fdos = new Fee_Detail_Of_Student();
            fdos.MdiParent = this;
            fdos.Dock = DockStyle.Fill;
            fdos.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Fee_Payment fp = new Fee_Payment();
            fp.MdiParent = this;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Enter_Course ec = new Enter_Course();
            ec.MdiParent = this;
            ec.Dock = DockStyle.Fill;
            ec.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            All_Course ac = new All_Course();
            ac.MdiParent = this;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Exam_List el = new Exam_List();
            el.MdiParent = this;
            el.Dock = DockStyle.Fill;
            el.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Manage_Marks mm = new Manage_Marks();
            mm.MdiParent = this;
            mm.Dock = DockStyle.Fill;
            mm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Employee_Salary_Detail esd = new Employee_Salary_Detail();
            esd.MdiParent = this;
            esd.Dock = DockStyle.Fill;
            esd.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Employee_Salary_Payment esp = new Employee_Salary_Payment();
            esp.MdiParent = this;
            esp.Dock = DockStyle.Fill;
            esp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Employee_Salary_Detail esd = new Employee_Salary_Detail();
            esd.MdiParent = this;
            esd.Dock = DockStyle.Fill;
            esd.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            Remaining_Fees rf = new Remaining_Fees();
            rf.MdiParent = this;
            rf.Dock = DockStyle.Fill;
            rf.Show();
        }
    }
}
