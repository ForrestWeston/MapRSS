namespace MapRss
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabGridViewsplitContainer = new System.Windows.Forms.SplitContainer();
            this.BrowserMapTabControl = new System.Windows.Forms.TabControl();
            this.BrowserTabPage = new System.Windows.Forms.TabPage();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.MapTabPage = new System.Windows.Forms.TabPage();
            this.ArticleDataGridView = new System.Windows.Forms.DataGridView();
            this.FeedTopicTabControl = new System.Windows.Forms.TabControl();
            this.FeedTabPage = new System.Windows.Forms.TabPage();
            this.FeedTreeView = new System.Windows.Forms.TreeView();
            this.TopicTabPage = new System.Windows.Forms.TabPage();
            this.TopicTreeView = new System.Windows.Forms.TreeView();
            this.AddButton = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.mapControl1 = new MapRss.MapControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabGridViewsplitContainer)).BeginInit();
            this.TabGridViewsplitContainer.Panel1.SuspendLayout();
            this.TabGridViewsplitContainer.Panel2.SuspendLayout();
            this.TabGridViewsplitContainer.SuspendLayout();
            this.BrowserMapTabControl.SuspendLayout();
            this.BrowserTabPage.SuspendLayout();
            this.MapTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleDataGridView)).BeginInit();
            this.FeedTopicTabControl.SuspendLayout();
            this.FeedTabPage.SuspendLayout();
            this.TopicTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createUserToolStripMenuItem.Text = "Create";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // TabGridViewsplitContainer
            // 
            this.TabGridViewsplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabGridViewsplitContainer.Location = new System.Drawing.Point(194, 53);
            this.TabGridViewsplitContainer.Name = "TabGridViewsplitContainer";
            this.TabGridViewsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TabGridViewsplitContainer.Panel1
            // 
            this.TabGridViewsplitContainer.Panel1.Controls.Add(this.BrowserMapTabControl);
            // 
            // TabGridViewsplitContainer.Panel2
            // 
            this.TabGridViewsplitContainer.Panel2.Controls.Add(this.ArticleDataGridView);
            this.TabGridViewsplitContainer.Size = new System.Drawing.Size(532, 508);
            this.TabGridViewsplitContainer.SplitterDistance = 387;
            this.TabGridViewsplitContainer.TabIndex = 3;
            // 
            // BrowserMapTabControl
            // 
            this.BrowserMapTabControl.Controls.Add(this.BrowserTabPage);
            this.BrowserMapTabControl.Controls.Add(this.MapTabPage);
            this.BrowserMapTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserMapTabControl.Location = new System.Drawing.Point(0, 0);
            this.BrowserMapTabControl.Name = "BrowserMapTabControl";
            this.BrowserMapTabControl.SelectedIndex = 0;
            this.BrowserMapTabControl.ShowToolTips = true;
            this.BrowserMapTabControl.Size = new System.Drawing.Size(532, 387);
            this.BrowserMapTabControl.TabIndex = 0;
            // 
            // BrowserTabPage
            // 
            this.BrowserTabPage.Controls.Add(this.WebBrowser);
            this.BrowserTabPage.Location = new System.Drawing.Point(4, 22);
            this.BrowserTabPage.Name = "BrowserTabPage";
            this.BrowserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserTabPage.Size = new System.Drawing.Size(524, 361);
            this.BrowserTabPage.TabIndex = 1;
            this.BrowserTabPage.Text = "Browser";
            this.BrowserTabPage.UseVisualStyleBackColor = true;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 3);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(518, 355);
            this.WebBrowser.TabIndex = 0;
            // 
            // MapTabPage
            // 
            this.MapTabPage.Controls.Add(this.elementHost1);
            this.MapTabPage.Location = new System.Drawing.Point(4, 22);
            this.MapTabPage.Name = "MapTabPage";
            this.MapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MapTabPage.Size = new System.Drawing.Size(524, 361);
            this.MapTabPage.TabIndex = 2;
            this.MapTabPage.Text = "Map";
            this.MapTabPage.UseVisualStyleBackColor = true;
            // 
            // ArticleDataGridView
            // 
            this.ArticleDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ArticleDataGridView.AllowUserToAddRows = false;
            this.ArticleDataGridView.AllowUserToDeleteRows = false;
            this.ArticleDataGridView.AllowUserToResizeRows = false;
            this.ArticleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArticleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticleDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArticleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ArticleDataGridView.MultiSelect = false;
            this.ArticleDataGridView.Name = "ArticleDataGridView";
            this.ArticleDataGridView.Size = new System.Drawing.Size(532, 117);
            this.ArticleDataGridView.TabIndex = 0;
            this.ArticleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticleDataGridView_CellContentClick);
            // 
            // FeedTopicTabControl
            // 
            this.FeedTopicTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FeedTopicTabControl.Controls.Add(this.FeedTabPage);
            this.FeedTopicTabControl.Controls.Add(this.TopicTabPage);
            this.FeedTopicTabControl.Location = new System.Drawing.Point(12, 53);
            this.FeedTopicTabControl.Name = "FeedTopicTabControl";
            this.FeedTopicTabControl.SelectedIndex = 0;
            this.FeedTopicTabControl.Size = new System.Drawing.Size(176, 508);
            this.FeedTopicTabControl.TabIndex = 1;
            // 
            // FeedTabPage
            // 
            this.FeedTabPage.Controls.Add(this.FeedTreeView);
            this.FeedTabPage.Location = new System.Drawing.Point(4, 22);
            this.FeedTabPage.Name = "FeedTabPage";
            this.FeedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FeedTabPage.Size = new System.Drawing.Size(168, 482);
            this.FeedTabPage.TabIndex = 0;
            this.FeedTabPage.Text = "Feeds";
            this.FeedTabPage.UseVisualStyleBackColor = true;
            // 
            // FeedTreeView
            // 
            this.FeedTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedTreeView.Location = new System.Drawing.Point(3, 3);
            this.FeedTreeView.Name = "FeedTreeView";
            this.FeedTreeView.Size = new System.Drawing.Size(162, 476);
            this.FeedTreeView.TabIndex = 0;
            this.FeedTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FeedTreeView_AfterSelect);
            // 
            // TopicTabPage
            // 
            this.TopicTabPage.Controls.Add(this.TopicTreeView);
            this.TopicTabPage.Location = new System.Drawing.Point(4, 22);
            this.TopicTabPage.Name = "TopicTabPage";
            this.TopicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TopicTabPage.Size = new System.Drawing.Size(168, 482);
            this.TopicTabPage.TabIndex = 1;
            this.TopicTabPage.Text = "Topics";
            this.TopicTabPage.UseVisualStyleBackColor = true;
            // 
            // TopicTreeView
            // 
            this.TopicTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicTreeView.Location = new System.Drawing.Point(3, 3);
            this.TopicTreeView.Name = "TopicTreeView";
            this.TopicTreeView.Size = new System.Drawing.Size(162, 476);
            this.TopicTreeView.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 27);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 25);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Manage";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(518, 355);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.mapControl1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 573);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FeedTopicTabControl);
            this.Controls.Add(this.TabGridViewsplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MapRSS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabGridViewsplitContainer.Panel1.ResumeLayout(false);
            this.TabGridViewsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabGridViewsplitContainer)).EndInit();
            this.TabGridViewsplitContainer.ResumeLayout(false);
            this.BrowserMapTabControl.ResumeLayout(false);
            this.BrowserTabPage.ResumeLayout(false);
            this.MapTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArticleDataGridView)).EndInit();
            this.FeedTopicTabControl.ResumeLayout(false);
            this.FeedTabPage.ResumeLayout(false);
            this.TopicTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.SplitContainer TabGridViewsplitContainer;
        private System.Windows.Forms.TabControl BrowserMapTabControl;
        private System.Windows.Forms.TabPage BrowserTabPage;
        private System.Windows.Forms.TabPage MapTabPage;
        private System.Windows.Forms.TabControl FeedTopicTabControl;
        private System.Windows.Forms.TabPage FeedTabPage;
        private System.Windows.Forms.TabPage TopicTabPage;
        private System.Windows.Forms.TreeView FeedTreeView;
        private System.Windows.Forms.TreeView TopicTreeView;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ArticleDataGridView;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MapControl mapControl1;

    }
}

