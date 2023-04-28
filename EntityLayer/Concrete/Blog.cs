using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BLogID { get; set; }
        public string BlogImage { get; set; }
        public DateTime AddDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }

        public int? AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
