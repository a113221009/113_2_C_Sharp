using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        private Average(int[] scores)
        {
            int total = 0;
            for (int index = 0; index < scores.Length; index++)
            {
                total += scores[index];
            }
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        private int Highest(int[] scores)
        {
           int highest = scores[0];
            foreach (int score in scores)
            {
                if (score > highest)
                {
                    highest = score;
                }
            }
            return highest;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        private int Lowest(int[] scores)
        {
           int lowest = scores[0];
            foreach (int score in scores)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }
            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 48;
            int[] testScores = new int[SIZE];
            int index = 0;
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0.0;
            StreamReader inputFile;
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Open the file.
                    inputFile = File.OpenText(OpenFile.FileName);
                    // clear the ListBox.
                    testScoresListBox.Items.Clear();
                    // Read the test scores from the file.
                    while (!inputFile.EndOfStream && index < SIZE)
                    {
                        testScores[index] = int.Parse(inputFile.ReadLine());
                        index++;
                    }
                    // Close the file.
                    inputFile.Close();
                    // Calculate the average, highest, and lowest scores.
                    averageScore = Average(testScores);
                    highestScore = Highest(testScores);
                    lowestScore = Lowest(testScores);
                    // Display the results.
                    averageLabel.Text = averageScore.ToString("n2");
                    highestLabel.Text = highestScore.ToString();
                    lowestLabel.Text = lowestScore.ToString();
                }
            }
            catch(Exception ex)
            {
                // Display an error message if the file cannot be opened.
                MessageBox.Show("Error opening file: " + ex.Message);
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
