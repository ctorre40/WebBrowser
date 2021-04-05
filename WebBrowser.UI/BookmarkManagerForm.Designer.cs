
namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bookmarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDBDataSet1 = new WebBrowser.UI.dataDBDataSet1();
            this.bookmarksTableAdapter = new WebBrowser.UI.dataDBDataSet1TableAdapters.BookmarksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(543, 405);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bookmarksBindingSource
            // 
            this.bookmarksBindingSource.DataMember = "Bookmarks";
            this.bookmarksBindingSource.DataSource = this.dataDBDataSet1;
            // 
            // dataDBDataSet1
            // 
            this.dataDBDataSet1.DataSetName = "dataDBDataSet1";
            this.dataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookmarksTableAdapter
            // 
            this.bookmarksTableAdapter.ClearBeforeFill = true;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 405);
            this.Controls.Add(this.listBox1);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private dataDBDataSet1 dataDBDataSet1;
        private System.Windows.Forms.BindingSource bookmarksBindingSource;
        private dataDBDataSet1TableAdapters.BookmarksTableAdapter bookmarksTableAdapter;
    }
}