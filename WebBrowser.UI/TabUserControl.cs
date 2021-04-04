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
        //Stack<string> urlBackList = new Stack<string>();
        //Stack<string> urlForwardList = new Stack<string>();

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
                HistoryManagerForm addToHistory= new HistoryManagerForm();
                AddNewUrl();
                UpdateHistory();
                //string oldUrl = url;
                //urlBackList.Push(oldUrl);

            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
  
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            WebBrowserFormM3 tabPage1 = new WebBrowserFormM3();
            String url = AddressBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
                AddNewUrl();
                UpdateHistory();
                //string oldUrl = url;
                //urlBackList.Push(oldUrl);

            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

            /**
            String saveTheUrl = AddressBox.Text;
            urlForwardList.Push(saveTheUrl); //stores the current url into the forward stack for later usage
            string bringBackUrl = urlBackList.Pop();
            webBrowser1.Navigate(bringBackUrl);
            */
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            /**
            String byeByeUrl = AddressBox.Text;
            urlBackList.Push(byeByeUrl); //sends the current url to back list 
            string helloAgain = urlForwardList.Pop();
            webBrowser1.Navigate(helloAgain);
            */
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
            //here we need to implement code
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddressBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowserFormM3 tabPage1 = new WebBrowserFormM3();

                String url = AddressBox.Text;
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    AddressBox.Text = url;
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                    AddNewUrl();
                    UpdateHistory();
                    //string oldUrl = url;
                    //urlBackList.Push(oldUrl);

                }

            }

        }
    }
}
