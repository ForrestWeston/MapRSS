namespace MapRss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Feed = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewBase = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addFeed = new System.Windows.Forms.Button();
            this.removeFeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowserBack_Button = new System.Windows.Forms.ToolStripButton();
            this.webBrowserFoward_Button = new System.Windows.Forms.ToolStripButton();
            this.webBrowserRefresh_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowserProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMapRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserTextOnly_Button = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 549);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Feed, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Map, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Topic, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Feed
            // 
            this.Feed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Feed.Location = new System.Drawing.Point(3, 3);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(67, 54);
            this.Feed.TabIndex = 0;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Map
            // 
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(76, 3);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(67, 54);
            this.Map.TabIndex = 1;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Topic
            // 
            this.Topic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Topic.Location = new System.Drawing.Point(149, 3);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(69, 54);
            this.Topic.TabIndex = 2;
            this.Topic.Text = "Topic";
            this.Topic.UseVisualStyleBackColor = true;
            this.Topic.Click += new System.EventHandler(this.Topic_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.treeViewBase, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(215, 483);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // treeViewBase
            // 
            this.treeViewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBase.Location = new System.Drawing.Point(3, 51);
            this.treeViewBase.Name = "treeViewBase";
            this.treeViewBase.Size = new System.Drawing.Size(209, 429);
            this.treeViewBase.TabIndex = 0;
            this.treeViewBase.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewBase_AfterSelect);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.addFeed, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.removeFeed, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 42);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // addFeed
            // 
            this.addFeed.Location = new System.Drawing.Point(149, 3);
            this.addFeed.Name = "addFeed";
            this.addFeed.Size = new System.Drawing.Size(25, 23);
            this.addFeed.TabIndex = 0;
            this.addFeed.Text = "+";
            this.addFeed.UseVisualStyleBackColor = true;
            this.addFeed.Click += new System.EventHandler(this.addFeed_Click);
            // 
            // removeFeed
            // 
            this.removeFeed.Location = new System.Drawing.Point(180, 3);
            this.removeFeed.Name = "removeFeed";
            this.removeFeed.Size = new System.Drawing.Size(26, 23);
            this.removeFeed.TabIndex = 1;
            this.removeFeed.Text = "-";
            this.removeFeed.UseVisualStyleBackColor = true;
            this.removeFeed.Click += new System.EventHandler(this.removeFeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feeds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.toolStrip1);
            this.panelContent.Controls.Add(this.webBrowser1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(224, 63);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(511, 483);
            this.panelContent.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webBrowserBack_Button,
            this.webBrowserFoward_Button,
            this.webBrowserRefresh_Button,
            this.webBrowserTextOnly_Button,
            this.toolStripSeparator1,
            this.webBrowserProgressBar,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowserBack_Button
            // 
            this.webBrowserBack_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.webBrowserBack_Button.Image = ((System.Drawing.Image)(resources.GetObject("webBrowserBack_Button.Image")));
            this.webBrowserBack_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.webBrowserBack_Button.Name = "webBrowserBack_Button";
            this.webBrowserBack_Button.Size = new System.Drawing.Size(23, 22);
            this.webBrowserBack_Button.Text = "Back";
            this.webBrowserBack_Button.Click += new System.EventHandler(this.webBrowserBack_Button_Click);
            // 
            // webBrowserFoward_Button
            // 
            this.webBrowserFoward_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.webBrowserFoward_Button.Image = global::MapRss.Properties.Resources.ForwardButtonImage;
            this.webBrowserFoward_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.webBrowserFoward_Button.Name = "webBrowserFoward_Button";
            this.webBrowserFoward_Button.Size = new System.Drawing.Size(23, 22);
            this.webBrowserFoward_Button.Text = "Foward";
            this.webBrowserFoward_Button.Click += new System.EventHandler(this.webBrowserFoward_Button_Click);
            // 
            // webBrowserRefresh_Button
            // 
            this.webBrowserRefresh_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.webBrowserRefresh_Button.Image = global::MapRss.Properties.Resources.RefreshButtonImage;
            this.webBrowserRefresh_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.webBrowserRefresh_Button.Name = "webBrowserRefresh_Button";
            this.webBrowserRefresh_Button.Size = new System.Drawing.Size(23, 22);
            this.webBrowserRefresh_Button.Text = "Refresh";
            this.webBrowserRefresh_Button.Click += new System.EventHandler(this.webBrowserRefresh_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // webBrowserProgressBar
            // 
            this.webBrowserProgressBar.Name = "webBrowserProgressBar";
            this.webBrowserProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(509, 458);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(224, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 54);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMapRSSToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMapRSSToolStripMenuItem
            // 
            this.aboutMapRSSToolStripMenuItem.Name = "aboutMapRSSToolStripMenuItem";
            this.aboutMapRSSToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutMapRSSToolStripMenuItem.Text = "About MapRSS";
            // 
            // webBrowserTextOnly_Button
            // 
            this.webBrowserTextOnly_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.webBrowserTextOnly_Button.Image = global::MapRss.Properties.Resources.TextModeButtonImage;
            this.webBrowserTextOnly_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.webBrowserTextOnly_Button.Name = "webBrowserTextOnly_Button";
            this.webBrowserTextOnly_Button.Size = new System.Drawing.Size(23, 22);
            this.webBrowserTextOnly_Button.Text = "Text Only Mode";
            this.webBrowserTextOnly_Button.Click += new System.EventHandler(this.webBrowserTextOnly_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MapRSS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button Topic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMapRSSToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeViewBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button addFeed;
        private System.Windows.Forms.Button removeFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton webBrowserBack_Button;
        private System.Windows.Forms.ToolStripButton webBrowserFoward_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripProgressBar webBrowserProgressBar;
        private System.Windows.Forms.ToolStripButton webBrowserRefresh_Button;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton webBrowserTextOnly_Button;
    }
}

