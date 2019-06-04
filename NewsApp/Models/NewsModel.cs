using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Models
{
    public class NewsModel
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public ArticleModel[] Articles { get; set; }
    }
}
