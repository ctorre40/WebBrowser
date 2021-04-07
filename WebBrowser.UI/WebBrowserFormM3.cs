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
    public partial class WebBrowserFormM3 : Form
    {
        public WebBrowserFormM3()
        {
            InitializeComponent();
        }

        private void WebBrowserFormM3_Load(object sender, EventArgs e)
        {
            
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // code for new tab event
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString(); // gives name to new tabs
            TabPage myTabPage = new TabPage(title);
            TabUserControl myTabUserControl = new TabUserControl();
            myTabUserControl.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(myTabUserControl);
            tabControl1.TabPages.Add(myTabPage);

           // my guess is changing the tab here to produce a new one
           

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Removes the selected tab:  
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
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
 
            HistoryManagerForm listBox1 = new HistoryManagerForm();
            listBox1.ShowDialog();

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm listBox1 = new BookmarkManagerForm();
            listBox1.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add message here
            MessageBox.Show("Hello there! This is my custom web browser. My name is Casandra. I am from Chicago and I have two cats. My student ID is czt0051. Thanks for checking me out!");
        }



        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString(); // gives name to new tabs
            TabPage myTabPage = new TabPage(title);
            TabUserControl myTabUserControl = new TabUserControl();
            myTabUserControl.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(myTabUserControl);
            tabControl1.TabPages.Add(myTabPage);

        }

        private void tabUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
