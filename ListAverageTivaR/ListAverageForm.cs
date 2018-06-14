using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 14-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program lets you enter marks and then determines your grade average
*/

namespace ListAverageTivaR
{
    public partial class frmListAverage : Form
    {
        // List of Integers
        List<int> myListOfIntegers = new List<int>();

        public frmListAverage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Declare local variables
            int userMark = -1;

            // Convert the value in the textbook to an integer 
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            // If the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occured: '{0}'", parseError);
            }

            // Check if the user entered a number between 0 and 100
            if ((userMark >= 0) && (userMark <= 100))
            {
                // Add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                // Add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // Otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            // Define local variables
            int numberOfMarks = 0;
            int allGradesAddedTogether = 0;
            int currentGrade = 0;
            int answer= 0;

            numberOfMarks = myListOfIntegers.Count;

            // To add all of the grades together
            for (int counter = 1; counter<= numberOfMarks; counter++)
            {
                currentGrade = myListOfIntegers[counter - 1];
                allGradesAddedTogether = allGradesAddedTogether + currentGrade;

            }

            // Divide the allGrades added together by the number of things in the list
            answer = allGradesAddedTogether / numberOfMarks;

            lblAnswer.Text = ("Your Average is: " + answer);

        }
    }
}
