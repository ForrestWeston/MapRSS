namespace MapRss
{
    partial class EditUserForm
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
            this.EditCurrentUserNameLable = new System.Windows.Forms.Label();
            this.EditNewUserNameLable = new System.Windows.Forms.Label();
            this.EditCurrentUserPasswordLable = new System.Windows.Forms.Label();
            this.EditNewUserPasswordLable = new System.Windows.Forms.Label();
            this.EditCurrentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.EditNewUsernameTextBox = new System.Windows.Forms.TextBox();
            this.EditCurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditUserAcceptButton = new System.Windows.Forms.Button();
            this.EditUserCancleButon = new System.Windows.Forms.Button();
            this.RefreshRateLabe = new System.Windows.Forms.Label();
            this.EditRefreshRatenumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EditRefreshRatenumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EditCurrentUserNameLable
            // 
            this.EditCurrentUserNameLable.AutoSize = true;
            this.EditCurrentUserNameLable.Location = new System.Drawing.Point(12, 9);
            this.EditCurrentUserNameLable.Name = "EditCurrentUserNameLable";
            this.EditCurrentUserNameLable.Size = new System.Drawing.Size(92, 13);
            this.EditCurrentUserNameLable.TabIndex = 0;
            this.EditCurrentUserNameLable.Text = "Current Username";
            // 
            // EditNewUserNameLable
            // 
            this.EditNewUserNameLable.AutoSize = true;
            this.EditNewUserNameLable.Location = new System.Drawing.Point(12, 51);
            this.EditNewUserNameLable.Name = "EditNewUserNameLable";
            this.EditNewUserNameLable.Size = new System.Drawing.Size(80, 13);
            this.EditNewUserNameLable.TabIndex = 1;
            this.EditNewUserNameLable.Text = "New Username";
            // 
            // EditCurrentUserPasswordLable
            // 
            this.EditCurrentUserPasswordLable.AutoSize = true;
            this.EditCurrentUserPasswordLable.Location = new System.Drawing.Point(12, 91);
            this.EditCurrentUserPasswordLable.Name = "EditCurrentUserPasswordLable";
            this.EditCurrentUserPasswordLable.Size = new System.Drawing.Size(90, 13);
            this.EditCurrentUserPasswordLable.TabIndex = 2;
            this.EditCurrentUserPasswordLable.Text = "Current Password";
            // 
            // EditNewUserPasswordLable
            // 
            this.EditNewUserPasswordLable.AutoSize = true;
            this.EditNewUserPasswordLable.Location = new System.Drawing.Point(12, 131);
            this.EditNewUserPasswordLable.Name = "EditNewUserPasswordLable";
            this.EditNewUserPasswordLable.Size = new System.Drawing.Size(78, 13);
            this.EditNewUserPasswordLable.TabIndex = 3;
            this.EditNewUserPasswordLable.Text = "New Password";
            // 
            // EditCurrentUsernameTextBox
            // 
            this.EditCurrentUsernameTextBox.Location = new System.Drawing.Point(15, 27);
            this.EditCurrentUsernameTextBox.Name = "EditCurrentUsernameTextBox";
            this.EditCurrentUsernameTextBox.ReadOnly = true;
            this.EditCurrentUsernameTextBox.Size = new System.Drawing.Size(257, 20);
            this.EditCurrentUsernameTextBox.TabIndex = 0;
            // 
            // EditNewUsernameTextBox
            // 
            this.EditNewUsernameTextBox.Location = new System.Drawing.Point(13, 68);
            this.EditNewUsernameTextBox.Name = "EditNewUsernameTextBox";
            this.EditNewUsernameTextBox.Size = new System.Drawing.Size(259, 20);
            this.EditNewUsernameTextBox.TabIndex = 1;
            // 
            // EditCurrentPasswordTextBox
            // 
            this.EditCurrentPasswordTextBox.Location = new System.Drawing.Point(15, 108);
            this.EditCurrentPasswordTextBox.Name = "EditCurrentPasswordTextBox";
            this.EditCurrentPasswordTextBox.ReadOnly = true;
            this.EditCurrentPasswordTextBox.Size = new System.Drawing.Size(257, 20);
            this.EditCurrentPasswordTextBox.TabIndex = 2;
            // 
            // EditNewPasswordTextBox
            // 
            this.EditNewPasswordTextBox.Location = new System.Drawing.Point(15, 148);
            this.EditNewPasswordTextBox.Name = "EditNewPasswordTextBox";
            this.EditNewPasswordTextBox.Size = new System.Drawing.Size(257, 20);
            this.EditNewPasswordTextBox.TabIndex = 3;
            // 
            // EditUserAcceptButton
            // 
            this.EditUserAcceptButton.Location = new System.Drawing.Point(15, 227);
            this.EditUserAcceptButton.Name = "EditUserAcceptButton";
            this.EditUserAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.EditUserAcceptButton.TabIndex = 5;
            this.EditUserAcceptButton.Text = "Accept";
            this.EditUserAcceptButton.UseVisualStyleBackColor = true;
            this.EditUserAcceptButton.Click += new System.EventHandler(this.EditUserAcceptButton_Click);
            // 
            // EditUserCancleButon
            // 
            this.EditUserCancleButon.Location = new System.Drawing.Point(196, 227);
            this.EditUserCancleButon.Name = "EditUserCancleButon";
            this.EditUserCancleButon.Size = new System.Drawing.Size(75, 23);
            this.EditUserCancleButon.TabIndex = 6;
            this.EditUserCancleButon.Text = "Cancle";
            this.EditUserCancleButon.UseVisualStyleBackColor = true;
            this.EditUserCancleButon.Click += new System.EventHandler(this.EditUserCancleButon_Click);
            // 
            // RefreshRateLabe
            // 
            this.RefreshRateLabe.AutoSize = true;
            this.RefreshRateLabe.Location = new System.Drawing.Point(15, 175);
            this.RefreshRateLabe.Name = "RefreshRateLabe";
            this.RefreshRateLabe.Size = new System.Drawing.Size(95, 13);
            this.RefreshRateLabe.TabIndex = 10;
            this.RefreshRateLabe.Text = "Refresh Rate (min)";
            // 
            // EditRefreshRatenumericUpDown
            // 
            this.EditRefreshRatenumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.EditRefreshRatenumericUpDown.Location = new System.Drawing.Point(13, 192);
            this.EditRefreshRatenumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.EditRefreshRatenumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.EditRefreshRatenumericUpDown.Name = "EditRefreshRatenumericUpDown";
            this.EditRefreshRatenumericUpDown.Size = new System.Drawing.Size(258, 20);
            this.EditRefreshRatenumericUpDown.TabIndex = 4;
            this.EditRefreshRatenumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.EditRefreshRatenumericUpDown);
            this.Controls.Add(this.RefreshRateLabe);
            this.Controls.Add(this.EditUserCancleButon);
            this.Controls.Add(this.EditUserAcceptButton);
            this.Controls.Add(this.EditNewPasswordTextBox);
            this.Controls.Add(this.EditCurrentPasswordTextBox);
            this.Controls.Add(this.EditNewUsernameTextBox);
            this.Controls.Add(this.EditCurrentUsernameTextBox);
            this.Controls.Add(this.EditNewUserPasswordLable);
            this.Controls.Add(this.EditCurrentUserPasswordLable);
            this.Controls.Add(this.EditNewUserNameLable);
            this.Controls.Add(this.EditCurrentUserNameLable);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.EditRefreshRatenumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditCurrentUserNameLable;
        private System.Windows.Forms.Label EditNewUserNameLable;
        private System.Windows.Forms.Label EditCurrentUserPasswordLable;
        private System.Windows.Forms.Label EditNewUserPasswordLable;
        private System.Windows.Forms.TextBox EditCurrentUsernameTextBox;
        private System.Windows.Forms.TextBox EditNewUsernameTextBox;
        private System.Windows.Forms.TextBox EditCurrentPasswordTextBox;
        private System.Windows.Forms.TextBox EditNewPasswordTextBox;
        private System.Windows.Forms.Button EditUserAcceptButton;
        private System.Windows.Forms.Button EditUserCancleButon;
        private System.Windows.Forms.Label RefreshRateLabe;
        private System.Windows.Forms.NumericUpDown EditRefreshRatenumericUpDown;
    }
}