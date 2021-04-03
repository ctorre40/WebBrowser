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
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title); 
        }

        public static List<BookmarkItem> GetBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.Title;
                item.Title = row.Title;

                results.Add(item);
            }
            return results;
        }

        
    }
}
