using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalPayroll
{
    public partial class Form1 : Form
    {
        public static string x;
        public static string y;

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" + Application.StartupPath + "/EmpTable.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = maskedTextBox1.Text;
            y = textBox1.Text;

            cn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            command.CommandText = "select * from EmployeeData where EmployeeNo='" + maskedTextBox1.Text + "' and EmployeeName='" + textBox1.Text+ "'";
            
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;

            }
            if (count == 1)
            {
                MessageBox.Show("Employee Number and Employee Name is Correct");
                cn.Close();
                cn.Dispose();
                this.Hide();
                form2 frmMain = new form2();
                frmMain.ShowDialog();

            }

            else
            {

                MessageBox.Show("Employee Number and Employee Name is Incorrect");
            }

           

            if (count > 1)
            {
                MessageBox.Show("Duplicate Employee Number and Employee Name");

            }

            



            cn.Close();
        }
    }
}
