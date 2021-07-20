using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCuteBird.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecords { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
