using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        public int Id { get; set; } //added this to see if exception would be fixed
        public string URL { get; set; }
        public string Title { get; set; }
    }
}
