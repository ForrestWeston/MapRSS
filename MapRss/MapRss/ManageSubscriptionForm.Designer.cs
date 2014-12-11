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
            this.ManageAcceptButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ManageFeedAddButton = new System.Windows.Forms.Button();
            this.ManageURLTextBox = new System.Windows.Forms.TextBox();
            this.ManageUrlLable = new System.Windows.Forms.Label();
            this.ManageDeleteFeedButton = new System.Windows.Forms.Button();
            this.SubscriptionDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageAcceptButton
            // 
            this.ManageAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManageAcceptButton.Location = new System.Drawing.Point(13, 395);
            this.ManageAcceptButton.Name = "ManageAcceptButton";
            this.ManageAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAcceptButton.TabIndex = 6;
            this.ManageAcceptButton.Text = "Done";
            this.ManageAcceptButton.UseVisualStyleBackColor = true;
            this.ManageAcceptButton.Click += new System.EventHandler(this.ManageAcceptButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ManageFeedAddButton);
            this.splitContainer1.Panel1.Controls.Add(this.ManageURLTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ManageUrlLable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ManageDeleteFeedButton);
            this.splitContainer1.Panel2.Controls.Add(this.SubscriptionDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(710, 376);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 8;
            // 
            // ManageFeedAddButton
            // 
            this.ManageFeedAddButton.Location = new System.Drawing.Point(6, 108);
            this.ManageFeedAddButton.Name = "ManageFeedAddButton";
            this.ManageFeedAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageFeedAddButton.TabIndex = 10;
            this.ManageFeedAddButton.Text = "Add";
            this.ManageFeedAddButton.UseVisualStyleBackColor = true;
            this.ManageFeedAddButton.Click += new System.EventHandler(this.ManageFeedAddButton_Click);
            // 
            // ManageURLTextBox
            // 
            this.ManageURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageURLTextBox.Location = new System.Drawing.Point(3, 29);
            this.ManageURLTextBox.Name = "ManageURLTextBox";
            this.ManageURLTextBox.Size = new System.Drawing.Size(704, 20);
            this.ManageURLTextBox.TabIndex = 8;
            // 
            // ManageUrlLable
            // 
            this.ManageUrlLable.AutoSize = true;
            this.ManageUrlLable.Location = new System.Drawing.Point(3, 13);
            this.ManageUrlLable.Name = "ManageUrlLable";
            this.ManageUrlLable.Size = new System.Drawing.Size(29, 13);
            this.ManageUrlLable.TabIndex = 6;
            this.ManageUrlLable.Text = "URL";
            // 
            // ManageDeleteFeedButton
            // 
            this.ManageDeleteFeedButton.Location = new System.Drawing.Point(6, 187);
            this.ManageDeleteFeedButton.Name = "ManageDeleteFeedButton";
            this.ManageDeleteFeedButton.Size = new System.Drawing.Size(75, 23);
            this.ManageDeleteFeedButton.TabIndex = 0;
            this.ManageDeleteFeedButton.Text = "Delete";
            this.ManageDeleteFeedButton.UseVisualStyleBackColor = true;
            this.ManageDeleteFeedButton.Click += new System.EventHandler(this.ManageDeleteFeedButton_Click);
            // 
            // SubscriptionDataGridView
            // 
            this.SubscriptionDataGridView.AllowUserToAddRows = false;
            this.SubscriptionDataGridView.AllowUserToDeleteRows = false;
            this.SubscriptionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubscriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubscriptionDataGridView.Location = new System.Drawing.Point(3, 0);
            this.SubscriptionDataGridView.Name = "SubscriptionDataGridView";
            this.SubscriptionDataGridView.Size = new System.Drawing.Size(704, 180);
            this.SubscriptionDataGridView.TabIndex = 0;
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 430);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ManageAcceptButton);
            this.Name = "ManageSubscriptionForm";
            this.Text = "ManageSubscriptionForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageAcceptButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ManageURLTextBox;
        private System.Windows.Forms.Label ManageUrlLable;
        private System.Windows.Forms.DataGridView SubscriptionDataGridView;
        private System.Windows.Forms.Button ManageFeedAddButton;
        private System.Windows.Forms.Button ManageDeleteFeedButton;
    }
}