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
    public partial class TabUserControl : UserControl
    {
        
        public TabUserControl()
        {
            InitializeComponent();
            
        }

        private void TabUserControl_Load(object sender, EventArgs e)
        {

        }

        private void AddressBox_Click(object sender, EventArgs e)
        {
            WebBrowserFormM3 AddressBox = new WebBrowserFormM3();

            String url = AddressBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AddressBox.Text = url;
                webBrowser1.Navigate(url);
                var item = new HistoryItem();
                item.URL = AddressBox.Text;
                item.Title = AddressBox.Text;
                item.Date = DateTime.Now;
                HistoryManager.AddItem(item);
              

            }
        }

       

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            AddressBox.Text = webBrowser1.Document.Url.ToString(); // updates the url to the page we are browsing on
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            WebBrowserFormM3 tabPage1 = new WebBrowserFormM3();
            String url = AddressBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
               
                var item = new HistoryItem();
                item.URL = AddressBox.Text;
                item.Title = AddressBox.Text;
                item.Date = DateTime.Now;
                HistoryManager.AddItem(item);
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void BookMarkButton_Click(object sender, EventArgs e)
        {
           
            var item = new BookmarkItem();
            item.URL = AddressBox.Text;
            item.Title = webBrowser1.Document.Title;
            BookmarkManager.AddItem(item);
            


        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowserFormM3 tabPage1 = new WebBrowserFormM3();
                HistoryManagerForm listBox1 = new HistoryManagerForm();
                String url = AddressBox.Text;
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    AddressBox.Text = url;
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                    var item = new HistoryItem();
                    item.URL = AddressBox.Text;
                    item.Title = AddressBox.Text;
                    item.Date = DateTime.Now;
                    HistoryManager.AddItem(item);

                }

            }

        }
    }
}
