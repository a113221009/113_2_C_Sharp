﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_9
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = rand.Next(1, 7);  // 產生1~6的亂數，有效範圍在button1_Click方法中
            int n2 = rand.Next(1, 7);  // 產生1~6的亂數，有效範圍在button1_Click方法中

            showPictureBox(n1, pictureBox1);
            
            showPictureBox(n2, pictureBox2);
        }

        private void showPictureBox(int n, PictureBox pic)
        {
            switch(n)  // 顯示圖片框的圖片
            {
                case 1:
                    pic.Image = Properties.Resources.Die1;
                    break;
                case 2:
                    pic.Image = Properties.Resources.Die2;
                    break;
                case 3:
                    pic.Image = Properties.Resources.Die3;
                    break;
                case 4:
                    pic.Image = Properties.Resources.Die4;
                    break;
                case 5:
                    pic.Image = Properties.Resources.Die5;
                    break;
                case 6:
                    pic.Image = Properties.Resources._6Die;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
