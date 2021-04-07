
namespace WebBrowser.UI
{
    partial class TabUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabUserControl));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.BookMarkButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBox = new System.Windows.Forms.ToolStripTextBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.RefreshButton,
            this.HomeButton,
            this.BookMarkButton,
            this.AddressBox,
            this.GoButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(757, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 22);
            this.BackButton.Text = "BackButton";
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 22);
            this.ForwardButton.Text = "ForwardButton";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Text = "RefreshButton";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(23, 22);
            this.HomeButton.Text = "HomeButton";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BookMarkButton
            // 
            this.BookMarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BookMarkButton.Image = ((System.Drawing.Image)(resources.GetObject("BookMarkButton.Image")));
            this.BookMarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookMarkButton.Name = "BookMarkButton";
            this.BookMarkButton.Size = new System.Drawing.Size(23, 22);
            this.BookMarkButton.Text = "BookMarkButton";
            this.BookMarkButton.Click += new System.EventHandler(this.BookMarkButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(400, 25);
            this.AddressBox.Text = "  ";
            this.AddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            this.AddressBox.Click += new System.EventHandler(this.AddressBox_Click);
            // 
            // GoButton
            // 
            this.GoButton.CheckOnClick = true;
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(23, 22);
            this.GoButton.Text = "GoButton";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(757, 448);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // TabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "TabUserControl";
            this.Size = new System.Drawing.Size(757, 473);
            this.Load += new System.EventHandler(this.TabUserControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripButton GoButton;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripTextBox AddressBox;
        public System.Windows.Forms.ToolStripButton BookMarkButton;
        public System.Windows.Forms.ToolStripButton BackButton;
    }
}
