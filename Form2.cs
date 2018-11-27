using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalPayroll
{
    public partial class form2 : Form
    {
        double gross;
        public form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.x;
            label4.Text = Form1.y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monday1 = maskedTextBox1.Text;
            string tuesday1 = maskedTextBox2.Text;
            string wednesday1 = maskedTextBox3.Text;
            string thursday1 = maskedTextBox4.Text;
            string friday1 = maskedTextBox5.Text;
            string saturday1 = maskedTextBox6.Text;

            double mon1 = double.Parse(monday1);
            double tue1 = double.Parse(tuesday1);
            double wed1 = double.Parse(wednesday1);
            double thu1 = double.Parse(thursday1);
            double fri1 = double.Parse(friday1);
            double sat1 = double.Parse(saturday1);


            string monday2 = maskedTextBox7.Text;
            string tuesday2 = maskedTextBox8.Text;
            string wednesday2 = maskedTextBox8.Text;    
            string thursday2 = maskedTextBox10.Text;
            string friday2 = maskedTextBox11.Text;
            string saturday2 = maskedTextBox12.Text;

            double mon2 = double.Parse(monday2);
            double tue2 = double.Parse(tuesday2);
            double wed2 = double.Parse(wednesday2);
            double thu2 = double.Parse(thursday2);
            double fri2 = double.Parse(friday2);
            double sat2 = double.Parse(saturday2);

            double sum = mon1 + tue1 + wed1 + thu1 + fri1 + sat1 + mon2 + tue2 + wed2 + thu2 + fri2 + sat2;

            label17.Text = Convert.ToString(sum);

            if (sum > 96)
            {
                label20.Text = "Overtime";
            }
            else if (sum < 96)
            {
                label20.Text = "Undertime";
            }
            else if (sum == 96)
            {
                label20.Text = "Balanced";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sss = ssSalary.Text;
            string tax = TAXMasked.Text;
            string philhealth = PHILHEALTHMasked.Text;
            string pagibig = PAGIBIGMasked.Text;

            double sssSalary = double.Parse(sss);
            double taxSalary = double.Parse(tax);
            double philhealthSalary = double.Parse(philhealth);
            double pagibigSalary = double.Parse(pagibig);

            double deduction = sssSalary + taxSalary + philhealthSalary + pagibigSalary;
            double NetSalary = gross - deduction;

            NetS.Text = Convert.ToString(NetSalary);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string work = label17.Text;
                string rate = RateMasked.Text;

                double work2 = double.Parse(work);
                double rate2 = double.Parse(rate);

                gross = work2 * rate2;

                GrossResult.Text = Convert.ToString(gross);
            }
            catch (Exception)
            {

            }
        }
    }
}
