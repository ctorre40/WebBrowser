using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarkDSTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem bItem)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(bItem.URL, bItem.Title); 
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var bItem = new BookmarkItem();
                bItem.URL = row.Title;
                bItem.Title = row.Title;

                results.Add(bItem);
            }
            return results;
        }

        
    }
}
