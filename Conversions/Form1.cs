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
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        public double InchesToCm (double inches)
        {
            double cm1 = inches * 2.54;
            return cm1;
        }

        public double FeetToCm(double feet)
        {
            double cm2 = feet * 30.48;
            return cm2;   
        }

        public double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres; 
        }

        public double MilesToKm(double miles)
        {
            double kilom = miles * 1.6;
            return kilom;  
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt32(choiceInput.Text);
            double userValue = Convert.ToDouble(valueInput.Text); 

            // CALL ON METHOD 1 (INCHES TO CM)
            double conversion1 = InchesToCm(userValue);
            outputLabel.Text = $"{userValue} inches is {conversion1} cms";

            // CALL ON METHOD 2 (FEET TO CM)
            double conversion2 = FeetToCm(userValue);
            outputLabel.Text = $"{userValue} feet is {conversion2} cms";

            // CALL ON METHOD 3 (YARDS TO M)
            double conversion3 = YardsToMetres(userValue);
            outputLabel.Text = $"{userValue} yards is {conversion3} metres";

            // CALL ON METHOD 4 (MILES TO KM)
            double conversion4 = MilesToKm(userValue);
            outputLabel.Text = $"{userValue} miles is {conversion4} kms";

            if (userInput == 1)
            {
                InchesToCm(userValue);
            }
            else if (userInput == 2)
            {
                FeetToCm(userValue);
            }
            else if (userInput == 3)
            {
                YardsToMetres(userValue);
            }
            else if (userInput == 4)
            {
                MilesToKm(userValue);
            }
            else
            {
                outputLabel.Text = "please input a numerical value between 1 & 4.";
            }
        }
    }
}
