using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            //might need to remove this data source
            // TODO: This line of code loads data into the 'dataDBDataSet1.Bookmarks' table. You can move, or remove it, as needed.
            this.bookmarksTableAdapter.Fill(this.dataDBDataSet1.Bookmarks);
            var items = BookmarkManager.GetBookmarkItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(string.Format("{0} - ({1})", item.Title, item.URL));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
