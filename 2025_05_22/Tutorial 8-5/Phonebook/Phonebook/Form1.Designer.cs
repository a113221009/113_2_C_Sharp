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
            this.nameListBox.Size = new System.Drawing.Size(135, 180);
            this.nameListBox.TabIndex = 1;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // selectedPhoneDescriptionLabel
            // 
            this.selectedPhoneDescriptionLabel.AutoSize = true;
            this.selectedPhoneDescriptionLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.selectedPhoneDescriptionLabel.Location = new System.Drawing.Point(208, 35);
            this.selectedPhoneDescriptionLabel.Name = "selectedPhoneDescriptionLabel";
            this.selectedPhoneDescriptionLabel.Size = new System.Drawing.Size(71, 16);
            this.selectedPhoneDescriptionLabel.TabIndex = 2;
            this.selectedPhoneDescriptionLabel.Text = "電話號碼";
            // 
            // phoneLabel
            // 
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.phoneLabel.Location = new System.Drawing.Point(173, 62);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(153, 31);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.exitButton.Location = new System.Drawing.Point(201, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.selectedPhoneDescriptionLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label selectedPhoneDescriptionLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button exitButton;
    }
}