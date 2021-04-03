using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    class HistoryItem
    {
        // need to decide whether this should be public or private
        public string URL = "";
        public string Title = "";
        public DateTime Date;
    }
}
