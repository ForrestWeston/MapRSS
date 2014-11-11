namespace MapRss
{
    partial class CreateUserForm
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
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.CreateUserAccept = new System.Windows.Forms.Button();
            this.CreateUserCancel = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.CreateUserConfirmPasswordLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(12, 21);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(260, 20);
            this.UsernameTextbox.TabIndex = 0;
            // 
            // UsernameLable
            // 
            this.UsernameLable.AutoSize = true;
            this.UsernameLable.Location = new System.Drawing.Point(7, 5);
            this.UsernameLable.Name = "UsernameLable";
            this.UsernameLable.Size = new System.Drawing.Size(55, 13);
            this.UsernameLable.TabIndex = 1;
            this.UsernameLable.Text = "Username";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(7, 44);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(53, 13);
            this.PasswordLable.TabIndex = 2;
            this.PasswordLable.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(12, 60);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(260, 20);
            this.PasswordTextbox.TabIndex = 1;
            // 
            // CreateUserAccept
            // 
            this.CreateUserAccept.Location = new System.Drawing.Point(12, 227);
            this.CreateUserAccept.Name = "CreateUserAccept";
            this.CreateUserAccept.Size = new System.Drawing.Size(75, 23);
            this.CreateUserAccept.TabIndex = 3;
            this.CreateUserAccept.Text = "Accept";
            this.CreateUserAccept.UseVisualStyleBackColor = true;
            this.CreateUserAccept.Click += new System.EventHandler(this.CreateUserAccept_Click);
            // 
            // CreateUserCancel
            // 
            this.CreateUserCancel.Location = new System.Drawing.Point(197, 227);
            this.CreateUserCancel.Name = "CreateUserCancel";
            this.CreateUserCancel.Size = new System.Drawing.Size(75, 23);
            this.CreateUserCancel.TabIndex = 4;
            this.CreateUserCancel.Text = "Cancel";
            this.CreateUserCancel.UseVisualStyleBackColor = true;
            this.CreateUserCancel.Click += new System.EventHandler(this.CreateUserCancel_Click);
            // 
            // ConfirmPasswordTextbox
            // 
            this.ConfirmPasswordTextbox.Location = new System.Drawing.Point(12, 99);
            this.ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            this.ConfirmPasswordTextbox.Size = new System.Drawing.Size(260, 20);
            this.ConfirmPasswordTextbox.TabIndex = 2;
            // 
            // CreateUserConfirmPasswordLable
            // 
            this.CreateUserConfirmPasswordLable.AutoSize = true;
            this.CreateUserConfirmPasswordLable.Location = new System.Drawing.Point(7, 83);
            this.CreateUserConfirmPasswordLable.Name = "CreateUserConfirmPasswordLable";
            this.CreateUserConfirmPasswordLable.Size = new System.Drawing.Size(91, 13);
            this.CreateUserConfirmPasswordLable.TabIndex = 7;
            this.CreateUserConfirmPasswordLable.Text = "Confirm Password";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.CreateUserConfirmPasswordLable);
            this.Controls.Add(this.ConfirmPasswordTextbox);
            this.Controls.Add(this.CreateUserCancel);
            this.Controls.Add(this.CreateUserAccept);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UsernameLable);
            this.Controls.Add(this.UsernameTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUserForm";
            this.Text = "Your User Profile ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label UsernameLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button CreateUserAccept;
        private System.Windows.Forms.Button CreateUserCancel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextbox;
        private System.Windows.Forms.Label CreateUserConfirmPasswordLable;
    }
}