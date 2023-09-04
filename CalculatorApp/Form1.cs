using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the strings from the TextBoxes
            string Nilai1 = tbNilai1.Text;
            string Nilai2 = tbNilai2.Text;

            // Declare integer variables to store the parsed values
            int parsedNilai1;
            int parsedNilai2;

            // Use int.TryParse to safely attempt the conversion
            if (int.TryParse(Nilai1, out parsedNilai1) && int.TryParse(Nilai2, out parsedNilai2))
            {
                // Conversion succeeded, and parsedNilai1 and parsedNilai2 now hold the integer values
                // You can use them in your code here
                // For example, you can add them together and display the result:
                int sum = parsedNilai1 + parsedNilai2;
                lbHasil.Text = sum.ToString();
            }
            else
            {
                // Conversion failed, handle the error here (e.g., display an error message)
                lbHasil.Text = "Invalid input. Please enter valid integer values.";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Get the strings from the TextBoxes
            string Nilai1 = tbNilai1.Text;
            string Nilai2 = tbNilai2.Text;

            // Declare integer variables to store the parsed values
            int parsedNilai1;
            int parsedNilai2;

            // Use int.TryParse to safely attempt the conversion
            if (int.TryParse(Nilai1, out parsedNilai1) && int.TryParse(Nilai2, out parsedNilai2))
            {
                // Conversion succeeded, and parsedNilai1 and parsedNilai2 now hold the integer values
                // You can use them in your code here
                // For example, you can divide them together and display the result:
                int divide = parsedNilai1 / parsedNilai2;
                lbHasil.Text = divide.ToString();
            }
            else
            {
                // Conversion failed, handle the error here (e.g., display an error message)
                lbHasil.Text = "Invalid input. Please enter valid integer values.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbHasil.Text = "";  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            // Get the strings from the TextBoxes
            string Nilai1 = tbNilai1.Text;
            string Nilai2 = tbNilai2.Text;

            // Declare integer variables to store the parsed values
            int parsedNilai1;
            int parsedNilai2;

            // Use int.TryParse to safely attempt the conversion
            if (int.TryParse(Nilai1, out parsedNilai1) && int.TryParse(Nilai2, out parsedNilai2))
            {
                // Conversion succeeded, and parsedNilai1 and parsedNilai2 now hold the integer values
                // You can use them in your code here
                // For example, you can minus them together and display the result:
                int minus = parsedNilai1 - parsedNilai2;
                lbHasil.Text = minus.ToString();
            }
            else
            {
                // Conversion failed, handle the error here (e.g., display an error message)
                lbHasil.Text = "Invalid input. Please enter valid integer values.";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // Get the strings from the TextBoxes
            string Nilai1 = tbNilai1.Text;
            string Nilai2 = tbNilai2.Text;

            // Declare integer variables to store the parsed values
            int parsedNilai1;
            int parsedNilai2;

            // Use int.TryParse to safely attempt the conversion
            if (int.TryParse(Nilai1, out parsedNilai1) && int.TryParse(Nilai2, out parsedNilai2))
            {
                // Conversion succeeded, and parsedNilai1 and parsedNilai2 now hold the integer values
                // You can use them in your code here
                // For example, you can multiply them together and display the result:
                int multiply = parsedNilai1 * parsedNilai2;
                lbHasil.Text = multiply.ToString();
            }
            else
            {
                // Conversion failed, handle the error here (e.g., display an error message)
                lbHasil.Text = "Invalid input. Please enter valid integer values.";
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            // Get the strings from the TextBoxes
            string Nilai1 = tbNilai1.Text;
            string Nilai2 = tbNilai2.Text;

            // Declare integer variables to store the parsed values
            int parsedNilai1;
            int parsedNilai2;

            // Use int.TryParse to safely attempt the conversion
            if (int.TryParse(Nilai1, out parsedNilai1) && int.TryParse(Nilai2, out parsedNilai2))
            {
                // Conversion succeeded, and parsedNilai1 and parsedNilai2 now hold the integer values
                // Calculate Nilai1 to the power of Nilai2
                double result = Math.Pow(parsedNilai1, parsedNilai2);

                // Convert the result back to an integer if needed
                int square = (int)result;

                lbHasil.Text = square.ToString();
            }
            else
            {
                // Conversion failed, handle the error here (e.g., display an error message)
                lbHasil.Text = "Invalid input. Please enter valid integer values.";
            }
        }
    }
}
