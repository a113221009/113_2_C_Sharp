namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedPhoneDescriptionLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.promptLabel.Location = new System.Drawing.Point(44, 11);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(87, 16);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "請選擇姓名";
            // 
            // nameListBox
            // 
            this.nameListBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(22, 35);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(135, 212);
            this.nameListBox.TabIndex = 1;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // selectedPhoneDescriptionLabel
            // 
            this.selectedPhoneDescriptionLabel.AutoSize = true;
            this.selectedPhoneDescriptionLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.selectedPhoneDescriptionLabel.Location = new System.Drawing.Point(219, 35);
            this.selectedPhoneDescriptionLabel.Name = "selectedPhoneDescriptionLabel";
            this.selectedPhoneDescriptionLabel.Size = new System.Drawing.Size(71, 16);
            this.selectedPhoneDescriptionLabel.TabIndex = 2;
            this.selectedPhoneDescriptionLabel.Text = "電話號碼";
            // 
            // phoneLabel
            // 
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.phoneLabel.Location = new System.Drawing.Point(179, 61);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(153, 31);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.exitButton.Location = new System.Drawing.Point(209, 262);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(369, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增通訊錄";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "電話";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 27);
            this.textBox2.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.addButton.Location = new System.Drawing.Point(24, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 34);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.saveButton.Location = new System.Drawing.Point(209, 183);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 34);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "儲存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.changeButton.Location = new System.Drawing.Point(141, 208);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(94, 34);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "修改";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.cancelButton.Location = new System.Drawing.Point(22, 262);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 34);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "刪除聯絡人";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 317);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.selectedPhoneDescriptionLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label selectedPhoneDescriptionLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}