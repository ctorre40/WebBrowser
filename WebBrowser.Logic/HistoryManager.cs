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
        public static void AddItem(HistoryItem hItem)
        {
            // should add history item to dB and get all history items from the dB
            //accepts the variables from history
            var adapter = new HistoryTableAdapter();
            adapter.Insert(hItem.URL, hItem.Title, hItem.Date); //.ToString("mm/dd/yyy hh::ss"));
        }

        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var hItem = new HistoryItem();
                hItem.URL = row.URL;
                hItem.Title = row.Title;
                hItem.Date = row.Date;

                results.Add(hItem);
            }
            return results;
        }
    }
}
