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
//using WebBrowser.HistoryDataSetTableAdapters;

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

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.dataDBDataSet.History);

        }
    }
}
