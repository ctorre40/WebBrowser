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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowserFormM3 AddressBox = new WebBrowserFormM3();
            string url = AddressBox.Text;
            listBox1.Items.Add(url);
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // might need to remove this data source
            // TODO: This line of code loads data into the 'dataDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.dataDBDataSet.History);

            var items = HistoryManager.GetHistoryItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(string.Format("[{0}], - {1} - ({2})", item.Date, item.Title, item.URL));
            }


        }
    }
}
