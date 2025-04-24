using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均分數
        private double Average(List<int> scores)
        {
            int total = 0;
            for (int index = 0; index < scores.Count; index++)
            {
                total += scores[index];
            }
            return (double)total / scores.Count;
        }

        // 回傳最高分
        private int Highest(List<int> scores)
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

        // 回傳最低分
        private int Lowest(List<int> scores)
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
            List<int> testScores = new List<int>();
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0.0;

            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // 使用 using 語句確保資源被正確釋放
                    using (StreamReader inputFile = File.OpenText(OpenFile.FileName))
                    {
                        testScoresListBox.Items.Clear();
                        int index = 0;

                        while (!inputFile.EndOfStream && index < SIZE)
                        {
                            string line = inputFile.ReadLine();
                            if (int.TryParse(line, out int score))
                            {
                                testScores.Add(score);
                                testScoresListBox.Items.Add(score);
                                index++;
                            }
                        }
                    }

                    if (testScores.Count > 0)
                    {
                        averageScore = Average(testScores);
                        highestScore = Highest(testScores);
                        lowestScore = Lowest(testScores);

                        averageLabel.Text = averageScore.ToString("n2");
                        highestLabel.Text = highestScore.ToString();
                        lowestLabel.Text = lowestScore.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}