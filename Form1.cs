using System.Security.Policy;
using CalculatorPrivateAssembly1;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);
            string selectedOperator = comboBox1.SelectedItem.ToString();

            float result = 0;

            switch (selectedOperator)
            {
                case "+":
                    result = BasicComputation.Addition(number1, number2);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(number1, number2);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(number1, number2);
                    break;
                case "/":
                    result = BasicComputation.Division(number1, number2);
                    break;
                default:
                    MessageBox.Show("Invalid operator selected.");
                    return;
            }
            label3.Text = $"Result: {result}";
        }
    }
}
