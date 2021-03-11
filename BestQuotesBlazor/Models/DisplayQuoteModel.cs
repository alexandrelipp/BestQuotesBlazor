using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestQuotesBlazor.Models
{
    public class DisplayQuoteModel
    {   [Required]
        [StringLength(255, ErrorMessage ="Content is too long")]
        [MinLength(3, ErrorMessage = "Content is too short")]
        public string Content { get; set; }
        [StringLength(100, ErrorMessage = "Content is too long")]
        [MinLength(1, ErrorMessage = "Content is too short")]
        public string Category { get; set; }
        
        [Range(1,10,ErrorMessage="Please provide a value from 1 to 10")]
        public int Grade { get; set; }
    }
}
