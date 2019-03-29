namespace StateExample
{
    partial class Form1
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
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.useSafeButton = new System.Windows.Forms.Button();
            this.alarmButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Location = new System.Drawing.Point(12, 9);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(231, 22);
            this.datetimeLabel.TabIndex = 0;
            this.datetimeLabel.Text = "label1";
            // 
            // outputListbox
            // 
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.ItemHeight = 12;
            this.outputListbox.Location = new System.Drawing.Point(12, 34);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.ScrollAlwaysVisible = true;
            this.outputListbox.Size = new System.Drawing.Size(356, 148);
            this.outputListbox.TabIndex = 1;
            // 
            // useSafeButton
            // 
            this.useSafeButton.Location = new System.Drawing.Point(31, 188);
            this.useSafeButton.Name = "useSafeButton";
            this.useSafeButton.Size = new System.Drawing.Size(75, 23);
            this.useSafeButton.TabIndex = 2;
            this.useSafeButton.Text = "金庫使用";
            this.useSafeButton.UseVisualStyleBackColor = true;
            this.useSafeButton.Click += new System.EventHandler(this.useSafeButton_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.Location = new System.Drawing.Point(112, 188);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(75, 23);
            this.alarmButton.TabIndex = 3;
            this.alarmButton.Text = "非常ベル";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(193, 188);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 4;
            this.callButton.Text = "通常通話";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(274, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 217);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.useSafeButton);
            this.Controls.Add(this.outputListbox);
            this.Controls.Add(this.datetimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label datetimeLabel;
        private System.Windows.Forms.ListBox outputListbox;
        private System.Windows.Forms.Button useSafeButton;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button exitButton;
    }
}

