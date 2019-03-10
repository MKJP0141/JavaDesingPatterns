namespace MediatorExample
{
    partial class MediatorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new ColleagueButton.ColleagueButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new ColleagueTextField.ColleagueTextField();
            this.passwordTextBox = new ColleagueTextField.ColleagueTextField();
            this.guestRadioButton = new ColleagueRadioButton.ColleagueRadioButton();
            this.userRadioButton = new ColleagueRadioButton.ColleagueRadioButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(18, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(99, 128);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(89, 56);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 19);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(89, 84);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 19);
            this.passwordTextBox.TabIndex = 5;
            // 
            // guestRadioButton
            // 
            this.guestRadioButton.AutoSize = true;
            this.guestRadioButton.Location = new System.Drawing.Point(21, 20);
            this.guestRadioButton.Name = "guestRadioButton";
            this.guestRadioButton.Size = new System.Drawing.Size(53, 16);
            this.guestRadioButton.TabIndex = 6;
            this.guestRadioButton.TabStop = true;
            this.guestRadioButton.Text = "Guest";
            this.guestRadioButton.UseVisualStyleBackColor = true;
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(99, 20);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(47, 16);
            this.userRadioButton.TabIndex = 7;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 163);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.guestRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "MediatorForm";
            this.Text = "Mediator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueButton.ColleagueButton okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColleagueTextField.ColleagueTextField usernameTextBox;
        private ColleagueTextField.ColleagueTextField passwordTextBox;
        private ColleagueRadioButton.ColleagueRadioButton guestRadioButton;
        private ColleagueRadioButton.ColleagueRadioButton userRadioButton;
    }
}

