using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    //add the following
    // add history item
    // must be static
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            // should add history item to dB and get all history items from the dB
            //accepts the variables from history
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date); //.ToString("mm/dd/yyy hh::ss"));
        }

        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;

                results.Add(item);
            }
            return results;
        }
    }
}
