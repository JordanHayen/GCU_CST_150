using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method executes when the Add button is pressed. It parses the inputs in the two Addition Term textboxes, adds them and sets the Addition Output label to the result
        private void Add_Click(object sender, EventArgs e)
        {
            double additionTerm1; // Creates a variable that will store the first addition term
            double additionTerm2; // Creates a variable that will store the second addition term
            double additionOutput; // Creates a variable that will store the result of adding the two above terms

            Double.TryParse(AdditionTerm1.Text, out additionTerm1); // Takes input from the textbox for the first addition term, converts it to a numeric data type and stores it in the additionTerm1 variable
            Double.TryParse(AdditionTerm2.Text, out additionTerm2); // Takes input from the textbox for the second addition term, converts it to a numeric data type and stores it in the additionTerm2 variable
            additionOutput = additionTerm1 + additionTerm2; // Sets the additionOutput variable to the sum of the addition term variables
            AdditionOutput.Text = additionOutput.ToString(); // Sets the text of the AdditionOutput label to the additionOutput variable
        }

        // This method executes when the Subtract button is pressed. It parses the inputs in the two Subtraction Term textboxes, subtracts them and sets the Subtraction Output label to the result
        private void Subtract_Click(object sender, EventArgs e)
        {
            double subtractionTerm1; // Creates a variable that will store the first subtraction term
            double subtractionTerm2; // Creates a variable that will store the second subtraction term
            double subtractionOutput; // Creates a variable that will store the result of subtracting the two above terms

            Double.TryParse(SubtractionTerm1.Text, out subtractionTerm1); // Takes input from the textbox for the first subtraction term, converts it to a numeric data type and stores it in the subtractionTerm1 variable
            Double.TryParse(SubtractionTerm2.Text, out subtractionTerm2); // Takes input from the textbox for the second subtraction term, converts it to a numeric data type and stores it in the subtractionTerm2 variable
            subtractionOutput = subtractionTerm1 - subtractionTerm2; // Sets the subtractionOutput variable to the difference of the subtraction term variables
            SubtractionOutput.Text = subtractionOutput.ToString(); // Sets the text of the SubtractionOutput label to the difference of the subtractionOutput variable
        }

        // This method executes when the Multiply button is pressed. It parses the inputs in the two Multiplication Term textboxes, multiplies them and sets the Multiplication Output label to the result
        private void Multiply_Click(object sender, EventArgs e)
        {
            double multiplicationTerm1; // Creates a variable that will store the first multiplication term
            double multiplicationTerm2; // Creates a variable that will store the second multiplication term
            double multiplicationOutput; // Creates a variable that will store the result of multiplying the two above terms

            Double.TryParse(MultiplicationTerm1.Text, out multiplicationTerm1); // Takes input from the textbox for the first multiplication term, converts it to a numeric data type and stores it in the multiplicationTerm1 variable
            Double.TryParse(MultiplicationTerm2.Text, out multiplicationTerm2); // Takes input from the textbox for the second multiplication term, converts it to a numeric data type and stores it in the multiplicationTerm2 variable
            multiplicationOutput = multiplicationTerm1 * multiplicationTerm2; // Sets the multiplicationOutput variable to the product of the multiplication term variables
            MultiplicationOutput.Text = multiplicationOutput.ToString(); // Sets the text of the MultiplicationOutput label to the product of the multiplicationOutput variable
        }

        // This method executes when the Divide button is pressed. It parses the inputs in the two Division Term text boxes, divides them and sets the Division Output label to the result
        private void Divide_Click(object sender, EventArgs e)
        {
            double divisionTerm1; // Creates a variable that will store the first division term
            double divisionTerm2; // Creates a variable that will store the second division term
            double divisionOutput; // Creates a variable that will store the result of dividing the two above terms

            Double.TryParse(DivisionTerm1.Text, out divisionTerm1); // Takes input from the textbox for the first division term, converts it to a numeric data type and stores it in the divisionTerm1 variable
            Double.TryParse(DivisionTerm2.Text, out divisionTerm2); // Takes input from the textbox for the second division term, converts it to a numeric data type and stores it in the divisionTerm2 variable
            divisionOutput = divisionTerm1 / divisionTerm2; // Sets the divisionOutput variable to the product of the division term variables
            DivisionOutput.Text = divisionOutput.ToString(); // Sets the text of the DivisionOutput label to the product of the divisionOutput variable
        }
    }
}
