using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string operationlast;
        private string task;
        public Calculator()
        {
            InitializeComponent();

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (Out.Text == "0")
            {
                Out.Text = "";
            }
            if ((sender as Button).Text == "+" || (sender as Button).Text == "-" || (sender as Button).Text == "*" || (sender as Button).Text == "/")
            {
                if (operationlast == "+" || operationlast == "/" || operationlast == "*" || operationlast == "-")
                {

                }
                else
                {
                    Out.Text += (sender as Button).Text;
                    operationlast = (sender as Button).Text;
                }
            }
            else
            {
                Out.Text += (sender as Button).Text;
                operationlast = (sender as Button).Text;
                
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Out.Text = "0";
        }

        private void Out_TextChanged(object sender, EventArgs e)
        {
            if (Out.Text.Length > 12)
            {
                
                MessageBox.Show("Invalid task Length", "Error", MessageBoxButtons.OKCancel);
                Out.Text = Out.Text.Remove(Out.Text.Length - 1);
            }
        }
        private void Calculate(string t)
        {
            Expression exp = new Expression(t);
            string ans = exp.Evaluate().ToString();
            Out.Text = ans.ToString();
        }
        private void result_Click(object sender, EventArgs e)
        {
            task = Out.Text;
            Calculate(task);
            
        }
        
    }
}
