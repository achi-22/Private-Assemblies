using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace Private_Assemblies
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void BasicCalculator_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                string op = cmbOperator.Text;
                float result = 0;

                switch (op)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Division(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operator.");
                        return;
                }

                lblTotal.Text = result.ToString("0.#####");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
