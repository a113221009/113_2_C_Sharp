namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance, gas, average;  // �ŧi�ϰ��ܼ�

            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas;  // �p�⥭���o��
                    averageLabel.Text = average.ToString("f2") + "����/����";  // ��ܥ�����
                    logListBox.Items.Add(average.ToString("f2") + "����/����");  // �[�J����
                }
                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    gasTextBox.Focus(); // �N�ƹ���в���gasTextBox
                    gasTextBox.Text = "";  // �M�ſ�J����r���
                    return;  // ���}�ƥ�B�z�禡
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distanceTextBox.Focus(); // �N�ƹ���в���distanceTextBox
                distanceTextBox.Text = "";  // �M�ſ�J����r���
                return;  // ���}�ƥ�B�z�禡
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // �������ε{��
            // this.Close();  // ��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӭ����G");
        }

        private void listAverageBtn_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count > 1)
            {
                for (int i = 1; i < logListBox.Items.Count; i ++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", ""));  // �֥[�����o��
                }
                logListBox.Items.Add("�����o�ӡG" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
