using System;
using System.Collections.Generic;
using System.Text;

namespace streachBackend.Data.Models
{
    public class WebPosts
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string PostBody { get; set; }
        public string AuthorName { get; set; }
        public double Kudos { get; set; }
    }
}
