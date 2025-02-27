namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            averageLabel = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            logListBox = new ListBox();
            listAverageBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(32, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F);
            label2.Location = new Point(32, 176);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(32, 282);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Font = new Font("Microsoft JhengHei UI", 18F);
            distanceTextBox.Location = new Point(236, 66);
            distanceTextBox.Margin = new Padding(4);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(160, 38);
            distanceTextBox.TabIndex = 3;
            // 
            // gasTextBox
            // 
            gasTextBox.Font = new Font("Microsoft JhengHei UI", 18F);
            gasTextBox.Location = new Point(236, 176);
            gasTextBox.Margin = new Padding(4);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(160, 38);
            gasTextBox.TabIndex = 4;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Font = new Font("Microsoft JhengHei UI", 16F);
            averageLabel.Location = new Point(236, 285);
            averageLabel.Margin = new Padding(4, 0, 4, 0);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(196, 33);
            averageLabel.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft JhengHei UI", 18F);
            btnCalculate.Location = new Point(75, 395);
            btnCalculate.Margin = new Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 57);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 18F);
            btnExit.Location = new Point(282, 395);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 57);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 20;
            logListBox.Location = new Point(461, 25);
            logListBox.Margin = new Padding(4);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(260, 344);
            logListBox.TabIndex = 8;
            // 
            // listAverageBtn
            // 
            listAverageBtn.Font = new Font("Microsoft JhengHei UI", 18F);
            listAverageBtn.Location = new Point(461, 395);
            listAverageBtn.Margin = new Padding(4);
            listAverageBtn.Name = "listAverageBtn";
            listAverageBtn.Size = new Size(150, 57);
            listAverageBtn.TabIndex = 9;
            listAverageBtn.Text = "總平均油耗";
            listAverageBtn.UseVisualStyleBackColor = true;
            listAverageBtn.Click += listAverageBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 544);
            Controls.Add(listAverageBtn);
            Controls.Add(logListBox);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(averageLabel);
            Controls.Add(gasTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextBox;
        private TextBox gasTextBox;
        private Label averageLabel;
        private Button btnCalculate;
        private Button btnExit;
        private ListBox logListBox;
        private Button listAverageBtn;
    }
}
