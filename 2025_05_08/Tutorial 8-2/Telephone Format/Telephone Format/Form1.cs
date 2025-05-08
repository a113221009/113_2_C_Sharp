using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber 方法接受一個字串，並在該字串包含10位數字時返回 true，否則返回 false。
        private bool IsValidNumber(string str)
        {
            // 檢查字串是否為10位數字
            return str.Length == 10 && str.All(char.IsDigit);
        }

        // TelephoneFormat 方法接受一個字串參數（以引用方式傳遞），並將其格式化為電話號碼。
        private void TelephoneFormat(ref string str)
        {
            // 格式化為電話號碼 (XXX) XXX-XXXX
            str = $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6)}";
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            String input = numberTextBox.Text; // 取得使用者輸入的字串

            if (IsValidNumber(input))
            {
                // 如果字串有效，則格式化並顯示
                TelephoneFormat(ref input);
                MessageBox.Show("格式化後的電話號碼是：" + input);
            }
            else
            {
                // 如果字串無效，則顯示錯誤訊息
                MessageBox.Show("請輸入一個有效的10位數字。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}