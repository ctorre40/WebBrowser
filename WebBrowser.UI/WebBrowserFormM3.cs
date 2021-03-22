using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class WebBrowserFormM3 : Form
    {
        public WebBrowserFormM3()
        {
            InitializeComponent();
        }

        private void WebBrowserFormM3_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //add code?
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add code here
            MessageBox.Show("Peace out!");
            Application.Exit();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add message here
            MessageBox.Show("Hello there! This is my custom web browser. My name is Casandra. I am from Chicago and I have two cats. My student ID is czt0051. Thanks for checking me out!");
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // add code here
            String url = AddressBox.Text;
            if(Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
            }
        }

        private void BookMarkButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void AddressBox_Click(object sender, EventArgs e)
        {
            //address box
            String url = AddressBox.Text;
            if(Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AddressBox.Text = url;
                webBrowser1.Navigate(url);
            }

        }
    }
}
