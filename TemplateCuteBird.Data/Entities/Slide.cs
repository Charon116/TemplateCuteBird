using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.Data.Enums;

namespace TemplateCuteBird.Data.Entities
{
    public class Slide
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public string Url { set; get; }

        public string Image { set; get; }
        public int SortOrder { set; get; }

        public Status Status { set; get; }
    }
}
