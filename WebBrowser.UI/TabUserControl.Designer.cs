
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
            this.UCtoolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // UCtoolStrip1
            // 
            this.UCtoolStrip1.Location = new System.Drawing.Point(0, 0);
            this.UCtoolStrip1.Name = "UCtoolStrip1";
            this.UCtoolStrip1.Size = new System.Drawing.Size(373, 25);
            this.UCtoolStrip1.TabIndex = 0;
            this.UCtoolStrip1.Text = "toolStrip1";
            this.UCtoolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.UCtoolStrip1_ItemClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(373, 233);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // TabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.UCtoolStrip1);
            this.Name = "TabUserControl";
            this.Size = new System.Drawing.Size(373, 258);
            this.Load += new System.EventHandler(this.TabUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip UCtoolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
