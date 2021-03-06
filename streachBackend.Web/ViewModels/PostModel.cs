using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace streachBackend.Web.ViewModels
{
    public class PostModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string PostBody { get; set; }
        public string AuthorName { get; set; }
        public double Kudos { get; set; }
    }
}
