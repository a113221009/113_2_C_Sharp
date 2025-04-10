using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5; // 陣列的大小
            int[] lotteryNumbers = new int[SIZE]; // 用來儲存樂透號碼的陣列
            Random rand = new Random(); // 用來產生亂數的物件

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                int number;
                do
                {
                    number = rand.Next(1, 43); // 產生一個介於 1 到 42 之間的亂數
                } while (lotteryNumbers.Contains(number)); // 確保不重複
                lotteryNumbers[i] = number; // 將不重複的號碼存入陣列
            }

            //將lotteryNumbers 陣列中的數字由小到大排列
            Array.Sort(lotteryNumbers); //使用 Array.Sort 方法將陣列中的數字由小到大排列





            //註解掉的原程式碼，逐一將透號碼顯示在 Label 上
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();
            //lotteryNumbers[i] = rand.Next(1, 43);  // 產生一個介於 1 到 42 之間的亂數
            // 使用迴圈顯示樂透號碼

            Label[] showLabel = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < showLabel.Length; i++)
            {
                showLabel[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
