using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestQuotesBlazor.Data
{
    public class Quote
    {
        public string Content { get; set; }
        public string Category { get; set; }
        public int Grade { get; set; }
    }
}
