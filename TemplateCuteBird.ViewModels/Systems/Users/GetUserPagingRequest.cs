using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.ViewModels.Common;

namespace TemplateCuteBird.ViewModels.Systems.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
