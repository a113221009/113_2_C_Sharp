using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串參數，
        // 並判斷它是否正確地格式化為台灣電話號碼，
        // 台灣電話號碼格式如下：(XX)XXXX-XXXX
        // 如果參數格式正確，則方法返回 true，否則返回 false。
        private bool IsValidFormat(string str)
        {
            // 檢查字串是否為空或長度不符合格式
            if (string.IsNullOrEmpty(str) || str.Length != 13)
            {
                return false;
            }

            // 檢查是否符合格式 (XX)XXXX-XXXX
            if (str.Length == 13 &&
                str[0] == '(' &&
                str[3] == ')' &&
                str[8] == '-')
            {
                string areaCode = str.Substring(1, 2);
                string numberPart1 = str.Substring(4, 4);
                string numberPart2 = str.Substring(9, 4);
                // 確保括號內和破折號後的部分都是數字
                if (str.Substring(1, 2).All(char.IsDigit) &&
                    str.Substring(4, 4).All(char.IsDigit) &&
                    str.Substring(9, 4).All(char.IsDigit))
                {
                    // 檢查區號是否在有效範圍內
                    if (int.Parse(str.Substring(1, 2)) < 1 || int.Parse(str.Substring(1, 2)) > 99)
                    {
                        return false;
                    }
                }
                else
                {
                    // 如果括號內或破折號後的部分不是數字，則返回 false，並刪除括號內或破折號後的部分
                    if (!str.Substring(1, 2).All(char.IsDigit) ||
                        !str.Substring(4, 4).All(char.IsDigit) ||
                        !str.Substring(9, 4).All(char.IsDigit))
                    {
                        return false;
                    }

                    return false;
                }
                return true;
            }

            return false;
        }

        // Unformat 方法接受一個字串（以引用方式傳遞），
        // 假設該字串包含格式為 (XXX)XXX-XXXX 的電話號碼。
        // 該方法通過移除括號和連字元來去除格式。
        private void Unformat(ref string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length == 13)
            {
                // 使用 Remove 方法移除括號和連字元
                str = str.Remove(0, 1);  // 移除左括號 '('
                str = str.Remove(2, 1);  // 移除右括號 ')'
                str = str.Remove(6, 1);  // 移除連字元 '-'

                // str = str.Remove(0, 1).Remove(2, 1).Remove(6, 1);  // 一行完成所有移除操作

                // str = str.Replace("(", "").Replace(")", "").Replace("-", "");  // 這行代碼也可以達到相同的效果
            }
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}