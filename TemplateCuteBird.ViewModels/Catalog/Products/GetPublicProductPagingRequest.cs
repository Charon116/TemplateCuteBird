using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.ViewModels.Common;

namespace TemplateCuteBird.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
