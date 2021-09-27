using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {

        string activeTextBox; // a string that contains the name of the last textbox to be edited

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* This method is called when the Convert button is clicked */
        private void Convert_Click(object sender, EventArgs e)
        {

            double temperatureInput; // a variable that stores the temperature to be converted
            
            // This switch determines which operation to perform depending on which was the last textbox to have been edited
            switch(activeTextBox)
            {
                // this code block runs if the last textbox to be edited was the Fahrenheit textbox
                case "Fahrenheit":
                    Double.TryParse(Fahrenheit.Text, out temperatureInput); // if the entry in the Fahrenheit textbox can be converted into a double, it is stored in the temperature variable. Information on the TryParse method was found in the textbook (Gaddis, 238)
                    Celsius.Text = FahrenheitToCelsius(temperatureInput).ToString(); // converts the the entry in the Fahrenheit textbox to Celsius and displays the result in the Celsius textbox
                    break;
                // this code block runs if the last textbox to be edited was the Celsius textbox
                case "Celsius":
                    Double.TryParse(Celsius.Text, out temperatureInput); // if the entry in the Celsius textbox can be converted into a double, it is stored in the temperature variable
                    Fahrenheit.Text = CelsiusToFahrenheit(temperatureInput).ToString(); // converts the the entry in the Celsius textbox to Fahrenheit and displays the result in the Fahrenheit textbox
                    break;
            }
        }

        /* This method is called when the Fahrenheit textbox is edited */
        private void Fahrenheit_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = "Fahrenheit"; // changes the activeTextBox variable to "Fahrenheit"
        }

        /* This method is called when the Celsius textbox is edited */
        private void Celsius_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = "Celsius"; // changes the activeTextBox variable to "Celsius"
        }

        /* Converts a double input from Fahrenheit to Celsius */
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;  // uses the input in the formula to convert Fahrenheit to Celsius and returns the result
        }

        /* Converts a double input from Celsius to Fahrenheit */
        private double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32; // uses the input in the formula to convert Celsius to Fahrenheit and returns the result
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.