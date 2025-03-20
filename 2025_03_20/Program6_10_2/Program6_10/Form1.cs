using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 修改元件的 Text 屬性
            this.Text = "猜拳遊戲";
            button1.Text = "石頭";
            button2.Text = "布";
            button3.Text = "剪刀";
            button4.Text = "重新開始";
        }

        Random rand = new Random();
        string compChoice, myChoice, winner;
        int compScore, playerScore, tieScore;

        private void Form1_Load(object sender, EventArgs e)
        {
            getCompChoice();
        }

        private void getCompChoice()
        {
            int n = rand.Next(1, 4);
            switch (n)
            {
                case 1:
                    compChoice = "石頭";
                    break;
                case 2:
                    compChoice = "布";
                    break;
                case 3:
                    compChoice = "剪刀";
                    break;
            }
        }

        private void showWinner(string myChoice)
        {
            if (myChoice == compChoice)
                winner = "平手";
            else if (myChoice == "石頭" && compChoice == "剪刀" ||
                myChoice == "布" && compChoice == "石頭" ||
                myChoice == "剪刀" && compChoice == "布")
                winner = "你贏了";
            else
                winner = "電腦贏了";
            if (winner == "你贏了")
                playerScore++;
            else if (winner == "電腦贏了")
                compScore++;
            else
                tieScore++;
            label1.Text = "電腦選擇：" + compChoice + "\n" + "你選擇：" + myChoice + "\n" + winner + "\n" + "電腦得分：" + compScore + "   你得分：" + playerScore +
                "   平手：" + tieScore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCompChoice();
            String myChoice = "石頭";
            showWinner(myChoice);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getCompChoice();
            String myChoice = "布";
            showWinner(myChoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getCompChoice();
            String myChoice = "剪刀";
            showWinner(myChoice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getCompChoice();
            label1.Text = "";
            compScore = 0;
            playerScore = 0;
        }
    }
}
