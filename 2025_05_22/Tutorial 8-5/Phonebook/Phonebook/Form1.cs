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

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 用來儲存 PhoneBookEntry 物件的清單欄位。
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        // 加入 OpenFileDialog 控制項
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法會讀取選取的檔案內容，
        // 並將其以 PhoneBookEntry 物件儲存到 phoneList。
        private void ReadFile()
        {
            StreamReader inputFile;

            // 設定檔案篩選與標題
            openFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog.Title = "請選取電話簿檔案";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inputFile = File.OpenText(openFileDialog.FileName);
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine().Trim();
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            PhoneBookEntry entry;
                            entry.name = parts[0].Trim();
                            entry.phone = parts[1].Trim();
                            phoneList.Add(entry);
                        }
                        else
                        {
                            MessageBox.Show("檔案格式錯誤，應為「姓名,電話號碼」");
                        }
                    }
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("檔案讀取錯誤: " + ex.Message);
                }
            }
        }

        // DisplayNames 方法會將姓名清單顯示在 nameListBox 控制項中。
        private void DisplayNames()
        {
            nameListBox.Items.Clear();
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile(); // 讀取電話簿資料
            DisplayNames(); // 顯示姓名清單
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1)
            {
                phoneLabel.Text = phoneList[index].phone;
            }
            else
            {
                phoneLabel.Text = "無資料";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉視窗
        }
    }
}
