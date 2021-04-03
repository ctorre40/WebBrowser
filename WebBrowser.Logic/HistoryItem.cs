using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        // need to decide whether this should be public or private
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
