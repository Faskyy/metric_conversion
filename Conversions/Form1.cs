using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        private static string[,] comboItems = new string[6, 2];

        public Form1()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double lengthToBeConverted;
            double convertedLength;
            //check if iniput is valid
            if (Double.TryParse(txtLength.Text, out lengthToBeConverted))
            {
                //convert the length and display it
                convertedLength = lengthToBeConverted * Convert.ToDouble(comboItems[cboConversions.SelectedIndex, 1]);
                lblCalculatedLength.Text = convertedLength.ToString("0.00");
            }
            //display error message when invalid input is entered
            else
            {
                MessageBox.Show("Invalid input.", "Error");
                txtLength.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add items to the array
            comboItems[0, 0] = "Miles to Kilometers";
            comboItems[0, 1] = "1.6093";
            comboItems[1, 0] = "Kilometers to miles";
            comboItems[1, 1] = "0.6214";
            comboItems[2, 0] = "Feet to meters";
            comboItems[2, 1] = "0.3048";
            comboItems[3, 0] = "Meters to feet";
            comboItems[3, 1] = "3.2808";
            comboItems[4, 0] = "Inches to Centimeters";
            comboItems[4, 1] = "2.54";
            comboItems[5, 0] = "Centimeters to inches";
            comboItems[0, 1] = "0.3937";
            //add the items to the combo box
            for (int i = 0; i < comboItems.GetLength(0); i++)
            {
                cboConversions.Items.Add(comboItems[i, 0]);
            }
            //select the first item on form load
            cboConversions.SelectedIndex = 0;
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the text of labels and clear the textboxes based on items selected in the combo box
            if (cboConversions.SelectedIndex == 0)
            {
                lblFromLength.Text = "Miles: ";
                lblToLength.Text = "Kilometers: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 1)
            {
                lblFromLength.Text = "Kilometers: ";
                lblToLength.Text = "Miles: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 2)
            {
                lblFromLength.Text = "Feet: ";
                lblToLength.Text = "Meters: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 3)
            {
                lblFromLength.Text = "Meters: ";
                lblToLength.Text = "Feet: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 4)
            {
                lblFromLength.Text = "Inches: ";
                lblToLength.Text = "Centimeters: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 5)
            {
                lblFromLength.Text = "Centimeters: ";
                lblToLength.Text = "Inches: ";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
        }

    }
}