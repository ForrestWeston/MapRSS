namespace MapRss
{
    partial class ManageSubscriptionForm
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
            this.ManageUrlLable = new System.Windows.Forms.Label();
            this.ManageNameLable = new System.Windows.Forms.Label();
            this.ManageTopicLable = new System.Windows.Forms.Label();
            this.ManageURLTextBox = new System.Windows.Forms.TextBox();
            this.ManageNameTextBox = new System.Windows.Forms.TextBox();
            this.ManageTopicUpDown = new System.Windows.Forms.DomainUpDown();
            this.ManageAcceptButton = new System.Windows.Forms.Button();
            this.ManageCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageUrlLable
            // 
            this.ManageUrlLable.AutoSize = true;
            this.ManageUrlLable.Location = new System.Drawing.Point(12, 9);
            this.ManageUrlLable.Name = "ManageUrlLable";
            this.ManageUrlLable.Size = new System.Drawing.Size(29, 13);
            this.ManageUrlLable.TabIndex = 0;
            this.ManageUrlLable.Text = "URL";
            // 
            // ManageNameLable
            // 
            this.ManageNameLable.AutoSize = true;
            this.ManageNameLable.Location = new System.Drawing.Point(12, 48);
            this.ManageNameLable.Name = "ManageNameLable";
            this.ManageNameLable.Size = new System.Drawing.Size(35, 13);
            this.ManageNameLable.TabIndex = 1;
            this.ManageNameLable.Text = "Name";
            // 
            // ManageTopicLable
            // 
            this.ManageTopicLable.AutoSize = true;
            this.ManageTopicLable.Location = new System.Drawing.Point(12, 87);
            this.ManageTopicLable.Name = "ManageTopicLable";
            this.ManageTopicLable.Size = new System.Drawing.Size(80, 13);
            this.ManageTopicLable.TabIndex = 2;
            this.ManageTopicLable.Text = "Topic (optional)";
            // 
            // ManageURLTextBox
            // 
            this.ManageURLTextBox.Location = new System.Drawing.Point(12, 25);
            this.ManageURLTextBox.Name = "ManageURLTextBox";
            this.ManageURLTextBox.Size = new System.Drawing.Size(260, 20);
            this.ManageURLTextBox.TabIndex = 3;
            // 
            // ManageNameTextBox
            // 
            this.ManageNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.ManageNameTextBox.Name = "ManageNameTextBox";
            this.ManageNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.ManageNameTextBox.TabIndex = 4;
            // 
            // ManageTopicUpDown
            // 
            this.ManageTopicUpDown.Location = new System.Drawing.Point(12, 103);
            this.ManageTopicUpDown.Name = "ManageTopicUpDown";
            this.ManageTopicUpDown.Size = new System.Drawing.Size(260, 20);
            this.ManageTopicUpDown.TabIndex = 5;
            // 
            // ManageAcceptButton
            // 
            this.ManageAcceptButton.Location = new System.Drawing.Point(13, 227);
            this.ManageAcceptButton.Name = "ManageAcceptButton";
            this.ManageAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAcceptButton.TabIndex = 6;
            this.ManageAcceptButton.Text = "Accept";
            this.ManageAcceptButton.UseVisualStyleBackColor = true;
            this.ManageAcceptButton.Click += new System.EventHandler(this.ManageAcceptButton_Click);
            // 
            // ManageCancelButton
            // 
            this.ManageCancelButton.Location = new System.Drawing.Point(197, 227);
            this.ManageCancelButton.Name = "ManageCancelButton";
            this.ManageCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCancelButton.TabIndex = 7;
            this.ManageCancelButton.Text = "Cancel";
            this.ManageCancelButton.UseVisualStyleBackColor = true;
            this.ManageCancelButton.Click += new System.EventHandler(this.ManageCancelButton_Click);
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ManageCancelButton);
            this.Controls.Add(this.ManageAcceptButton);
            this.Controls.Add(this.ManageTopicUpDown);
            this.Controls.Add(this.ManageNameTextBox);
            this.Controls.Add(this.ManageURLTextBox);
            this.Controls.Add(this.ManageTopicLable);
            this.Controls.Add(this.ManageNameLable);
            this.Controls.Add(this.ManageUrlLable);
            this.Name = "ManageSubscriptionForm";
            this.Text = "ManageSubscriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageUrlLable;
        private System.Windows.Forms.Label ManageNameLable;
        private System.Windows.Forms.Label ManageTopicLable;
        private System.Windows.Forms.TextBox ManageURLTextBox;
        private System.Windows.Forms.TextBox ManageNameTextBox;
        private System.Windows.Forms.DomainUpDown ManageTopicUpDown;
        private System.Windows.Forms.Button ManageAcceptButton;
        private System.Windows.Forms.Button ManageCancelButton;
    }
}