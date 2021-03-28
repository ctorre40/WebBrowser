﻿using System;
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
    public partial class TabUserControl : UserControl
    {
        public TabUserControl()
        {
            InitializeComponent();
        }

        private void TabUserControl_Load(object sender, EventArgs e)
        {

        }

        //private void UCtoolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    WebBrowserFormM3 AddressBox = new WebBrowserFormM3();

        //    String url = AddressBox.Text;
        //    if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
        //    {
        //        AddressBox.Text = url;
        //        webBrowser1.Navigate(url);
        //    }
        //}

        private void AddressBox_Click(object sender, EventArgs e)
        {
            WebBrowserFormM3 AddressBox = new WebBrowserFormM3();

            String url = AddressBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AddressBox.Text = url;
                webBrowser1.Navigate(url);
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
            }
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

        private void BookMarkButton_Click(object sender, EventArgs e)
        {

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
                }

            }
        }
    }
}